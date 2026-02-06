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
            string sql = @"INSERT INTO tblBooking
                  (CustomerID, RoomID, BookingStartsDate, BookingEndsDate)
                  VALUES (?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.Add("@CustomerID", OleDbType.Integer).Value = booking.CustomerID;
                cmd.Parameters.Add("@RoomID", OleDbType.Integer).Value = booking.RoomID;
                cmd.Parameters.Add("@Start", OleDbType.Date).Value = booking.BookingStartsDate.Date;
                cmd.Parameters.Add("@End", OleDbType.Date).Value = booking.BookingEndsDate.Date;


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
                            BookingID = Convert.ToInt32(reader["BookingID"]),
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            RoomID = Convert.ToInt32(reader["RoomID"]),
                            CheckInDate = Convert.ToDateTime(reader["CheckInDate"]),
                            CheckOutDate = Convert.ToDateTime(reader["CheckOutDate"]),
                            TotalAmount = Convert.ToInt32(reader["TotalAmount"]),
                            BookingStartsDate = Convert.ToDateTime(reader["BookingStartsDate"]),
                            BookingEndsDate = Convert.ToDateTime(reader["BookingEndsDate"])
                        };


                        bookings.Add(booking);
                    }
                }
            }
            return bookings;
        }
    }
}
