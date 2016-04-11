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

namespace StudentRegistrationWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int loginattempt = 1;
        public MainWindow()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            StudentRegistrationWindow srw = new StudentRegistrationWindow();
            if (txtUsername.Text == "root" && txtPassword.Password == "root")
            {
                lblLoginInfo.Content = "Access Granted";
                loginattempt = 0;
                MessageBox.Show("Welcome to the student registration portal!!", "Login Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Hide();
               srw.Show();
            }
            else if (loginattempt == 3)
            {
                lblLoginInfo.Content = "Last chance";
                MessageBox.Show("Sorry!! Maximum attempts reached. Try again next time");
                this.Close();
            }
            else
            {
                lblLoginInfo.Content = "Access Denied!!";
                txtUsername.Text = "";
                txtPassword.Password = "";
                MessageBox.Show("Invalid Username or Password!! Please enter again, you have reached attempt " + loginattempt + " of 3");
                loginattempt += 1;
            }

        }
    }
}
