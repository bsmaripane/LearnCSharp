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

            //InsertUniversities();
            //InsertStudents();
            //InsertLectures();
            InsertStudentLectureAssociation();
        }

        public void InsertUniversities()
        {
            if (!dataContext.Universities.Any(uni => uni.Name == "University of Johannesburg"))
            {
                University UJ = new University();
                UJ.Name = "University of Johannesburg";
                dataContext.Universities.InsertOnSubmit(UJ);
            }

            if (!dataContext.Universities.Any(uni => uni.Name == "University of South Africa"))
            {
                University unisa = new University();
                unisa.Name = "University of South Africa";
                dataContext.Universities.InsertOnSubmit(unisa);
            }

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            University uj = dataContext.Universities.First(un => un.Name.Equals("University of Johannesburg"));
            University unisa = dataContext.Universities.First(un => un.Name.Equals("University of South Africa"));

            var students = new List<Student>
            {
                new Student { StudentName = "Felicia", Gender = "female", UniversityId = uj.Id },
                new Student { StudentName = "Belmy", Gender = "male", UniversityId = unisa.Id },
                new Student { StudentName = "Tracy", Gender = "female", UniversityId = uj.Id },
                new Student { StudentName = "Lesego", Gender = "male", UniversityId = unisa.Id }
            };

            var existingStudents = dataContext.Students
                .Select(s => new { s.StudentName, s.UniversityId })
                .ToList();

            var newStudents = students
                .Where(s => !existingStudents.Any(e =>
                    e.StudentName == s.StudentName &&
                    e.UniversityId == s.UniversityId))
                .ToList();

            if (newStudents.Any())
            {
                dataContext.Students.InsertAllOnSubmit(newStudents);
                dataContext.SubmitChanges();
            }

            MainDataGrid.ItemsSource = dataContext.Students
                .Select(s => new
                {
                    s.Id,
                    s.StudentName,
                    s.Gender,
                    s.UniversityId,
                    University = s.University.Name
                })
                .ToList();
        }
        
        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { LectureName = "Visual Programming I" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { LectureName = "Computer Programming I" });

            dataContext.SubmitChanges ();
            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociation()
        {
            Student felicia = dataContext.Students.First(st => st.StudentName.Equals("Felicia"));
            Student belmy = dataContext.Students.First(st => st.StudentName.Equals("Belmy"));
            Student tracy = dataContext.Students.First(st => st.StudentName.Equals("Tracy"));
            Student lesego = dataContext.Students.First(st => st.StudentName.Equals("Lesego"));

            Lecture visualProgram = dataContext.Lectures.First(lec => lec.LectureName.Equals("Visual Programming I"));
            Lecture compProgram = dataContext.Lectures.First(lec => lec.LectureName.Equals("Computer Programming I"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = felicia, Lecture = visualProgram});
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = belmy, Lecture = compProgram});
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = tracy, Lecture = visualProgram});
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = lesego, Lecture = compProgram});

            StudentLecture slFelicia = new StudentLecture();
            slFelicia.Student = felicia;
            slFelicia.LectureId = visualProgram.Id;
            dataContext.StudentLectures.InsertOnSubmit(slFelicia);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }
    }
}
