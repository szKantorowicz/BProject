using BProject.Core.Models;
using BProject.Core.Repositories;

namespace BProject.Infrastructure.EntityFramework.Repositories
{
    public class CustomerRepository : BaseRepository<Customer> , ICustomerRepository
    {
    }
}
