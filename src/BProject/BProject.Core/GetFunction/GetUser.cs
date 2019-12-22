using BProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BProject.Core.Model;

namespace BProject.Core.GetFunction
{
    public class GetUser 
    {
        public static void GetUsers()
        {
            UserRepo userRepo = new UserRepo();
            CustomerRepo customerRepo = new CustomerRepo();
            var users = userRepo.GetAll();

            IEnumerable<User> userDatas = users.ToList();
            if (!userDatas.Any())
            {
                Console.WriteLine("No users placed.");
            }
            else
            {
                foreach (var userData in userDatas)
                {
                    Console.WriteLine("");

                    var customers = customerRepo.Find(c => c.UserID == userData.ID);
                    if (!customers.Any()) continue;
                    Console.WriteLine("");

                    foreach (var client in customers)
                    {
                        Console.WriteLine(client.FirstName);
                    }
                }
            }

        }
    }
}

