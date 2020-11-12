using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Creazione100Bgw
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        BackgroundWorker bgw1, bgw2;
        List<BackgroundWorker> bgw_List = new List<BackgroundWorker>();


        private void Bgw_DoWork_1(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            TextBox txt = e.Argument as TextBox;

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                bgw.ReportProgress(i, txt);

                if (bgw.CancellationPending)
                {
                    e.Result = (false, txt);
                    return;
                }
            }

            e.Result = (true, txt);
        }

        private void Bgw_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            TextBox txt = e.UserState as TextBox;
            txt.Text = e.ProgressPercentage + Environment.NewLine + txt.Text;
        }

        private void Bgw_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            var (completato, txt) = (ValueTuple<bool, TextBox>)e.Result;
            txt.Text = completato ? "concluso" + Environment.NewLine + txt.Text : "cancellato" + Environment.NewLine + txt.Text;
        }

        private void btnAvvio2_Click_1(object sender, EventArgs e)
        {
            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += Bgw_DoWork_1;
            bgw1.ProgressChanged += Bgw_ProgressChanged_1;
            bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted_1;

            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += Bgw_DoWork_1;
            bgw2.ProgressChanged += Bgw_ProgressChanged_1;
            bgw2.RunWorkerCompleted += Bgw_RunWorkerCompleted_1;

            bgw1.RunWorkerAsync(txt2);
            bgw2.RunWorkerAsync(txt2);
        }

        private void btnStop2_Click_1(object sender, EventArgs e)
        {
            bgw1.CancelAsync();
            bgw2.CancelAsync();
        }

        private void btnAvvio100_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                BackgroundWorker bgw1 = new BackgroundWorker();
                bgw1.WorkerReportsProgress = true;
                bgw1.WorkerSupportsCancellation = true;
                bgw1.DoWork += Bgw_DoWork_1;
                bgw1.ProgressChanged += Bgw_ProgressChanged_1;
                bgw1.RunWorkerCompleted += Bgw_RunWorkerCompleted_1;

                bgw_List.Add(bgw1);
            }

            foreach (var bgw in bgw_List)
            {
                bgw.RunWorkerAsync(txt100);
            }
        }

        private void btnStop100_Click_1(object sender, EventArgs e)
        {
            foreach (var bgw in bgw_List)
            {
                bgw.CancelAsync();
            }
        }

    }
}

