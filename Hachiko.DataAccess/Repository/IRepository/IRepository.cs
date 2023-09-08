using System.Linq.Expressions;

namespace Hachiko.DataAccess.Repository.IRepository
{
    //Generic <T>
    public interface IRepository <T> where T : class
    {
        // T - Category / Product
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T,bool>> filter, string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
         
    }
}
