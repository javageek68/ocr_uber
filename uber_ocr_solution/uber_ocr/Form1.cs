using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using IronOcr;
using System.Collections.Generic;

namespace uber_ocr
{
    public partial class Form1 : Form
    {
        string strFolder = @"C:\Users\mike\OneDrive\Documents\School\CS_685_Foundations_of_Data_Science\Homework\Uber_Trip_Annotation\BRASCOME";
        string strOutFile = @"C:\Users\mike\OneDrive\Documents\School\CS_685_Foundations_of_Data_Science\Homework\Uber_Trip_Annotation\out_file.csv";
        string strHeader = "Image Filename, Origin Address, Origin Coordinates, Destination Address, Destination Coordinates, Fare, Duration, Distance, Vehicle Type, Time Requested, Date Requested, Points Earned, Origin Coordinates, Coordinates 2, Coordinates 3,	Coordinates 4, Coordinates 5, Coordinates 6, Coordinates 7, Coordinates 8, Coordinates 9, Coordinates 10, Coordinates 11, Coordinates 12, Coordinates 13, Coordinates 14, Coordinates 15, Coordinates 16, Coordinates 17, Coordinates 18, Coordinates 19, Coordinates 20";

        DataTable dtData = new DataTable();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init_data_table();
        }

        private void Init_data_table()
        {
            //had to define these again because the csv file lists Origin Coordinate twice
            string strColHeaders = "Image Filename, Origin Address, Origin Coordinates, Destination Address, Destination Coordinates, Fare, Duration, Distance, Vehicle Type, Time Requested, Date Requested, Points Earned, Coordinates 2, Coordinates 3,	Coordinates 4, Coordinates 5, Coordinates 6, Coordinates 7, Coordinates 8, Coordinates 9, Coordinates 10, Coordinates 11, Coordinates 12, Coordinates 13, Coordinates 14, Coordinates 15, Coordinates 16, Coordinates 17, Coordinates 18, Coordinates 19, Coordinates 20";
            string[] strColumns = strColHeaders.Split(",".ToCharArray());
            foreach(string strColumn in strColumns)
            {
                this.dtData.Columns.Add(strColumn);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string strErrMsg = string.Empty;
            this.fbdFolders.SelectedPath = strFolder;
            if(this.fbdFolders.ShowDialog() == DialogResult.OK)
            {
                this.txtSourceFolder.Text = this.txtSourceFolder.Text = this.fbdFolders.SelectedPath;
                if (this.get_files(this.fbdFolders.SelectedPath, ref strErrMsg) )
                {

                }
                else
                {
                    // failed
                    this.handleError(strErrMsg);
                }
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strErrMsg = string.Empty;
            string strOcrText = string.Empty;
            ListItem selectedItem = (ListItem)this.lstFiles.SelectedItem;

            this.pctData.Load(selectedItem.value);

            // get the ocr string from the file
            if (this.read_ocr(selectedItem.value, ref strOcrText, ref strErrMsg))
            {
                string strCSV = string.Empty;
                //parse the ocr text
                if (this.parse_ocr_text(strOcrText, selectedItem.name, ref strCSV, ref strErrMsg))
                {

                }
                else
                {
                    // an error happened whie parsing the ocr text
                    this.handleError(strErrMsg);
                }
            }
            else
            {
                // an error happened while reading the ocr data
                this.handleError(strErrMsg);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            string strErrMsg = string.Empty;
            try
            {
                if (process_files(strFolder, strOutFile, ref strErrMsg))
                {
                    //done
                    this.displayMsg("Done!");
                }
                else
                {
                    this.handleError(strErrMsg);
                }
            }
            catch (Exception ex)
            {
                this.handleError(ex.ToString());
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = this.dtData.NewRow();
            row["Date Requested"] = this.txtDateRequested.Text;
            row["Destination Address"] = this.txtDestAddress.Text;
            row["Distance"] = this.txtDistance.Text;
            row["Duration"] = this.txtDuration.Text;
            row["Fare"] = this.txtFare.Text;
            row["Image Filename"] = this.txtImageName.Text;
            row["Origin Address"] = this.txtOrgAddress.Text;
            row["Points Earned"] = this.txtPointsEarned.Text;
            row["Time Requested"] = this.txtTimeRequested.Text;
            row["Vehicle Type"] = this.txtVehicleType.Text;
            this.dtData.Rows.Add(row);
        }

        private void btnWriteCSVFile_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strFolder"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        private bool get_files(string strFolder, ref string strErrMsg)
        {
            bool blnRetVal = true;

            try
            {
                this.lstFiles.Items.Clear();
                //get all files in the folder
                string[] files = Directory.GetFiles(strFolder, "*.jpg");

                //loop through each file
                foreach (string strFile in files)
                {
                    // use file info to parse the name of the file
                    FileInfo fileInfo = new FileInfo(strFile);
                    ListItem listItem = new ListItem(fileInfo.Name, strFile);
                    this.lstFiles.Items.Add(listItem);
                }
            }
            catch (Exception ex)
            {
                blnRetVal = false;
                strErrMsg = ex.ToString();
            }
            return blnRetVal;
        }

        /// <summary>
        /// Loop through all files and process each one
        /// </summary>
        /// <param name="strFolder"></param>
        /// <param name="strOutFile"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        private bool process_files(string strFolder, string strOutFile, ref string strErrMsg)
        {
            bool blnRetVal = true;
            string strOcrText = string.Empty;

            try
            {
                //write the header for the csvfile
                File.WriteAllText(strOutFile, strHeader);

                //get all files in the folder
                string[] files = Directory.GetFiles(strFolder, "*.jpg");

                //loop through each file
                foreach (string strFile in files)
                {
                    // get the ocr string from the file
                    if (this.read_ocr(strFile, ref strOcrText, ref strErrMsg))
                    {
                        string strCSV = string.Empty;
                        //parse the ocr text
                        if (this.parse_ocr_text(strOcrText, strFile, ref strCSV, ref strErrMsg))
                        {
                            //write the csv line to the file
                            File.AppendAllText(strOutFile, strCSV);
                        }
                        else
                        {
                            // an error happened whie parsing the ocr text
                            this.handleError(strErrMsg);
                        }
                    }
                    else
                    {
                        // an error happened while reading the ocr data
                        this.handleError(strErrMsg);
                    }
                }
            }
            catch (Exception ex)
            {
                blnRetVal = false;
                strErrMsg = ex.ToString();
            }
            return blnRetVal;
        }

        /// <summary>
        /// Read text with ocr and return the text
        /// </summary>
        /// <param name="strImg"></param>
        /// <param name="strText"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        private bool read_ocr(string strImg, ref string strText, ref string strErrMsg)
        {
            bool blnRetVal = true;
            try
            {
                var Ocr = new IronTesseract();
                using (var Input = new OcrInput(strImg))
                {
                    // Input.Deskew();  // use if image not straight
                    // Input.DeNoise(); // use if image contains digital noise
                    var Result = Ocr.Read(Input);
                    this.txtOutput.Text = Result.Text;
                    Console.WriteLine(Result.Text);
                    strText = Result.Text;
                }

            }
            catch (Exception ex)
            {
                blnRetVal = false;
                strErrMsg = ex.ToString();
            }
            return blnRetVal;
        }

        /// <summary>
        /// parse the text from the ocr string and return a csv line
        /// </summary>
        /// <param name="strInput"></param>
        /// <param name="strFile"></param>
        /// <param name="strCSV"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        private bool parse_ocr_text(string strInput, string strFile, ref string strCSV, ref string strErrMsg)
        {
            bool blnRetVal = true;

            string strImageFilename = string.Empty; 
            string strOriginAddress = string.Empty; 
            string strOriginCoordinates = string.Empty; 
            string strDestinationAddress = string.Empty; 
            string strDestinationCoordinates = string.Empty; 
            string strFare = string.Empty; 
            string strDuration = string.Empty; 
            string strDistance = string.Empty; 
            string strVehicleType = string.Empty; 
            string strTimeRequested = string.Empty; 
            string strDateRequested = string.Empty; 
            string strPointsEarned = string.Empty; 
            string strCoordinates2 = string.Empty; 
            string strCoordinates3 = string.Empty; 
            string strCoordinates4 = string.Empty; 
            string strCoordinates5 = string.Empty; 
            string strCoordinates6 = string.Empty; 
            string strCoordinates7 = string.Empty; 
            string strCoordinates8 = string.Empty; 
            string strCoordinates9 = string.Empty; 
            string strCoordinates10 = string.Empty; 
            string strCoordinates11 = string.Empty; 
            string strCoordinates12 = string.Empty; 
            string strCoordinates13 = string.Empty; 
            string strCoordinates14 = string.Empty; 
            string strCoordinates15 = string.Empty; 
            string strCoordinates16 = string.Empty; 
            string strCoordinates17 = string.Empty; 
            string strCoordinates18 = string.Empty; 
            string strCoordinates19 = string.Empty; 
            string strCoordinates20 = string.Empty;
            try
            {
                strImageFilename = strFile;
                
                //parse the lines in the ocr text
                string[] strLines = strInput.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                List<string> lstLines = new List<string>();
                foreach(string strLine in strLines)
                {
                    if (strLine.Trim().Length > 0) lstLines.Add(strLine);
                }

                strOriginAddress = lstLines[0];
                strDestinationAddress = lstLines[1];

                //loop through each line
                for (int intLine = 0; intLine< lstLines.Count; intLine++)
                {
                    string strLine = lstLines[intLine];
                    this.displayMsg(strLine);
                    if (strLine.Contains("Your Earnings"))
                    {
                        //earnings should be on the next line
                        string next_line = lstLines[intLine + 1];
                        strFare = next_line;
                    }
                    else if (strLine.Contains("Duration Distance"))
                    {
                        //duration and distance on the next line
                        string next_line = lstLines[intLine + 1];
                        string[] strParts = next_line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        strDuration = string.Format("{0}{1}", strParts[0], strParts[1]);
                        strDistance = string.Format("{0}", strParts[2]);
                    }
                    else if (strLine.Contains("Vehicle Type"))
                    {
                        //vehilce type on this line
                        strVehicleType = strLine.Replace("Vehicle Type", "").Trim();
                    }
                    else if (strLine.Contains("Time Requested"))
                    {
                        //Time Requested on this line
                        strTimeRequested = strLine.Replace("Vehicle Type", "").Trim();
                    }
                    else if (strLine.Contains("Date Requested"))
                    {
                        //Date Requested on this line
                        strDateRequested = strLine.Replace("Date Requested", "").Trim();
                    }
                    else if (strLine.Contains("Points Earned"))
                    {
                        //Points Earned on this line
                        strPointsEarned = strLine.Replace("Vehicle Type", "").Trim();
                    }
                    else if (strLine.Contains("Fare"))
                    {
                        //Paid to you on this line
                        strFare = strLine.Replace("Fare", "").Trim();
                    }

                }
                strCSV = string.Format("Image Filename, Origin Address, Origin Coordinates, Destination Address, Destination Coordinates, Fare, Duration, Distance, Vehicle Type, Time Requested, Date Requested, Points Earned, Origin Coordinates, Coordinates 2, Coordinates 3,	Coordinates 4, Coordinates 5, Coordinates 6, Coordinates 7, Coordinates 8, Coordinates 9, Coordinates 10, Coordinates 11, Coordinates 12, Coordinates 13, Coordinates 14, Coordinates 15, Coordinates 16, Coordinates 17, Coordinates 18, Coordinates 19, Coordinates 20", strImageFilename, strOriginAddress, strOriginCoordinates, strDestinationAddress, strDestinationCoordinates, strFare, strDuration, strDistance, strVehicleType, strTimeRequested, strDateRequested, strPointsEarned, strOriginCoordinates, strCoordinates2, strCoordinates3, strCoordinates4, strCoordinates5, strCoordinates6, strCoordinates7, strCoordinates8, strCoordinates9, strCoordinates10, strCoordinates11, strCoordinates12, strCoordinates13, strCoordinates14, strCoordinates15, strCoordinates16, strCoordinates17, strCoordinates18, strCoordinates19, strCoordinates20);

                this.txtDateRequested.Text = strDateRequested;
                this.txtDestAddress.Text = strDestinationAddress;
                this.txtDistance.Text = strDistance;
                this.txtDuration.Text = strDuration;
                this.txtFare.Text = strFare;
                this.txtImageName.Text = strImageFilename;
                this.txtOrgAddress.Text = strOriginAddress;
                this.txtPointsEarned.Text = strPointsEarned;
                this.txtTimeRequested.Text = strTimeRequested;
                this.txtVehicleType.Text = strVehicleType;
   
            }
            catch (Exception ex)
            {
                blnRetVal = false;
                strErrMsg = ex.ToString();
            }
            return blnRetVal;
        }

        /// <summary>
        /// write a csv line to the out file
        /// </summary>
        /// <param name="strOutFile"></param>
        /// <param name="strCSV"></param>
        /// <param name="strErrMsg"></param>
        /// <returns></returns>
        private bool write_to_file(string strOutFile, string strCSV, ref string strErrMsg)
        {
            bool blnRetVal = true;
            try
            {
                System.IO.File.WriteAllText(strOutFile, strCSV);
            }
            catch (Exception ex)
            {
                blnRetVal = false;
                strErrMsg = ex.ToString();
            }
            return blnRetVal;
        }

        /// <summary>
        /// display user messages to the ui
        /// </summary>
        /// <param name="strMsg"></param>
        private void displayMsg(string strMsg)
        {
            this.txtOutput.AppendText(string.Format("{0}\r\n", strMsg));
        }

        /// <summary>
        /// display error messages to the ui
        /// </summary>
        /// <param name="strMsg"></param>
        private void handleError(string strMsg)
        {
            this.txtOutput.AppendText(string.Format("Error {0}\r\n", strMsg));
        }

 
    }
}
