using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Odbc;
using WebApi_Abhishek_task.Models;

namespace WebApi_Abhishek_task
{
    public class InternsOperation
    {
        Dictionary<String, String> parameters = new Dictionary<string, string>();
        Connection connection = new Connection();
        OdbcDataReader reader;

        public List<Interns> Get()
        {
            List<Interns> interns = new List<Interns>();
            reader = connection.ExecuteQuery("Select * from Intern_table", parameters);
            while (reader.Read())
                interns.Add(new Interns((int)reader[0], reader[1].ToString()));
            return interns;
           
        }

        public Interns Get(int id)
        {
            UpdateParameters(id: id);
            reader = connection.ExecuteQuery("Select * from Intern_table where Id=?", parameters);
            parameters.Clear();
            if (reader.Read())
                return new Interns((int)reader[0], reader[1].ToString());
            return null;
        }

        public int Post(Interns intern)
        {
            int result = 0;
            UpdateParameters(intern.Id, intern.Interns_name);
            result = connection.ExecuteNonQuery("Insert into Intern_table(Id,Interns_name) values (?,?)", parameters);
            parameters.Clear();
            return result;
        }

        public int Put(int id, String Interns_name)
        {
            int result = 0;
            UpdateParameters(id, Interns_name);
            result = connection.ExecuteNonQuery("Update Intern_table set Interns_name=? where Id=?", parameters);
            parameters.Clear();
            return result;
        }

        public int Delete(int id)
        {
            int result = 0;
            UpdateParameters(id : id );
            result = connection.ExecuteNonQuery("Delete from Intern_table where Id=?", parameters);
            parameters.Clear();
            return result;
        }

        public void UpdateParameters(int id=0, String name = "")
        {
            if (id != 0)
                parameters.Add("@Id", "" + id);
            if (!name.Equals(""))
                parameters.Add("@Interns_name", name);
        }
    }
}