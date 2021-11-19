using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginningToAsyncProgramming
{
    public partial class Form1 : Form
    {
        public int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public string ReadFile()
        {
            string data = string.Empty;

            using (StreamReader reader = new StreamReader("names.txt"))
            {
                Thread.Sleep(5000);
                data = reader.ReadToEnd();
            }

            return data;
        }

        private async Task<string> ReadFileAsync()
        {
            string data = string.Empty;

            using (StreamReader reader = new StreamReader("names.txt"))
            {
                Task<string> myTask = reader.ReadToEndAsync();

                //İşlem başlangıcından bitişine kadar işlem 
                //yapılabilir.

                await Task.Delay(5000);

                data = await myTask;
            }

            return data;
        }

        private void btnAddCounter_Click(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = counter.ToString();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            string data = String.Empty;

            Task<string> readingFile = ReadFileAsync();


            rchTxtGoogle.Text = await new HttpClient().GetStringAsync("https://www.google.com");


            data = await readingFile;

            rchTxtName.Text = data;
        }

    }
}
