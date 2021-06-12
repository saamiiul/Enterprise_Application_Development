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

namespace SignUpForm
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
        private void save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( "You Enter Following Information:\n\n" + firstName.Text + "\n" + lastName.Text + "\n" + userName.Text + "\n" + email.Text + "\n" + password.Password);
        }
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush mySolidColor = new SolidColorBrush();
            mySolidColor.Color = Colors.Silver;
            firstName.Text = "First Name";
            firstName.Foreground = mySolidColor;
            lastName.Text = "Last Name";
            lastName.Foreground = mySolidColor;
            userName.Text = "User Name";
            userName.Foreground = mySolidColor;
            email.Text = "Email";
            email.Foreground = mySolidColor;
            password.Password = "Password";
            password.Foreground = mySolidColor;
        }
        private void firstName_GotFocus(object sender, RoutedEventArgs e)
        {
            if(firstName.Text == "First Name")
            {
                firstName.Text = "";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Black;
                firstName.Foreground = mySolidColor;
            }
        }
        private void firstName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (firstName.Text == "")
            {
                firstName.Text = "First Name";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Silver;
                firstName.Foreground = mySolidColor;
            }
        }
        private void lastName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (lastName.Text == "Last Name")
            {
                lastName.Text = "";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Black;
                lastName.Foreground = mySolidColor;
            }
        }

        private void lastName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (lastName.Text == "")
            {
                lastName.Text = "Last Name";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Silver;
                lastName.Foreground = mySolidColor;
            }
        }

        private void userName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (userName.Text == "User Name")
            {
                userName.Text = "";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Black;
                userName.Foreground = mySolidColor;
            }
        }

        private void userName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (userName.Text == "")
            {
                userName.Text = "User Name";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Silver;
                userName.Foreground = mySolidColor;
            }
        }
        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = "";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Black;
                email.Foreground = mySolidColor;
            }
        }

        private void email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Silver;
                email.Foreground = mySolidColor;
            }
        }

        private void password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (password.Password == "Password")
            {
                password.Password = "";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Black;
                password.Foreground = mySolidColor;
            }
        }
        private void password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (password.Password == "")
            {
                password.Password = "Password";
                SolidColorBrush mySolidColor = new SolidColorBrush();
                mySolidColor.Color = Colors.Silver;
                password.Foreground = mySolidColor;
            }
        }
    }
}
