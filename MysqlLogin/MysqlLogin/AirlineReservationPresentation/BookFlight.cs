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

namespace MysqlLogin.AirlineReservationPresentation
{
    public partial class BookFlight : Form
    {
        public PassengerDAL pDal = new PassengerDAL();
        public Booking booking = new Booking();
        public BookFlight()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            txtBoxFlightNumber.Enabled = false;
            txtBoxAirline.Enabled = false;
            txtBoxSource.Enabled = false;
            txtSourceDestination.Enabled = false;
            txtDepartureDate.Enabled = false;
            txtDepartureTime.Enabled = false;
            txtArrivalDate.Enabled = false;
            txtBoxArrivalTime.Enabled = false;
            txtBoxSeatType.Enabled = false;
            txtBoxCurrency.Enabled = false;

            booking.flightNumber = txtBoxFlightNumber.Text;
            booking.source = txtBoxSource.Text;
            booking.destination = txtSourceDestination.Text;
            booking.departureDate = txtDepartureDate.Text;
            booking.departureTime = txtDepartureTime.Text;
            booking.arrivalDate = txtArrivalDate.Text;
            booking.arrivalTime = txtBoxArrivalTime.Text;
            booking.seatType = txtBoxSeatType.Text;
            booking.currency = txtBoxCurrency.Text;
            booking.airline = txtBoxAirline.Text;
            booking.fare = Convert.ToDecimal(txtBoxCost.Text);
            booking.numberSeats = Convert.ToInt32(txtBoxNumberSeats.Text);
            int rows = pDal.BookTicket(booking);
            if (rows > 0)
            {
                MessageBox.Show("Booked successfully");
                
            }
            else
            {
                MessageBox.Show("Please select all the fields");
            }
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void txtBoxNumberSeats_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxNumberSeats.Text))
            {
                int numberOfSeats = Convert.ToInt32(txtBoxNumberSeats.Text);
                decimal fare = Convert.ToDecimal(txtBoxCost.Text);
                fare = numberOfSeats * fare;
                txtBoxCost.Text = Convert.ToString(fare);
            }
        }

        private void BookFlight_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBoxNumberSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(ch==46 && txtBoxNumberSeats.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
        }

        private void txtBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtBoxCost.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowBooking sb = new ShowBooking();
        }
    }
}
