using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Service.Infrastructure
{
    public interface IServiceBase<T> where T : class
    {
        int Add(T entity);

        bool Update(T entity);

        bool Delete(int id);

        bool Delete(T entity);

        T GetSingleById(int id);

        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IEnumerable<T> GetAll(string[] includes = null);
    }
}
