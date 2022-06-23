using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Repository.Generic
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //protected readonly DbContext Context;
        //public GenericRepository(DbContext context)
        //{
        //    Context = context;
        //}
        //protected readonly DbSet<T>? Table;
        //public GenericRepository(T)
        //{
        //    Table = new DbSet<T>();
        //}

        private List<T> List = new List<T>();

        public List<T> GetAll()
        {
            return List;
        }
        //public T Get(object id)
        //{
        //    return List.FirstOrDefault(T => T.id == id);
        //}
        public bool Add(T entity)
        {
            try
            {
               List.Add(entity);
               return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public bool AddRange(List<T> entities)
        {
            try
            {
                List.AddRange(entities);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public bool Remove(T entity)
        {
            try
            {
                List.Remove(entity);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
        public bool RemoveRange(List<T> entities)
        {
            try
            {
                List.ForEach(entity => List.Remove(entity));// RemoveRange(entities);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        

        //public int Update(T entity)
        //{
        //    try
        //    {
        //        int index = list.IndexOf(entity);
        //        if (index>=0)
        //        {
        //            if (list[index].Equals(entity))
        //                return 0; //already exists
        //            list[index] = entity;
        //            return 1; //successfuly updated
        //        }
        //        return -1; //doesn't exist
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //    return -2; //Exception
        //}
    }
}
