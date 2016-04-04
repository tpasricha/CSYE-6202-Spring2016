using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class LoginPage : Form
    {
      int loginattempt = 1;        
        public LoginPage()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            MainPage mp = new MainPage();
                if (txtUsername.Text == "root" && txtPassword.Text == "root")
                {
                    labelLoginInfo.Text = "Access Granted";
                    loginattempt = 0;
                    this.Hide();
                    mp.Show();
                }
                else if (loginattempt==3)
                {
                    labelLoginInfo.Text = "Last chance";
                    MessageBox.Show("Sorry!! Maximum attempts reached. Application is closing");
                    this.Close();
                 }
                else 
                {
                labelLoginInfo.Text = "Access Denied!!";
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Invalid Username or Password!! Please enter again, you have reached attempt "+ loginattempt+ " of 3");
                loginattempt += 1;
                }
            }
        
         }
}