using System.Collections.Generic;

namespace PC2.Service
{
    public interface IService<T>
    {
         bool Save(T entity);
         bool Update(T entity);
         bool Delete(int id);
         IEnumerable<T> FindAll();
         T FindById(int id);
    }
}