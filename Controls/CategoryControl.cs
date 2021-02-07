using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.DAL;
using ProductStock.Models;
using ProductStock.Validations;

namespace ProductStock.Controls
{
    public partial class CategoryControl : Form
    {
        public CategoryControl()
        {
            InitializeComponent();
        }
        private Form _loginControl;


        public CategoryControl(Form form) : this()
        {
            _loginControl = form;
            CategoryDAL categoryDAL = new CategoryDAL();
            categoryDAL.GetGridData(dgvCategory);
        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                Name = this.txbNameCategories.Text
            };

            bool isValid = ValidationOperation<Category>.ValidateOperation(category);
            if (isValid)
            {
                CategoryDAL categoryDAL = new CategoryDAL();
                categoryDAL.Add(category);
                MessageBox.Show("Successfully Added!");
                categoryDAL.GetGridData(dgvCategory);
            }
        }

        private void btnUpdateCategories_Click(object sender, EventArgs e)
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            Category category = new Category()
            {
                Id = Convert.ToInt32(dgvCategory.CurrentRow.Cells[0].Value),
                Name = this.txbNameCategories.Text
            };
            bool isValid = ValidationOperation<Category>.ValidateOperation(category);
            if (isValid)
            {
                categoryDAL.Update(category);
                MessageBox.Show("Successfully Updated");
                categoryDAL.GetGridData(dgvCategory);
            }
            
        }

        private void btnDeleteCategories_Click(object sender, EventArgs e)
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                categoryDAL.Delete(Convert.ToInt32(dgvCategory.CurrentRow.Cells[0].Value));
                MessageBox.Show("Successfully Deleted");
                categoryDAL.GetGridData(dgvCategory);
            }
            
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            var category = categoryDAL.GetByFilter(x => x.Id == Convert.ToInt32(dgvCategory.CurrentRow.Cells[0].Value));
            txbNameCategories.Text = category.Name;
        }
    }
}
