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

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string sql = "SELECT * FROM tblCustomer";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {   
                        Customer customer = new Customer
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            CustomerName = reader["CustomerName"].ToString(),
                            CustomerDOB = reader.GetDateTime(2).Date,
                            CustomerEmail = reader["CustomerEmail"].ToString(),
                            CustomerAddress = reader["CustomerAddress"].ToString(),
                            CustomerPhoneNumber = reader["CustomerPhoneNumber"].ToString()
                        };

                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }


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

        public Customer GetSelectedCustomer(int customerID)
        {
            Customer customer = null;
            string sql = "SELECT * FROM tblCustomer WHERE CustomerID = ?"; // ? is a placeholder for parameters in OleDb
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@customerID", customerID); // add the parameter value

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new Customer
                        {
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            CustomerName = reader["CustomerName"].ToString(),
                            CustomerDOB = reader.GetDateTime(2).Date,
                            CustomerEmail = reader["CustomerEmail"].ToString(),
                            CustomerAddress = reader["CustomerAddress"].ToString(),
                            CustomerPhoneNumber = reader["CustomerPhoneNumber"].ToString()
                        };
                    }
                }
            }

            return customer;
        }


        public void UpdateCustomer(Customer customer)
        {
            string sql = @"UPDATE tblCustomer 
                   SET CustomerName = ?, 
                       CustomerDOB = ?, 
                       CustomerEmail = ?, 
                       CustomerPhoneNumber = ?, 
                       CustomerAddress = ?
                   WHERE CustomerID = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Name", customer.CustomerName);
                cmd.Parameters.AddWithValue("@DOB", customer.CustomerDOB);
                cmd.Parameters.AddWithValue("@Email", customer.CustomerEmail);
                cmd.Parameters.AddWithValue("@Phone", customer.CustomerPhoneNumber);
                cmd.Parameters.AddWithValue("@Address", customer.CustomerAddress);
                cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool CustomerHasBookings(int customerID)
        {
            string sql = "SELECT * FROM tblBooking WHERE CustomerID = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void DeleteCustomer(int customerID)
        {
            string sql = "DELETE FROM tblCustomer WHERE CustomerID = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
