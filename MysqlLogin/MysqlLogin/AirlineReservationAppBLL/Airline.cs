using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlLogin.AirlineReservationAppDAL
{
    public class Airline
    {
        public string airline { get; set; }
        public string flightNumber { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public string departureDate { get; set; }
        public string departureTime { get; set; }
        public string arrivalDate { get; set; }
        public string arrivalTime { get; set; }
        public string currency { get; set; }
        public decimal fare { get; set; }
        public int seats { get; set; }
        public int crew { get; set; }
        public string seatType { get; set; }
    }
}
