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
using MysqlLogin.AirlineReservationPresentation;

namespace MysqlLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }

        private void btnShowBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowBooking sb = new ShowBooking();
            sb.ShowDialog();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelReservation cr = new CancelReservation();
            cr.ShowDialog();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPassenger lp = new LoginPassenger();
            lp.ShowDialog();
         }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
