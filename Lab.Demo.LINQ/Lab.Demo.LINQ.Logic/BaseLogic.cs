using Lab.Demo.LINQ.Data;
using Lab.Demo.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.LINQ.Logic
{
    public class BaseLogic
    {
        private readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }
    }
}
