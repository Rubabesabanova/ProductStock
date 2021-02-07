using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStock.Validations;

namespace ProductStock.Models
{
    
    public class User : Entity
    {
        public User()
        {
            Products = new List<Product>();
            Logs = new List<Log>();
        }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [MinLength(2, ErrorMessage = "The minimum length of Surname is 2 characters")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [Phone(ErrorMessage = "Invalid Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public int Type { get; set; }
        public List<Product> Products { get; set; }
        public List<Log> Logs { get; set; }
    }
}
