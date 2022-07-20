using Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Respositories.Base
{

    public interface IRepository<T> where T : IEntities
    {
        T Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        T Get(Predicate<T> filter = null);

        List<T> GetAll(Predicate<T> filter = null);
    }

}
