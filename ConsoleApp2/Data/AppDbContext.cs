using ConsoleApp2.Models;
using ConsoleApp2.Repository.CustomerRepo;
using ConsoleApp2.Repository.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    internal class AppDbContext : DbContext
    {

        //public AppDbContext()
        //{
        //    //CustomerRepository = new CustomerRepository();
        //    //OrderRepository = new GenericRepository<Order>();
        //    //OrderItemRepository = new GenericRepository<OrderItem>();
        //    //ProductRepository = new GenericRepository<Product>();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ConosleApp2_EF_DB;Trusted_Connection=True;");
        }

        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? Items { get; set; }
        public DbSet<Product>? Products { get; set; }

        //public ICustomerRepository CustomerRepository;
        //public IGenericRepository<Order> OrderRepository;
        //public IGenericRepository<OrderItem> OrderItemRepository;
        //public IGenericRepository<Product> ProductRepository;
    }
}
