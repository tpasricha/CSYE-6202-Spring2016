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
using log4net;

namespace MysqlLogin
{
    public partial class Register : Form
    {

        private static ILog logger = LogManager.GetLogger(typeof(Register));
        public Passenger passenger = new Passenger();
        public string gender;
        public PassengerDAL pDal = new PassengerDAL();
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            passenger.name = txtBoxName.Text;
            if(radioMale.Checked==true)
            {
                gender = "Male";
            }
            if(radioFemale.Checked == true)
            {
                gender = "Female";
            }
            passenger.gender = gender;
            passenger.emailId = txtBoxEmailId.Text;
            //   passenger.dob = Convert.ToDateTime(dateTimepicker.ToShortDateString());
            passenger.age = Convert.ToInt32(txtBoxAge.Text);
            passenger.phoneNumber = Convert.ToInt32(txtBoxPhoneNumber.Text);
            passenger.userName = txtBoxUserName.Text;
            passenger.password = txtBoxPassword.Text;
            passenger.confirmPassword = txtBoxConfirmPassword.Text;

            int rows = pDal.insertPassenger(passenger);
            if(rows>0)
            {
                logger.Info("Rows more than zero");
                this.Hide();
                MainWindow mw = new MainWindow();
                mw.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
    }
}
