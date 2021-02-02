using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStock.DbContexts;
using ProductStock.Models;

namespace ProductStock.DAL
{
    class UserDAL : IOperation<User>
    {
        public void Add(User user)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<User> Show()
        {
            using (DatabaseContext context = new DatabaseContext())
            {   
                return context.Users.ToList();
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        
    }
}
