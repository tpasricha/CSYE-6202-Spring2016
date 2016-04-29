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
    public partial class DeletePassenger : Form
    {
        public PassengerDAL pDal = new PassengerDAL();
        public Passenger pass = new Passenger();
        public Connection db = new Connection();

        public DeletePassenger()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) { 
        this.Hide();
        AdminMain am = new AdminMain();
        am.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPassengers.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPassengers.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvPassengers.Rows[selectedrowindex];
                string userName = selectedRow.Cells[5].Value.ToString();
                pDal.deletePassenger(userName);
                MessageBox.Show("Deletion Successful");
                DeletePassenger_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Please select one row");
            }

        }

        private void DeletePassenger_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pDal.showPassenger(pass);
            dgvPassengers.DataSource = dt;
        }
    }
}
