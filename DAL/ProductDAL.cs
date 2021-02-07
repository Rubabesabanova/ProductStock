using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.DbContexts;
using ProductStock.Enums;
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

        public List<Product> Show()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Products.ToList();
            }
        }
        //Getting all the data for Data Grid View
        public void GetGridData(DataGridView dgv)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var products = context.Products.Select(product => new
                {
                    Number = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    User = product.User.Name,
                    Contact = product.User.Phone,
                    Category = product.Category.Name,
                    Count = product.Count,
                    Status = ((ProductStatusEnum)product.Status).ToString()
                }).Where(p => p.Count != 0 && p.Status == "Active").ToList();
                dgv.DataSource = products;

            }
        }
        //Getting all the data for Data Grid View filtered by product name
        public void GetGridByName(DataGridView dgv, string key)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var products = context.Products.Select(product => new
                {
                    Number = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    User = product.User.Name,
                    Contact = product.User.Phone,
                    Category = product.Category.Name,
                    Count = product.Count,
                    Status = ((ProductStatusEnum)product.Status).ToString()
                }).Where(p => p.Count != 0 && p.Name.Contains(key) && p.Status == "Active").ToList();
                dgv.DataSource = products;

            }
        }
        //Getting all the data for Data Grid View filtered by category
        public void GetGridByCategory(DataGridView dgv, string key)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var products = context.Products.Select(product => new
                {
                    Number = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    User = product.User.Name,
                    Contact = product.User.Phone,
                    Category = product.Category.Name,
                    Count = product.Count,
                    Status = ((ProductStatusEnum)product.Status).ToString()
                }).Where(p => p.Count != 0 && p.Category== key && p.Status == "Active").ToList();
                dgv.DataSource = products;

            }
        }
        //Getting all the data for Data Grid View filtered by advanced search
        public void GetGridAdvancedSearch(DataGridView dgv, List<string> key)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                //Sorting the fields one by one to prevent SQL error
                string categoryName = key[1];
                string name = key[0];
                string userName = key[2];
                string count = key[3];
                string price = key[4];
                var products = context.Products.Select(product => new
                {
                    Number = product.Id,
                    Name = product.Name,
                    Price = product.Price.ToString(),
                    User = product.User.Name,
                    Contact = product.User.Phone,
                    Category = product.Category.Name,
                    Count = product.Count.ToString(),
                    Status = ((ProductStatusEnum)product.Status).ToString()
                }).Where(p => p.Count != "0" &&
                        p.Name.Contains(name) &&
                        p.Category.Contains(categoryName) &&
                        p.User.Contains(userName) &&
                        p.Count.Contains(count) &&
                        p.Price.Contains(price) &&
                        p.Status == "Active").ToList();
                dgv.DataSource = products;

            }
        }
        
        public Product GetByFilter(Func<Product, bool> expression = null)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Products.FirstOrDefault(expression);
            }
        }
        //Function to purchase a product
        public void GetProduct(int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var item = GetByFilter(x => x.Id == id);
                item.Count -= 1;
                item.Sold += 1;
                context.Products.AddOrUpdate(item);
                context.SaveChanges();
            }
        }

        public void Update(Product item)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Products.AddOrUpdate(item);
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var item = GetByFilter(x => x.Id == id);
                item.Status = Convert.ToInt32(ProductStatusEnum.Deleted);
                context.Products.AddOrUpdate(item);
                context.SaveChanges();
            }
        }
    }
}
