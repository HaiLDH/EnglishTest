using EnglishTest.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Service.Infrastructure
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        IRepositoryBase<T> _repositoryBase;

        public ServiceBase()
        {
            _repositoryBase = Activator.CreateInstance<RepositoryBase<T>>();
        }

        public int Add(T entity)
        {
            return _repositoryBase.Add(entity);
        }

        public bool Delete(T entity)
        {
            return _repositoryBase.Delete(entity);
        }

        public bool Delete(int id)
        {
            return _repositoryBase.Delete(id);
        }

        public bool Update(T entity)
        {
            return _repositoryBase.Update(entity);
        }

        public T GetSingleById(int id)
        {
            return _repositoryBase.GetSingleById(id);
        }

        public IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            return _repositoryBase.GetMulti(predicate, includes);
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            return _repositoryBase.GetAll(includes);
        }
    }
}
