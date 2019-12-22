using BProject.Core.Model;

namespace BProject.Core.Repository.Base
{
    public interface IUserRepository : IRepository<User>
    {
        bool Exists();
    }
}
