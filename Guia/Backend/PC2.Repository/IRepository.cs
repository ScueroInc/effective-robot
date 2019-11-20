using System.Collections.Generic;

namespace PC2.Repository
{
    public interface IRepository<T>
    {
         bool Save(T entity);
         bool Update(T entity);
         bool Delete(int id);
         IEnumerable<T> FindAll();
         T FindById(int id);
    }
}