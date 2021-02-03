using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStock.DbContexts;
using ProductStock.Models;

namespace ProductStock.DAL
{
    class CategoryDAL : IOperation<Category>
    {
        public void Add(Category item)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Category> Show()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Categories.ToList();
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
