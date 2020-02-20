using BProject.Core.Models;
using BProject.Core.Repositories;

namespace BProject.Infrastructure.EntityFramework.Repositories
{
    public class PaymentTypeRepository : BaseRepository<PaymentType> , IPaymentTypeRepository
    {
    }
}
