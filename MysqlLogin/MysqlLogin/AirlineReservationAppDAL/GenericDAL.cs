using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MysqlLogin.AirlineReservationAppDAL;
using MysqlLogin.AirlineReservationPresentation;

namespace MysqlLogin
{
    public class PassengerDAL
    {
        DataTable dt = new DataTable();
        public Connection db = new Connection();
        public Passenger pass = new Passenger();
        public Airline air = new Airline();
        public Booking book = new Booking();
        public Crew crew = new Crew();
              
        public int insertPassenger(Passenger passenger)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into PassengerLogin Values('" + passenger.name + "','" + passenger.gender + "','" + passenger.emailId + "','" + passenger.age + "','" + passenger.phoneNumber + "','" + passenger.userName + "','"
                + passenger.password + "','" + passenger.confirmPassword + "','Passenger')";
            return db.ExeNonQuery(command);
            
        }

        public DataTable showBooking(Booking book)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Booking";
            return db.ExecuteReader(command);
        }

        public int deletePassenger(string Username)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from PassengerLogin WHERE userName='" + Username+ "'";
            return db.ExeNonQuery(command);
        }

        public DataTable showAirlines(Airline air)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Flight";
            return db.ExecuteReader(command);
            }

        public DataTable checkAvailability(string airline, string source, string destination)
        {
            var result= new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Flight WHERE airline ='" + airline + "'and Source='" + source + "'and Destination='" + destination + "'";
            try
            {
                result = db.ExecuteReader(command);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }

        public int BookTicket(Booking b)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Booking Values('" + b.flightNumber + "','" + b.source+ "','" + b.destination + "','" + b.departureDate + "','" + b.departureTime 
                + "','" + b.arrivalDate + "','" + b.arrivalTime + "','" + b.fare + "','" + b.numberSeats + "','" + b.airline + "','" + b.currency + "','" + b.seatType+ "')";
            return db.ExeNonQuery(command);
        }

        public DataTable showPassenger(Passenger pass)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from PassengerLogin";
            return db.ExecuteReader(command);
        }

        public int insertAirline(Airline airline)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Flight Values('" + airline.flightNumber + "','" + airline.source + "','" + airline.destination + "','" + airline.departureDate +"','"
                + airline.departureTime + "','" + airline.arrivalDate + "','" + airline.arrivalTime + "','" + airline.fare + "','" + airline.currency +"','" + airline.seats + "','" + airline.airline + "','" + airline.crew+ "','" + airline.seatType + "')";
            return db.ExeNonQuery(command);
        }

        public int deleteAirline(string fligtNo)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from Flight WHERE FlightNumber='" + fligtNo + "'";  
            return db.ExeNonQuery(command);
        }

        public int insertCrew(Airline airline)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Crew Values('" + airline.flightNumber + "','" + crew.id + "','" + crew.crewNumber + "')";
            return db.ExeNonQuery(command);
        }

        public DataTable login(Passenger pass)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PassengerLogin WHERE userName ='" + pass.userName + "'and Password='" + pass.password + "'";
            return db.ExecuteReader(command);
        }
    }
}
