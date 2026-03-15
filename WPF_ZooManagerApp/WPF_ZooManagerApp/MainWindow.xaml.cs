using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPF_ZooManagerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager
                .ConnectionStrings["WPF_ZooManagerApp.Properties.Settings.TutorialsDbConnectionString"]
                .ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos();
        }

        private void ShowZoos()
        {
            try
            {
                string query = "SELECT * FROM Zoo";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();

                    sqlDataAdapter.Fill(zooTable);
                    listZoos.DisplayMemberPath = "Location";    // Which information of the Table in the DataTable should be shown in our ListBox?
                    listZoos.SelectedValuePath = "Id";  // Which value should be delivered, when an item from our ListBox is selected?
                    listZoos.ItemsSource = zooTable.DefaultView; // Reference to the Data the ListBox  should populate
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ShowAssociatedAnimals()
        { 
            try
            {
                string query = "SELECT * " +
                    "FROM Animal a " +
                    "INNER JOIN ZooAnimal za ON a.Id = za.AnimalId " +
                    "WHERE za.ZooId = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                    DataTable animalTable = new DataTable();

                    sqlDataAdapter.Fill(animalTable);
                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           MessageBox.Show(listZoos.SelectedValue.ToString());
        }
    }
}
