using BProject.Core.Models;
using BProject.Core.Repositories;

namespace BProject.Infrastructure.EntityFramework.Repositories
{
    public class OrderRepository : BaseRepository<Order> , IOrderRepository
    {
    }
}
