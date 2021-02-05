using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public List<Category> Show()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Categories.ToList();
            }
        }
        public Category GetByFilter(Func<Category, bool> expression = null)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Categories.FirstOrDefault(expression);
            }
        }

        public void Update(Category item)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Categories.AddOrUpdate(item);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {

                context.Categories.Remove(GetByFilter(x => x.Id == id));
                context.SaveChanges();
            }
        }
    }
}
