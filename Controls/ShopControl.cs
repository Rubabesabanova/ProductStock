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
using ProductStock.DAL;
using ProductStock.Enums;
using ProductStock.Models;
using ProductStock.Validations;

namespace ProductStock
{
    public partial class FormShop : Form
    {
        public static User CurrentUser { get; set; }
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
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetGridData(dgvShop);
            GetCategory();
        }

        private void btnAddCrudShop_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = this.txbNameCrudShop.Text,
                CategoryId = Convert.ToInt32(this.cmbCategoryCrudShop.Text.Split('-')[0]),
                Count = Convert.ToInt32(this.txbCountCrudShop.Text),
                Price = Convert.ToDouble(this.txbPriceCrudShop.Text),
                UserId = CurrentUser.Id,
                Status = (int)ProductStatusEnum.Active,
            };
            bool isValid = ValidationOperation<Product>.ValidateOperation(product);
            if (isValid)
            {
                ProductDAL productDAL = new ProductDAL();
                productDAL.Add(product);
                MessageBox.Show("Successfully Added!");
                productDAL.GetGridData(dgvShop);
            }
        }
        private void GetCategory()
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            foreach (Category category in categoryDAL.Show())
            {
                cmbCategoryCrudShop.Items.Add(category.Id + "-" + category.Name);
            }
        }

        private void btnShowAllShop_Click(object sender, EventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetGridData(dgvShop);
        }
    }
}
