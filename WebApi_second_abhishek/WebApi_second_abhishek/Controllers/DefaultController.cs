using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApi_second_abhishek.Models;
using System.Text;


namespace WebApi_second_abhishek.Controllers
{
    [Produces("application/json")]
    [System.Web.Http.Route("api/Default")]

    public class DefaultController : ApiController
    {
        
        // GET: api/Default
      

        // GET: api/Default/5
        public string Get()
        {
            string result = "";
            SqlConnection con = new SqlConnection();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "NILESH-IN07";
            builder.UserID = "nilesh";
            builder.Password = "123456";
            builder.InitialCatalog = "stu_info";

            con = new SqlConnection(builder.ConnectionString);
            con.Open();

            StringBuilder sb_View = new StringBuilder();
            sb_View.Append("Select * from Intern_table;");
            String sql = sb_View.ToString();
            List<Intern> intern_list = new List<Intern>();

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Intern intern = new Intern();
                        intern.Id = Convert.ToInt32(reader.GetValue(0));
                        intern.Interns_name = reader.GetValue(1).ToString();
                        intern_list.Add(intern);
                    }
                }
                result = Newtonsoft.Json.JsonConvert.SerializeObject(intern_list);
            }
            return result;
        }



        [Produces("application/json")]
        [System.Web.Http.Route("api/Default")]
        // POST: api/Default
        public Intern Post([System.Web.Http.FromBody]Intern intern)
        {
            SqlConnection con = new SqlConnection();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "NILESH-IN07";
            builder.UserID = "nilesh";
            builder.Password = "123456";
            builder.InitialCatalog = "stu_info";

            con = new SqlConnection(builder.ConnectionString);
            con.Open();
            string sqltext = "Insert into Intern_table values('@Id','@Interns_name')";
            SqlCommand sqlcmd = new SqlCommand(sqltext, con);
            sqlcmd.Parameters.AddWithValue("@Id", intern.Id);
            sqlcmd.Parameters.AddWithValue("@Interns_name", intern.Interns_name);

            int i = sqlcmd.ExecuteNonQuery();
            return intern;
        }
        
        // PUT: api/Default/5
        public Intern Put(Intern intern, int id)
        {

            SqlConnection con = new SqlConnection();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "NILESH-IN07";
            builder.UserID = "nilesh";
            builder.Password = "123456";
            builder.InitialCatalog = "stu_info";

            con = new SqlConnection(builder.ConnectionString);
            con.Open();

            string sqltext = "Update Intern_table set Id=@Id, Intern_name=@Intern_name where Id = " + id + ";";
            SqlCommand sqlcmd = new SqlCommand(sqltext, con);
            sqlcmd.Parameters.AddWithValue("@Id", intern.Id);
            sqlcmd.Parameters.AddWithValue("@Interns_name", intern.Interns_name);
            sqlcmd.ExecuteNonQuery();
            return intern;

        }
        
        // DELETE: api/Default/5
        public string Delete(int id)
        {
            SqlConnection con = new SqlConnection();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "NILESH-IN07";
            builder.UserID = "nilesh";
            builder.Password = "123456";
            builder.InitialCatalog = "stu_info";

            con = new SqlConnection(builder.ConnectionString);
            con.Open();

            string sqltext = "Delete from intern_table where Id = " + id + ";";
            SqlCommand sqlcmd = new SqlCommand(sqltext, con);
            sqlcmd.ExecuteNonQuery();
            return "Deleted Successfully";
        }
        
    }
}
