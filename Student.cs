using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_Selection_boxes
{
    public class Student
    {
        //fields
        public string FirstName;
        public string LastName;
        public int CSIGrade;
        public int GenEdGrade;

       //Constructor
        public Student(string firstName, string lastName, int cSIGrade, int genEdGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = cSIGrade;
            GenEdGrade = genEdGrade;
        }

    }
}
