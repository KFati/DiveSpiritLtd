using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UOMDiveSpirit.Data
{
    public class clsUserDA
    {
        // Read a user
        public Common.clsUser Read(Common.clsLogInData objLogin)
        {

            Common.clsUser objUsers = new Common.clsUser();

            try
            {
                // Query to read a voter
                string QueryString = string.Format(@"select Username, 
                                                            Passwords, 
                                                            UserType
                                                     from   users
                                                     where  Username = '{0}' 
                                                     and    Passwords = '{1}'
                                                     and    UserType = '{2}'",
                                                     objLogin.Username, objLogin.Password, objLogin.UserType);

                using (SqlConnection Connection = new SqlConnection(clsConnectingDA.ConnectionString))
                {
                    using (SqlCommand Command = Connection.CreateCommand())
                    {
                        // Load Query
                        Command.CommandText = QueryString;

                        // Open connection
                        Connection.Open();

                        // Execute query
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                objUsers.Username = (string)reader["Username"];
                                objUsers.Password = (string)reader["Passwords"];
                                objUsers.UserType = (string)reader["UserType"];
                            }
                        }

                        // Close connection
                        Connection.Close();
                    }
                }
            }
            catch (Exception)
            {

            }

            return objUsers;
        }
    }
}
