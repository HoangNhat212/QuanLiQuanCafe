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
    public partial class FormFood : Form
    {
        public FormFood()
        {
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            btnAddFood.BackColor = ThemeColor.PrimaryColor;
            btnAddFood.ForeColor = Color.White;
            btnAddFood.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnDeleteFood.BackColor = ThemeColor.PrimaryColor;
            btnDeleteFood.ForeColor = Color.White;
            btnDeleteFood.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnEditFood.BackColor = ThemeColor.PrimaryColor;
            btnEditFood.ForeColor = Color.White;
            btnEditFood.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnSearchFood.BackColor = ThemeColor.PrimaryColor;
            btnSearchFood.ForeColor = Color.White;
            btnSearchFood.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnShowFood.BackColor = ThemeColor.PrimaryColor;
            btnShowFood.ForeColor = Color.White;
            btnShowFood.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

        }
    }
}
