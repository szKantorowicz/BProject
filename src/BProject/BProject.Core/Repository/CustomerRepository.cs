using BProject.Core.Model;
using BProject.Core.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.Repository
{
    public class CustomerRepository : BaseRepository<Customer> , ICustomerRepository
    {
    }
}
