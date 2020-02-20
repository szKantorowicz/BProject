using BProject.Core.Models;

namespace BProject.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        bool Exists();
    }
}
