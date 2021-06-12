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

namespace LoginForm
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome.");
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

        private void cancek_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush mySolidColor = new SolidColorBrush();
            mySolidColor.Color = Colors.Silver;
            email.Text = "Email";
            email.Foreground = mySolidColor;
            password.Password = "Password";
            password.Foreground = mySolidColor;
        }
    }
}
