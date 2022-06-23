using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository.Generic
{
    internal interface IGenericRepository<T>
    {
        List<T> GetAll();
        //T Get(object id);
        bool Add(T entity);
        bool AddRange(List<T> entities);
        bool Remove(T entity);
        bool RemoveRange(List<T> entities);

        //int Update(T entity);
    }
}
