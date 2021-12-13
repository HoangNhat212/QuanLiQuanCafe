using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.FormsInAdmin
{
    public partial class FormCategory : Form
    {
        BindingSource categoryList = new BindingSource();
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            dtgvCategory.DataSource = categoryList;
            LoadTheme();
            LoadListCategory();
            AddCategoryBinding();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                btnAddCategory.BackColor = ThemeColor.PrimaryColor;
                btnAddCategory.ForeColor = Color.White;
                btnAddCategory.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                btnDeleteCategory.BackColor = ThemeColor.PrimaryColor;
                btnDeleteCategory.ForeColor = Color.White;
                btnDeleteCategory.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                btnEditCategory.BackColor = ThemeColor.PrimaryColor;
                btnEditCategory.ForeColor = Color.White;
                btnEditCategory.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                btnShowCategory.BackColor = ThemeColor.PrimaryColor;
                btnShowCategory.ForeColor = Color.White;
                btnShowCategory.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            }
        }

        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
            dtgvCategory.Columns[0].HeaderText = "Mã danh mục";
            dtgvCategory.Columns[0].DataPropertyName = "ID";
            dtgvCategory.Columns[1].HeaderText = "Tên danh mục";
            dtgvCategory.Columns[1].DataPropertyName = "Name";
        }

        void AddCategoryBinding()
        {
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name",true,DataSourceUpdateMode.Never));
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID",true,DataSourceUpdateMode.Never));
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
         
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Xóa mục thất bại");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);

            if (CategoryDAO.Instance.UpdateFoodCategory(id, name)) 
            {
                MessageBox.Show("Cập nhật danh mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Cập nhật danh mục thất bại");
            }
        }
    }
}
