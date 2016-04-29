using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MysqlLogin.AirlineReservationAppDAL;
using MysqlLogin.AirlineReservationPresentation;

namespace MysqlLogin
{
    public partial class LoginPassenger : Form
    {
        public Passenger pass = new Passenger();
        public PassengerDAL pDal = new PassengerDAL();
        public string checkType;

        DataTable dt = new DataTable();

        public LoginPassenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pass.userName = txtBoxUserName.Text;
            pass.password = txtBoxPassword.Text;

            dt = pDal.login(pass);
             if(dt.Rows.Count>0)
            {
                checkType = dt.Rows[0][8].ToString().Trim();
                if (checkType == "Admin")
                {
                    this.Hide();
                    AdminMain am = new AdminMain();
                    am.ShowDialog();
                }
                else {
                    this.Hide();
                    MainWindow mw = new MainWindow();
                    mw.ShowDialog();
                }
            }
             else
            {
                MessageBox.Show("Please input username/password correct.");
            }
        }
    }
}
