using BProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BProject.Core.Model;

namespace BProject.Core.GetFunction
{
    class GetUser 
    {
        static void GetUsers()
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

                    var customer = customerRepo.Find(c => c.UserID == userData.CustomerID);
                    IEnumerable<Customer> customers = customer as Customer[] ?? customer.ToArray();
                    if (!customers.Any()) continue;
                    Console.WriteLine("");
                    foreach (var customer in customers)
                    {
                        Console.WriteLine(customers.FirstName)

                    }
                }
            }

        }
    }
}

