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
using ProductStock.Enums;
using ProductStock.Models;

namespace ProductStock.Controls
{
    public partial class ReportControl : Form
    {
        public static User CurrentUser { get; set; }
        public ReportControl()
        {
            InitializeComponent();
        }
        private Form _loginControl;


        public ReportControl(Form form) : this()
        {
            _loginControl = form;
            LogDAL logDAL = new LogDAL();
            if (CurrentUser.Type==2)
            {
                logDAL.GetGridReport(dgvReport);
            }
            else
            {
                logDAL.GetGridReport(dgvReport, CurrentUser.Email);
            }
            GetComboBoxItems();
        }

        private void btnShowAllReport_Click(object sender, EventArgs e)
        {
            LogDAL logDAL = new LogDAL();
            if (CurrentUser.Type == 2)
            {
                logDAL.GetGridReport(dgvReport);
            }
            else
            {
                logDAL.GetGridReport(dgvReport, CurrentUser.Email);
            }
        }

        private void btnSearchReport_Click(object sender, EventArgs e)
        {
            LogDAL logDAL = new LogDAL();
            CategoryDAL categorDAL = new CategoryDAL();
            var categoryName = "";
            var statusName = "";
            var typeName = "";
            if (cmbCategoryReport.Text != "")
            {
                var categoryId = Convert.ToInt32(cmbCategoryReport.Text.Split('-')[0]);
                categoryName = categorDAL.GetByFilter(x => x.Id == categoryId).Name;
            }
            if (cmbStatusReport.Text != "")
            {
                var statusId = Convert.ToInt32(cmbStatusReport.Text.Split('-')[0]); 
                statusName = ((ProductStatusEnum)statusId).ToString();
            }
            if (cmbTypeReport.Text != "")
            {
                var typeId = Convert.ToInt32(cmbTypeReport.Text.Split('-')[0]);
                typeName = ((LogTypeEnum)typeId).ToString();
            }
            List<string> SearchString = new List<string>
            {
                tbxProductNameReport.Text,
                tbxPriceReport.Text,
                categoryName,
                tbxCountReport.Text,
                tbxSoldReport.Text,
                tbxDescriptionReport.Text,
                statusName,
                typeName,
            };
            if (CurrentUser.Type == 2)
            {
                logDAL.GetGridAdvancedSearch(dgvReport, SearchString);
            }
            else
            {
                logDAL.GetGridAdvancedSearch(dgvReport, SearchString, CurrentUser.Email);
            }
        }

        private void GetCategory()
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            foreach (Category category in categoryDAL.Show())
            {
                cmbCategoryReport.Items.Add(category.Id + "-" + category.Name);
            }
        }
        private void GetStatus()
        {
            foreach (ProductStatusEnum status in Enum.GetValues(typeof(ProductStatusEnum)))
            {
                cmbStatusReport.Items.Add(Convert.ToInt32(status) + "-" + status.ToString());
            }
        }
        private void GetType()
        {
            foreach (UserTypeEnum type in Enum.GetValues(typeof(UserTypeEnum)))
            {
                cmbTypeReport.Items.Add(Convert.ToInt32(type) + "-" + type.ToString());
            }
        }
        private void GetComboBoxItems()
        {
            GetCategory();
            GetStatus();
            GetType();
        }
    }
}
