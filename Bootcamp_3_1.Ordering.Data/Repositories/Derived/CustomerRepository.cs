using Bootcamp_3_1.Ordering.Data.Repositories.Core;
using Bootcamp_3_1.Ordering.Data.Repositories.Interface;
using Bootcamp_3_1.Ordering.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_3_1.Ordering.Data.Repositories.Derived
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public async Task<bool> IsExistsCustomer(string name)
        {
            var sql = $"Select Count(*) as TotalCount From Customers where FirstName = '{name}'";

            var result = await base.ExecSqlQuery(sql, async (reader) =>
            {
                int totalCount = 0;
                if (await reader.ReadAsync())
                    totalCount = reader.GetInt32(reader.GetOrdinal("TotalCount"));

                return totalCount > 0;
            })?.FirstOrDefault();
            return result;
        }
    }
}