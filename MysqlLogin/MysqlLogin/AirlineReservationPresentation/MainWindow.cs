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
    public partial class MainWindow : Form
    {
        public PassengerDAL pDal = new PassengerDAL();
        DataTable dt = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dgvAvailability.Hide();
            btnBook.Hide();
        }
        private void btnShowBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowBooking sb = new ShowBooking();
            sb.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void btnCheckReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelReservation cr = new CancelReservation();
            cr.ShowDialog();
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            string airline = txtBoxAirline.Text;
            string source = textBoxSource.Text;
            string destination = textBoxDestination.Text;
            if (textBoxSource.Text == textBoxDestination.Text)
            {
                MessageBox.Show("Select Correct Destination");
            }
            else
            {
                dgvAvailability.Show();
                btnBook.Show();
                dt = pDal.checkAvailability(airline, source, destination);
                dgvAvailability.DataSource = dt;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookFlight bf = new BookFlight();
            if (dgvAvailability.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAvailability.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAvailability.Rows[selectedrowindex];
                string flightNumber = selectedRow.Cells[0].Value.ToString();
                string airline = selectedRow.Cells[10].Value.ToString();
                string source = selectedRow.Cells[1].Value.ToString();
                string destination = selectedRow.Cells[2].Value.ToString();
                string departureDate = selectedRow.Cells[3].Value.ToString();
                string departureTime = selectedRow.Cells[4].Value.ToString();
                string arrivalDate = selectedRow.Cells[5].Value.ToString();
                string arrivalTime = selectedRow.Cells[6].Value.ToString();
                string seatType = selectedRow.Cells[11].Value.ToString();
                string currency = selectedRow.Cells[8].Value.ToString();
                string fare = selectedRow.Cells[7].Value.ToString();

                bf.txtBoxFlightNumber.Text = flightNumber;
                bf.txtBoxAirline.Text = airline;
                bf.txtBoxSource.Text = source;
                bf.txtSourceDestination.Text = destination;
                bf.txtDepartureDate.Text = departureDate;
                bf.txtDepartureTime.Text = departureTime;
                bf.txtArrivalDate.Text = arrivalDate;
                bf.txtBoxArrivalTime.Text = arrivalTime;
                bf.txtBoxSeatType.Text = seatType;
                bf.txtBoxCurrency.Text = currency;
                bf.txtBoxCost.Text = fare;
                this.Hide();
                bf.ShowDialog(); 
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
