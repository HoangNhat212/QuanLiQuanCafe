using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FormsInAdmin
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            LoadTheme();
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
    }
}
