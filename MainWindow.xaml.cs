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

namespace _122_Selection_boxes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {


            InitializeComponent();

            //how to add iteams to a selection box
            //add to a selection box by accessing its
            // iteam list
            //////lbDisplay.Items.Add("Alex");
            //////lbDisplay.Items.Add(1);
            //////lbDisplay.Items.Add(1.6);
            //////lbDisplay.Items.Add(true);
            PreLoad();
            DisplayToListBox();
            
        }
        



        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {
            string userinput = txtToAdd.Text;

            lbDisplay.Items.Add(userinput);

        }


        public void DisplayToListBox()
        {
            for (int i = 0; i < students.Count; i++)
            {
                string firstName = students[i].FirstName;
                string lastName = students[i].LastName;
                string fullName = firstName + " " + lastName;

                lbDisplay.Items.Add(fullName);
            }
        }



        public void PreLoad()
        {
            //Student student1 = new Student()
            //{
            //    FirstName = "Alex",
            //    LastName = "Garcia",
            //    CSIGrade = 67,
            //    GenEdGrade = 97

            //};
            Student student = new Student("Alex", "Garcia", 67, 97);

            students.Add(student);
            students.Add(new Student("Hannah", "Angel", 101, 99));
            students.Add(new Student("Dylan", "Register", 101, 99));
            students.Add(new Student("Kris", "Taniguchi", 101, 99));


        }

        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {
            //You can access the selected iteam by using .SelectedIndex
            int selectedindex = lbDisplay.SelectedIndex;

            if(selectedindex < 0)
            {
                MessageBox.Show("Please select a name from the listbox");
            }
            else
            {
                Student selectedStudent = students[selectedindex];
                txtFirstName.Text = selectedStudent.FirstName;
                txtLastName.Text = selectedStudent.LastName;
                txtCsiGrade.Text = selectedStudent.CSIGrade.ToString();
                txtGenEdGrade.Text = selectedStudent.GenEdGrade.ToString();



            }

        }
    }
}
