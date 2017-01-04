namespace MyConverter
{
    using System.Diagnostics;
    using System;
    using System.Windows.Forms;
    using MyConverter.Core;
    using MyConverter.Globals;

    public partial class Form1 : Form
    {
        private ConverterRepo repo;
        private Converter converter;
        
        public Form1()
        {
            this.InitializeComponent();
            this.repo = new ConverterRepo();
        }

        private void SelectSource(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = false;

            if (this.rBtnMkvToMp4.Checked)
            {
                ofd.Title = InfoText.SelectMKV;
                ofd.Filter = InfoText.FilterMKV;
            }
            else if (this.rBtnMp4ToMkv.Checked)
            {
                ofd.Title = InfoText.SelectMp4;
                ofd.Filter = InfoText.FilterMp4;
            }

            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.tBoxInput.Text = ofd.FileName;
            }
        }

        private void SelectOutput(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (this.rBtnMkvToMp4.Checked)
            {
                saveFileDialog.Title = InfoText.TypeName;
                saveFileDialog.Filter = InfoText.FilterMp4;
            }
            else if (this.rBtnMp4ToMkv.Checked)
            {
                saveFileDialog.Title = InfoText.TypeName;
                saveFileDialog.Filter = InfoText.FilterMKV;
            }

            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.tBoxOutput.Text = saveFileDialog.FileName;
            }
        }

        private void SelectMultipleFiles(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var fileName in openFileDialog.FileNames)
                {
                    this.cboxMultipleFiles.Items.Add(fileName);
                }

                this.cboxMultipleFiles.SelectedIndex = 0;
            }
        }

        private void SelectMultipleOutput(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.tboxMultiSelectDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void OnClickConvert(object sender, EventArgs e)
        {
            this.LockForm();
            this.converter = new Converter(this.progressBar);
            this.converter.ConvertIsDone += this.UnlockForm;

            if (this.tabPageSingleConvert.Focus())
            {
                string sourceName = this.tBoxInput.Text;
                string outputFile = this.tBoxOutput.Text;
                
                this.ChoseConvertMethod(sourceName, outputFile);
            }
            else
            {
                if (this.cboxMultipleFiles.Items.Count == 0)
                {
                    MessageBox.Show(InfoText.NoChosenFile);
                    return;
                }

                foreach (var item in this.cboxMultipleFiles.Items)
                {
                    string sourceName = item.ToString();
                    string outputDirectory = this.tboxMultiSelectDirectory.Text;

                    this.ChoseConvertMethod(sourceName, outputDirectory);
                }
            }

            this.converter.ConvertAsync(this.repo.GetAll(), !this.cboxConsoleBox.Checked);
            this.repo.Clear();
        }

        private void ChoseConvertMethod(string sourceName, string outputFile)
        {
            if (string.IsNullOrEmpty(sourceName))
            {
                MessageBox.Show(InfoText.NoChosenFile);
                return;
            }
            
            if (!this.tboxFFMpegPath.Text.EndsWith(InfoText.FFMPEGFile))
            {
                MessageBox.Show(InfoText.SelectFFMPEG);
                return;
            }

            if (this.rBtnMkvToMp4.Checked)
            {
                if (!sourceName.ToLower().EndsWith(FileExtension.Mkv)) 
                {
                    MessageBox.Show(string.Format(InfoText.InvalidFormat, FileExtension.Mkv));
                    return;
                }

                if (string.IsNullOrWhiteSpace(outputFile))
                {
                    outputFile = IO.ChangeExtension(sourceName, FileExtension.Mp4);
                }

                if (!outputFile.EndsWith(FileExtension.Mp4)) 
                {
                    MessageBox.Show(string.Format(InfoText.InvalidFormat, FileExtension.Mp4));
                    return;
                }

                while(IO.IsFileExists(outputFile))
                {
                    outputFile = IO.SetNewName(outputFile);
                }
                
                this.SetProcess(sourceName, outputFile);
            }
            else if (this.rBtnMp4ToMkv.Checked)
            {
                
            }
            else
            {
                MessageBox.Show(InfoText.SelectMethod);
                return;
            }
        }
        
        private void LockForm()
        {
            //this.btnCancel.Enabled = true;
            this.btnMultiSelectDirectory.Enabled = false;
            this.btnMultiAddFiles.Enabled = false;
            this.btnRemoveFile.Enabled = false;
            this.btnConvert.Enabled = false;
            this.btnSelectInput.Enabled = false;
            this.btnSelectOutput.Enabled = false;
            this.btnFFMpegSelect.Enabled = false;
            this.tBoxInput.ReadOnly = true;
            this.tBoxOutput.ReadOnly = true;
            this.tboxFFMpegPath.ReadOnly = true;
            this.tBoxInput.Enabled = false;
            this.tBoxOutput.Enabled = false;
            this.tboxFFMpegPath.Enabled = false;
            this.rBtnMkvToMp4.Enabled = false;
            this.rBtnMp4ToMkv.Enabled = false;
            this.cboxConsoleBox.Enabled = false;
        }

        private void UnlockForm()
        {
            //this.btnCancel.Enabled = false;
            this.btnMultiSelectDirectory.Enabled = true;
            this.btnMultiAddFiles.Enabled = true;
            this.btnRemoveFile.Enabled = true;
            this.btnConvert.Enabled = true;
            this.btnSelectInput.Enabled = true;
            this.btnSelectOutput.Enabled = true;
            this.tBoxInput.Enabled = true;
            this.tBoxOutput.Enabled = true;
            this.tboxFFMpegPath.Enabled = true;
            this.btnFFMpegSelect.Enabled = true;
            this.tBoxInput.ReadOnly = false;
            this.tBoxOutput.ReadOnly = false;
            this.tboxFFMpegPath.ReadOnly = false;
            this.rBtnMkvToMp4.Enabled = true;
            this.rBtnMp4ToMkv.Enabled = true;
            this.cboxConsoleBox.Enabled = true;
        }

        private void SelectAdditionalProgram(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Multiselect = false;
            OFD.FilterIndex = 1;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                this.tboxFFMpegPath.Text = OFD.FileName;
            }
        }
        
        private void SetProcess(string infile, string outfile)
        {
            // ffmpeg path
            // source file full path
            // output file full path

            Process process = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(this.tboxFFMpegPath.Text);
            
            psi.Arguments = $"-i \"{infile}\" -c:v libx264 -c:a aac \"{outfile}\"";
            psi.CreateNoWindow = !this.cboxConsoleBox.Checked;
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = !this.cboxConsoleBox.Checked;
            psi.RedirectStandardError = !this.cboxConsoleBox.Checked;      
            psi.WorkingDirectory = IO.GetDirectory(outfile); 
            
            if (!this.cboxConsoleBox.Checked)
            {
                process.ErrorDataReceived += this.converter.GetProgress;
            }
            string ffmpegDirectory = IO.GetDirectory(this.tboxFFMpegPath.Text);
            process.StartInfo.EnvironmentVariables.Add("TempPath", ffmpegDirectory);
            process.StartInfo = psi;
            
            this.repo.Add(process);
        }

        private void OnClickRemoveFile(object sender, EventArgs e)
        {
            int currentItemIndex = this.cboxMultipleFiles.SelectedIndex;

            this.cboxMultipleFiles.Items.RemoveAt(currentItemIndex);

            if (this.cboxMultipleFiles.Items.Count > 0)
            {
                this.cboxMultipleFiles.SelectedIndex = 0;
            }
        }
    }
}
