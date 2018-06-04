using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
