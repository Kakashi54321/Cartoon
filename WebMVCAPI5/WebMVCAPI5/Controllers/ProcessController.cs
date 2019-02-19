using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCAPI5.Models;

namespace WebMVC2.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        /*public string Index()
        {
            return "This is Process Page.";
        }*/

        public ActionResult Index()
        {
            OdbcConnection DbConnection = new OdbcConnection("DSN=myDsn;");
            DbConnection.Open();
            OdbcCommand DbCommand = DbConnection.CreateCommand();
            DbCommand.CommandText = "Select * from Intern;";
            OdbcDataReader DbReader = DbCommand.ExecuteReader();
            List<User> User_list = new List<User>();
            while (DbReader.Read())
            {
                User_list.Add(new User(int.Parse(DbReader["ID"].ToString()), DbReader["Name"].ToString()));
            }
            DbReader.Close();
            DbCommand.Dispose();
            DbConnection.Close();
            return View(User_list);
        }

        public ActionResult InsertData(FormCollection fc)
        {
            string ID = Convert.ToString(fc["TxtID"]);
            string Name = Convert.ToString(fc["Name"]);
            OdbcConnection DbConnection = new OdbcConnection("DSN=myDsn;");
            DbConnection.Open();
            OdbcCommand DbCommand = DbConnection.CreateCommand();
            DbCommand.CommandText = "INSERT INTO Intern (ID,Name) VALUES (" + int.Parse(ID) + ",'" + Name + "');";
            OdbcDataReader DbReader = DbCommand.ExecuteReader();
            DbReader.Close();
            DbCommand.Dispose();
            DbConnection.Close();
            return RedirectToAction("Index");
        }

        public ActionResult NewRecord()
        {
            return View();
        }
    }
}