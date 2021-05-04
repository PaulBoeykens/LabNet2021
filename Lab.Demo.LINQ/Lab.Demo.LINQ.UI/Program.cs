using Lab.Demo.LINQ.Entities;
using Lab.Demo.LINQ.Logic;
using System;
using System.Collections.Generic;

namespace Lab.Demo.LINQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            Queries queries = new Queries();

            queries.Customers();
            queries.FirstProduct();
            queries.ProductsMayMin();
            queries.ProductName();
            queries.CustomersWashington();
            queries.JoinCustomersOrder();
            queries.NameCustomers();
            queries.Products();
            queries.Customers();
            queries.StockProducts();
            queries.NoStockProducts();
            Console.ReadLine();
        }

    }
}
