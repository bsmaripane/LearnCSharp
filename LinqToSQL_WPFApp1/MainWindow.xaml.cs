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

namespace LinqToSQL_WPFApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL_WPFApp1.Properties.Settings.TutorialsDbConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            InsertUniversities();
            InsertStudent();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("DELETE FROM University");

            University UJ = new University();
            UJ.Name = "University of Johannesburg";
            dataContext.Universities.InsertOnSubmit(UJ);

            University unisa = new University();
            unisa.Name = "University of South Africa";
            dataContext.Universities.InsertOnSubmit(unisa);

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudent()
        {
            University uj = dataContext.Universities.First(un => un.Name.Equals("University of Johannesburg"));
            University unisa = dataContext.Universities.First(un => un.Name.Equals("University of South Africa"));

            List<Student> students = new List<Student>();

            students.Add(new Student { StudentName = "Felicia", Gender = "female", UniversityId = uj.Id });
            students.Add(new Student { StudentName = "Belmy", Gender = "male", University = unisa });
            students.Add(new Student { StudentName = "Tracy", Gender = "female", University = uj });
            students.Add(new Student { StudentName = "Lesego", Gender = "male", UniversityId = unisa.Id });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }
        
        public void InsertLecturer()
        {

        }
    }
}
