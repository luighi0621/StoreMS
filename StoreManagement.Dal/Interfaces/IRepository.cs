using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace StoreManagement.Dal.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T add);
        void Delete(T delete);
        void Update(T update);
        T Get(Expression<Func<T, bool>> condition);
        IList<T> GetAll();
        long Count();
    }
}
