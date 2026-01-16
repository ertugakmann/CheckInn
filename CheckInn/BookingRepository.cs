using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn
{
    internal class BookingRepository
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CheckInnDatabase.accdb";

        public void CreateBooking(Booking booking)
        {
            // Create New Record for new Customer
            string sql = "INSERT INTO tblBooking (CustomerID, RoomID, BookingStartsDate, BookingEndsDate) VALUES (?, ?, ?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", booking.CustomerID);
                cmd.Parameters.AddWithValue("@RoomID", booking.RoomID);
                cmd.Parameters.AddWithValue("@BookingStartsDate", booking.BookingStartsDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@BookingEndsDate", booking.BookingEndsDate.ToString("yyyy-MM-dd"));
              
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Booking> getSelectedRoomBookings(int roomID)
        {
            List<Booking> bookings = new List<Booking>();
            string sql = "SELECT * FROM tblBooking WHERE RoomID = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@RoomID", roomID); // add the parameter value

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Booking booking = new Booking
                        {
                            BookingID = reader.GetInt32(0),
                            CustomerID = reader.GetInt32(1),
                            RoomID = reader.GetInt32(2),
                            CheckInDate = reader.GetDateTime(3),
                            CheckOutDate = reader.GetDateTime(4),
                            TotalAmount = reader.GetInt32(5),
                            BookingStartsDate = reader.GetDateTime(6),
                            BookingEndsDate = reader.GetDateTime(7),
                        };

                        bookings.Add(booking);
                    }
                }
            }
            return bookings;
        }
    }
}
