namespace MyConverter
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
            this.tabChooseFile = new System.Windows.Forms.TabControl();
            this.tabPageSingleConvert = new System.Windows.Forms.TabPage();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.tBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectInput = new System.Windows.Forms.Button();
            this.tBoxInput = new System.Windows.Forms.TextBox();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.tabPageMultipleConvert = new System.Windows.Forms.TabPage();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.lblViewSelectedItems = new System.Windows.Forms.Label();
            this.cboxMultipleFiles = new System.Windows.Forms.ComboBox();
            this.btnMultiSelectDirectory = new System.Windows.Forms.Button();
            this.tboxMultiSelectDirectory = new System.Windows.Forms.TextBox();
            this.lblMultiSelectDirectory = new System.Windows.Forms.Label();
            this.btnMultiAddFiles = new System.Windows.Forms.Button();
            this.btnFFMpegSelect = new System.Windows.Forms.Button();
            this.tboxFFMpegPath = new System.Windows.Forms.TextBox();
            this.lblFFMpeg = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rBtnMkvToMp4 = new System.Windows.Forms.RadioButton();
            this.rBtnMp4ToMkv = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cboxConsoleBox = new System.Windows.Forms.CheckBox();
            this.tabChooseFile.SuspendLayout();
            this.tabPageSingleConvert.SuspendLayout();
            this.tabPageMultipleConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChooseFile
            // 
            this.tabChooseFile.AccessibleName = "";
            this.tabChooseFile.Controls.Add(this.tabPageSingleConvert);
            this.tabChooseFile.Controls.Add(this.tabPageMultipleConvert);
            this.tabChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabChooseFile.Location = new System.Drawing.Point(2, 36);
            this.tabChooseFile.Name = "tabChooseFile";
            this.tabChooseFile.SelectedIndex = 0;
            this.tabChooseFile.Size = new System.Drawing.Size(647, 254);
            this.tabChooseFile.TabIndex = 0;
            // 
            // tabPageSingleConvert
            // 
            this.tabPageSingleConvert.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageSingleConvert.Controls.Add(this.btnSelectOutput);
            this.tabPageSingleConvert.Controls.Add(this.tBoxOutput);
            this.tabPageSingleConvert.Controls.Add(this.label1);
            this.tabPageSingleConvert.Controls.Add(this.btnSelectInput);
            this.tabPageSingleConvert.Controls.Add(this.tBoxInput);
            this.tabPageSingleConvert.Controls.Add(this.lblInputFile);
            this.tabPageSingleConvert.Location = new System.Drawing.Point(4, 29);
            this.tabPageSingleConvert.Name = "tabPageSingleConvert";
            this.tabPageSingleConvert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingleConvert.Size = new System.Drawing.Size(639, 221);
            this.tabPageSingleConvert.TabIndex = 0;
            this.tabPageSingleConvert.Text = "Single File Convert";
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectOutput.Location = new System.Drawing.Point(566, 86);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(67, 26);
            this.btnSelectOutput.TabIndex = 6;
            this.btnSelectOutput.Text = "Select";
            this.btnSelectOutput.UseVisualStyleBackColor = true;
            this.btnSelectOutput.Click += new System.EventHandler(this.SelectOutput);
            // 
            // tBoxOutput
            // 
            this.tBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxOutput.Location = new System.Drawing.Point(6, 86);
            this.tBoxOutput.Name = "tBoxOutput";
            this.tBoxOutput.Size = new System.Drawing.Size(539, 26);
            this.tBoxOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output File (not necessary, file will be created in the same directory as input f" +
    "ile)";
            // 
            // btnSelectInput
            // 
            this.btnSelectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectInput.Location = new System.Drawing.Point(567, 26);
            this.btnSelectInput.Name = "btnSelectInput";
            this.btnSelectInput.Size = new System.Drawing.Size(67, 26);
            this.btnSelectInput.TabIndex = 2;
            this.btnSelectInput.Text = "Select";
            this.btnSelectInput.UseVisualStyleBackColor = true;
            this.btnSelectInput.Click += new System.EventHandler(this.SelectSource);
            // 
            // tBoxInput
            // 
            this.tBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxInput.Location = new System.Drawing.Point(6, 26);
            this.tBoxInput.Name = "tBoxInput";
            this.tBoxInput.Size = new System.Drawing.Size(539, 26);
            this.tBoxInput.TabIndex = 1;
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFile.Location = new System.Drawing.Point(6, 3);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(75, 20);
            this.lblInputFile.TabIndex = 0;
            this.lblInputFile.Text = "Input File";
            // 
            // tabPageMultipleConvert
            // 
            this.tabPageMultipleConvert.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageMultipleConvert.Controls.Add(this.btnRemoveFile);
            this.tabPageMultipleConvert.Controls.Add(this.lblViewSelectedItems);
            this.tabPageMultipleConvert.Controls.Add(this.cboxMultipleFiles);
            this.tabPageMultipleConvert.Controls.Add(this.btnMultiSelectDirectory);
            this.tabPageMultipleConvert.Controls.Add(this.tboxMultiSelectDirectory);
            this.tabPageMultipleConvert.Controls.Add(this.lblMultiSelectDirectory);
            this.tabPageMultipleConvert.Controls.Add(this.btnMultiAddFiles);
            this.tabPageMultipleConvert.Location = new System.Drawing.Point(4, 29);
            this.tabPageMultipleConvert.Name = "tabPageMultipleConvert";
            this.tabPageMultipleConvert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultipleConvert.Size = new System.Drawing.Size(639, 221);
            this.tabPageMultipleConvert.TabIndex = 1;
            this.tabPageMultipleConvert.Text = "Multiple Files Convert";
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(525, 158);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(108, 27);
            this.btnRemoveFile.TabIndex = 9;
            this.btnRemoveFile.Text = "Remove File";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.OnClickRemoveFile);
            // 
            // lblViewSelectedItems
            // 
            this.lblViewSelectedItems.AutoSize = true;
            this.lblViewSelectedItems.Location = new System.Drawing.Point(6, 89);
            this.lblViewSelectedItems.Name = "lblViewSelectedItems";
            this.lblViewSelectedItems.Size = new System.Drawing.Size(154, 20);
            this.lblViewSelectedItems.TabIndex = 8;
            this.lblViewSelectedItems.Text = "View Selected Items";
            // 
            // cboxMultipleFiles
            // 
            this.cboxMultipleFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMultipleFiles.Location = new System.Drawing.Point(10, 112);
            this.cboxMultipleFiles.MaxDropDownItems = 30;
            this.cboxMultipleFiles.Name = "cboxMultipleFiles";
            this.cboxMultipleFiles.Size = new System.Drawing.Size(486, 28);
            this.cboxMultipleFiles.TabIndex = 7;
            // 
            // btnMultiSelectDirectory
            // 
            this.btnMultiSelectDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiSelectDirectory.Location = new System.Drawing.Point(525, 38);
            this.btnMultiSelectDirectory.Name = "btnMultiSelectDirectory";
            this.btnMultiSelectDirectory.Size = new System.Drawing.Size(108, 26);
            this.btnMultiSelectDirectory.TabIndex = 6;
            this.btnMultiSelectDirectory.Text = "Select Directory";
            this.btnMultiSelectDirectory.UseVisualStyleBackColor = true;
            this.btnMultiSelectDirectory.Click += new System.EventHandler(this.SelectMultipleOutput);
            // 
            // tboxMultiSelectDirectory
            // 
            this.tboxMultiSelectDirectory.Location = new System.Drawing.Point(10, 38);
            this.tboxMultiSelectDirectory.Name = "tboxMultiSelectDirectory";
            this.tboxMultiSelectDirectory.Size = new System.Drawing.Size(486, 26);
            this.tboxMultiSelectDirectory.TabIndex = 4;
            // 
            // lblMultiSelectDirectory
            // 
            this.lblMultiSelectDirectory.AutoSize = true;
            this.lblMultiSelectDirectory.Location = new System.Drawing.Point(6, 15);
            this.lblMultiSelectDirectory.Name = "lblMultiSelectDirectory";
            this.lblMultiSelectDirectory.Size = new System.Drawing.Size(174, 20);
            this.lblMultiSelectDirectory.TabIndex = 3;
            this.lblMultiSelectDirectory.Text = "Select Output Directory";
            // 
            // btnMultiAddFiles
            // 
            this.btnMultiAddFiles.Location = new System.Drawing.Point(525, 112);
            this.btnMultiAddFiles.Name = "btnMultiAddFiles";
            this.btnMultiAddFiles.Size = new System.Drawing.Size(108, 28);
            this.btnMultiAddFiles.TabIndex = 2;
            this.btnMultiAddFiles.Text = "Add File/s";
            this.btnMultiAddFiles.UseVisualStyleBackColor = true;
            this.btnMultiAddFiles.Click += new System.EventHandler(this.SelectMultipleFiles);
            // 
            // btnFFMpegSelect
            // 
            this.btnFFMpegSelect.Location = new System.Drawing.Point(573, 307);
            this.btnFFMpegSelect.Name = "btnFFMpegSelect";
            this.btnFFMpegSelect.Size = new System.Drawing.Size(66, 23);
            this.btnFFMpegSelect.TabIndex = 10;
            this.btnFFMpegSelect.Text = "Select";
            this.btnFFMpegSelect.UseVisualStyleBackColor = true;
            this.btnFFMpegSelect.Click += new System.EventHandler(this.SelectAdditionalProgram);
            // 
            // tboxFFMpegPath
            // 
            this.tboxFFMpegPath.Location = new System.Drawing.Point(13, 309);
            this.tboxFFMpegPath.Name = "tboxFFMpegPath";
            this.tboxFFMpegPath.Size = new System.Drawing.Size(539, 20);
            this.tboxFFMpegPath.TabIndex = 9;
            // 
            // lblFFMpeg
            // 
            this.lblFFMpeg.AutoSize = true;
            this.lblFFMpeg.Location = new System.Drawing.Point(13, 293);
            this.lblFFMpeg.Name = "lblFFMpeg";
            this.lblFFMpeg.Size = new System.Drawing.Size(97, 13);
            this.lblFFMpeg.TabIndex = 8;
            this.lblFFMpeg.Text = "FFMpeg.Exe - path";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConvert.Location = new System.Drawing.Point(484, 360);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(68, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.OnClickConvert);
            // 
            // rBtnMkvToMp4
            // 
            this.rBtnMkvToMp4.AutoSize = true;
            this.rBtnMkvToMp4.Location = new System.Drawing.Point(13, 335);
            this.rBtnMkvToMp4.Name = "rBtnMkvToMp4";
            this.rBtnMkvToMp4.Size = new System.Drawing.Size(84, 17);
            this.rBtnMkvToMp4.TabIndex = 1;
            this.rBtnMkvToMp4.Text = "MKV to Mp4";
            this.rBtnMkvToMp4.UseVisualStyleBackColor = true;
            // 
            // rBtnMp4ToMkv
            // 
            this.rBtnMp4ToMkv.AutoSize = true;
            this.rBtnMp4ToMkv.Location = new System.Drawing.Point(13, 363);
            this.rBtnMp4ToMkv.Name = "rBtnMp4ToMkv";
            this.rBtnMp4ToMkv.Size = new System.Drawing.Size(88, 17);
            this.rBtnMp4ToMkv.TabIndex = 2;
            this.rBtnMp4ToMkv.Text = "Mp4 To MKV";
            this.rBtnMp4ToMkv.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(134, 363);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(317, 17);
            this.progressBar.TabIndex = 3;
            // 
            // cboxConsoleBox
            // 
            this.cboxConsoleBox.AutoSize = true;
            this.cboxConsoleBox.Location = new System.Drawing.Point(134, 336);
            this.cboxConsoleBox.Name = "cboxConsoleBox";
            this.cboxConsoleBox.Size = new System.Drawing.Size(85, 17);
            this.cboxConsoleBox.TabIndex = 4;
            this.cboxConsoleBox.Text = "Console Info";
            this.cboxConsoleBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 396);
            this.Controls.Add(this.btnFFMpegSelect);
            this.Controls.Add(this.cboxConsoleBox);
            this.Controls.Add(this.tboxFFMpegPath);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblFFMpeg);
            this.Controls.Add(this.rBtnMp4ToMkv);
            this.Controls.Add(this.rBtnMkvToMp4);
            this.Controls.Add(this.tabChooseFile);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabChooseFile.ResumeLayout(false);
            this.tabPageSingleConvert.ResumeLayout(false);
            this.tabPageSingleConvert.PerformLayout();
            this.tabPageMultipleConvert.ResumeLayout(false);
            this.tabPageMultipleConvert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabChooseFile;
        private System.Windows.Forms.TabPage tabPageSingleConvert;
        private System.Windows.Forms.Button btnSelectOutput;
        private System.Windows.Forms.TextBox tBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSelectInput;
        private System.Windows.Forms.TextBox tBoxInput;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.RadioButton rBtnMkvToMp4;
        private System.Windows.Forms.RadioButton rBtnMp4ToMkv;
        private System.Windows.Forms.Button btnFFMpegSelect;
        private System.Windows.Forms.TextBox tboxFFMpegPath;
        private System.Windows.Forms.Label lblFFMpeg;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox cboxConsoleBox;
        private System.Windows.Forms.TabPage tabPageMultipleConvert;
        private System.Windows.Forms.Button btnMultiAddFiles;
        private System.Windows.Forms.TextBox tboxMultiSelectDirectory;
        private System.Windows.Forms.Label lblMultiSelectDirectory;
        private System.Windows.Forms.Button btnMultiSelectDirectory;
        private System.Windows.Forms.Label lblViewSelectedItems;
        private System.Windows.Forms.ComboBox cboxMultipleFiles;
        private System.Windows.Forms.Button btnRemoveFile;
    }
}

