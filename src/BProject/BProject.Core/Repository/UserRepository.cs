using BProject.Core.Model;
using BProject.Core.Repository.Base;
using System.Linq;

namespace BProject.Core.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public bool Exists()
        {
            return Entities.Any();
        }
    }
}
