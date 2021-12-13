
namespace WindowsFormsApp1.FormsInAdmin
{
    partial class FormCategory
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.btnShowCategory);
            this.panel17.Controls.Add(this.btnEditCategory);
            this.panel17.Controls.Add(this.btnDeleteCategory);
            this.panel17.Controls.Add(this.btnAddCategory);
            this.panel17.Location = new System.Drawing.Point(614, 17);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(570, 71);
            this.panel17.TabIndex = 8;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCategory.Font = new System.Drawing.Font("UTM Androgyne", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCategory.Location = new System.Drawing.Point(450, 3);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(116, 63);
            this.btnShowCategory.TabIndex = 0;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("UTM Androgyne", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.Location = new System.Drawing.Point(303, 3);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(116, 63);
            this.btnEditCategory.TabIndex = 0;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("UTM Androgyne", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(150, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(116, 63);
            this.btnDeleteCategory.TabIndex = 0;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("UTM Androgyne", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(3, 3);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(116, 63);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(614, 94);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 24;
            this.dtgvCategory.Size = new System.Drawing.Size(570, 631);
            this.dtgvCategory.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.panel16);
            this.panel12.Location = new System.Drawing.Point(32, 94);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(484, 631);
            this.panel12.TabIndex = 9;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txbCategoryName);
            this.panel15.Controls.Add(this.label7);
            this.panel15.Location = new System.Drawing.Point(3, 91);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(478, 57);
            this.panel15.TabIndex = 1;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Font = new System.Drawing.Font("UTM Androgyne", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryName.Location = new System.Drawing.Point(192, 14);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(284, 31);
            this.txbCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Androgyne", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(-6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên danh mục:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txbCategoryID);
            this.panel16.Controls.Add(this.label8);
            this.panel16.Location = new System.Drawing.Point(3, 17);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(478, 57);
            this.panel16.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.BackColor = System.Drawing.SystemColors.Window;
            this.txbCategoryID.Font = new System.Drawing.Font("UTM Androgyne", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryID.Location = new System.Drawing.Point(189, 14);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(284, 31);
            this.txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Androgyne", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bground__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 732);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.dtgvCategory);
            this.Controls.Add(this.panel12);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCategory";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Label label8;
    }
}