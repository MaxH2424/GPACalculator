using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    public class Student
    {
        private double gradePoints;
        private int creditHours;
        private string studentName;
        private int classes;
        private double gpa;

        Student()
        {
            gradePoints = 0;
            creditHours = 0;
            studentName = "";
            classes = 0;
            gpa = 0;
        }

        Student(int points, int ch, string sn, int cl, double g)
        {
            gradePoints = points;
            creditHours = ch;
            studentName = sn;
            classes = cl;
            gpa = g;
        }

        public void SetName(string n)
        {
            studentName = n;
        }

        public string GetName()
        {
            return studentName;
        }

        public double GetPoints()
        {
            return gradePoints;
        }

        public void SetPoints(double p)
        {
            gradePoints = p;
        }

        public double GetHours()
        {
            return creditHours;
        }

        public void SetHours(int h)
        {
            creditHours = h;
        }

        public void SetClasses(int c)
        {
            classes = c;
        }

        public int GetClasses()
        {
            return classes;
        }

        public double GetGpa()
        {
            return gpa;
        }

        public void SetGpa(double g)
        {
            gpa = g;
        }

        public double SolveGpa(double points, double ch)
        {
            return (points / ch);
        }

    }
}
