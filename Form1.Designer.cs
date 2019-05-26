namespace USB_Creator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.files = new System.Windows.Forms.ListView();
			this.addBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.remBtn = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.changeName = new System.Windows.Forms.CheckBox();
			this.volumeNameTxt = new System.Windows.Forms.TextBox();
			this.copyBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tries = new System.Windows.Forms.NumericUpDown();
			this.eject = new System.Windows.Forms.CheckBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.log = new System.Windows.Forms.RichTextBox();
			this.formatFS = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.usbList = new System.Windows.Forms.ListView();
			this.format = new System.Windows.Forms.CheckBox();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tries)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// files
			// 
			this.files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.files.Location = new System.Drawing.Point(6, 19);
			this.files.Name = "files";
			this.files.Size = new System.Drawing.Size(366, 190);
			this.files.TabIndex = 0;
			this.files.UseCompatibleStateImageBehavior = false;
			this.files.View = System.Windows.Forms.View.List;
			// 
			// addBtn
			// 
			this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addBtn.Location = new System.Drawing.Point(378, 19);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 1;
			this.addBtn.Text = "Add file";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.remBtn);
			this.groupBox1.Controls.Add(this.files);
			this.groupBox1.Controls.Add(this.addBtn);
			this.groupBox1.Location = new System.Drawing.Point(12, 172);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(459, 215);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Files to copy";
			// 
			// remBtn
			// 
			this.remBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.remBtn.Location = new System.Drawing.Point(378, 48);
			this.remBtn.Name = "remBtn";
			this.remBtn.Size = new System.Drawing.Size(75, 23);
			this.remBtn.TabIndex = 2;
			this.remBtn.Text = "Remove file";
			this.remBtn.UseVisualStyleBackColor = true;
			this.remBtn.Click += new System.EventHandler(this.remBtn_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// changeName
			// 
			this.changeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.changeName.AutoSize = true;
			this.changeName.Location = new System.Drawing.Point(185, 395);
			this.changeName.Name = "changeName";
			this.changeName.Size = new System.Drawing.Size(129, 17);
			this.changeName.TabIndex = 4;
			this.changeName.Text = "Change volume name";
			this.changeName.UseVisualStyleBackColor = true;
			this.changeName.CheckedChanged += new System.EventHandler(this.changeName_CheckedChanged);
			// 
			// volumeNameTxt
			// 
			this.volumeNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.volumeNameTxt.Location = new System.Drawing.Point(320, 393);
			this.volumeNameTxt.Name = "volumeNameTxt";
			this.volumeNameTxt.Size = new System.Drawing.Size(170, 20);
			this.volumeNameTxt.TabIndex = 5;
			// 
			// copyBtn
			// 
			this.copyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copyBtn.Location = new System.Drawing.Point(742, 393);
			this.copyBtn.Name = "copyBtn";
			this.copyBtn.Size = new System.Drawing.Size(75, 23);
			this.copyBtn.TabIndex = 3;
			this.copyBtn.Text = "Copy files";
			this.copyBtn.UseVisualStyleBackColor = true;
			this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(608, 395);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tries";
			// 
			// tries
			// 
			this.tries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tries.Location = new System.Drawing.Point(644, 393);
			this.tries.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.tries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tries.Name = "tries";
			this.tries.Size = new System.Drawing.Size(69, 20);
			this.tries.TabIndex = 8;
			this.tries.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// eject
			// 
			this.eject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.eject.AutoSize = true;
			this.eject.Checked = true;
			this.eject.CheckState = System.Windows.Forms.CheckState.Checked;
			this.eject.Location = new System.Drawing.Point(517, 395);
			this.eject.Name = "eject";
			this.eject.Size = new System.Drawing.Size(71, 17);
			this.eject.TabIndex = 10;
			this.eject.Text = "Autoeject";
			this.eject.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 419);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(829, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStatus
			// 
			this.toolStatus.Name = "toolStatus";
			this.toolStatus.Size = new System.Drawing.Size(60, 17);
			this.toolStatus.Text = "toolStatus";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.log);
			this.groupBox2.Location = new System.Drawing.Point(477, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(340, 375);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Log";
			// 
			// log
			// 
			this.log.Location = new System.Drawing.Point(6, 19);
			this.log.Name = "log";
			this.log.Size = new System.Drawing.Size(328, 350);
			this.log.TabIndex = 0;
			this.log.Text = "";
			// 
			// formatFS
			// 
			this.formatFS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.formatFS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.formatFS.FormattingEnabled = true;
			this.formatFS.Location = new System.Drawing.Point(76, 393);
			this.formatFS.Name = "formatFS";
			this.formatFS.Size = new System.Drawing.Size(101, 21);
			this.formatFS.TabIndex = 13;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.usbList);
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(459, 154);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Detected USB drives";
			// 
			// usbList
			// 
			this.usbList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.usbList.Location = new System.Drawing.Point(6, 19);
			this.usbList.Name = "usbList";
			this.usbList.Size = new System.Drawing.Size(447, 129);
			this.usbList.TabIndex = 1;
			this.usbList.UseCompatibleStateImageBehavior = false;
			this.usbList.View = System.Windows.Forms.View.Details;
			// 
			// format
			// 
			this.format.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.format.AutoSize = true;
			this.format.Location = new System.Drawing.Point(12, 395);
			this.format.Name = "format";
			this.format.Size = new System.Drawing.Size(58, 17);
			this.format.TabIndex = 15;
			this.format.Text = "Format";
			this.format.UseVisualStyleBackColor = true;
			this.format.CheckedChanged += new System.EventHandler(this.format_CheckedChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Drive";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Label";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "FileSystem";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 441);
			this.Controls.Add(this.formatFS);
			this.Controls.Add(this.format);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.volumeNameTxt);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.eject);
			this.Controls.Add(this.changeName);
			this.Controls.Add(this.tries);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.copyBtn);
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(666, 300);
			this.Name = "Form1";
			this.Text = "USB Creator";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tries)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView files;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button remBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox changeName;
        private System.Windows.Forms.TextBox volumeNameTxt;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tries;
        private System.Windows.Forms.CheckBox eject;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox log;
		private System.Windows.Forms.ComboBox formatFS;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView usbList;
		private System.Windows.Forms.CheckBox format;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}

