using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;

namespace UserProject.Database
{
    public class DB
    {
        private DB()
        {
            listUsers = new List<User>();
        }

        private static DB _instance;
        public static DB Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DB();
                    return _instance;
                }
                else
                {
                    return _instance;
                }


            }
        }
        public List<User> listUsers;
    }
}
