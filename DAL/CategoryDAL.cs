using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.DbContexts;
using ProductStock.Models;

namespace ProductStock.DAL
{
    class CategoryDAL : IOperation<Category>
    {
        public void Add(Category item)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Categories.Add(item);
                context.SaveChanges();
            }
        }

        public List<Category> Show()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Categories.ToList();
            }
        }
        //Getting all the data for Data Grid View
        public void GetGridData(DataGridView dgv)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var categories = context.Categories.Select(category => new
                {
                    Number =category.Id,
                    Name = category.Name,
                }).ToList();
                dgv.DataSource = categories;

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
                var item = GetByFilter(x => x.Id == id);
                context.Entry(item).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
