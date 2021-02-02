using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.Enums;
using ProductStock.Models;

namespace ProductStock
{
    public partial class FormShop : Form
    {
        public FormShop()
        {
            InitializeComponent();
        }

        static void Validate(Product product)
        {
            ValidationContext context = new ValidationContext(product);
            List<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(product, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            }
        }
        private Form _loginControl;


        public FormShop(Form form) : this()
        {
            _loginControl = form;
        }
    }
}
