using Bootcamp_3_1.Ordering.Data.Repositories.Core;
using Bootcamp_3_1.Ordering.Domain.Entities;
using System.Threading.Tasks;

namespace Bootcamp_3_1.Ordering.Data.Repositories.Interface
{
    public interface ICustomerRepository : IReadRepository<Customer>, IWriteRepository<Customer>
    {
        Task<bool> IsExistsCustomer(string name);
    }
}