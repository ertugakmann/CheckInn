using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace CheckInn
{
    internal class RoomRepository
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + @"\CheckInnDatabase.accdb";

        public List<Room> getAllRooms()
        {
            List<Room> rooms = new List<Room>();
            string sql = "SELECT * FROM tblRoom";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Room room = new Room();
                room.RoomID = Convert.ToInt32(reader["RoomID"]);
                room.RoomType = reader["RoomType"].ToString();
                room.PricePerNight = reader.GetDecimal(2);
                rooms.Add(room);
            }

            conn.Close();
            return rooms;
        }

        public Room GetSelectedRoom(int roomNumber)
        {
            Room room = null;
            string sql = "SELECT * FROM tblRoom WHERE RoomID = ?";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@RoomID", roomNumber);

            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                room = new Room();
                room.RoomID = Convert.ToInt32(reader["RoomID"]);
                room.RoomType = reader["RoomType"].ToString();
                room.PricePerNight = reader.GetDecimal(2);
            }

            conn.Close();
            return room;
        }

        public string GetRoomStatus(int roomID)
        {
            string sql = "SELECT BookingStatus FROM tblBooking WHERE RoomID = ? AND BookingStatus = 'CheckedIn'";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@RoomID", roomID);

            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();

            if (result != null)
            {
                return "Occupied";
            }

            return "Available";
        }

        public void SetRoomStatus(int roomID, string status)
        {
            string sql = "UPDATE tblRoom SET Status = ? WHERE RoomID = ?";

            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@RoomID", roomID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}