using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskRun
{
    public partial class Form1 : Form
    {
        public static int Counter { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            var firstTask = ProgressBarStart(progressBar1);

            var secondTask = ProgressBarStart(progressBar2);

            await Task.WhenAll(firstTask, secondTask);
        }

        public async Task ProgressBarStart(ProgressBar progressBar)
        {
            await Task.Run(() =>
            {
                Enumerable.Range(1, 100).ToList().ForEach(x =>
                {
                    Thread.Sleep(100);

                    //Farklı bir thread üzerinden işlem yaparken , UI thread
                    //üzerinden erişemediği için normalde hata verecektir.
                    progressBar.Invoke((MethodInvoker) delegate
                    {
                        progressBar.Value = x;
                    });
                });
            });

        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            btnCounter.Text = Counter++.ToString();
        }
    }
}
