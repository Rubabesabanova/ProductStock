using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.DbContexts;
using ProductStock.Models;

namespace ProductStock.DAL
{
    class ProductDAL : IOperation<Product>
    {
        public void Add(Product item)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Products.Add(item);
                context.SaveChanges();
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Product> Show()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Products.ToList();
            }
        }
        public void GetGridData(DataGridView dgv)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var products = context.Products.Select(product => new
                {
                    Name = product.Name,
                    Price = product.Price,
                    User = product.User.Name,
                    Contact = product.User.Phone,
                    Category = product.Category.Name
                }).ToList();
                dgv.DataSource = products;

            }
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
