
namespace ProductStock.Controls
{
    partial class ReportControl
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnShowAllReport = new System.Windows.Forms.Button();
            this.gbxSearchReport = new System.Windows.Forms.GroupBox();
            this.tbxProductNameReport = new System.Windows.Forms.TextBox();
            this.lblProductNameReport = new System.Windows.Forms.Label();
            this.tbxPriceReport = new System.Windows.Forms.TextBox();
            this.lblPriceReport = new System.Windows.Forms.Label();
            this.lblCategoryReport = new System.Windows.Forms.Label();
            this.cmbCategoryReport = new System.Windows.Forms.ComboBox();
            this.tbxSoldReport = new System.Windows.Forms.TextBox();
            this.lblSoldReport = new System.Windows.Forms.Label();
            this.tbxCountReport = new System.Windows.Forms.TextBox();
            this.lblCountReport = new System.Windows.Forms.Label();
            this.lblStatusReport = new System.Windows.Forms.Label();
            this.tbxDescriptionReport = new System.Windows.Forms.TextBox();
            this.lblDescriptionReport = new System.Windows.Forms.Label();
            this.cmbStatusReport = new System.Windows.Forms.ComboBox();
            this.cmbTypeReport = new System.Windows.Forms.ComboBox();
            this.lblTypeReport = new System.Windows.Forms.Label();
            this.btnSearchReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbxSearchReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(231, 27);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(539, 411);
            this.dgvReport.TabIndex = 0;
            // 
            // btnShowAllReport
            // 
            this.btnShowAllReport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowAllReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllReport.Location = new System.Drawing.Point(12, 27);
            this.btnShowAllReport.Name = "btnShowAllReport";
            this.btnShowAllReport.Size = new System.Drawing.Size(92, 24);
            this.btnShowAllReport.TabIndex = 1;
            this.btnShowAllReport.Text = "Show All";
            this.btnShowAllReport.UseVisualStyleBackColor = false;
            this.btnShowAllReport.Click += new System.EventHandler(this.btnShowAllReport_Click);
            // 
            // gbxSearchReport
            // 
            this.gbxSearchReport.Controls.Add(this.cmbTypeReport);
            this.gbxSearchReport.Controls.Add(this.lblTypeReport);
            this.gbxSearchReport.Controls.Add(this.cmbStatusReport);
            this.gbxSearchReport.Controls.Add(this.lblStatusReport);
            this.gbxSearchReport.Controls.Add(this.tbxDescriptionReport);
            this.gbxSearchReport.Controls.Add(this.lblDescriptionReport);
            this.gbxSearchReport.Controls.Add(this.tbxSoldReport);
            this.gbxSearchReport.Controls.Add(this.lblSoldReport);
            this.gbxSearchReport.Controls.Add(this.tbxCountReport);
            this.gbxSearchReport.Controls.Add(this.lblCountReport);
            this.gbxSearchReport.Controls.Add(this.lblCategoryReport);
            this.gbxSearchReport.Controls.Add(this.tbxPriceReport);
            this.gbxSearchReport.Controls.Add(this.cmbCategoryReport);
            this.gbxSearchReport.Controls.Add(this.lblPriceReport);
            this.gbxSearchReport.Controls.Add(this.tbxProductNameReport);
            this.gbxSearchReport.Controls.Add(this.lblProductNameReport);
            this.gbxSearchReport.Location = new System.Drawing.Point(12, 57);
            this.gbxSearchReport.Name = "gbxSearchReport";
            this.gbxSearchReport.Size = new System.Drawing.Size(201, 381);
            this.gbxSearchReport.TabIndex = 2;
            this.gbxSearchReport.TabStop = false;
            this.gbxSearchReport.Text = "Report Search";
            // 
            // tbxProductNameReport
            // 
            this.tbxProductNameReport.Location = new System.Drawing.Point(20, 37);
            this.tbxProductNameReport.Name = "tbxProductNameReport";
            this.tbxProductNameReport.Size = new System.Drawing.Size(151, 20);
            this.tbxProductNameReport.TabIndex = 1;
            // 
            // lblProductNameReport
            // 
            this.lblProductNameReport.AutoSize = true;
            this.lblProductNameReport.Location = new System.Drawing.Point(17, 21);
            this.lblProductNameReport.Name = "lblProductNameReport";
            this.lblProductNameReport.Size = new System.Drawing.Size(75, 13);
            this.lblProductNameReport.TabIndex = 0;
            this.lblProductNameReport.Text = "Product Name";
            // 
            // tbxPriceReport
            // 
            this.tbxPriceReport.Location = new System.Drawing.Point(20, 83);
            this.tbxPriceReport.Name = "tbxPriceReport";
            this.tbxPriceReport.Size = new System.Drawing.Size(151, 20);
            this.tbxPriceReport.TabIndex = 3;
            // 
            // lblPriceReport
            // 
            this.lblPriceReport.AutoSize = true;
            this.lblPriceReport.Location = new System.Drawing.Point(17, 67);
            this.lblPriceReport.Name = "lblPriceReport";
            this.lblPriceReport.Size = new System.Drawing.Size(31, 13);
            this.lblPriceReport.TabIndex = 2;
            this.lblPriceReport.Text = "Price";
            // 
            // lblCategoryReport
            // 
            this.lblCategoryReport.AutoSize = true;
            this.lblCategoryReport.Location = new System.Drawing.Point(17, 115);
            this.lblCategoryReport.Name = "lblCategoryReport";
            this.lblCategoryReport.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryReport.TabIndex = 7;
            this.lblCategoryReport.Text = "Category";
            // 
            // cmbCategoryReport
            // 
            this.cmbCategoryReport.FormattingEnabled = true;
            this.cmbCategoryReport.Location = new System.Drawing.Point(20, 131);
            this.cmbCategoryReport.Name = "cmbCategoryReport";
            this.cmbCategoryReport.Size = new System.Drawing.Size(151, 21);
            this.cmbCategoryReport.TabIndex = 6;
            // 
            // tbxSoldReport
            // 
            this.tbxSoldReport.Location = new System.Drawing.Point(20, 222);
            this.tbxSoldReport.Name = "tbxSoldReport";
            this.tbxSoldReport.Size = new System.Drawing.Size(151, 20);
            this.tbxSoldReport.TabIndex = 11;
            // 
            // lblSoldReport
            // 
            this.lblSoldReport.AutoSize = true;
            this.lblSoldReport.Location = new System.Drawing.Point(17, 206);
            this.lblSoldReport.Name = "lblSoldReport";
            this.lblSoldReport.Size = new System.Drawing.Size(28, 13);
            this.lblSoldReport.TabIndex = 10;
            this.lblSoldReport.Text = "Sold";
            // 
            // tbxCountReport
            // 
            this.tbxCountReport.Location = new System.Drawing.Point(20, 176);
            this.tbxCountReport.Name = "tbxCountReport";
            this.tbxCountReport.Size = new System.Drawing.Size(151, 20);
            this.tbxCountReport.TabIndex = 9;
            // 
            // lblCountReport
            // 
            this.lblCountReport.AutoSize = true;
            this.lblCountReport.Location = new System.Drawing.Point(17, 160);
            this.lblCountReport.Name = "lblCountReport";
            this.lblCountReport.Size = new System.Drawing.Size(35, 13);
            this.lblCountReport.TabIndex = 8;
            this.lblCountReport.Text = "Count";
            // 
            // lblStatusReport
            // 
            this.lblStatusReport.AutoSize = true;
            this.lblStatusReport.Location = new System.Drawing.Point(17, 297);
            this.lblStatusReport.Name = "lblStatusReport";
            this.lblStatusReport.Size = new System.Drawing.Size(37, 13);
            this.lblStatusReport.TabIndex = 14;
            this.lblStatusReport.Text = "Status";
            // 
            // tbxDescriptionReport
            // 
            this.tbxDescriptionReport.Location = new System.Drawing.Point(20, 267);
            this.tbxDescriptionReport.Name = "tbxDescriptionReport";
            this.tbxDescriptionReport.Size = new System.Drawing.Size(151, 20);
            this.tbxDescriptionReport.TabIndex = 13;
            // 
            // lblDescriptionReport
            // 
            this.lblDescriptionReport.AutoSize = true;
            this.lblDescriptionReport.Location = new System.Drawing.Point(17, 251);
            this.lblDescriptionReport.Name = "lblDescriptionReport";
            this.lblDescriptionReport.Size = new System.Drawing.Size(60, 13);
            this.lblDescriptionReport.TabIndex = 12;
            this.lblDescriptionReport.Text = "Description";
            // 
            // cmbStatusReport
            // 
            this.cmbStatusReport.FormattingEnabled = true;
            this.cmbStatusReport.Location = new System.Drawing.Point(20, 313);
            this.cmbStatusReport.Name = "cmbStatusReport";
            this.cmbStatusReport.Size = new System.Drawing.Size(151, 21);
            this.cmbStatusReport.TabIndex = 16;
            // 
            // cmbTypeReport
            // 
            this.cmbTypeReport.FormattingEnabled = true;
            this.cmbTypeReport.Location = new System.Drawing.Point(20, 354);
            this.cmbTypeReport.Name = "cmbTypeReport";
            this.cmbTypeReport.Size = new System.Drawing.Size(151, 21);
            this.cmbTypeReport.TabIndex = 18;
            // 
            // lblTypeReport
            // 
            this.lblTypeReport.AutoSize = true;
            this.lblTypeReport.Location = new System.Drawing.Point(17, 338);
            this.lblTypeReport.Name = "lblTypeReport";
            this.lblTypeReport.Size = new System.Drawing.Size(31, 13);
            this.lblTypeReport.TabIndex = 17;
            this.lblTypeReport.Text = "Type";
            // 
            // btnSearchReport
            // 
            this.btnSearchReport.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReport.Location = new System.Drawing.Point(110, 27);
            this.btnSearchReport.Name = "btnSearchReport";
            this.btnSearchReport.Size = new System.Drawing.Size(88, 24);
            this.btnSearchReport.TabIndex = 3;
            this.btnSearchReport.Text = "Search";
            this.btnSearchReport.UseVisualStyleBackColor = false;
            this.btnSearchReport.Click += new System.EventHandler(this.btnSearchReport_Click);
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchReport);
            this.Controls.Add(this.gbxSearchReport);
            this.Controls.Add(this.btnShowAllReport);
            this.Controls.Add(this.dgvReport);
            this.Name = "ReportControl";
            this.Text = "ReportControl";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbxSearchReport.ResumeLayout(false);
            this.gbxSearchReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnShowAllReport;
        private System.Windows.Forms.GroupBox gbxSearchReport;
        private System.Windows.Forms.Label lblProductNameReport;
        private System.Windows.Forms.TextBox tbxProductNameReport;
        private System.Windows.Forms.TextBox tbxPriceReport;
        private System.Windows.Forms.Label lblPriceReport;
        private System.Windows.Forms.Label lblCategoryReport;
        private System.Windows.Forms.ComboBox cmbCategoryReport;
        private System.Windows.Forms.TextBox tbxSoldReport;
        private System.Windows.Forms.Label lblSoldReport;
        private System.Windows.Forms.TextBox tbxCountReport;
        private System.Windows.Forms.Label lblCountReport;
        private System.Windows.Forms.Label lblStatusReport;
        private System.Windows.Forms.TextBox tbxDescriptionReport;
        private System.Windows.Forms.Label lblDescriptionReport;
        private System.Windows.Forms.ComboBox cmbStatusReport;
        private System.Windows.Forms.ComboBox cmbTypeReport;
        private System.Windows.Forms.Label lblTypeReport;
        private System.Windows.Forms.Button btnSearchReport;
    }
}