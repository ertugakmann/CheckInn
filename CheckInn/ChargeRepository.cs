using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace CheckInn
{
    internal class ChargeRepository
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + @"\CheckInnDatabase.accdb";

        public void CreateRoomCharge(int bookingID, decimal amount, string chargeContent)
        {
            string sql = "INSERT INTO tblRoomCharge (BookingID, RoomCharge, ChargeContent) VALUES (?, ?, ?)";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@BookingID", bookingID);
            cmd.Parameters.AddWithValue("@RoomCharge", amount);
            cmd.Parameters.AddWithValue("@ChargeContent", chargeContent);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<RoomCharge> GetChargesByBookingID(int bookingID)
        {
            List<RoomCharge> charges = new List<RoomCharge>();
            string sql = "SELECT * FROM tblRoomCharge WHERE BookingID = ?";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@BookingID", bookingID);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RoomCharge charge = new RoomCharge();
                charge.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                charge.BookingID = Convert.ToInt32(reader["BookingID"]);
                charge.RoomChargeAmount = Convert.ToDecimal(reader["RoomCharge"]);
                charge.ChargeContent = reader["ChargeContent"].ToString();
                charges.Add(charge);
            }
            conn.Close();
            return charges;
        }

        public void UpdateRoomCharge(RoomCharge charge)
        {
            string sql = "UPDATE tblRoomCharge SET RoomCharge = ?, ChargeContent = ? WHERE ServiceID = ?";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@RoomCharge", charge.RoomChargeAmount);
            cmd.Parameters.AddWithValue("@ChargeContent", charge.ChargeContent);
            cmd.Parameters.AddWithValue("@ServiceID", charge.ServiceID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteRoomCharge(int serviceID)
        {
            string sql = "DELETE FROM tblRoomCharge WHERE ServiceID = ?";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ServiceID", serviceID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}