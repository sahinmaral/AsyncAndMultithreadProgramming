namespace ParallelForCancellationToken
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cancellationTokenSource;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource.Token.IsCancellationRequested)
            {
                cancellationTokenSource = new CancellationTokenSource();
            }
            
            List<string> urls = new()
            {
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
                "https://www.google.com",
                "https://www.microsoft.com",
                "https://www.amazon.com",
            };

            HttpClient httpClient = new HttpClient();
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.CancellationToken = cancellationTokenSource.Token;


                Task.Run(() =>
                {
                    try
                    {
                        Parallel.ForEach(urls, parallelOptions, (url) =>
                        {
                            cancellationTokenSource.Token.ThrowIfCancellationRequested();
                            // parallelOptions.CancellationToken.ThrowIfCancellationRequested();

                            string content = httpClient.GetStringAsync(url).Result;
                            listBoxContents.Invoke(() =>
                            {
                                listBoxContents.Items.Add($"url : {url} : content : {content.Length}");
                            });
                        });
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    
                });
            
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            count++;
            buttonIncrease.Text = count.ToString();
        }
    }
}
