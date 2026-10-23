using System;

namespace StudentGradeCalculator
{
    public class Student
    {
        public double grade;

        public void ReadGrade()
        {
            Console.WriteLine("Enter the grade of the student:");
        }

        public void GetGrade()
        {
            grade = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();

            student1.ReadGrade();
            student1.GetGrade();

            student2.ReadGrade();
            student2.GetGrade();

            student3.ReadGrade();
            student3.GetGrade();

            double average = CalculateAverage(student1, student2, student3);
            DisplayAverage(average);
        }

        static double CalculateAverage(Student s1, Student s2, Student s3)
        {
            return (s1.grade + s2.grade + s3.grade) / 3.0;
        }

        static void DisplayAverage(double average)
        {
            Console.WriteLine("The average grade of the students is: " + average);
        }
    }
}
