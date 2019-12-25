using BProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BProject.Core.Repository.Base
{
    interface IOrderRepository : IRepository<Order>
    {
        bool Exsite();
    }
}
