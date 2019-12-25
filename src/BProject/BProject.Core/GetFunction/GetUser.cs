using BProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BProject.Core.Model;
using BProject.Core.Repository.Base;

namespace BProject.Core.GetFunction
{
    public class GetUser 
    {
        public static void GetUsers()
        {
            IUserRepository userRepo = new UserRepository();
            CustomerRepository customerRepo = new CustomerRepository();
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

