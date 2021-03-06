using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Repository.Generic;
using ConsoleApp2.Models;

namespace ConsoleApp2.Repository.CustomerRepo
{
    internal interface ICustomerRepository : IGenericRepository<Customer>
    {
        public List<Customer> GetCustomersByAge(int age, bool max = true);
        bool Delete(Customer customer);
    }
}
