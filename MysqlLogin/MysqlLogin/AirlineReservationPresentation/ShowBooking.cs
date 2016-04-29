using MysqlLogin.AirlineReservationAppDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysqlLogin
{
      public partial class ShowBooking : Form
    {
        public PassengerDAL pDal = new PassengerDAL();
        public Booking book = new Booking();
        public Connection db = new Connection();
        public ShowBooking()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void ShowBooking_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pDal.showBooking(book);
            dgvShowBooking.DataSource = dt;
        }
    }
}
