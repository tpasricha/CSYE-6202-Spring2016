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
    
    public partial class AddFlight : Form
    {
        public Airline air = new Airline();
        public PassengerDAL pDal = new PassengerDAL();
        public AddFlight()
        {
            InitializeComponent();
        }

       
           private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

           private void btnAdd_Click(object sender, EventArgs e)
        {
            air.flightNumber = txtBoxFlightNumber.Text;
            air.source = txtBoxSource.Text;
            air.destination = txtBoxDestination.Text;
            air.departureDate = dateTimePicker1.Text;
            air.departureTime = txtBoxDepartureTime.Text;
            air.arrivalDate = dateTimePicker2.Text;
            air.arrivalTime = txtBoxArrivalTime.Text;
            air.fare = Convert.ToDecimal(txtBoxFare.Text);
            air.currency = txtBoxCurrency.Text;
            air.seats = Convert.ToInt32(txtBoxSeats.Text);
            air.airline = txtBoxAirline.Text;
            air.crew = Convert.ToInt32(textBoxCrew.Text);
            int rows = pDal.insertAirline(air);
            if (rows > 0)
            {
                MessageBox.Show("Airline added successfully");
            }
            else
            {
                MessageBox.Show("Please select all the fields");
            }
            AdminMain am = new AdminMain();
            am.ShowDialog();
        }

        private void AddAirline_Load(object sender, EventArgs e)
        {
               
        }
    }
}
