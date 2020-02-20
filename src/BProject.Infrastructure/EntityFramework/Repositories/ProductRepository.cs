using BProject.Core.Models;
using BProject.Core.Repositories;

namespace BProject.Infrastructure.EntityFramework.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository 
    {
    }
}
