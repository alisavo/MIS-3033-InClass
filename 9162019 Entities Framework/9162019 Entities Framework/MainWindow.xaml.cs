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

namespace _9162019_Entities_Framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB_128040_practiceEntities db = new DB_128040_practiceEntities();


        public MainWindow()
        {
            InitializeComponent();
            TBStudentID.Text = string.Empty;
        }

        private void btnFetch_Click(object sender, RoutedEventArgs e)
        {
            if(TBStudentID.Text==string.Empty)
            {
                foreach (var student in db.Students)
                {
                    string temp = $"{student.LastName},{student.FirstName} ({student.StudentID}) likes {student.FavoriteColor}";
                    LBData.Items.Add(temp);
                }

            }
            else
            {
                int id;
                if (Int32.TryParse(TBStudentID.Text,out id)==true)
                {
                   var s= db.Students.Find(id);// Where(student => student.StudentID == id);


                    foreach (var student in db.Students)
                    {
                        if (student.StudentID == id)
                        {
                            string temp = $"{student.LastName},{student.FirstName} ({student.StudentID}) likes {student.FavoriteColor}";
                            LBData.Items.Add(temp);

                        }
                    }
                    //Find can only work on Primary Keys
                }
            }

        }


    }
}
