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

namespace MenuBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void newItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Item Selected.");
        }
        private void openItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Item Opened.");
        }

        private void closeItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Item Closed.");
        }

        private void editItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit Item.");
        }

        private void viewItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Item Viewed.");
        }

        private void sum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal num1 = decimal.Parse(number01.Text);
                decimal num2 = decimal.Parse(number02.Text);
                MessageBox.Show("The Result is: " + (num1 + num2).ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Only Enter Number in input.");
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal num1 = decimal.Parse(number01.Text);
                decimal num2 = decimal.Parse(number02.Text);
                MessageBox.Show("The Result is: " + (num1 - num2).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Only Enter Number in input.");
            }
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal num1 = decimal.Parse(number01.Text);
                decimal num2 = decimal.Parse(number02.Text);
                MessageBox.Show("The Result is: " + (num1 * num2).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Only Enter Number in input.");
            }
        }

        private void devide_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal num1 = decimal.Parse(number01.Text);
                decimal num2 = decimal.Parse(number02.Text);
                if (num1 >= num2)
                {
                    MessageBox.Show("The Result is: " + (num1 / num2).ToString());
                }
                else
                {
                    MessageBox.Show("Division is not possible.");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Only Enter Number in input.");
            }
        }

        private void number01_GotFocus(object sender, RoutedEventArgs e)
        {
            if (number01.Text == "Enter Number")
            {
                number01.Text = "";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Black;
                number01.Foreground = mySolidColor;
            }
        }

        private void number01_LostFocus(object sender, RoutedEventArgs e)
        {
            if (number01.Text == "")
            {
                number01.Text = "Enter Number";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Silver;
                number01.Foreground = mySolidColor;
            }
        }

        private void number02_GotFocus(object sender, RoutedEventArgs e)
        {
            if (number02.Text == "Enter Number")
            {
                number02.Text = "";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Black;
                number02.Foreground = mySolidColor;
            }
        }

        private void number02_LostFocus(object sender, RoutedEventArgs e)
        {
            if (number02.Text == "")
            {
                number02.Text = "Enter Number";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Silver;
                number02.Foreground = mySolidColor;
            }
        }
    }
}
