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
    public partial class AddCrew : Form       
    {
        public PassengerDAL pDal = new PassengerDAL();
        public Airline airline = new Airline();
        public Crew crew = new Crew();
        public AddCrew()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            airline.flightNumber = textBoxFlightNumber.Text;
            crew.id = textBoxCrewId.Text;
            crew.crewNumber = Convert.ToInt32(textBoxCrewMembers.Text);           
        }
    }
}
