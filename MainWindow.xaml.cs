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

        Student selectedStudent = null;
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

            //automatically select the first item in our listbox load
            lbDisplay.SelectedIndex = 0;
            
        }
        



        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {
            string userinput = txtToAdd.Text;

            lbDisplay.Items.Add(userinput);

        }


        public void DisplayToListBox()

        {
            //use the .Clear() method to clear all iteams from our listbox
            lbDisplay.Items.Clear();


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
                DisplayStudentInformation(selectedStudent);

            }

        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string fName = txtFirstName.Text;
            string LName = txtLastName.Text;
            string csi = txtCsiGrade.Text;
            string gened = txtGenEdGrade.Text;

            int csiGrade = int.Parse(csi);
            int genEdGrade = int.Parse(gened);

            // i want to create a new instance of students
            



            students.Add(new Student(fName, LName, csiGrade, genEdGrade));
            //update our listbox
            //so we call our method

            DisplayToListBox();
            
        }


        public void DisplayStudentInformation(Student student)
        {
            
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCsiGrade.Text = student.CSIGrade.ToString();
            txtGenEdGrade.Text = student.GenEdGrade.ToString();


        }
        private void btnRemoveSelectedStudent_Click(object sender, RoutedEventArgs e)
        {

            //remove by index
            //int selectedIndex = lbDisplay.SelectedIndex;
            //students.RemoveAt(selectedIndex);

            //Remove by Object
            int selectedIndex = lbDisplay.SelectedIndex;
            Student selectedStudent = students[selectedIndex];
            students.Remove(selectedStudent);

            DisplayToListBox();
        }

        private void lbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = lbDisplay.SelectedIndex;

            selectedStudent = students[selectedIndex];
        }
    }
}
