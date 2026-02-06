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

        public int CreateCustomer(Customer customer)
        {
            string sql = @"INSERT INTO tblCustomer
                  (CustomerName, CustomerDOB, CustomerEmail, CustomerPhoneNumber, CustomerAddress)
                  VALUES (?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Name", customer.CustomerName);
                cmd.Parameters.AddWithValue("@DOB", customer.CustomerDOB);
                cmd.Parameters.AddWithValue("@Email", customer.CustomerEmail);
                cmd.Parameters.AddWithValue("@Phone", customer.CustomerPhoneNumber);
                cmd.Parameters.AddWithValue("@Address", customer.CustomerAddress);

                conn.Open();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT @@IDENTITY";
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }



    }
}
