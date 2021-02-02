using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStock.DbContexts;
using ProductStock.Models;

namespace ProductStock.Validations
{
    public class EmailValidationAttribute: Attribute
    {
        public List<string> Emails { get; set; }

        public EmailValidationAttribute()
        {
            using(DatabaseContext context = new DatabaseContext())
            {
                var users = context.Users.ToList();
                foreach (User user in users)
                {
                    Emails.Add(user.Email);
                }
            }
            
        }
    }
}
