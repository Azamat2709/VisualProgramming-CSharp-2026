using System;
namespace FillingTheBlanks
{
 class Student
    {
        private string name; // Private field to store the student's name

        public string Name
        {
            get {
                 return name; // Getter to retrieve the student's name
                 }
            set {
                 name = value; // Setter to set the student's name
                 }
        }
    }
}