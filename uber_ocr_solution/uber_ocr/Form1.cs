using System;
using System.Windows.Forms;
using System.IO;
using IronOcr;

namespace uber_ocr
{
    public partial class Form1 : Form
    {
        string strFolder = @"C:\Users\mike\OneDrive\Documents\School\CS_685_Foundations_of_Data_Science\Homework\Uber_Trip_Annotation\BRASCOME";
        string strOutFile = @"C:\Users\mike\OneDrive\Documents\School\CS_685_Foundations_of_Data_Science\Homework\Uber_Trip_Annotation\out_file.csv";
        string strHeader = "Image Filename, Origin Address, Origin Coordinates, Destination Address, Destination Coordinates, Fare, Duration, Distance, Vehicle Type, Time Requested, Date Requested, Points Earned, Origin Coordinates, Coordinates 2, Coordinates 3,	Coordinates 4, Coordinates 5, Coordinates 6, Coordinates 7, Coordinates 8, Coordinates 9, Coordinates 10, Coordinates 11, Coordinates 12, Coordinates 13, Coordinates 14, Coordinates 15, Coordinates 16, Coordinates 17, Coordinates 18, Coordinates 19, Coordinates 20";

        public Form1()
        {
            InitializeComponent();
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
                string[] files = System.IO.Directory.GetFiles(strFolder, "*.jpg");

                foreach (string strFile in files)
                {
                    // get the ocr string from the file
                    if (this.read_ocr(strFile, ref strOcrText, ref strErrMsg))
                    {
                        string strCSV = string.Empty;
                        if (this.parse_ocr_text(strOcrText, strFile, ref strCSV, ref strErrMsg))
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
                
                string[] strLines = strInput.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach(string strLine in strLines)
                {
                    this.displayMsg(strLine);
                    string strOutLine = string.Format("Image Filename, Origin Address, Origin Coordinates, Destination Address, Destination Coordinates, Fare, Duration, Distance, Vehicle Type, Time Requested, Date Requested, Points Earned, Origin Coordinates, Coordinates 2, Coordinates 3,	Coordinates 4, Coordinates 5, Coordinates 6, Coordinates 7, Coordinates 8, Coordinates 9, Coordinates 10, Coordinates 11, Coordinates 12, Coordinates 13, Coordinates 14, Coordinates 15, Coordinates 16, Coordinates 17, Coordinates 18, Coordinates 19, Coordinates 20", strImageFilename, strOriginAddress, strOriginCoordinates, strDestinationAddress, strDestinationCoordinates, strFare, strDuration, strDistance, strVehicleType, strTimeRequested, strDateRequested, strPointsEarned, strOriginCoordinates, strCoordinates2, strCoordinates3, strCoordinates4, strCoordinates5, strCoordinates6, strCoordinates7, strCoordinates8, strCoordinates9, strCoordinates10, strCoordinates11, strCoordinates12, strCoordinates13, strCoordinates14, strCoordinates15, strCoordinates16, strCoordinates17, strCoordinates18, strCoordinates19, strCoordinates20);
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
