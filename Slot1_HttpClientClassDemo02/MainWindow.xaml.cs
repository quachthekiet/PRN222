using System.Net.Http;
using System.Windows;

namespace Slot1_HttpClientClassDemo02
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        readonly HttpClient client = new HttpClient();
        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();
        private async void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtContent.Text = string.Empty;
        }
        private async void btnViewHTML_Click(object sender, RoutedEventArgs e)
        {
            string uri = txtURL.Text;
            try
            {
                string responseBody = await client.GetStringAsync(uri);
                txtContent.Text = responseBody.Trim();
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show($"Message: {ex.Message}");
            }
        }


    }
}