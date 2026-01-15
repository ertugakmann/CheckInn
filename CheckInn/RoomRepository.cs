using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn
{
    internal class RoomRepository
    {
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
                            Status = reader["Status"].ToString()
                        };

                        rooms.Add(student);
                    }
                }
            }
            return rooms;
        }

        public Room GetSelectedRoom(int roomNumber)
        {
            Room room = null;
            string sql = "SELECT * FROM tblRoom WHERE RoomID = ?"; // ? is a placeholder for parameters in OleDb
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@RoomID", roomNumber); // add the parameter value

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        room = new Room
                        {
                            RoomID = reader.GetInt32(0), // the first column is StudentID
                            RoomType = reader.GetString(1), // the second column is FirstName
                            PricePerNight = reader.GetDecimal(2), // the third column is LastName
                            Status = reader.GetString(3) // the fourth column is StudentDOB
                        };
                    }
                }
            }

            return room;
        }
    }
}
