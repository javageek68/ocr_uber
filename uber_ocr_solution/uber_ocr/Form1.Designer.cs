
namespace uber_ocr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseSrc = new System.Windows.Forms.Button();
            this.fbdFolders = new System.Windows.Forms.FolderBrowserDialog();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.ctmnuDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.btnWriteCSVFile = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.txtTimeRequested = new System.Windows.Forms.TextBox();
            this.txtDateRequested = new System.Windows.Forms.TextBox();
            this.txtPointsEarned = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrgAddress = new System.Windows.Forms.TextBox();
            this.txtDestAddress = new System.Windows.Forms.TextBox();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctData = new System.Windows.Forms.PictureBox();
            this.sfdFiles = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBrowseGeoSite = new System.Windows.Forms.Button();
            this.btnTakeSnapshot = new System.Windows.Forms.Button();
            this.btnScrapeCords = new System.Windows.Forms.Button();
            this.grdCoords = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.txtDestFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseDst = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.ctmnuDataGrid.SuspendLayout();
            this.gbForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutput.Location = new System.Drawing.Point(399, 17);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(389, 855);
            this.txtOutput.TabIndex = 2;
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(15, 20);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(379, 849);
            this.lstFiles.TabIndex = 3;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolder.Location = new System.Drawing.Point(117, 12);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(1695, 20);
            this.txtSourceFolder.TabIndex = 4;
            // 
            // btnBrowseSrc
            // 
            this.btnBrowseSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSrc.Location = new System.Drawing.Point(1820, 13);
            this.btnBrowseSrc.Name = "btnBrowseSrc";
            this.btnBrowseSrc.Size = new System.Drawing.Size(31, 19);
            this.btnBrowseSrc.TabIndex = 5;
            this.btnBrowseSrc.Text = "...";
            this.btnBrowseSrc.UseVisualStyleBackColor = true;
            this.btnBrowseSrc.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grdData
            // 
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.ContextMenuStrip = this.ctmnuDataGrid;
            this.grdData.Location = new System.Drawing.Point(7, 516);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(390, 371);
            this.grdData.TabIndex = 6;
            // 
            // ctmnuDataGrid
            // 
            this.ctmnuDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ctmnuDataGrid.Name = "ctmnuDataGrid";
            this.ctmnuDataGrid.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // gbForm
            // 
            this.gbForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbForm.Controls.Add(this.btnWriteCSVFile);
            this.gbForm.Controls.Add(this.btnAdd);
            this.gbForm.Controls.Add(this.txtVehicleType);
            this.gbForm.Controls.Add(this.grdData);
            this.gbForm.Controls.Add(this.txtTimeRequested);
            this.gbForm.Controls.Add(this.txtDateRequested);
            this.gbForm.Controls.Add(this.txtPointsEarned);
            this.gbForm.Controls.Add(this.label10);
            this.gbForm.Controls.Add(this.label7);
            this.gbForm.Controls.Add(this.label8);
            this.gbForm.Controls.Add(this.label9);
            this.gbForm.Controls.Add(this.txtOrgAddress);
            this.gbForm.Controls.Add(this.txtDestAddress);
            this.gbForm.Controls.Add(this.txtFare);
            this.gbForm.Controls.Add(this.txtDuration);
            this.gbForm.Controls.Add(this.txtDistance);
            this.gbForm.Controls.Add(this.txtImageName);
            this.gbForm.Controls.Add(this.label6);
            this.gbForm.Controls.Add(this.label5);
            this.gbForm.Controls.Add(this.label4);
            this.gbForm.Controls.Add(this.label3);
            this.gbForm.Controls.Add(this.label2);
            this.gbForm.Controls.Add(this.label1);
            this.gbForm.Location = new System.Drawing.Point(1434, 86);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(417, 913);
            this.gbForm.TabIndex = 7;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form";
            // 
            // btnWriteCSVFile
            // 
            this.btnWriteCSVFile.Location = new System.Drawing.Point(171, 465);
            this.btnWriteCSVFile.Name = "btnWriteCSVFile";
            this.btnWriteCSVFile.Size = new System.Drawing.Size(83, 23);
            this.btnWriteCSVFile.TabIndex = 21;
            this.btnWriteCSVFile.Text = "Write CSV File";
            this.btnWriteCSVFile.UseVisualStyleBackColor = true;
            this.btnWriteCSVFile.Click += new System.EventHandler(this.btnWriteCSVFile_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVehicleType.Location = new System.Drawing.Point(122, 244);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(261, 20);
            this.txtVehicleType.TabIndex = 19;
            // 
            // txtTimeRequested
            // 
            this.txtTimeRequested.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeRequested.Location = new System.Drawing.Point(122, 277);
            this.txtTimeRequested.Name = "txtTimeRequested";
            this.txtTimeRequested.Size = new System.Drawing.Size(261, 20);
            this.txtTimeRequested.TabIndex = 18;
            // 
            // txtDateRequested
            // 
            this.txtDateRequested.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateRequested.Location = new System.Drawing.Point(122, 310);
            this.txtDateRequested.Name = "txtDateRequested";
            this.txtDateRequested.Size = new System.Drawing.Size(261, 20);
            this.txtDateRequested.TabIndex = 17;
            // 
            // txtPointsEarned
            // 
            this.txtPointsEarned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPointsEarned.Location = new System.Drawing.Point(122, 343);
            this.txtPointsEarned.Name = "txtPointsEarned";
            this.txtPointsEarned.Size = new System.Drawing.Size(261, 20);
            this.txtPointsEarned.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Points Earned";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date Requested";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Time Requested";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Vehicle Type";
            // 
            // txtOrgAddress
            // 
            this.txtOrgAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrgAddress.Location = new System.Drawing.Point(122, 76);
            this.txtOrgAddress.Name = "txtOrgAddress";
            this.txtOrgAddress.Size = new System.Drawing.Size(261, 20);
            this.txtOrgAddress.TabIndex = 11;
            // 
            // txtDestAddress
            // 
            this.txtDestAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestAddress.Location = new System.Drawing.Point(122, 112);
            this.txtDestAddress.Name = "txtDestAddress";
            this.txtDestAddress.Size = new System.Drawing.Size(261, 20);
            this.txtDestAddress.TabIndex = 10;
            // 
            // txtFare
            // 
            this.txtFare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFare.Location = new System.Drawing.Point(122, 145);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(261, 20);
            this.txtFare.TabIndex = 9;
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuration.Location = new System.Drawing.Point(122, 178);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(261, 20);
            this.txtDuration.TabIndex = 8;
            // 
            // txtDistance
            // 
            this.txtDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDistance.Location = new System.Drawing.Point(122, 211);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(261, 20);
            this.txtDistance.TabIndex = 7;
            // 
            // txtImageName
            // 
            this.txtImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageName.Location = new System.Drawing.Point(122, 43);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(261, 20);
            this.txtImageName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origin Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Name";
            // 
            // pctData
            // 
            this.pctData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctData.Location = new System.Drawing.Point(794, 17);
            this.pctData.Name = "pctData";
            this.pctData.Size = new System.Drawing.Size(586, 855);
            this.pctData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctData.TabIndex = 8;
            this.pctData.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1407, 923);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstFiles);
            this.tabPage1.Controls.Add(this.txtOutput);
            this.tabPage1.Controls.Add(this.pctData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1399, 897);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OCR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnBrowseGeoSite);
            this.tabPage2.Controls.Add(this.btnTakeSnapshot);
            this.tabPage2.Controls.Add(this.btnScrapeCords);
            this.tabPage2.Controls.Add(this.grdCoords);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1399, 897);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Georeferencer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBrowseGeoSite
            // 
            this.btnBrowseGeoSite.Enabled = false;
            this.btnBrowseGeoSite.Location = new System.Drawing.Point(8, 20);
            this.btnBrowseGeoSite.Name = "btnBrowseGeoSite";
            this.btnBrowseGeoSite.Size = new System.Drawing.Size(159, 26);
            this.btnBrowseGeoSite.TabIndex = 10;
            this.btnBrowseGeoSite.Text = "Browse To Georeferencer";
            this.btnBrowseGeoSite.UseVisualStyleBackColor = true;
            this.btnBrowseGeoSite.Click += new System.EventHandler(this.btnBrowseGeoSite_Click);
            // 
            // btnTakeSnapshot
            // 
            this.btnTakeSnapshot.Enabled = false;
            this.btnTakeSnapshot.Location = new System.Drawing.Point(374, 20);
            this.btnTakeSnapshot.Name = "btnTakeSnapshot";
            this.btnTakeSnapshot.Size = new System.Drawing.Size(102, 26);
            this.btnTakeSnapshot.TabIndex = 9;
            this.btnTakeSnapshot.Text = "Take Snapshot";
            this.btnTakeSnapshot.UseVisualStyleBackColor = true;
            this.btnTakeSnapshot.Click += new System.EventHandler(this.btnTakeSnapshot_Click);
            // 
            // btnScrapeCords
            // 
            this.btnScrapeCords.Enabled = false;
            this.btnScrapeCords.Location = new System.Drawing.Point(195, 20);
            this.btnScrapeCords.Name = "btnScrapeCords";
            this.btnScrapeCords.Size = new System.Drawing.Size(159, 26);
            this.btnScrapeCords.TabIndex = 8;
            this.btnScrapeCords.Text = "Scrape Coordinates";
            this.btnScrapeCords.UseVisualStyleBackColor = true;
            this.btnScrapeCords.Click += new System.EventHandler(this.btnScrapeCords_Click);
            // 
            // grdCoords
            // 
            this.grdCoords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCoords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCoords.ContextMenuStrip = this.ctmnuDataGrid;
            this.grdCoords.Location = new System.Drawing.Point(1120, 100);
            this.grdCoords.Name = "grdCoords";
            this.grdCoords.Size = new System.Drawing.Size(273, 775);
            this.grdCoords.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.wbBrowser);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 833);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browser";
            // 
            // wbBrowser
            // 
            this.wbBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBrowser.Location = new System.Drawing.Point(3, 16);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(1082, 814);
            this.wbBrowser.TabIndex = 0;
            // 
            // txtDestFolder
            // 
            this.txtDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestFolder.Location = new System.Drawing.Point(119, 38);
            this.txtDestFolder.Name = "txtDestFolder";
            this.txtDestFolder.Size = new System.Drawing.Size(1695, 20);
            this.txtDestFolder.TabIndex = 10;
            // 
            // btnBrowseDst
            // 
            this.btnBrowseDst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDst.Location = new System.Drawing.Point(1820, 39);
            this.btnBrowseDst.Name = "btnBrowseDst";
            this.btnBrowseDst.Size = new System.Drawing.Size(31, 19);
            this.btnBrowseDst.TabIndex = 11;
            this.btnBrowseDst.Text = "...";
            this.btnBrowseDst.UseVisualStyleBackColor = true;
            this.btnBrowseDst.Click += new System.EventHandler(this.btnBrowseDst_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Source Images";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Destination Images";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(525, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(337, 31);
            this.label13.TabIndex = 11;
            this.label13.Text = "This tab isn\'t working yet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 1025);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBrowseDst);
            this.Controls.Add(this.txtDestFolder);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.btnBrowseSrc);
            this.Controls.Add(this.txtSourceFolder);
            this.Name = "Form1";
            this.Text = "Uber OCR";
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ctmnuDataGrid.ResumeLayout(false);
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnBrowseSrc;
        private System.Windows.Forms.FolderBrowserDialog fbdFolders;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.TextBox txtTimeRequested;
        private System.Windows.Forms.TextBox txtDateRequested;
        private System.Windows.Forms.TextBox txtPointsEarned;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrgAddress;
        private System.Windows.Forms.TextBox txtDestAddress;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWriteCSVFile;
        private System.Windows.Forms.SaveFileDialog sfdFiles;
        private System.Windows.Forms.ContextMenuStrip ctmnuDataGrid;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDestFolder;
        private System.Windows.Forms.Button btnBrowseDst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTakeSnapshot;
        private System.Windows.Forms.Button btnScrapeCords;
        private System.Windows.Forms.DataGridView grdCoords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btnBrowseGeoSite;
        private System.Windows.Forms.Label label13;
    }
}

