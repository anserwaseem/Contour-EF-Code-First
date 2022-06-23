using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Repository.Generic;
using ConsoleApp2.Models;

namespace ConsoleApp2.Repository.CustomerRepo
{
    internal class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public List<Customer> GetCustomersByAge(int age, bool max = true)
        {
            //Context.
            List<Customer> AllCustomers = GetAll();
            if (max)
                return AllCustomers.Where(customer => customer.Age >= age).ToList();
            return AllCustomers.Where(customer => customer.Age < age).ToList();
        }
        public bool Delete(Customer customer)
        {
            bool deleted = Remove(customer);
            if (deleted)
                Customer.CustomerCount--;
            return deleted;
        }
        
        //public EComContext EComContext
        //{
        //    get { return Context as EComContext; }
        //}
    }
}
