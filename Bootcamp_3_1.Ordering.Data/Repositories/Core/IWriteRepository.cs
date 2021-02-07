using Bootcamp_3_1.Ordering.Domain.Interfaces;
using System.Threading.Tasks;

namespace Bootcamp_3_1.Ordering.Data.Repositories.Core
{
    public interface IWriteRepository<T> where T : IEntity
    {
        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<bool> Delete(T entity);

        Task<bool> Delete(int id);
    }
}