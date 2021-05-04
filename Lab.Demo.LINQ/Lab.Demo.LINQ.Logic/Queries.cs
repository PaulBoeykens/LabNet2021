using Lab.Demo.LINQ.Data;
using Lab.Demo.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.LINQ.Logic
{
    public class Queries
    {
        private readonly NorthwindContext context;

        public Queries()
        {
            context = new NorthwindContext();
        }
        public void ObjectCustomer()
        {
            var query1 = context.Customers.Where(c => c.CustomerID == "ALFKI")
                                           .Select(c => c)
                                           .ToList();
            
        }

        public void NoStockProducts()
        {
            var query2 = from Products in context.Products
                         where Products.UnitsInStock == 0
                         select Products;

            foreach (var item in query2)
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName}");
            }

        }

        public void StockProducts()
        {
            var query3 = context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice < 3)
                                         .Select(p => p)
                                         .ToList();
            foreach (var item in query3)
            {
                Console.WriteLine($"{item.UnitsInStock} - {item.UnitPrice}");
            }

        }

        public void Customers()
        {
            var query4 = from Customers in context.Customers
                         where Customers.Region == "WA"
                         select Customers;
            foreach (var item in query4)
            {
                Console.WriteLine($"{item.CustomerID}- {item.ContactName}");
            }
        }

        public void Products()
        {
            try
            {
                var query5 = context.Products.ToList().FirstOrDefault(o => o.ProductID == 789);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"NUll{ex.Message}");
            }
        
        }

        public void NameCustomers()
        {
            var query6 = from customers in context.Customers
                         select customers;
                       
            foreach (var item in query6)
            {
                Console.WriteLine($"{item.CustomerID} -{item.ContactName.ToUpper()}-{item.ContactName.ToLower()}");
            }
        }

        public void JoinCustomersOrder()
        {
            var Date = new DateTime(1997, 1, 1);
            var query7 = (from customers in context.Customers
                          join order in context.Orders
                          on customers.CustomerID equals order.CustomerID
                          where customers.Region == "WA" && order.OrderDate > Date
                          select new
                          {
                              customers.CompanyName,
                              order.OrderID,
                              order.OrderDate
                          }).ToList();
            foreach (var item in query7)
            {
                Console.WriteLine($"{item.CompanyName} - {item.OrderID} - {item.OrderDate}"); 
            }                
        }
        public void CustomersWashington()
        {
            var query8 = context.Customers.Where(c => c.Region == "WA")
                                         .Take(3)
                                         .ToList();
            foreach (var item in query8)
            {
                Console.WriteLine($"{item.Region}");
            }
        }

        public void ProductName()
        {
            var query9 = context.Products.OrderBy(n => n.ProductName)
                                          .ToList();
            foreach (var item in query9)
            {
                Console.WriteLine($"{item.ProductName}");
            }

        }

       public void ProductsMayMin()
        {
            var query10 = context.Products.OrderByDescending(m => m.UnitsInStock)
                                            .ToList();
            foreach (var item in query10)
            {
                Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            }
        }

        public void FirstProduct()
        {
            var query12 = (from Products in context.Products                           
                           select Products)
                           .Take(1)
                           .ToList();
            foreach (var item in query12)
            {
                Console.WriteLine($"{item.ProductID} - {item.ProductName}");
            }
 
        }
    }
}
