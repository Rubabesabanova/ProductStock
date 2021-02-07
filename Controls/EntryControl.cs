using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStock.Models;

namespace ProductStock.Controls
{
    public partial class EntryControl : Form
    {
        public static User CurrentUser { get; set; }
        public EntryControl()
        {
            InitializeComponent();
            
        }
        private Form _loginControl;

        private void AddButtons()
        {
            if (CurrentUser.Type==1)
            {
                Button btnSeeAllEntry = new Button();
                btnSeeAllEntry.BackColor = System.Drawing.Color.CornflowerBlue;
                btnSeeAllEntry.Location = new System.Drawing.Point(240, 87);
                btnSeeAllEntry.Name = "btnSeeAllEntry";
                btnSeeAllEntry.Size = new System.Drawing.Size(104, 51);
                btnSeeAllEntry.Text = "See All Products";
                this.Controls.Add(btnSeeAllEntry);
                btnSeeAllEntry.Click += new System.EventHandler(this.btnSeeAllEntry_Click);
                Button btnSeeReportsEntry = new Button();
                btnSeeReportsEntry.BackColor = System.Drawing.Color.CornflowerBlue;
                btnSeeReportsEntry.Location = new System.Drawing.Point(70, 87);
                btnSeeReportsEntry.Name = "btnSeeReportsEntry";
                btnSeeReportsEntry.Size = new System.Drawing.Size(107, 51);
                btnSeeReportsEntry.Text = "See your reports";
                this.Controls.Add(btnSeeReportsEntry);
                btnSeeReportsEntry.Click += new System.EventHandler(this.btnSeeAllReportsEntry_Click);
            }
            else if (CurrentUser.Type == 2)
            {
                Button btnSeeAllEntry = new Button();
                btnSeeAllEntry.BackColor = System.Drawing.Color.CornflowerBlue;
                btnSeeAllEntry.Location = new System.Drawing.Point(30, 87);
                btnSeeAllEntry.Name = "btnSeeAllEntry";
                btnSeeAllEntry.Size = new System.Drawing.Size(104, 51);
                btnSeeAllEntry.Text = "See All Products";
                this.Controls.Add(btnSeeAllEntry);
                btnSeeAllEntry.Click += new System.EventHandler(this.btnSeeAllEntry_Click);
                Button btnCategoryEntry = new Button();
                btnCategoryEntry.BackColor = System.Drawing.Color.CornflowerBlue;
                btnCategoryEntry.Location = new System.Drawing.Point(300, 87);
                btnCategoryEntry.Name = "btnCategoryEntry";
                btnCategoryEntry.Size = new System.Drawing.Size(107, 51);
                btnCategoryEntry.Text = "See Categories";
                this.Controls.Add(btnCategoryEntry);
                btnCategoryEntry.Click += new System.EventHandler(this.btnCategoryEntry_Click);
                Button btnSeeAllReportsEntry = new Button();
                btnSeeAllReportsEntry.BackColor = System.Drawing.Color.CornflowerBlue;
                btnSeeAllReportsEntry.Location = new System.Drawing.Point(160, 87);
                btnSeeAllReportsEntry.Name = "btnSeeAllReportsEntry";
                btnSeeAllReportsEntry.Size = new System.Drawing.Size(107, 51);
                btnSeeAllReportsEntry.Text = "See all Reports";
                this.Controls.Add(btnSeeAllReportsEntry);
                btnSeeAllReportsEntry.Click += new System.EventHandler(this.btnSeeAllReportsEntry_Click);

            }
        }
        public EntryControl(Form form) : this()
        {
            _loginControl = form;
            AddButtons();
        }

        private void btnSeeAllEntry_Click(object sender, EventArgs e)
        {
            FormShop.CurrentUser = EntryControl.CurrentUser;
            FormShop formShop = new FormShop(this);
            formShop.ShowDialog();
        }

        private void btnCategoryEntry_Click(object sender, EventArgs e)
        {
            CategoryControl formCategory = new CategoryControl(this);
            FormShop.CurrentUser = EntryControl.CurrentUser;
            formCategory.ShowDialog();
        }

        private void btnSeeAllReportsEntry_Click(object sender, EventArgs e)
        {
            ReportControl.CurrentUser = EntryControl.CurrentUser;
            ReportControl formReport = new ReportControl(this);
            formReport.ShowDialog();
        }
    }
}
