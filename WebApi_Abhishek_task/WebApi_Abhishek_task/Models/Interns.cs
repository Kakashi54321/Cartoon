using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Abhishek_task.Models
{
    public class Interns
    {
        public int Id { get; set; }
        public String Interns_name { get; set; }

        public Interns(int id, String name)
        {
            this.Id = id;
            this.Interns_name = name;
        }
    }
}