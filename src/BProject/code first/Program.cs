using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using code_first.Model;

namespace code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new User {ID='1',Name="user1"},
                new User {ID='2',Name="user2"},
                new User {ID='3',Name="user3"},
            };
            using (var context = new FirstCodeContext())
            {
                context.Users.AddRange(users);
                context.SaveChanges();

            }
            foreach (var user in users)
            {
                System.Console.WriteLine($"Username: {user.Name}, email: {user.Email}");
            }
            System.Console.ReadKey();
        }
    }
}
