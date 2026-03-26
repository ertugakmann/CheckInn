using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace CheckInn
{
    internal class BookingRepository
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + @"\CheckInnDatabase.accdb";

        // Check if a room is already booked for selected dates
        public Booking CheckRoomAvailability(int roomID, DateTime startDate, DateTime endDate)
        {
            string sql = @"SELECT * FROM tblBooking
                           WHERE RoomID = ?
                           AND BookingStatus = 'Active'
                           AND BookingStartsDate < ?
                           AND BookingEndsDate > ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@RoomID", roomID);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@StartDate", startDate);

                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Booking
                        {
                            BookingID = Convert.ToInt32(reader["BookingID"]),
                            BookingStartsDate = Convert.ToDateTime(reader["BookingStartsDate"]),
                            BookingEndsDate = Convert.ToDateTime(reader["BookingEndsDate"])
                        };
                    }
                }
            }

            return null;
        }

       
        public void CreateBooking(Booking booking)
        {
            string sql = @"INSERT INTO tblBooking
                           (CustomerID, RoomID, BookingStartsDate, BookingEndsDate, BookingStatus)
                           VALUES (?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.Add("@CustomerID", OleDbType.Integer).Value = booking.CustomerID;
                cmd.Parameters.Add("@RoomID", OleDbType.Integer).Value = booking.RoomID;
                cmd.Parameters.Add("@Start", OleDbType.Date).Value = booking.BookingStartsDate.Date;
                cmd.Parameters.Add("@End", OleDbType.Date).Value = booking.BookingEndsDate.Date;
                cmd.Parameters.Add("@Status", OleDbType.VarChar).Value = booking.BookingStatus;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Get all bookings
        public List<Booking> GetAllBookings()
        {
            List<Booking> bookings = new List<Booking>();

            string sql = "SELECT * FROM tblBooking";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Booking booking = new Booking
                        {
                            BookingID = Convert.ToInt32(reader["BookingID"]),
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            RoomID = Convert.ToInt32(reader["RoomID"]),
                            TotalAmount = Convert.ToInt32(reader["TotalAmount"]),
                            BookingStatus = Convert.ToString(reader["BookingStatus"]),
                            BookingStartsDate = Convert.ToDateTime(reader["BookingStartsDate"]),
                            BookingEndsDate = Convert.ToDateTime(reader["BookingEndsDate"])
                        };

                        bookings.Add(booking);
                    }
                }
            }

            return bookings;
        }

        
        public List<Booking> getSelectedRoomBookings(int roomID)
        {
            List<Booking> bookings = new List<Booking>();

            string sql = "SELECT * FROM tblBooking WHERE RoomID = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@RoomID", roomID);

                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Booking booking = new Booking
                        {
                            BookingID = Convert.ToInt32(reader["BookingID"]),
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            RoomID = Convert.ToInt32(reader["RoomID"]),
                            TotalAmount = Convert.ToInt32(reader["TotalAmount"]),
                            BookingStatus = Convert.ToString(reader["BookingStatus"]),
                            BookingStartsDate = Convert.ToDateTime(reader["BookingStartsDate"]),
                            BookingEndsDate = Convert.ToDateTime(reader["BookingEndsDate"])
                        };

                        bookings.Add(booking);
                    }
                }
            }

            return bookings;
        }

     
        public void UpdateBooking(Booking booking)
        {
            string sql = @"UPDATE tblBooking
                           SET CustomerID = ?,
                               RoomID = ?,
                               TotalAmount = ?,
                               BookingStartsDate = ?,
                               BookingEndsDate = ?
                           WHERE BookingID = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", booking.CustomerID);
                cmd.Parameters.AddWithValue("@RoomID", booking.RoomID);
                cmd.Parameters.AddWithValue("@TotalAmount", booking.TotalAmount);
                cmd.Parameters.AddWithValue("@StartDate", booking.BookingStartsDate);
                cmd.Parameters.AddWithValue("@EndDate", booking.BookingEndsDate);
                cmd.Parameters.AddWithValue("@BookingID", booking.BookingID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

      
        public void CancelBooking(int bookingID)
        {
            string sql = "UPDATE tblBooking SET BookingStatus = 'Cancelled' WHERE BookingID = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@BookingID", bookingID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string GetCustomerNameByBookingID(int bookingID)
        {
            string sql = @"SELECT tblCustomer.CustomerName 
                   FROM (tblBooking 
                   INNER JOIN tblCustomer 
                   ON tblBooking.CustomerID = tblCustomer.CustomerID)
                   WHERE tblBooking.BookingID = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@BookingID", bookingID);

                conn.Open();

                object result = cmd.ExecuteScalar();

                return result != null ? result.ToString() : "Unknown";
            }
        }

        public int GetTotalRooms()
        {
            string sql = "SELECT COUNT(*) FROM tblRoom";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

       
        public int GetOccupiedRooms()
        {
            string sql = @"SELECT COUNT(*) FROM tblBooking
                           WHERE BookingStatus='Active'
                           AND BookingStartsDate <= Date()
                           AND BookingEndsDate >= Date()";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

      
        public DataTable GetTodaysCheckIns()
        {
            DataTable table = new DataTable();

            string sql = @"SELECT 
                           tblRoom.RoomID AS Room,
                           tblCustomer.CustomerName AS Customer,
                           tblBooking.BookingStartsDate AS [Check In]
                           FROM (tblBooking
                           INNER JOIN tblRoom ON tblBooking.RoomID = tblRoom.RoomID)
                           INNER JOIN tblCustomer ON tblBooking.CustomerID = tblCustomer.CustomerID
                           WHERE tblBooking.BookingStartsDate = Date()
                           AND tblBooking.BookingStatus = 'Active'";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
            {
                adapter.Fill(table);
            }

            return table;
        }

        public DataTable GetTodaysCheckOuts()
        {
            DataTable table = new DataTable();

            string sql = @"SELECT 
                           tblRoom.RoomID AS Room,
                           tblCustomer.CustomerName AS Customer,
                           tblBooking.BookingEndsDate AS [Check Out]
                           FROM (tblBooking
                           INNER JOIN tblRoom ON tblBooking.RoomID = tblRoom.RoomID)
                           INNER JOIN tblCustomer ON tblBooking.CustomerID = tblCustomer.CustomerID
                           WHERE tblBooking.BookingEndsDate = Date()
                           AND tblBooking.BookingStatus = 'Active'";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
            {
                adapter.Fill(table);
            }

            return table;
        }

        public void CheckIn(int bookingID, int roomID)
        {
            string sql = "UPDATE tblBooking SET BookingStatus = 'CheckedIn', CheckInDate = ? WHERE BookingID = ?";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CheckInDate", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@BookingID", bookingID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            RoomRepository roomRepository = new RoomRepository();
            roomRepository.SetRoomStatus(roomID, "Occupied");
        }

        public void CheckOut(int bookingID, int roomID)
        {
            string sql = "UPDATE tblBooking SET BookingStatus = 'Finished', CheckOutDate = ? WHERE BookingID = ?";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CheckOutDate", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@BookingID", bookingID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            RoomRepository roomRepository = new RoomRepository();
            roomRepository.SetRoomStatus(roomID, "Available");
        }
    }
}