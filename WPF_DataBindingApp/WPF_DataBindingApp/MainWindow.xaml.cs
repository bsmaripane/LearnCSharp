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

        public List<Person> People = new List<Person>()
        {
            new Person{Name = "Belmy", Age = 30},
            new Person{Name = "Felicia", Age = 29},
            new Person{Name = "Maashele", Age = 53},
            new Person{Name = "Lesego", Age = 11},
            new Person{Name = "Kganya", Age = 4}
        };

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = person;
            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;

            foreach (var item in selectedItems)
            {
                var person = (Person)item;
                MessageBox.Show($"Name: { person.Name}, age: {person.Age} years");
            }
        }

        //    private void Button_Click(object sender, RoutedEventArgs e)
        //    {
        //        string personData = $"{person.Name} is {person.Age} years old" ;
        //        MessageBox.Show(personData);
        //    }
    }
}