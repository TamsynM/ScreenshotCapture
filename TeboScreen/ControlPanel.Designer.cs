namespace ScreenshotCapture
{
    partial class ControlPanel
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
            this.bttCaptureScreen = new System.Windows.Forms.Button();
            this.bttCaptureArea = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtTips = new System.Windows.Forms.RichTextBox();
            this.saveToClipboard = new System.Windows.Forms.CheckBox();
            this.projNumLbl = new System.Windows.Forms.Label();
            this.projNameLbl = new System.Windows.Forms.Label();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.versionLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.projNumTxtBox = new System.Windows.Forms.TextBox();
            this.projNameTxtBox = new System.Windows.Forms.TextBox();
            this.fileNameTxtBox = new System.Windows.Forms.TextBox();
            this.versionTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttCaptureScreen
            // 
            this.bttCaptureScreen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttCaptureScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttCaptureScreen.Location = new System.Drawing.Point(2, 15);
            this.bttCaptureScreen.Name = "bttCaptureScreen";
            this.bttCaptureScreen.Size = new System.Drawing.Size(90, 32);
            this.bttCaptureScreen.TabIndex = 0;
            this.bttCaptureScreen.TabStop = false;
            this.bttCaptureScreen.Text = "Capture Screen";
            this.bttCaptureScreen.UseVisualStyleBackColor = false;
            this.bttCaptureScreen.Click += new System.EventHandler(this.bttCaptureScreen_Click);
            this.bttCaptureScreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bttCaptureScreen_KeyUp);
            // 
            // bttCaptureArea
            // 
            this.bttCaptureArea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttCaptureArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttCaptureArea.Location = new System.Drawing.Point(2, 57);
            this.bttCaptureArea.Name = "bttCaptureArea";
            this.bttCaptureArea.Size = new System.Drawing.Size(90, 32);
            this.bttCaptureArea.TabIndex = 2;
            this.bttCaptureArea.TabStop = false;
            this.bttCaptureArea.Text = "Capture Area";
            this.bttCaptureArea.UseVisualStyleBackColor = false;
            this.bttCaptureArea.Click += new System.EventHandler(this.bttCaptureArea_Click);
            this.bttCaptureArea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bttCaptureArea_KeyUp);
            // 
            // txtTips
            // 
            this.txtTips.BackColor = System.Drawing.SystemColors.Window;
            this.txtTips.Location = new System.Drawing.Point(125, 7);
            this.txtTips.Name = "txtTips";
            this.txtTips.ReadOnly = true;
            this.txtTips.Size = new System.Drawing.Size(247, 105);
            this.txtTips.TabIndex = 5;
            this.txtTips.Text = "";
            this.txtTips.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTips_KeyUp);
            // 
            // saveToClipboard
            // 
            this.saveToClipboard.AutoSize = true;
            this.saveToClipboard.Location = new System.Drawing.Point(9, 95);
            this.saveToClipboard.Name = "saveToClipboard";
            this.saveToClipboard.Size = new System.Drawing.Size(110, 17);
            this.saveToClipboard.TabIndex = 6;
            this.saveToClipboard.TabStop = false;
            this.saveToClipboard.Text = "Save to Clipboard";
            this.saveToClipboard.UseVisualStyleBackColor = true;
            this.saveToClipboard.CheckedChanged += new System.EventHandler(this.saveToClipboard_CheckedChanged);
            this.saveToClipboard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.saveToClipboard_KeyUp);
            // 
            // projNumLbl
            // 
            this.projNumLbl.AutoSize = true;
            this.projNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projNumLbl.Location = new System.Drawing.Point(6, 25);
            this.projNumLbl.Name = "projNumLbl";
            this.projNumLbl.Size = new System.Drawing.Size(98, 13);
            this.projNumLbl.TabIndex = 7;
            this.projNumLbl.Text = "Project Number:";
            // 
            // projNameLbl
            // 
            this.projNameLbl.AutoSize = true;
            this.projNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projNameLbl.Location = new System.Drawing.Point(193, 25);
            this.projNameLbl.Name = "projNameLbl";
            this.projNameLbl.Size = new System.Drawing.Size(87, 13);
            this.projNameLbl.TabIndex = 8;
            this.projNameLbl.Text = "Project Name:";
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLbl.Location = new System.Drawing.Point(6, 79);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(67, 13);
            this.fileNameLbl.TabIndex = 9;
            this.fileNameLbl.Text = "File Name:";
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLbl.Location = new System.Drawing.Point(193, 79);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(53, 13);
            this.versionLbl.TabIndex = 10;
            this.versionLbl.Text = "Version:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLbl.Location = new System.Drawing.Point(6, 134);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(48, 13);
            this.authorLbl.TabIndex = 11;
            this.authorLbl.Text = "Author:";
            // 
            // projNumTxtBox
            // 
            this.projNumTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ScreenshotCapture.Properties.Settings.Default, "projectNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.projNumTxtBox.Location = new System.Drawing.Point(9, 41);
            this.projNumTxtBox.Name = "projNumTxtBox";
            this.projNumTxtBox.Size = new System.Drawing.Size(115, 20);
            this.projNumTxtBox.TabIndex = 12;
            this.projNumTxtBox.Text = global::ScreenshotCapture.Properties.Settings.Default.projectNumber;
            // 
            // projNameTxtBox
            // 
            this.projNameTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ScreenshotCapture.Properties.Settings.Default, "projectName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.projNameTxtBox.Location = new System.Drawing.Point(196, 41);
            this.projNameTxtBox.Name = "projNameTxtBox";
            this.projNameTxtBox.Size = new System.Drawing.Size(115, 20);
            this.projNameTxtBox.TabIndex = 13;
            this.projNameTxtBox.Text = global::ScreenshotCapture.Properties.Settings.Default.projectName;
            // 
            // fileNameTxtBox
            // 
            this.fileNameTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ScreenshotCapture.Properties.Settings.Default, "fileName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fileNameTxtBox.Location = new System.Drawing.Point(9, 95);
            this.fileNameTxtBox.Name = "fileNameTxtBox";
            this.fileNameTxtBox.Size = new System.Drawing.Size(115, 20);
            this.fileNameTxtBox.TabIndex = 14;
            this.fileNameTxtBox.Text = global::ScreenshotCapture.Properties.Settings.Default.fileName;
            // 
            // versionTxtBox
            // 
            this.versionTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ScreenshotCapture.Properties.Settings.Default, "version", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.versionTxtBox.Location = new System.Drawing.Point(196, 95);
            this.versionTxtBox.Name = "versionTxtBox";
            this.versionTxtBox.Size = new System.Drawing.Size(115, 20);
            this.versionTxtBox.TabIndex = 15;
            this.versionTxtBox.Text = global::ScreenshotCapture.Properties.Settings.Default.version;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ScreenshotCapture.Properties.Settings.Default, "author", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.authorTxtBox.Location = new System.Drawing.Point(9, 150);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(115, 20);
            this.authorTxtBox.TabIndex = 16;
            this.authorTxtBox.Text = global::ScreenshotCapture.Properties.Settings.Default.author;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(196, 192);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 17;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(196, 150);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save Settings";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.projNumLbl);
            this.groupBox1.Controls.Add(this.exitBtn);
            this.groupBox1.Controls.Add(this.projNameLbl);
            this.groupBox1.Controls.Add(this.authorTxtBox);
            this.groupBox1.Controls.Add(this.fileNameLbl);
            this.groupBox1.Controls.Add(this.versionTxtBox);
            this.groupBox1.Controls.Add(this.versionLbl);
            this.groupBox1.Controls.Add(this.fileNameTxtBox);
            this.groupBox1.Controls.Add(this.authorLbl);
            this.groupBox1.Controls.Add(this.projNameTxtBox);
            this.groupBox1.Controls.Add(this.projNumTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 237);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Screenshot Settings";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(380, 384);
            this.Controls.Add(this.saveToClipboard);
            this.Controls.Add(this.txtTips);
            this.Controls.Add(this.bttCaptureScreen);
            this.Controls.Add(this.bttCaptureArea);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanel";
            this.ShowIcon = false;
            this.Text = "Screenshot App";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttCaptureScreen;
        private System.Windows.Forms.Button bttCaptureArea;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox txtTips;
        private System.Windows.Forms.CheckBox saveToClipboard;
        private System.Windows.Forms.Label projNumLbl;
        private System.Windows.Forms.Label projNameLbl;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox projNumTxtBox;
        private System.Windows.Forms.TextBox projNameTxtBox;
        private System.Windows.Forms.TextBox fileNameTxtBox;
        private System.Windows.Forms.TextBox versionTxtBox;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}