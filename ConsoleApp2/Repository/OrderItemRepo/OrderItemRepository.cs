using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Repository.Generic;
using ConsoleApp2.Models;
using System.Data.Entity;

namespace ConsoleApp2.Repository.OrderItemRepo
{
    internal class OrderItemRepository:GenericRepository<OrderItem>,IOrderItemRepository
    {
    }
}
