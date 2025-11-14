using CheckInn.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInn
{
    internal class StaffRepository
    {

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + Environment.CurrentDirectory + @"\CheckInnDatabase.accdb";

        public Staff getStaffDetails(int staffPIN)
        {
            // Define value to store staff
            Staff staff = null;

            string sql = "SELECT * FROM tblStaff WHERE StaffPIN = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@StaffPIN", staffPIN); // add the parameter value

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        staff = new Staff
                        {
                            StaffID = reader.GetInt32(0), // first column
                            StaffName = reader.GetString(1), // second column
                            StaffDOB = reader.GetDateTime(2), // third column
                            StaffPIN = reader.GetInt32(3), // ...
                            RoleID = reader.GetInt32(4),  // ...
                            StaffEmail = reader.GetString(5),  // ...
                            StaffPhone = reader.GetString(6),  // ...
                        };
                    }
                }
            }
            return staff;
        }

        public StaffRole getStaffRole(int roleID)
        {
            // Define value to store staff
            StaffRole staffRole = null;

            string sql = "SELECT * FROM tblStaffRoles WHERE RoleID = ?";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@RoleID", roleID); // add the parameter value

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        staffRole = new StaffRole
                        {
                            RoleID = reader.GetInt32(0), // first column
                            RoleName = reader.GetString(1), // second column
                            RoleDesc = reader.GetString(2), // third column
                           
                        };
                    }
                }
            }
            return staffRole;
        }
    }
       
}
