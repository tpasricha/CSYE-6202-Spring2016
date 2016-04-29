using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MysqlLogin.AirlineReservationAppDAL;

namespace MysqlLogin.AirlineReservationPresentation
{
    public partial class DeleteAirline : Form
    {
        public PassengerDAL pDal = new PassengerDAL();
        public Airline air = new Airline();
        public Connection db = new Connection();

        public DeleteAirline()
        {
            InitializeComponent();
        }

        private void DeleteAirline_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pDal.showAirlines(air);
            dgvFlights.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
                if (dgvFlights.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvFlights.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvFlights.Rows[selectedrowindex];
                string flightNo = selectedRow.Cells[0].Value.ToString();
                pDal.deleteAirline(flightNo);
                MessageBox.Show("Deletion Successful");
                DeleteAirline_Load(sender, e);
            }
                else
            {
                MessageBox.Show("Please select one row");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain am = new AdminMain();
            am.ShowDialog();
        }
    }
}
