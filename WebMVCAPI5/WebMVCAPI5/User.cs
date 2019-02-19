using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCAPI5.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public User()
        {

        }

        public User(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}