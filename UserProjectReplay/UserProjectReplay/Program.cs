using System.Text;
using UserProjectReplay.Models;
using UserProjectReplay.Services.Concrete;

namespace UserProjectReplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Giriş et və Qeydiyyatdan keç seçimləri olacaq.
            //2.İstifadəçini qeydiyyatdan keçirəndə, istifadəçinin roll`u user default olaraq.
            //3.Giriş edəndə, əgər daxil olan admindirsə, açılan pəncərədə ~istifadəçi əlavə et, istifadəçiləri gör, istifadəçi sil, istifadəçini redaktə et, çıxış et, istifadəçinin rolunu dəyiş seçimləri olacaq.
            //Əgər daxil olan userdirsə, məlumatları redaktə et, hesabı sil və çıxış et seçimləri olacaq. (Qeyd user kimi daxil olanda sadəcə öz məlumatlarını redaktə edə və öz hesabını silə bilər.)
            Console.OutputEncoding = Encoding.UTF8;
            UserManager userManager = new();
            while (true)
            {
                Console.WriteLine("1. Giriş et\n" +
                    "2. Qeydiyyat et");

                bool isNumber = int.TryParse(Console.ReadLine(), out int chocie);
                if (isNumber)
                {
                    switch (chocie)
                    {
                        case 1:
                            {
                                Console.WriteLine("Email daxil edin:");
                                string email = Console.ReadLine();
                                Console.WriteLine("Password daxil edin:");
                                string password = Console.ReadLine();

                                bool checkUser = userManager.CheckUser(email, password, out User user);
                                if (checkUser)
                                {
                                    if (user.Role == "user")
                                    {
                                        UserChocie();
                                    }
                                    else
                                    {
                                        AdminChocie();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("İstifadəçi tapılmadı");
                                }
                            }
                        
                            break;
                            case 2:
                            {
                                Console.WriteLine("Id daxil edin");
                                int id = int.Parse(Console.ReadLine());

                                Console.WriteLine("Ad daxil edin:");
                                string name = Console.ReadLine();

                                Console.WriteLine("Email daxil edin:");
                                string email = Console.ReadLine();

                                Console.WriteLine("Password daxil edin:");
                                string password = Console.ReadLine();

                                var newUser = new User()
                                {
                                    Id = id,
                                    Name = name,
                                    Email = email,
                                    Password = password,
                                };
                                userManager.Add(newUser);
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Yalnız rəqəm daxil edə bilərsiniz!!!");
                }
            }
        }

        public static void UserChocie()
        {
            //məlumatları redaktə et, hesabı sil və çıxış et seçimləri olacaq.
        }
        public static void AdminChocie()
        {
            //istifadəçi əlavə et, istifadəçiləri gör, istifadəçi sil, istifadəçini redaktə et, çıxış et, istifadəçinin rolunu dəyiş
        }
    }
}
