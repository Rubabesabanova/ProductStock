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
                cmbCategorySrchShop.Items.Add(category.Id + "-" + category.Name);
            }
        }

        private void btnShowAllShop_Click(object sender, EventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetGridData(dgvShop);
        }

        private void dgvShop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            var product = productDAL.GetByFilter(x => x.Id == Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value));
            txbNameCrudShop.Text = product.Name;
            txbPriceCrudShop.Text = product.Price.ToString();
            txbCountCrudShop.Text = product.Count.ToString();
            CategoryDAL categoryDAL = new CategoryDAL();
            var category = categoryDAL.GetByFilter(x => x.Id == Convert.ToInt32(product.CategoryId));
            cmbCategoryCrudShop.SelectedItem = category.Id.ToString() + "-" + category.Name.ToString();
        }

        private void btnUpdateCrudShop_Click(object sender, EventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            var product = productDAL.GetByFilter(x => x.Id == Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value));
            Product productItem = new Product()
            {
                Id = Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value),
                Name = this.txbNameCrudShop.Text,
                CategoryId = Convert.ToInt32(this.cmbCategoryCrudShop.Text.Split('-')[0]),
                Count = Convert.ToInt32(this.txbCountCrudShop.Text),
                Price = Convert.ToDouble(this.txbPriceCrudShop.Text),
                UserId = product.UserId,
                Status = (int)ProductStatusEnum.Active,
            };
            productDAL.Update(productItem);
            MessageBox.Show("Successfully Deleted");
            productDAL.GetGridData(dgvShop);
        }

        private void btnDeleteCrudShop_Click(object sender, EventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.Delete(Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value));
            MessageBox.Show("Successfully Deleted");
            productDAL.GetGridData(dgvShop);
        }

        private void txbProductNameSrchShop_TextChanged(object sender, EventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetGridByName(dgvShop, txbProductNameSrchShop.Text);
        }

        private void cmbCategorySrchShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetGridByCategory(dgvShop, cmbCategorySrchShop.Text.Split('-')[1]);
        }

        private void btnSearchShop_Click(object sender, EventArgs e)
        {
            List<string> SearchString = new List<string>
            {
                txbNameSearchShop.Text,
                cmbCategorySearchShop.Text,
                txbUserSearchShop.Text,
                txbCountSearchShop.Text,
                txbPriceSearchShop.Text
            };
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetGridAdvancedSearch(dgvShop, SearchString);
        }
    }
}
