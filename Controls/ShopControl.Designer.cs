
namespace ProductStock
{
    partial class FormShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.tcShop = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearchShop = new System.Windows.Forms.Button();
            this.lblPriceSearchShop = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblCountSearchShop = new System.Windows.Forms.Label();
            this.txbCountSearchShop = new System.Windows.Forms.TextBox();
            this.lblCategorySearchShop = new System.Windows.Forms.Label();
            this.cmbCategorySearchShop = new System.Windows.Forms.ComboBox();
            this.lblUserSearchShop = new System.Windows.Forms.Label();
            this.txbUserSearchShop = new System.Windows.Forms.TextBox();
            this.lblNameSearchShop = new System.Windows.Forms.Label();
            this.txbNameSearchShop = new System.Windows.Forms.TextBox();
            this.CrudProductsShop = new System.Windows.Forms.TabPage();
            this.btnAddCrudShop = new System.Windows.Forms.Button();
            this.lblPriceCrudShop = new System.Windows.Forms.Label();
            this.txbPriceCrudShop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCountCrudShop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoryCrudShop = new System.Windows.Forms.ComboBox();
            this.lblNameCrudShop = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnShowAllShop = new System.Windows.Forms.Button();
            this.cmbCategorySrchShop = new System.Windows.Forms.ComboBox();
            this.lblCategorySrchShop = new System.Windows.Forms.Label();
            this.lblProductNameSrchShop = new System.Windows.Forms.Label();
            this.txbProductNameSrchShop = new System.Windows.Forms.TextBox();
            this.btnUpdateCrudShop = new System.Windows.Forms.Button();
            this.btnDeleteCrudShop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.tcShop.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CrudProductsShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShop
            // 
            this.dgvShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Location = new System.Drawing.Point(328, 71);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.Size = new System.Drawing.Size(448, 352);
            this.dgvShop.TabIndex = 0;
            // 
            // tcShop
            // 
            this.tcShop.Controls.Add(this.tabPage1);
            this.tcShop.Controls.Add(this.CrudProductsShop);
            this.tcShop.Location = new System.Drawing.Point(21, 71);
            this.tcShop.Name = "tcShop";
            this.tcShop.SelectedIndex = 0;
            this.tcShop.Size = new System.Drawing.Size(281, 352);
            this.tcShop.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearchShop);
            this.tabPage1.Controls.Add(this.lblPriceSearchShop);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.lblCountSearchShop);
            this.tabPage1.Controls.Add(this.txbCountSearchShop);
            this.tabPage1.Controls.Add(this.lblCategorySearchShop);
            this.tabPage1.Controls.Add(this.cmbCategorySearchShop);
            this.tabPage1.Controls.Add(this.lblUserSearchShop);
            this.tabPage1.Controls.Add(this.txbUserSearchShop);
            this.tabPage1.Controls.Add(this.lblNameSearchShop);
            this.tabPage1.Controls.Add(this.txbNameSearchShop);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(273, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detailed Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearchShop
            // 
            this.btnSearchShop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchShop.Location = new System.Drawing.Point(65, 281);
            this.btnSearchShop.Name = "btnSearchShop";
            this.btnSearchShop.Size = new System.Drawing.Size(123, 35);
            this.btnSearchShop.TabIndex = 10;
            this.btnSearchShop.Text = "Search";
            this.btnSearchShop.UseVisualStyleBackColor = false;
            // 
            // lblPriceSearchShop
            // 
            this.lblPriceSearchShop.AutoSize = true;
            this.lblPriceSearchShop.Location = new System.Drawing.Point(28, 239);
            this.lblPriceSearchShop.Name = "lblPriceSearchShop";
            this.lblPriceSearchShop.Size = new System.Drawing.Size(31, 13);
            this.lblPriceSearchShop.TabIndex = 9;
            this.lblPriceSearchShop.Text = "Price";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(28, 255);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 20);
            this.textBox4.TabIndex = 8;
            // 
            // lblCountSearchShop
            // 
            this.lblCountSearchShop.AutoSize = true;
            this.lblCountSearchShop.Location = new System.Drawing.Point(28, 190);
            this.lblCountSearchShop.Name = "lblCountSearchShop";
            this.lblCountSearchShop.Size = new System.Drawing.Size(35, 13);
            this.lblCountSearchShop.TabIndex = 7;
            this.lblCountSearchShop.Text = "Count";
            // 
            // txbCountSearchShop
            // 
            this.txbCountSearchShop.Location = new System.Drawing.Point(28, 206);
            this.txbCountSearchShop.Name = "txbCountSearchShop";
            this.txbCountSearchShop.Size = new System.Drawing.Size(197, 20);
            this.txbCountSearchShop.TabIndex = 6;
            // 
            // lblCategorySearchShop
            // 
            this.lblCategorySearchShop.AutoSize = true;
            this.lblCategorySearchShop.Location = new System.Drawing.Point(25, 88);
            this.lblCategorySearchShop.Name = "lblCategorySearchShop";
            this.lblCategorySearchShop.Size = new System.Drawing.Size(49, 13);
            this.lblCategorySearchShop.TabIndex = 5;
            this.lblCategorySearchShop.Text = "Category";
            // 
            // cmbCategorySearchShop
            // 
            this.cmbCategorySearchShop.FormattingEnabled = true;
            this.cmbCategorySearchShop.Location = new System.Drawing.Point(28, 104);
            this.cmbCategorySearchShop.Name = "cmbCategorySearchShop";
            this.cmbCategorySearchShop.Size = new System.Drawing.Size(200, 21);
            this.cmbCategorySearchShop.TabIndex = 4;
            // 
            // lblUserSearchShop
            // 
            this.lblUserSearchShop.AutoSize = true;
            this.lblUserSearchShop.Location = new System.Drawing.Point(25, 140);
            this.lblUserSearchShop.Name = "lblUserSearchShop";
            this.lblUserSearchShop.Size = new System.Drawing.Size(29, 13);
            this.lblUserSearchShop.TabIndex = 3;
            this.lblUserSearchShop.Text = "User";
            // 
            // txbUserSearchShop
            // 
            this.txbUserSearchShop.Location = new System.Drawing.Point(28, 156);
            this.txbUserSearchShop.Name = "txbUserSearchShop";
            this.txbUserSearchShop.Size = new System.Drawing.Size(197, 20);
            this.txbUserSearchShop.TabIndex = 2;
            // 
            // lblNameSearchShop
            // 
            this.lblNameSearchShop.AutoSize = true;
            this.lblNameSearchShop.Location = new System.Drawing.Point(28, 32);
            this.lblNameSearchShop.Name = "lblNameSearchShop";
            this.lblNameSearchShop.Size = new System.Drawing.Size(35, 13);
            this.lblNameSearchShop.TabIndex = 1;
            this.lblNameSearchShop.Text = "Name";
            // 
            // txbNameSearchShop
            // 
            this.txbNameSearchShop.Location = new System.Drawing.Point(28, 51);
            this.txbNameSearchShop.Name = "txbNameSearchShop";
            this.txbNameSearchShop.Size = new System.Drawing.Size(200, 20);
            this.txbNameSearchShop.TabIndex = 0;
            // 
            // CrudProductsShop
            // 
            this.CrudProductsShop.Controls.Add(this.btnDeleteCrudShop);
            this.CrudProductsShop.Controls.Add(this.btnUpdateCrudShop);
            this.CrudProductsShop.Controls.Add(this.btnAddCrudShop);
            this.CrudProductsShop.Controls.Add(this.lblPriceCrudShop);
            this.CrudProductsShop.Controls.Add(this.txbPriceCrudShop);
            this.CrudProductsShop.Controls.Add(this.label2);
            this.CrudProductsShop.Controls.Add(this.txbCountCrudShop);
            this.CrudProductsShop.Controls.Add(this.label3);
            this.CrudProductsShop.Controls.Add(this.cmbCategoryCrudShop);
            this.CrudProductsShop.Controls.Add(this.lblNameCrudShop);
            this.CrudProductsShop.Controls.Add(this.textBox5);
            this.CrudProductsShop.Location = new System.Drawing.Point(4, 22);
            this.CrudProductsShop.Name = "CrudProductsShop";
            this.CrudProductsShop.Padding = new System.Windows.Forms.Padding(3);
            this.CrudProductsShop.Size = new System.Drawing.Size(273, 326);
            this.CrudProductsShop.TabIndex = 1;
            this.CrudProductsShop.Text = "CRUD Products";
            this.CrudProductsShop.UseVisualStyleBackColor = true;
            // 
            // btnAddCrudShop
            // 
            this.btnAddCrudShop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddCrudShop.Location = new System.Drawing.Point(28, 235);
            this.btnAddCrudShop.Name = "btnAddCrudShop";
            this.btnAddCrudShop.Size = new System.Drawing.Size(93, 35);
            this.btnAddCrudShop.TabIndex = 21;
            this.btnAddCrudShop.Text = "Add";
            this.btnAddCrudShop.UseVisualStyleBackColor = false;
            // 
            // lblPriceCrudShop
            // 
            this.lblPriceCrudShop.AutoSize = true;
            this.lblPriceCrudShop.Location = new System.Drawing.Point(28, 181);
            this.lblPriceCrudShop.Name = "lblPriceCrudShop";
            this.lblPriceCrudShop.Size = new System.Drawing.Size(31, 13);
            this.lblPriceCrudShop.TabIndex = 20;
            this.lblPriceCrudShop.Text = "Price";
            // 
            // txbPriceCrudShop
            // 
            this.txbPriceCrudShop.Location = new System.Drawing.Point(28, 197);
            this.txbPriceCrudShop.Name = "txbPriceCrudShop";
            this.txbPriceCrudShop.Size = new System.Drawing.Size(197, 20);
            this.txbPriceCrudShop.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Count";
            // 
            // txbCountCrudShop
            // 
            this.txbCountCrudShop.Location = new System.Drawing.Point(28, 148);
            this.txbCountCrudShop.Name = "txbCountCrudShop";
            this.txbCountCrudShop.Size = new System.Drawing.Size(197, 20);
            this.txbCountCrudShop.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Category";
            // 
            // cmbCategoryCrudShop
            // 
            this.cmbCategoryCrudShop.FormattingEnabled = true;
            this.cmbCategoryCrudShop.Location = new System.Drawing.Point(28, 93);
            this.cmbCategoryCrudShop.Name = "cmbCategoryCrudShop";
            this.cmbCategoryCrudShop.Size = new System.Drawing.Size(200, 21);
            this.cmbCategoryCrudShop.TabIndex = 15;
            // 
            // lblNameCrudShop
            // 
            this.lblNameCrudShop.AutoSize = true;
            this.lblNameCrudShop.Location = new System.Drawing.Point(28, 21);
            this.lblNameCrudShop.Name = "lblNameCrudShop";
            this.lblNameCrudShop.Size = new System.Drawing.Size(35, 13);
            this.lblNameCrudShop.TabIndex = 12;
            this.lblNameCrudShop.Text = "Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(28, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 11;
            // 
            // btnShowAllShop
            // 
            this.btnShowAllShop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAllShop.Location = new System.Drawing.Point(25, 20);
            this.btnShowAllShop.Name = "btnShowAllShop";
            this.btnShowAllShop.Size = new System.Drawing.Size(121, 21);
            this.btnShowAllShop.TabIndex = 2;
            this.btnShowAllShop.Text = "Show All";
            this.btnShowAllShop.UseVisualStyleBackColor = false;
            // 
            // cmbCategorySrchShop
            // 
            this.cmbCategorySrchShop.FormattingEnabled = true;
            this.cmbCategorySrchShop.Location = new System.Drawing.Point(269, 19);
            this.cmbCategorySrchShop.Name = "cmbCategorySrchShop";
            this.cmbCategorySrchShop.Size = new System.Drawing.Size(159, 21);
            this.cmbCategorySrchShop.TabIndex = 3;
            // 
            // lblCategorySrchShop
            // 
            this.lblCategorySrchShop.AutoSize = true;
            this.lblCategorySrchShop.Location = new System.Drawing.Point(177, 23);
            this.lblCategorySrchShop.Name = "lblCategorySrchShop";
            this.lblCategorySrchShop.Size = new System.Drawing.Size(86, 13);
            this.lblCategorySrchShop.TabIndex = 4;
            this.lblCategorySrchShop.Text = "Category Search";
            // 
            // lblProductNameSrchShop
            // 
            this.lblProductNameSrchShop.AutoSize = true;
            this.lblProductNameSrchShop.Location = new System.Drawing.Point(457, 23);
            this.lblProductNameSrchShop.Name = "lblProductNameSrchShop";
            this.lblProductNameSrchShop.Size = new System.Drawing.Size(112, 13);
            this.lblProductNameSrchShop.TabIndex = 5;
            this.lblProductNameSrchShop.Text = "Product Name Search";
            // 
            // txbProductNameSrchShop
            // 
            this.txbProductNameSrchShop.Location = new System.Drawing.Point(575, 20);
            this.txbProductNameSrchShop.Name = "txbProductNameSrchShop";
            this.txbProductNameSrchShop.Size = new System.Drawing.Size(166, 20);
            this.txbProductNameSrchShop.TabIndex = 6;
            // 
            // btnUpdateCrudShop
            // 
            this.btnUpdateCrudShop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateCrudShop.Location = new System.Drawing.Point(127, 235);
            this.btnUpdateCrudShop.Name = "btnUpdateCrudShop";
            this.btnUpdateCrudShop.Size = new System.Drawing.Size(98, 35);
            this.btnUpdateCrudShop.TabIndex = 22;
            this.btnUpdateCrudShop.Text = "Update";
            this.btnUpdateCrudShop.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCrudShop
            // 
            this.btnDeleteCrudShop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteCrudShop.Location = new System.Drawing.Point(31, 276);
            this.btnDeleteCrudShop.Name = "btnDeleteCrudShop";
            this.btnDeleteCrudShop.Size = new System.Drawing.Size(194, 35);
            this.btnDeleteCrudShop.TabIndex = 24;
            this.btnDeleteCrudShop.Text = "Delete";
            this.btnDeleteCrudShop.UseVisualStyleBackColor = false;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbProductNameSrchShop);
            this.Controls.Add(this.lblProductNameSrchShop);
            this.Controls.Add(this.lblCategorySrchShop);
            this.Controls.Add(this.cmbCategorySrchShop);
            this.Controls.Add(this.btnShowAllShop);
            this.Controls.Add(this.tcShop);
            this.Controls.Add(this.dgvShop);
            this.Name = "FormShop";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.tcShop.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.CrudProductsShop.ResumeLayout(false);
            this.CrudProductsShop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.TabControl tcShop;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage CrudProductsShop;
        private System.Windows.Forms.TextBox txbNameSearchShop;
        private System.Windows.Forms.Label lblNameSearchShop;
        private System.Windows.Forms.Label lblUserSearchShop;
        private System.Windows.Forms.TextBox txbUserSearchShop;
        private System.Windows.Forms.ComboBox cmbCategorySearchShop;
        private System.Windows.Forms.Label lblCategorySearchShop;
        private System.Windows.Forms.Label lblCountSearchShop;
        private System.Windows.Forms.TextBox txbCountSearchShop;
        private System.Windows.Forms.Label lblPriceSearchShop;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSearchShop;
        private System.Windows.Forms.Button btnShowAllShop;
        private System.Windows.Forms.ComboBox cmbCategorySrchShop;
        private System.Windows.Forms.Label lblCategorySrchShop;
        private System.Windows.Forms.Label lblProductNameSrchShop;
        private System.Windows.Forms.TextBox txbProductNameSrchShop;
        private System.Windows.Forms.Button btnAddCrudShop;
        private System.Windows.Forms.Label lblPriceCrudShop;
        private System.Windows.Forms.TextBox txbPriceCrudShop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCountCrudShop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoryCrudShop;
        private System.Windows.Forms.Label lblNameCrudShop;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnUpdateCrudShop;
        private System.Windows.Forms.Button btnDeleteCrudShop;
    }
}

