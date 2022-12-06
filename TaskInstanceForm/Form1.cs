namespace TaskInstanceForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetData()
        {
            var myTask = new HttpClient().GetStringAsync("https://www.google.com");
            return myTask.Result;
        }

        private void btnStartGetStringAsync_Click(object sender, EventArgs e)
        {
            var data = GetData();
            rchTxtGoogleString.Text = data;
        }
    }
}