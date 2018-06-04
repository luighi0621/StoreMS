using StoreManagement.Dal.Models;
using StoreManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace StoreManagement.Dal
{
    public class UserRepository
    {
        private StoreManagementEntities _DbContext;
        public UserRepository()
        {
            _DbContext = new StoreManagementEntities();
        }
        public void Add(User add)
        {
            if (add != null)
            {
                try
                {
                    _DbContext.Users.Add(add);
                    _DbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public long Count()
        {
            return _DbContext.Users.LongCount();
        }

        public void Delete(User delete)
        {
            if (delete != null)
            {
                try
                {
                    _DbContext.Users.Remove(delete);
                    _DbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public User Get(Expression<Func<User, bool>> condition)
        {
            if (condition != null)
            {
                var singleUser = _DbContext.Users.Where(condition).FirstOrDefault();
                return singleUser;

            }
            return null;
        }

        public IList<User> GetAll()
        {
            return _DbContext.Users.ToList();
        }

        public void Update(User update)
        {
            try
            {
                _DbContext.Entry(update).State = System.Data.Entity.EntityState.Modified;
                _DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
