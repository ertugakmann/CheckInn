using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace CheckInn
{
    internal class ServiceRepository
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + @"\CheckInnDatabase.accdb";

        public void CreateServiceRequest(int roomID, int bookingID, string serviceContent)
        {
            string sql = "INSERT INTO tblRoomService (RoomID, BookingID, ServiceContent, RequestTime) VALUES (?, ?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@RoomID", roomID.ToString());
            cmd.Parameters.AddWithValue("@BookingID", bookingID.ToString());
            cmd.Parameters.AddWithValue("@ServiceContent", serviceContent);
            cmd.Parameters.AddWithValue("@RequestTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<RoomService> GetServicesByBookingID(int bookingID)
        {
            List<RoomService> services = new List<RoomService>();
            string sql = "SELECT * FROM tblRoomService WHERE BookingID = ?";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@BookingID", bookingID.ToString());
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RoomService service = new RoomService();
                service.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                service.ServiceContent = reader["ServiceContent"].ToString();
                service.RoomID = Convert.ToInt32(reader["RoomID"]);
                service.BookingID = Convert.ToInt32(reader["BookingID"]);
                service.RequestTime = Convert.ToDateTime(reader["RequestTime"]);
                services.Add(service);
            }
            conn.Close();
            return services;
        }

        public void UpdateServiceRequest(RoomService service)
        {
            string sql = "UPDATE tblRoomService SET ServiceContent = ? WHERE ServiceID = ?";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ServiceContent", service.ServiceContent);
            cmd.Parameters.AddWithValue("@ServiceID", service.ServiceID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteServiceRequest(int serviceID)
        {
            string sql = "DELETE FROM tblRoomService WHERE ServiceID = ?";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ServiceID", serviceID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}