using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.DbContexts;
using ProductStock.Enums;
using ProductStock.Models;

namespace ProductStock.DAL
{
    class LogDAL : IOperation<Log>
    {
        public void Add(Log item)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Logs.Add(item);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Log GetByFilter(Func<Log, bool> expression = null)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Logs.FirstOrDefault(expression);
            }
        }

        public List<Log> Show()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Logs.ToList();
            }
        }

        public void Update(Log item)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Logs.AddOrUpdate(item);
                context.SaveChanges();
            }
        }
        //Checking if a record of this product exists
        public bool ProductExists(int id)
        {
            bool result = false;
            using (DatabaseContext context = new DatabaseContext())
            {
                foreach (var item in context.Logs.ToList())
                {
                    if (item.ProductId==id)
                    {
                        result = true;
                        break;
                    }
                } 
            }
            return result;

        }
        //Getting all the data for Data Grid View
        public void GetGridReport(DataGridView dgv)
        {
            
            using (DatabaseContext context = new DatabaseContext())
            {
                var products = context.Products.Select(product => new
                {
                    Number = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    UserEmail = product.User.Email,
                    Category = product.Category.Name,
                    Count = product.Count,
                    Sold = product.Sold,
                    Description = context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().Description,
                    Status = ((ProductStatusEnum)product.Status).ToString(),
                    Type = ((LogTypeEnum)context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().Type).ToString(),
                    Date = context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().ModifiedDate
            }).ToList();
                dgv.DataSource = products;

            }
        }
        //Getting all the data for Data Grid View by User Email (overloaded method)
        public void GetGridReport(DataGridView dgv, string email)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var products = context.Products.Select(product => new
                {
                    Number = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    UserEmail = product.User.Email,
                    Category = product.Category.Name,
                    Count = product.Count,
                    Sold = product.Sold,
                    Description = context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().Description,
                    Status = ((ProductStatusEnum)product.Status).ToString(),
                    Type = ((LogTypeEnum)context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().Type).ToString(),
                    Date = context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().ModifiedDate
                }).Where(p=> p.UserEmail == email).ToList();
                dgv.DataSource = products;

            }
        }
        //Getting all the data for Data Grid View filtered by advanced search
        public void GetGridAdvancedSearch(DataGridView dgv, List<string> key)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                string name = key[0];
                string price = key[1];
                string categoryName = key[2];
                string count = key[3];
                string sold = key[4];
                string description = key[5];
                string status = key[6];
                string type = key[7];
                var products = context.Products.Select(product => new
                {
                    Number = product.Id,
                    Name = product.Name,
                    Price = product.Price.ToString(),
                    UserEmail = product.User.Email,
                    Category = product.Category.Name,
                    Count = product.Count.ToString(),
                    Sold = product.Sold.ToString(),
                    Description = context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().Description,
                    Status = ((ProductStatusEnum)product.Status).ToString(),
                    Type = ((LogTypeEnum)context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().Type).ToString(),
                    Date = context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().ModifiedDate
                }).Where(p => 
                        p.Name.Contains(name) &&
                        p.Price.Contains(price) &&
                        p.Category.Contains(categoryName)|| p.Category==null &&
                        p.Count.Contains(count) &&
                        p.Sold.Contains(sold) &&
                        p.Description.Contains(description) &&
                        p.Status.Contains(status) || p.Status == null &&
                        p.Type.Contains(type) || p.Type == null).ToList();
                dgv.DataSource = products;

            }
        }
        //Getting all the data for Data Grid View filtered by advanced search by User Email(overloaded method)
        public void GetGridAdvancedSearch(DataGridView dgv, List<string> key, string email)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                string name = key[0];
                string price = key[1];
                string categoryName = key[2];
                string count = key[3];
                string sold = key[4];
                string description = key[5];
                string status = key[6];
                string type = key[7];
                var products = context.Products.Select(product => new
                {
                    Number = product.Id,
                    Name = product.Name,
                    Price = product.Price.ToString(),
                    UserEmail = product.User.Email,
                    Category = product.Category.Name,
                    Count = product.Count.ToString(),
                    Sold = product.Sold.ToString(),
                    Description = context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().Description,
                    Status = ((ProductStatusEnum)product.Status).ToString(),
                    Type = ((LogTypeEnum)context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().Type).ToString(),
                    Date = context.Logs.ToList().Where(x => x.ProductId == product.Id).FirstOrDefault().ModifiedDate
                }).Where(p =>
                        p.Name.Contains(name) &&
                        p.Price.Contains(price) &&
                        p.Category.Contains(categoryName) &&
                        p.Count.Contains(count) &&
                        p.Sold.Contains(sold) &&
                        p.Description.Contains(description) || p.Description==null &&
                        p.Status.Contains(status) || p.Status==null &&
                        p.Type.Contains(type)).Where(p => p.UserEmail == email).ToList();
                dgv.DataSource = products;

            }
        }
    }
}
