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
                            RoomID = reader.GetInt32(0), // the first column is StudentID
                            RoomType = reader.GetString(1), // the second column is FirstName
                            PricePerNight = reader.GetFloat(2), // the third column is LastName
                            Status = reader.GetString(3) // the fourth column is StudentDOB
                        };
                        rooms.Add(student);
                    }
                }
            }
            return rooms;
        }
    }
}
