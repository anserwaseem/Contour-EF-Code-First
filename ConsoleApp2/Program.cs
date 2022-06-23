// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Data;
using ConsoleApp2.Models;
using ConsoleApp2.Repository;
using ConsoleApp2.Repository.CustomerRepo;
using ConsoleApp2.Repository.ProductRepo;

//Controller

//ICustomerRepository CustomerRepo=new CustomerRepository();
//var customer1 = new Customer("Anser", 3520029856782, "JT Lahore", 22);
//var customer2 = new Customer("Waseem", 3520029856799, age: 50);
//CustomerRepo.Add(customer2);


//var product1 = new Product("pin", 2, category: Category.Fashion);
//var product2 = new Product("charger", 12, category: Category.Electronics);
//var product3 = new Product("apple", 25, "Fruit");

//List<Product> products = new List<Product>() { product1, product2, product3 };

//IProductRepository ProductRepo = new ProductRepository();
//ProductRepo.AddRange(products);




using (var context = new AppDbContext())
{
    //context.AddRange(CustomerRepo.GetAll());
    //context.AddRange(ProductRepo.GetAll());
    //context.Add(order1);


    //var deleteCustomer =context.Customers.First(cust => cust.Id == 3);
    //context.Remove(deleteCustomer);


    //var deleteProducts = from p in context.Products where p.Id > 3 select p;
    //context.RemoveRange(deleteProducts);


    //var products = context.Products?.ToList();
    //var product1 = products?.FirstOrDefault(p => p.Name == "pin");
    //var item1 = new OrderItem(24, product1);
    //var product2 = products?.FirstOrDefault(p => p.Name == "charger");
    //var item2 = new OrderItem(56, product2);

    //var customer1 = context.Customers?.FirstOrDefault(c => c.Name.Equals("Anser"));
    //var order1 = new Order(customer1); 
    //order1.AddOrderItem(item1).AddOrderItem(item2);

    //context.Add(order1);


    context.SaveChanges();
}