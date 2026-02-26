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

namespace WPF__CurrencyConverter_StaticApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblCurreny.Content = "Hello World";
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            // Add conversion logic here
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // Add clear logic here
        }

        private void NumberValidationTextBox(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            // Add number validation logic here
        }
    }
}