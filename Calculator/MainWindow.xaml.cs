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
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float first;
        float second;
        string? ope;
        public MainWindow()
        {


            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            resultTextBox.Text += btn.Content.ToString();
            second=float.Parse(resultTextBox.Text);
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            first = float.Parse(resultTextBox.Text);
            ope = "/";
            resultTextBox.Clear();
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            first=float.Parse(resultTextBox.Text);
            ope = "*";
            resultTextBox.Clear();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            first = float.Parse(resultTextBox.Text);
            ope="+";
            resultTextBox.Clear();
        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {
            first= float.Parse(resultTextBox.Text);
            ope = "-";
            resultTextBox.Clear();
        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {
            second=float.Parse(resultTextBox.Text);
            float result = 0;
            if (ope == "+")
            {
                result = first + second;
            }
            else if (ope == "-")
            {
                result=first-second;
            }
            else if (ope == "*")
            {
                result = first * second;
            }
            else if (ope == "/")
            {
                result = first / second;
            }
            resultTextBox.Text=result.ToString();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();  
        }

        private void powerButton_Click(object sender, RoutedEventArgs e)
        {
            float result1 = 0; 
            first= float.Parse(resultTextBox.Text);
            ope = "^2";
            result1=first*first;
            resultTextBox.Text=result1.ToString();

        }


        private void percent_Click(object sender, RoutedEventArgs e)
        {
            float result1 = 0;
            first= float.Parse(resultTextBox.Text);
            ope = "%";
            result1=first/100;
            resultTextBox.Text=result1.ToString();
        }
    }
}
