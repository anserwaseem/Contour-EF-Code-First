using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Repository.Generic;
using ConsoleApp2.Models;
using System.Data.Entity;
using ConsoleApp2.Repository.ProductRepo;

namespace ConsoleApp2.Repository
{
    internal class ProductRepository:GenericRepository<Product>,IProductRepository
    {
    }
}
