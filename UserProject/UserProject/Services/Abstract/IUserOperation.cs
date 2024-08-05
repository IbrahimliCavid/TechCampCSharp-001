using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Models;

namespace UserProject.Services.Abstract
{
    public interface IUserOperation
    {
        void Add(User user);
        void ShowAllUser();
        void DeleteUserById(int id);
        void UpdateUserEmail(int id, string email);
    }
}
