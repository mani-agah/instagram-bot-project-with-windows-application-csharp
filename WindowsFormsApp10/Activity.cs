using InstagramApiSharp;
using InstagramApiSharp.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Activity : Form
    {
        public IInstaApi api;
        public Activity()
        {
            InitializeComponent();
        }

        private void Activity_Load(object sender, EventArgs e)
        {
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private async void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var resAc = await api.UserProcessor.GetRecentActivityFeedAsync(PaginationParameters.MaxPagesToLoad(1));
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Maximum = resAc.Value.Items.Count;
            });
            for (int i = 0; i<resAc.Value.Items.Count; i++)
            {
                backgroundWorker1.ReportProgress(i);
            }
        }
    }
}
