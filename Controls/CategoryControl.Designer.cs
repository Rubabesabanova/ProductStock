
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
            this.btnDeleteCrudShop = new System.Windows.Forms.Button();
            this.btnUpdateCrudShop = new System.Windows.Forms.Button();
            this.btnAddCrudShop = new System.Windows.Forms.Button();
            this.lblNameCrudShop = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.tcShop.SuspendLayout();
            this.CrudProductsShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
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
            this.CrudProductsShop.Controls.Add(this.btnDeleteCrudShop);
            this.CrudProductsShop.Controls.Add(this.btnUpdateCrudShop);
            this.CrudProductsShop.Controls.Add(this.btnAddCrudShop);
            this.CrudProductsShop.Controls.Add(this.lblNameCrudShop);
            this.CrudProductsShop.Controls.Add(this.textBox5);
            this.CrudProductsShop.Location = new System.Drawing.Point(4, 22);
            this.CrudProductsShop.Name = "CrudProductsShop";
            this.CrudProductsShop.Padding = new System.Windows.Forms.Padding(3);
            this.CrudProductsShop.Size = new System.Drawing.Size(273, 191);
            this.CrudProductsShop.TabIndex = 1;
            this.CrudProductsShop.Text = "CRUD Categories";
            this.CrudProductsShop.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCrudShop
            // 
            this.btnDeleteCrudShop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteCrudShop.Location = new System.Drawing.Point(34, 134);
            this.btnDeleteCrudShop.Name = "btnDeleteCrudShop";
            this.btnDeleteCrudShop.Size = new System.Drawing.Size(196, 35);
            this.btnDeleteCrudShop.TabIndex = 24;
            this.btnDeleteCrudShop.Text = "Delete";
            this.btnDeleteCrudShop.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCrudShop
            // 
            this.btnUpdateCrudShop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateCrudShop.Location = new System.Drawing.Point(130, 93);
            this.btnUpdateCrudShop.Name = "btnUpdateCrudShop";
            this.btnUpdateCrudShop.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateCrudShop.TabIndex = 22;
            this.btnUpdateCrudShop.Text = "Update";
            this.btnUpdateCrudShop.UseVisualStyleBackColor = false;
            // 
            // btnAddCrudShop
            // 
            this.btnAddCrudShop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddCrudShop.Location = new System.Drawing.Point(34, 93);
            this.btnAddCrudShop.Name = "btnAddCrudShop";
            this.btnAddCrudShop.Size = new System.Drawing.Size(95, 35);
            this.btnAddCrudShop.TabIndex = 21;
            this.btnAddCrudShop.Text = "Add";
            this.btnAddCrudShop.UseVisualStyleBackColor = false;
            // 
            // lblNameCrudShop
            // 
            this.lblNameCrudShop.AutoSize = true;
            this.lblNameCrudShop.Location = new System.Drawing.Point(31, 32);
            this.lblNameCrudShop.Name = "lblNameCrudShop";
            this.lblNameCrudShop.Size = new System.Drawing.Size(35, 13);
            this.lblNameCrudShop.TabIndex = 12;
            this.lblNameCrudShop.Text = "Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(34, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(202, 20);
            this.textBox5.TabIndex = 11;
            // 
            // dgvShop
            // 
            this.dgvShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Location = new System.Drawing.Point(330, 31);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.Size = new System.Drawing.Size(448, 352);
            this.dgvShop.TabIndex = 2;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.tcShop);
            this.Controls.Add(this.dgvShop);
            this.Name = "CategoryControl";
            this.Text = "CategoryControl";
            this.tcShop.ResumeLayout(false);
            this.CrudProductsShop.ResumeLayout(false);
            this.CrudProductsShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcShop;
        private System.Windows.Forms.TabPage CrudProductsShop;
        private System.Windows.Forms.Button btnDeleteCrudShop;
        private System.Windows.Forms.Button btnUpdateCrudShop;
        private System.Windows.Forms.Button btnAddCrudShop;
        private System.Windows.Forms.Label lblNameCrudShop;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgvShop;
    }
}