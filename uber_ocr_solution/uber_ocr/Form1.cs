using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tesseract;
using System.Drawing;
using System.Drawing.Imaging;

namespace uber_ocr
{
    public partial class Form1 : Form
    {
        string strFolder = @"C:\Users\mike\OneDrive\Documents\School\CS_685_Foundations_of_Data_Science\Homework\Uber_Trip_Annotation\BRASCOME";
        string strOutFile = @"C:\Users\mike\OneDrive\Documents\School\CS_685_Foundations_of_Data_Science\Homework\Uber_Trip_Annotation\out_file.csv";
        string strHeader = "Image Filename, Origin Address, Origin Coordinates, Destination Address, Destination Coordinates, Fare, Duration, Distance, Vehicle Type, Time Requested, Date Requested, Points Earned, Origin Coordinates, Coordinates 2, Coordinates 3,	Coordinates 4, Coordinates 5, Coordinates 6, Coordinates 7, Coordinates 8, Coordinates 9, Coordinates 10, Coordinates 11, Coordinates 12, Coordinates 13, Coordinates 14, Coordinates 15, Coordinates 16, Coordinates 17, Coordinates 18, Coordinates 19, Coordinates 20";

        DataTable dtCSVData = new DataTable();

        DataTable dtCoordsData = new DataTable();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.grdCoords.RowHeaderMouseClick += GrdCoords_RowHeaderMouseClick;
            this.grdCoords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCoords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.grdCoords.AllowUserToOrderColumns = true;
            this.grdCoords.AllowUserToResizeColumns = true;
            this.InitWeb();
            this.cmbTargetField.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init_data_table();
        }

        async void InitWeb()
        {
            try
            {
                await this.wbBrowser.EnsureCoreWebView2Async(null);
                //this.wbBrowser.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("ERROR : {0} \r\n  You may need to download the WebView2 runtime at https://developer.microsoft.com/en-us/microsoft-edge/webview2/", ex.ToString()));
                throw;
            }

        }

        private void Init_data_table()
        {
            //had to define these again because the csv file lists Origin Coordinate twice
            string strColHeaders = "Image Filename, Origin Address, Origin Coordinates, Destination Address, Destination Coordinates, Fare, Duration, Distance, Vehicle Type, Time Requested, Date Requested, Points Earned, Origin Coordinates2, Coordinates 2, Coordinates 3,	Coordinates 4, Coordinates 5, Coordinates 6, Coordinates 7, Coordinates 8, Coordinates 9, Coordinates 10, Coordinates 11, Coordinates 12, Coordinates 13, Coordinates 14, Coordinates 15, Coordinates 16, Coordinates 17, Coordinates 18, Coordinates 19, Coordinates 20";
            string[] strColumns = strColHeaders.Split(",".ToCharArray());
            foreach(string strColumn in strColumns)
            {
                this.dtCSVData.Columns.Add(strColumn.Trim());
            }
            this.dtCSVData.TableName = "uber_data";
   
        }

        private void Init_coords_table()
        {
            this.dtCoordsData = new DataTable();
            this.dtCoordsData.Columns.Add("id");
            this.dtCoordsData.Columns.Add("x");
            this.dtCoordsData.Columns.Add("y");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ofdFiles.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (this.ofdFiles.ShowDialog() == DialogResult.OK )
            {
                string strFile = this.ofdFiles.FileName;
                this.dtCSVData.ReadXml(strFile);
                this.grdData.DataSource = this.dtCSVData;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sfdFiles.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (this.sfdFiles.ShowDialog() == DialogResult.OK)
            {
                string strFile = this.sfdFiles.FileName;
                this.dtCSVData.WriteXml(strFile);
            }
            
        }

        private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnWriteCSVFile_Click(null, null);
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
                this.txtSourceFolder.Text = this.fbdFolders.SelectedPath;
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

        private void btnBrowseDst_Click(object sender, EventArgs e)
        {
            string strErrMsg = string.Empty;
            this.fbdFolders.SelectedPath = strFolder;
            if (this.fbdFolders.ShowDialog() == DialogResult.OK)
            {
                this.txtDestFolder.Text = this.fbdFolders.SelectedPath;
            }
        }

        private void btnBrowseGeoSite_Click(object sender, EventArgs e)
        {
            if (this.wbBrowser != null && this.wbBrowser.CoreWebView2 != null)
            {
                this.wbBrowser.CoreWebView2.Navigate("https://www.georeferencer.com");
            }
        }

        private void btnScrapeCords_Click(object sender, EventArgs e)
        {
            try
            {
                this.get_dom_from_WebView2();
            }
            catch (Exception ex)
            {
                this.handleError(ex.ToString());
                throw;
            }
        }

        async void get_dom_from_WebView2()
        {
            string sHtml = await wbBrowser.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");
            string sHtmlDecoded = System.Text.RegularExpressions.Regex.Unescape(sHtml);
   
            //for now, we will use test data
            //string sHtmlDecoded = System.IO.File.ReadAllText(@"C:\Users\mike\Documents\Code\DotNet\ocr_uber\uber_ocr_solution\uber_ocr\docs\sample_scrape-class.txt");

            // clear the table
            this.Init_coords_table();

            try
            {
                List<List<string>> lstTable = this.parse_data_table(sHtmlDecoded);

                foreach (List<string> lstRow in lstTable)
                {
                    DataRow row = this.dtCoordsData.NewRow();
                    row["id"] = lstRow[0];
                    row["x"] = lstRow[1];
                    row["y"] = lstRow[2];
                    this.dtCoordsData.Rows.Add(row);

                    this.grdCoords.DataSource = this.dtCoordsData;
                }
            }
            catch (Exception ex)
            {
                this.handleError(ex.ToString());
            }

      
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strHtml"></param>
        /// <returns></returns>
        private List<List<string>> parse_data_table(string strHtml)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(strHtml);

            List<List<string>> table = doc.DocumentNode.SelectSingleNode("//table[@id='coordsModeTable']")
                        .Descendants("tr")
                        .Skip(1)
                        .Where(tr => tr.Elements("td").Count() > 1)
                        .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                        .ToList();

            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTakeSnapshot_Click(object sender, EventArgs e)
        {
            string strImage = this.txtImageName.Text;
            string strImagePath = string.Format(@"{0}\\{1}", this.txtDestFolder.Text, strImage);
            try
            {
                Rectangle bounds = Screen.GetBounds(Point.Empty);
                
                this.TakeCroppedScreenShot(strImagePath, this.Location.X, this.Location.Y , this.Width, this.Height, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                this.handleError(ex.ToString());
            }
        }

        public void TakeCroppedScreenShot(string fileName, int x, int y, int width, int height, System.Drawing.Imaging.ImageFormat format)
        {
            Rectangle r = new Rectangle(x, y, width, height);
            Bitmap bmp = new Bitmap(r.Width, r.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(r.Left, r.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save(fileName, format);
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strErrMsg = string.Empty;
            string strOcrText = string.Empty;
            ListItem selectedItem = (ListItem)this.lstFiles.SelectedItem;

            this.pctData.Load(selectedItem.value);
            this.clear_text_fields();

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
        /// Clear the textboxes in the data entry form
        /// </summary>
        private void clear_text_fields()
        {
            foreach(Control ctl in this.gbForm.Controls)
            {
                if (typeof(TextBox) == ctl.GetType()) ctl.Text = string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = this.dtCSVData.NewRow();
            row["Coordinates 10"] = this.txtCoords10.Text;
            row["Coordinates 11"] = this.txtCoords11.Text;
            row["Coordinates 12"] = this.txtCoords12.Text;
            row["Coordinates 13"] = this.txtCoords13.Text;
            row["Coordinates 14"] = this.txtCoords14.Text;
            row["Coordinates 15"] = this.txtCoords15.Text;
            row["Coordinates 16"] = this.txtCoords16.Text;
            row["Coordinates 17"] = this.txtCoords17.Text;
            row["Coordinates 18"] = this.txtCoords18.Text;
            row["Coordinates 19"] = this.txtCoords19.Text;
            row["Coordinates 20"] = this.txtCoords20.Text;
            row["Coordinates 2"] = this.txtCoords2.Text;
            row["Coordinates 3"] = this.txtCoords3.Text;
            row["Coordinates 4"] = this.txtCoords4.Text;
            row["Coordinates 5"] = this.txtCoords5.Text;
            row["Coordinates 6"] = this.txtCoords6.Text;
            row["Coordinates 7"] = this.txtCoords7.Text;
            row["Coordinates 8"] = this.txtCoords8.Text;
            row["Coordinates 9"] = this.txtCoords9.Text;
            row["Date Requested"] = this.txtDateRequested.Text;
            row["Destination Address"] = this.txtDestAddress.Text;
            row["Destination Coordinates"] = this.txtDestCoords.Text;
            row["Distance"] = this.txtDistance.Text;
            row["Duration"] = this.txtDuration.Text;
            row["Fare"] = this.txtFare.Text;
            row["Image Filename"] = this.txtImageName.Text;
            row["Origin Address"] = this.txtOrgAddress.Text;
            row["Origin Coordinates"] = this.txtOrgCoords.Text;
            row["Origin Coordinates2"] = this.txtOrgCoords.Text;
            row["Points Earned"] = this.txtPointsEarned.Text;
            row["Time Requested"] = this.txtTimeRequested.Text;
            row["Vehicle Type"] = this.txtVehicleType.Text;
            this.dtCSVData.Rows.Add(row);

            this.grdData.DataSource = this.dtCSVData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection grdRows = this.grdData.SelectedRows;
            foreach(DataGridViewRow row in grdRows)
            {
                string file = (string)row.Cells["Image Filename"].Value;
                DataRow[] drr = this.dtCSVData.Select("[Image Filename]='" + file + "' ");
                for (int i = 0; i < drr.Length; i++)
                    drr[i].Delete();
                this.dtCSVData.AcceptChanges();

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWriteCSVFile_Click(object sender, EventArgs e)
        {
            this.sfdFiles.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (this.sfdFiles.ShowDialog() == DialogResult.OK)
            {
                string strFile = this.sfdFiles.FileName;
                StringBuilder sb = new StringBuilder();

                IEnumerable<string> columnNames = this.dtCSVData.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                sb.AppendLine(string.Join(",", columnNames));

                foreach (DataRow row in this.dtCSVData.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field =>  string.Format("\"{0}\"", field.ToString() ) );
                    sb.AppendLine(string.Join(",", fields));
                }

                File.WriteAllText(strFile, sb.ToString());
            }
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


        private bool read_ocr(string strImg, ref string strText, ref string strErrMsg)
        {
            bool blnRetVal = true;
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(strImg))
                    {
                        using (var page = engine.Process(img))
                        {
                            strText = page.GetText();
                            //this.txtStatus.AppendText(string.Format("Mean confidence: {0}", page.GetMeanConfidence()));
                            //this.txtStatus.AppendText(string.Format("Text (GetText): \r\n{0}", text));
                        }
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

                //clear the msg box
                this.clearMsg();
                
                //parse the lines in the ocr text
                string[] strLines = strInput.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                List<string> lstLines = new List<string>();
                foreach(string strLine in strLines)
                {
                    if (strLine.Trim().Length > 0) lstLines.Add(strLine);
                }

                strOriginAddress = lstLines[0].Replace("©","").Trim();
                strDestinationAddress = lstLines[1].Replace("©", "").Trim();

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
                        if (strParts.Length == 6)
                        {
                            strDuration = string.Format("{0} {1} {2} {3}", strParts[0], strParts[1], strParts[2], strParts[3]).Replace("/n", "").Replace("/r", "");
                            strDistance = string.Format("{0} {1}", strParts[4], strParts[5]).Replace("/n", "").Replace("/r", "");
                        }
                    }
                    else if (strLine.Contains("Vehicle Type"))
                    {
                        //vehilce type on this line
                        strVehicleType = strLine.Replace("Vehicle Type", "").Trim();
                    }
                    else if (strLine.Contains("Time Requested"))
                    {
                        //Time Requested on this line
                        strTimeRequested = strLine.Replace("Time Requested", "").Trim();
                    }
                    else if (strLine.Contains("Date Requested"))
                    {
                        //Date Requested on this line
                        strDateRequested = strLine.Replace("Date Requested", "").Trim();
                    }
                    else if (strLine.Contains("Points Earned"))
                    {
                        //Points Earned on this line
                        strPointsEarned = strLine.Replace("Points Earned", "").Replace("¢", "").Replace("point", "").Replace("points", "").Trim();
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

 
        private void GrdCoords_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection grdRows = this.grdCoords.SelectedRows;
            foreach (DataGridViewRow row in grdRows)
            {
                string strId = (string)row.Cells["id"].Value;
                string strX = (string)row.Cells["x"].Value;
                string strY = (string)row.Cells["y"].Value;

                string strValue = string.Format("{0}, {1}", strX, strY);

                string strTarg = this.cmbTargetField.Text;
                if (strTarg == "Origin Coords") this.txtOrgCoords.Text = strValue;
                else if (strTarg == "Dest Coords") this.txtDestCoords.Text = strValue;
                else if (strTarg == "Coordinates 2") this.txtCoords2.Text = strValue;
                else if (strTarg == "Coordinates 3") this.txtCoords3.Text = strValue;
                else if (strTarg == "Coordinates 4") this.txtCoords4.Text = strValue;
                else if (strTarg == "Coordinates 5") this.txtCoords5.Text = strValue;
                else if (strTarg == "Coordinates 6") this.txtCoords6.Text = strValue;
                else if (strTarg == "Coordinates 7") this.txtCoords7.Text = strValue;
                else if (strTarg == "Coordinates 8") this.txtCoords8.Text = strValue;
                else if (strTarg == "Coordinates 9") this.txtCoords9.Text = strValue;
                else if (strTarg == "Coordinates 10") this.txtCoords10.Text = strValue;
                else if (strTarg == "Coordinates 11") this.txtCoords11.Text = strValue;
                else if (strTarg == "Coordinates 12") this.txtCoords12.Text = strValue;
                else if (strTarg == "Coordinates 13") this.txtCoords13.Text = strValue;
                else if (strTarg == "Coordinates 14") this.txtCoords14.Text = strValue;
                else if (strTarg == "Coordinates 15") this.txtCoords15.Text = strValue;
                else if (strTarg == "Coordinates 16") this.txtCoords16.Text = strValue;
                else if (strTarg == "Coordinates 17") this.txtCoords17.Text = strValue;
                else if (strTarg == "Coordinates 18") this.txtCoords18.Text = strValue;
                else if (strTarg == "Coordinates 19") this.txtCoords19.Text = strValue;
                else if (strTarg == "Coordinates 20") this.txtCoords20.Text = strValue;

            }
        }

        private void clearMsg()
        {
            this.txtOutput.Text = "";
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

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
