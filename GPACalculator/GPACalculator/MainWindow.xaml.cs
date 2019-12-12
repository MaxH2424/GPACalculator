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

namespace GPACalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string name;
        private string date;

        public MainWindow()
        {
            InitializeComponent();
            //System.IO.File.WriteAllLines(@"C:\Users\Max Hendricks\Downloads\C#\GPADoc", name);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = this.NameBox.Text;
            date = this.NameBox.Text;
            
        }
    }
}
