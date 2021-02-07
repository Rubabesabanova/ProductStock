
namespace ProductStock.Controls
{
    partial class CategoryControl
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
            this.tcShop = new System.Windows.Forms.TabControl();
            this.CrudProductsShop = new System.Windows.Forms.TabPage();
            this.btnDeleteCategories = new System.Windows.Forms.Button();
            this.btnUpdateCategories = new System.Windows.Forms.Button();
            this.btnAddCategories = new System.Windows.Forms.Button();
            this.lblNameCategories = new System.Windows.Forms.Label();
            this.txbNameCategories = new System.Windows.Forms.TextBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.tcShop.SuspendLayout();
            this.CrudProductsShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tcShop
            // 
            this.tcShop.Controls.Add(this.CrudProductsShop);
            this.tcShop.Location = new System.Drawing.Point(23, 93);
            this.tcShop.Name = "tcShop";
            this.tcShop.SelectedIndex = 0;
            this.tcShop.Size = new System.Drawing.Size(281, 217);
            this.tcShop.TabIndex = 3;
            // 
            // CrudProductsShop
            // 
            this.CrudProductsShop.Controls.Add(this.btnDeleteCategories);
            this.CrudProductsShop.Controls.Add(this.btnUpdateCategories);
            this.CrudProductsShop.Controls.Add(this.btnAddCategories);
            this.CrudProductsShop.Controls.Add(this.lblNameCategories);
            this.CrudProductsShop.Controls.Add(this.txbNameCategories);
            this.CrudProductsShop.Location = new System.Drawing.Point(4, 22);
            this.CrudProductsShop.Name = "CrudProductsShop";
            this.CrudProductsShop.Padding = new System.Windows.Forms.Padding(3);
            this.CrudProductsShop.Size = new System.Drawing.Size(273, 191);
            this.CrudProductsShop.TabIndex = 1;
            this.CrudProductsShop.Text = "CRUD Categories";
            this.CrudProductsShop.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategories
            // 
            this.btnDeleteCategories.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteCategories.Location = new System.Drawing.Point(34, 134);
            this.btnDeleteCategories.Name = "btnDeleteCategories";
            this.btnDeleteCategories.Size = new System.Drawing.Size(196, 35);
            this.btnDeleteCategories.TabIndex = 24;
            this.btnDeleteCategories.Text = "Delete";
            this.btnDeleteCategories.UseVisualStyleBackColor = false;
            this.btnDeleteCategories.Click += new System.EventHandler(this.btnDeleteCategories_Click);
            // 
            // btnUpdateCategories
            // 
            this.btnUpdateCategories.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateCategories.Location = new System.Drawing.Point(130, 93);
            this.btnUpdateCategories.Name = "btnUpdateCategories";
            this.btnUpdateCategories.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateCategories.TabIndex = 22;
            this.btnUpdateCategories.Text = "Update";
            this.btnUpdateCategories.UseVisualStyleBackColor = false;
            this.btnUpdateCategories.Click += new System.EventHandler(this.btnUpdateCategories_Click);
            // 
            // btnAddCategories
            // 
            this.btnAddCategories.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddCategories.Location = new System.Drawing.Point(34, 93);
            this.btnAddCategories.Name = "btnAddCategories";
            this.btnAddCategories.Size = new System.Drawing.Size(95, 35);
            this.btnAddCategories.TabIndex = 21;
            this.btnAddCategories.Text = "Add";
            this.btnAddCategories.UseVisualStyleBackColor = false;
            this.btnAddCategories.Click += new System.EventHandler(this.btnAddCategories_Click);
            // 
            // lblNameCategories
            // 
            this.lblNameCategories.AutoSize = true;
            this.lblNameCategories.Location = new System.Drawing.Point(31, 32);
            this.lblNameCategories.Name = "lblNameCategories";
            this.lblNameCategories.Size = new System.Drawing.Size(35, 13);
            this.lblNameCategories.TabIndex = 12;
            this.lblNameCategories.Text = "Name";
            // 
            // txbNameCategories
            // 
            this.txbNameCategories.Location = new System.Drawing.Point(34, 57);
            this.txbNameCategories.Name = "txbNameCategories";
            this.txbNameCategories.Size = new System.Drawing.Size(202, 20);
            this.txbNameCategories.TabIndex = 11;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(330, 31);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(448, 352);
            this.dgvCategory.TabIndex = 2;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.tcShop);
            this.Controls.Add(this.dgvCategory);
            this.Name = "CategoryControl";
            this.Text = "CategoryControl";
            this.tcShop.ResumeLayout(false);
            this.CrudProductsShop.ResumeLayout(false);
            this.CrudProductsShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcShop;
        private System.Windows.Forms.TabPage CrudProductsShop;
        private System.Windows.Forms.Button btnDeleteCategories;
        private System.Windows.Forms.Button btnUpdateCategories;
        private System.Windows.Forms.Button btnAddCategories;
        private System.Windows.Forms.Label lblNameCategories;
        private System.Windows.Forms.TextBox txbNameCategories;
        private System.Windows.Forms.DataGridView dgvCategory;
    }
}