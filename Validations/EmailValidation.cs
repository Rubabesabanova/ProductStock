using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.DAL;
using ProductStock.DbContexts;
using ProductStock.Models;

namespace ProductStock.Validations
{
    public static class EmailValidation
    {
        public static bool IsUniqueEmail(User user)
        {
            UserDAL userDAL = new UserDAL();
            var result = userDAL.GetByFilter(x => x.Email == user.Email);
            return result == null ? true : false;
        }
    }
}
