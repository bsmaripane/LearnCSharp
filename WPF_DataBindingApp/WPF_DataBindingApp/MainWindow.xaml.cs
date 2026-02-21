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
using WPF_DataBindingApp.Data;

namespace WPF_DataBindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person()
        {
            Name = "Test",
            Age = 18,
        };

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = person;
            ListBoxNames.ItemsSource = new List<string>()
            { 
                "Belmy",
                "Felicia",
                "Lesego",
                "Maashele",
                "Kganya"
            };
        }

    //    private void Button_Click(object sender, RoutedEventArgs e)
    //    {
    //        string personData = $"{person.Name} is {person.Age} years old" ;
    //        MessageBox.Show(personData);
    //    }
    }
}