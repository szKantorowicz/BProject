using System.Data.Entity;

namespace BProject.Infrastructure.EntityFramework
{
    public interface IUnitOfWork
    {
        DbContextTransaction BeginTransaction();
        void Rollback(DbContextTransaction transaction);
        void CommitTransaction(DbContextTransaction transaction);
        void SaveEntities();
    }
}
