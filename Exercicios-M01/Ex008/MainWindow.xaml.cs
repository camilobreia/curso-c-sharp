using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int n1, n2;
            int.TryParse(txtInic.Text, out n1);
            int.TryParse(txtFim.Text, out n2);

            Random gerador = new Random();
            int ger = gerador.Next(n1, n2+1);

            lblMsg.Visibility = Visibility.Visible;
            lblMsg.Content = $"Sorteando de {n1} a {n2}...";
            await Task.Delay(2000);
            lblMsg.Content = $"Sorteei o valor {ger}";
        }
    }
}