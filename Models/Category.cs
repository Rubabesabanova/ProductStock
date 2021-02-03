using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock.Models
{
    public class Category:Entity
    {
        public Category()
        {
            //Products = new List<Product>();
        }
        public List<Product> Products { get; set; }
    }
}
