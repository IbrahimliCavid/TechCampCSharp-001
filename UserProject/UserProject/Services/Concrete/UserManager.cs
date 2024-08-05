using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProject.Database;
using UserProject.Models;
using UserProject.Services.Abstract;

namespace UserProject.Services.Concrete
{
    public class UserManger : IUserOperation
    {

        public void Add(User user)
        {
            DB.Instance.listUsers.Add(user);
        }

        public void DeleteUserById(int id)
        {
            var user = DB.Instance.listUsers.Find(x => x.Id == id);
            if (user is null)
            {
                Console.WriteLine("Bu idli user yoxdur");
            }
            else
            {
                DB.Instance.listUsers.Remove(user);
            }

        }

        public void ShowAllUser()
        {
            var list = DB.Instance.listUsers;
            foreach (var item in list)
            {
                Console.WriteLine($"Id: {item.Id} \n" +
                    $"Ad: {item.Name}\n" +
                    $"Soyad: {item.Surname}\n" +
                    $"Email: {item.Email}\n" +
                    $"Password: {item.Password}");
            }
        }

        public void UpdateUserEmail(int id, string email)
        {
            var user = DB.Instance.listUsers.Find(x => x.Id == id);
            if (user is null)
            {
                Console.WriteLine("Bu idli istifadeci movcud deyil");
            }
            else
            {
                user.Email = email;
                Console.WriteLine("Email ugurla update olundu");
            }
        }
    }
}
