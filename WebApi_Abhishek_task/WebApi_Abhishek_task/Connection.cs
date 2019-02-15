using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Odbc;

namespace WebApi_Abhishek_task
{
    public class Connection
    {
        String connectionString;
        static OdbcConnection connection;
        OdbcCommand command;

        public Connection()
        {
            connectionString = "Driver={SQL Server}; Server=NILESH-IN07; Database=SampleDB; Uid=nilesh; Pwd=nilesh;";
            connection = new OdbcConnection(connectionString);
            connection.Open();
        }

        public OdbcDataReader ExecuteQuery(String query, Dictionary<String, String> parameters)
        {
            CreateCommand(query, parameters);
            return command.ExecuteReader();
        }

        public int ExecuteNonQuery(String query, Dictionary<String, String> parameters)
        {
            CreateCommand(query, parameters);
            return command.ExecuteNonQuery();
        }

        public void CreateCommand(String query, Dictionary<String, String> parameters)
        {
            command = new OdbcCommand(query, connection);
            foreach (var item in parameters)
                command.Parameters.AddWithValue(item.Key, item.Value);
        }

        ~Connection()
        {
            connection.Close();
        }
    }
}