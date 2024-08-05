using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProjectReplay.Models;

namespace UserProjectReplay.Database
{
    public class DB
    {
        public DB()
        {
            Users = new List<User>();
        }

        private static DB _instance;


        public static DB Instance
        {
            get
            {

                if (_instance is null)
                    _instance = new DB();
                return _instance;
            }
        }

        public List<User> Users { get; set; }

        User newUser = new User()
        {
            Id = 999,
            Name = "Admin",
            Email = "admin@gmail.com",
            Password = "admin123",
            Role = "admin"
        };
    }
}


