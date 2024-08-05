using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProjectReplay.Database;
using UserProjectReplay.Models;
using UserProjectReplay.Services.Abstract;

namespace UserProjectReplay.Services.Concrete
{
    public class UserManager : IUserOperation
    {
        public void Add(User model)
        {
          DB.Instance.Users.Add(model);
        }

        public bool CheckUser(string email, string password, out User user)
        {
            var findUser = DB.Instance.Users.Find(x => x.Email == email && x.Password == password);

            if (findUser is null)
            {
                user = null;
                return false;
            }
            else
            {
                user = findUser;
                return true;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
