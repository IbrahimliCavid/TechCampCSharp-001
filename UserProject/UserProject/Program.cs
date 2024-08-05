using UserProject.Models;
using UserProject.Services.Abstract;

namespace UserProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new();
            //1. Add User
            //2.show all user
            //3. Remove user
            //4.Update user email
           while (true)
            {
                Console.WriteLine("1. Istifad'ci elave edin\n" +
                    "2. istifadecileri gosterin\n" +
                    "3. Idye gore istifadeci silin\n" +
                    "4. Update edin");
                Console.WriteLine("Seçim edin");
                int chocie = int.Parse(Console.ReadLine());
                switch (chocie)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Id daxil edin");
                            int id = int.Parse(Console.ReadLine());    
                            Console.WriteLine("Ad daxil edin:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Soyad  daxil edin:");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Email daxil edin:");
                            string email = Console.ReadLine();
                            Console.WriteLine("Password daxil edin:");
                            string password = Console.ReadLine();

                            User newUser = new()
                            {
                                Id = id,
                                Name = name,
                                Surname = surname,
                                Email = email,
                                Password = password
                            };

                            userManager.Add(newUser);

                        }
                        break;
                    case 2:
                        Console.Clear();
                        userManager.ShowAllUser();
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Silmek istediyiniz userin idsini yazin");
                            int id = int.Parse(Console.ReadLine());
                            userManager.DeleteUserById(id);
                        }
                        
                        break;
                        case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Id daxil edin");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Yeni email daxil edin");
                            string email = Console.ReadLine();
                            userManager.UpdateUserEmail(id, email);
                        }
                
                        break;
                }
            }

        }

    }


}
