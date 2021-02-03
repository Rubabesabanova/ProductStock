using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock.Models
{
    public class Product: Entity
    {
        public Product()
        {
            //Logs = new List<Log>();
        }
        [Required(ErrorMessage = "The field is required")]
        public int Count { get; set; }
        [DefaultValue(0)]
        public int Sold { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public double Price { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public int Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Log> Logs { get; set; }
    }
}
