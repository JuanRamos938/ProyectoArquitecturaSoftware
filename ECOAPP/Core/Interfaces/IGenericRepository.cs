using System.Threading.Tasks;

namespace ECOAPP.Core.Interfaces.Repositories
{
    public interface IGenericRepository<in T>
    {
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
