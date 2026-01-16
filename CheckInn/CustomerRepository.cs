using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn
{
    internal class CustomerRepository
    {

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CheckInnDatabase.accdb";

        public void CreateCustomer(Customer customer)
        {
            // Create New Record for new Customer
            string sql = "INSERT INTO tblCustomer (CustomerName, CustomerDOB, CustomerEmail, CustomerPhoneNumber, CustomerAddress) VALUES (?, ?, ?, ?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                cmd.Parameters.AddWithValue("@CustomerDOB", customer.CustomerDOB.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@CustomerEmail", customer.CustomerEmail);
                cmd.Parameters.AddWithValue("@CustomerPhoneNumber", customer.CustomerPhoneNumber);
                cmd.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
                conn.Open();
                cmd.ExecuteNonQuery();
            }


        }


    }
}
