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
using System.Windows.Shapes;

namespace GPACalculator
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private string name;
        private string date;
        int length;
        Student studentExample = new Student();

        public Window1()
        {
            InitializeComponent();
        }

        public void Button_Calculation(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();
            name = this.NameBox.Text; // Saving the name and the date on button click
            date = this.NameBox.Text;

            newStudent.SetName(name);
            newStudent.SetDate(date);
        }

        public void Generate_Classes(object sender, RoutedEventArgs e)
        {
            string x= this.DropDown.Text;
            if(!Int32.TryParse(x, out length))
            {
                length = 0;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    ComboBox newOne = new ComboBox();
                    newOne.Items.Add("A");
                    newOne.Items.Add("A-");
                    newOne.Items.Add("B+");
                    newOne.Items.Add("B");
                    newOne.Items.Add("B-");
                    newOne.Items.Add("C+");
                    newOne.Items.Add("C");
                    newOne.Items.Add("C-");
                    newOne.Items.Add("D+");
                    newOne.Items.Add("D");
                    newOne.Items.Add("D-");
                    newOne.Items.Add("F");

                    this.StackPack1.Children.Add(new TextBox());
                    this.StackPack2.Children.Add(newOne);
                }
            }
        }

        public void Reset_Classes(object sender, RoutedEventArgs e)
        {
            this.StackPack1.Children.Clear();
            this.StackPack2.Children.Clear();
            this.CalcBox.Text = "";
        }

        public double Get_Grades(string txt)
        {
            switch (txt)
            {
                case "A":
                    return 4.0;
                case "A-":
                    return 3.67;
                case "B+":
                    return 3.33;
                case "B":
                    return 3.00;
                case "B-":
                    return 2.67;
                case "C+":
                    return 2.33;
                case "C":
                    return 2.00;
                case "C-":
                    return 1.67;
                case "D+":
                    return 1.33;
                case "D":
                    return 1.00;
                case "D-":
                    return 0.67;
                case "F":
                    return 0.00;
            }

            return 0.00;
        }

        public void Calculate_Points(object sender, RoutedEventArgs e)
        {
            double newPoints = 0;
            double hours = 0;

            double[] pointArr = new double[this.StackPack2.Children.Count];
            double[] hourArr = new double[this.StackPack1.Children.Count];

            int i = 0;

            foreach (var table in StackPack2.Children.OfType<ComboBox>())
            {
                pointArr[i] = Get_Grades(table.Text);
                i++;
            }

            int j = 0;

            try
            {
                foreach (var table in StackPack1.Children.OfType<TextBox>())
                {
                    double dummyValues;
                    if (double.TryParse(table.Text, out dummyValues)){
                        hourArr[j] = Convert.ToDouble(table.Text);
                        j++;
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input -- try again");
                this.CalcBox.Text = "";
            }

            int lengthOfArray = pointArr.Length;

            for (int z = 0; z < lengthOfArray ; z++)
            {
                newPoints += pointArr[z] * hourArr[z];
                hours += hourArr[z];
            }

            double calculatedGPA = Math.Round(studentExample.SolveGpa(newPoints, hours), 2);

            this.CalcBox.Text = calculatedGPA.ToString();

        }
    }
}
