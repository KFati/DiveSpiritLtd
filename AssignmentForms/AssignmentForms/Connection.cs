using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AssignmentForms
{
    class Connection
    {
        public static SqlConnection conn = null;

        public void GetConnection()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AssignmentDiveSpirit.mdf;Integrated Security=True");

            conn.Open();
        }
    }
}
