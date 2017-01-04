namespace MyConverter.Core
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using MyConverter.Globals;

    public class Converter
    {
        private ProgressBar progressBar;

        public delegate void OnFinish();

        public event OnFinish ConvertIsDone;

        public Converter(ProgressBar progressBar)
        {
            this.progressBar = progressBar;
        }

        public async void ConvertAsync(ICollection<Process> collection, bool consoleInfo)
        {
            foreach (Process process in collection)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        process.Start();

                        if (consoleInfo)
                        {
                            process.BeginOutputReadLine();
                            process.BeginErrorReadLine();
                        }

                        process.WaitForExit();
                    });

                    if (process.HasExited)
                    {
                        process.Dispose();
                    }

                    this.progressBar.Value = 0;

                }
                catch (Exception ex)
                {
                    this.TestLogger(Default.ErrorLogPath, ex.Message);
                }
            }

            if (this.ConvertIsDone != null)
            {
                this.ConvertIsDone();
            }
        }

        private void TestLogger(string path, string text)
        {
            File.AppendAllText(path, text + Environment.NewLine);
        }

        public void GetProgress(object sender, DataReceivedEventArgs e)
        {
            string logData = e.Data;

            if (string.IsNullOrEmpty(logData))
            {
                this.progressBar.Invoke(new Action(() => this.progressBar.Value = 0));
                return;
            }

            int lastIndexOf = logData.IndexOf("Duration:");

            if (lastIndexOf > 0)
            {
                var durationText = logData.Substring(lastIndexOf, 18).Split(' ')[1].Split(':');

                int durationOfFile = this.CalculateSeconds(durationText);

                //string durPath = @"D:\Downloads\Test\dur.txt";
                //this.TestLogger(durPath,"-----------" + durationOfFile + "------" + logData);

                this.progressBar.Invoke(new Action(() => this.progressBar.Maximum = durationOfFile));
            }

            lastIndexOf = logData.IndexOf("time=");

            if (lastIndexOf > 0)
            {
                string fullTimeText = logData.Substring(lastIndexOf, 13);

                var time = fullTimeText.Split('=')[1].Split(':');

                int currentSecond = this.CalculateSeconds(time);

                //string durPath = @"D:\Downloads\Test\time.txt";
                //this.TestLogger(durPath, total + "-----" + logData);

                this.progressBar.Invoke(new Action(() => this.progressBar.Value = currentSecond < this.progressBar.Maximum ? currentSecond : this.progressBar.Maximum - 1));
            }
        }

        private int CalculateSeconds(string[] time)
        {
            int hour = int.Parse(time[0]) * Default.SecondsPerMin * Default.SecondsPerMin;
            int min = int.Parse(time[1]) * Default.SecondsPerMin;
            int sec = int.Parse(time[2]);

            int totalSeconds = hour + min + sec;

            return totalSeconds;
        }
    }
}
