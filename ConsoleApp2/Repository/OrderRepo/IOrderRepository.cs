using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Models;
using ConsoleApp2.Repository.Generic;

namespace ConsoleApp2.Repository.OrderRepo
{
    internal interface IOrderRepository:IGenericRepository<Order>
    {
    }
}
