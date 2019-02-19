using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApi_second_abhishek
{
    public class Connection
    {
        public SqlConnection con()
        {
            SqlConnection connection = null;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "NILESH-IN07";
                builder.UserID = "Nilesh";
                builder.Password = "123456";
                builder.InitialCatalog = "stu_info";

                connection = new SqlConnection(builder.ConnectionString);
                connection.Open();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return connection;
        }
    }
}