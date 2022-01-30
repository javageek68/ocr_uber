
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.fbdFolders = new System.Windows.Forms.FolderBrowserDialog();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.txtDestAddress = new System.Windows.Forms.TextBox();
            this.txtOrgAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPointsEarned = new System.Windows.Forms.TextBox();
            this.txtDateRequested = new System.Windows.Forms.TextBox();
            this.txtTimeRequested = new System.Windows.Forms.TextBox();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.pctData = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnWriteCSVFile = new System.Windows.Forms.Button();
            this.sfdFiles = new System.Windows.Forms.SaveFileDialog();
            this.ctmnuDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.gbForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctData)).BeginInit();
            this.ctmnuDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOutput.Location = new System.Drawing.Point(440, 111);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(389, 875);
            this.txtOutput.TabIndex = 2;
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(21, 111);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(403, 875);
            this.lstFiles.TabIndex = 3;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolder.Location = new System.Drawing.Point(29, 66);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(1783, 20);
            this.txtSourceFolder.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(1820, 67);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 19);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grdData
            // 
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.ContextMenuStrip = this.ctmnuDataGrid;
            this.grdData.Location = new System.Drawing.Point(838, 574);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(438, 425);
            this.grdData.TabIndex = 6;
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.btnWriteCSVFile);
            this.gbForm.Controls.Add(this.btnAdd);
            this.gbForm.Controls.Add(this.txtVehicleType);
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
            this.gbForm.Location = new System.Drawing.Point(838, 115);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(432, 429);
            this.gbForm.TabIndex = 7;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origin Address";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fare";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Distance";
            // 
            // txtImageName
            // 
            this.txtImageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageName.Location = new System.Drawing.Point(122, 43);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(276, 20);
            this.txtImageName.TabIndex = 6;
            // 
            // txtDistance
            // 
            this.txtDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDistance.Location = new System.Drawing.Point(122, 211);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(276, 20);
            this.txtDistance.TabIndex = 7;
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuration.Location = new System.Drawing.Point(122, 178);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(276, 20);
            this.txtDuration.TabIndex = 8;
            // 
            // txtFare
            // 
            this.txtFare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFare.Location = new System.Drawing.Point(122, 145);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(276, 20);
            this.txtFare.TabIndex = 9;
            // 
            // txtDestAddress
            // 
            this.txtDestAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestAddress.Location = new System.Drawing.Point(122, 112);
            this.txtDestAddress.Name = "txtDestAddress";
            this.txtDestAddress.Size = new System.Drawing.Size(276, 20);
            this.txtDestAddress.TabIndex = 10;
            // 
            // txtOrgAddress
            // 
            this.txtOrgAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrgAddress.Location = new System.Drawing.Point(122, 76);
            this.txtOrgAddress.Name = "txtOrgAddress";
            this.txtOrgAddress.Size = new System.Drawing.Size(276, 20);
            this.txtOrgAddress.TabIndex = 11;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Points Earned";
            // 
            // txtPointsEarned
            // 
            this.txtPointsEarned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPointsEarned.Location = new System.Drawing.Point(122, 343);
            this.txtPointsEarned.Name = "txtPointsEarned";
            this.txtPointsEarned.Size = new System.Drawing.Size(276, 20);
            this.txtPointsEarned.TabIndex = 16;
            // 
            // txtDateRequested
            // 
            this.txtDateRequested.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateRequested.Location = new System.Drawing.Point(122, 310);
            this.txtDateRequested.Name = "txtDateRequested";
            this.txtDateRequested.Size = new System.Drawing.Size(276, 20);
            this.txtDateRequested.TabIndex = 17;
            // 
            // txtTimeRequested
            // 
            this.txtTimeRequested.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeRequested.Location = new System.Drawing.Point(122, 277);
            this.txtTimeRequested.Name = "txtTimeRequested";
            this.txtTimeRequested.Size = new System.Drawing.Size(276, 20);
            this.txtTimeRequested.TabIndex = 18;
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVehicleType.Location = new System.Drawing.Point(122, 244);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(276, 20);
            this.txtVehicleType.TabIndex = 19;
            // 
            // pctData
            // 
            this.pctData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctData.Location = new System.Drawing.Point(1291, 115);
            this.pctData.Name = "pctData";
            this.pctData.Size = new System.Drawing.Size(560, 884);
            this.pctData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctData.TabIndex = 8;
            this.pctData.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnWriteCSVFile
            // 
            this.btnWriteCSVFile.Location = new System.Drawing.Point(171, 391);
            this.btnWriteCSVFile.Name = "btnWriteCSVFile";
            this.btnWriteCSVFile.Size = new System.Drawing.Size(83, 23);
            this.btnWriteCSVFile.TabIndex = 21;
            this.btnWriteCSVFile.Text = "Write CSV File";
            this.btnWriteCSVFile.UseVisualStyleBackColor = true;
            this.btnWriteCSVFile.Click += new System.EventHandler(this.btnWriteCSVFile_Click);
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
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 1025);
            this.Controls.Add(this.pctData);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Uber OCR";
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctData)).EndInit();
            this.ctmnuDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnBrowse;
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
    }
}

