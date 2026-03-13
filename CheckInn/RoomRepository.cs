using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn
{
    internal class RoomRepository
    {
        BookingRepository bookingRepository = new BookingRepository();

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CheckInnDatabase.accdb";
        public List<Room> getAllRooms()
        {
            List<Room> rooms = new List<Room>();
            string sql = "SELECT * FROM tblRoom";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room student = new Room
                        {
                            RoomID = Convert.ToInt32(reader["RoomID"]),
                            RoomType = reader["RoomType"].ToString(),
                            PricePerNight = reader.GetDecimal(2),
                        };

                        rooms.Add(student);
                    }
                }
            }
            return rooms;
        }

        public Room GetSelectedRoom(int roomID)
        {
            Room room = null;
            string sql = "SELECT * FROM tblRoom WHERE RoomID = ?"; // ? is a placeholder for parameters in OleDb
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@RoomID", roomID); // add the parameter value

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        room = new Room
                        {
                            RoomID = reader.GetInt32(0), // the first column is StudentID
                            RoomType = reader.GetString(1), // the second column is FirstName
                            PricePerNight = reader.GetDecimal(2), // the third column is LastName
                        };
                    }
                }
            }

            return room;
        }

        public string GetRoomStatus(int roomID)
        {
            string sql = @"SELECT COUNT(*) FROM tblBooking
                   WHERE RoomID = ?
                   AND BookingStatus = 'Active'
                   AND BookingStartsDate <= Date()
                   AND BookingEndsDate >= Date()";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@RoomID", roomID);

                conn.Open();

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                    return "Occupied";
                else
                    return "Available";
            }
        }
    }
}
