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


        private Form _loginControl;


        public FormShop(Form form) : this()
        {
            _loginControl = form;
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetGridData(dgvShop);
            GetCategory();
            AddDescription();
        }

        private void btnAddCrudShop_Click(object sender, EventArgs e)
        {
            if (cmbCategoryCrudShop.Text!="" && txbCountCrudShop.Text!="" && txbPriceCrudShop.Text !="")
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
            else
            {
                MessageBox.Show("The field is required");
            }
            
        }
        
        private void GetCategory()
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            foreach (Category category in categoryDAL.Show())
            {
                cmbCategoryCrudShop.Items.Add(category.Id + "-" + category.Name);
                cmbCategorySrchShop.Items.Add(category.Id + "-" + category.Name);
                cmbCategorySearchShop.Items.Add(category.Id + "-" + category.Name);
            }
        }

        private void btnShowAllShop_Click(object sender, EventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetGridData(dgvShop);
        }

        private void dgvShop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoveItem("btnBuyShop");
            ProductDAL productDAL = new ProductDAL();
            var product = productDAL.GetByFilter(x => x.Id == Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value));
            txbNameCrudShop.Text = product.Name;
            txbPriceCrudShop.Text = product.Price.ToString();
            txbCountCrudShop.Text = product.Count.ToString();
            CategoryDAL categoryDAL = new CategoryDAL();
            var category = categoryDAL.GetByFilter(x => x.Id == Convert.ToInt32(product.CategoryId));
            cmbCategoryCrudShop.SelectedItem = category.Id.ToString() + "-" + category.Name.ToString();
            if (product.UserId != CurrentUser.Id)
            {
                AddBuyButton();
            }

        }

        private void btnUpdateCrudShop_Click(object sender, EventArgs e)
        {

            ProductDAL productDAL = new ProductDAL();
            var product = productDAL.GetByFilter(x => x.Id == Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value));
            if (cmbCategoryCrudShop.Text != "" && txbCountCrudShop.Text != "" && txbPriceCrudShop.Text != "")
            {
                if (product.UserId == CurrentUser.Id || CurrentUser.Type == 2)
                {
                    Product productItem = new Product()
                    {
                        Id = Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value),
                        Name = this.txbNameCrudShop.Text,
                        CategoryId = Convert.ToInt32(cmbCategoryCrudShop.Text.Split('-')[0]),
                        Count = Convert.ToInt32(this.txbCountCrudShop.Text),
                        Price = Convert.ToDouble(this.txbPriceCrudShop.Text),
                        UserId = product.UserId,
                        Status = (int)ProductStatusEnum.Active,
                    };
                    if (CurrentUser.Type == 2)
                    {
                        LogDAL LogDAL = new LogDAL();
                        bool productExists = LogDAL.ProductExists(Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value));
                        Log log = new Log()
                        {
                            UserId = CurrentUser.Id,
                            Description = txbDescriptionCrudProducts.Text,
                            ProductId = Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value),
                            Type = Convert.ToInt32(LogTypeEnum.Update),
                            ModifiedDate = DateTime.UtcNow
                        };
                        if (productExists)
                        {
                            int logId = LogDAL.GetByFilter(x=>x.ProductId == Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value)).Id;
                            log.Id = logId;
                        }
                        bool isValid = ValidationOperation<Log>.ValidateOperation(log);
                        if (isValid)
                        {
                            productDAL.Update(productItem);
                            MessageBox.Show("Successfully Updated");
                            LogDAL.Update(log);
                            productDAL.GetGridData(dgvShop);
                        }
                    }
                    else
                    {
                        productDAL.Update(productItem);
                        MessageBox.Show("Successfully Updated");
                        productDAL.GetGridData(dgvShop);
                    }

                }
                else
                {
                    MessageBox.Show("You are not allowed to update others' products");
                }
            }
            else
            {
                MessageBox.Show("The field is required");
            }



        }

        private void btnDeleteCrudShop_Click(object sender, EventArgs e)
        {
            ProductDAL productDAL = new ProductDAL();
            var product = productDAL.GetByFilter(x => x.Id == Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value));
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (product.UserId == CurrentUser.Id || CurrentUser.Type == 2)
                {
                    if (CurrentUser.Type == 2)
                    {
                        LogDAL LogDAL = new LogDAL();
                        bool productExists = LogDAL.ProductExists(Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value));
                        Log log = new Log()
                        {
                            UserId = CurrentUser.Id,
                            Description = txbDescriptionCrudProducts.Text,
                            ProductId = Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value),
                            Type = Convert.ToInt32(LogTypeEnum.Delete),
                            ModifiedDate = DateTime.UtcNow
                        };
                        if (productExists)
                        {
                            int logId = LogDAL.GetByFilter(x => x.ProductId == Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value)).Id;
                            log.Id = logId;
                        }
                        bool isValid = ValidationOperation<Log>.ValidateOperation(log);
                        if (isValid)
                        {
                            productDAL.Delete(Convert.ToInt32(product.Id));
                            LogDAL.Update(log);
                            MessageBox.Show("Successfully Deleted");
                            productDAL.GetGridData(dgvShop);
                        }
                    }
                    else
                    {
                        productDAL.Delete(Convert.ToInt32(product.Id));
                        MessageBox.Show("Successfully Deleted");
                        productDAL.GetGridData(dgvShop);
                    }
                }
                else
                {
                    MessageBox.Show("You are not allowed to delete others' products");
                }
            }
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
            CategoryDAL categorDAL = new CategoryDAL();
            var categoryName ="";
            if (cmbCategorySearchShop.Text != "")
            {
                var categoryId = Convert.ToInt32(cmbCategorySearchShop.Text.Split('-')[0]);
                categoryName = categorDAL.GetByFilter(x => x.Id == categoryId).Name;
            }
            
            List<string> SearchString = new List<string>
            {
                txbNameSearchShop.Text,
                categoryName,
                txbUserSearchShop.Text,
                txbCountSearchShop.Text,
                txbPriceSearchShop.Text
            };
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetGridAdvancedSearch(dgvShop, SearchString);
        }
        // Function to add Buy button for customers
        public void AddBuyButton()
        {
            Button btnBuyShop = new Button();
            btnBuyShop.BackColor = System.Drawing.Color.CornflowerBlue;
            btnBuyShop.Location = new System.Drawing.Point(8, 20);
            btnBuyShop.Name = "btnBuyShop";
            btnBuyShop.Size = new System.Drawing.Size(78, 21);
            btnBuyShop.Text = "Buy";
            btnBuyShop.Click += new System.EventHandler(btnBuyShop_Click);
            this.Controls.Add(btnBuyShop);
        }
        //Function in order to remove an item from form by name
        public void RemoveItem(string name)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name == name)
                {
                    this.Controls.Remove(item);
                    break; 
                }
            }
        }

        //Adding description field for Admins
        public void AddDescription()
        {
            if (CurrentUser.Type == 2)
            {
                lblDescriptionCrudProducts.Visible = true;
                txbDescriptionCrudProducts.Visible = true;
            }
            
        }
        private void btnBuyShop_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value);
            ProductDAL productDAL = new ProductDAL();
            var product = productDAL.GetByFilter(x => x.Id == Convert.ToInt32(dgvShop.CurrentRow.Cells[0].Value));
            productDAL.GetProduct(id);
            if (product.UserId != CurrentUser.Id)
            {
                MessageBox.Show("Successfully purchase");
                productDAL.GetGridData(dgvShop);
                RemoveItem("btnBuyShop");
            }
            else
            {
                MessageBox.Show("You can't< purchase your product");
            }
            
        }
    }
}
