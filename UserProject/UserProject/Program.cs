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


    public interface IUserOperation
    {
        void Add(User user);
        void ShowAllUser();
        void DeleteUserById(int id);
        void UpdateUserEmail(int id, string email);
    }

    public class UserManager : IUserOperation
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

    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
    }

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

        //public static List<User> userList= new();
    }
}
