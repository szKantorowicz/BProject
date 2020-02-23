using System.Linq;
using BProject.Core.Models;
using BProject.Core.Repositories;

namespace BProject.Infrastructure.EntityFramework.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public bool Exists()
        {
            return Entities.Any();
        }
    }
}
