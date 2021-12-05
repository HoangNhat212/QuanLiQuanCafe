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
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            btnAddTable.BackColor = ThemeColor.PrimaryColor;
            btnAddTable.ForeColor = Color.White;
            btnAddTable.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnDeleteTable.BackColor = ThemeColor.PrimaryColor;
            btnDeleteTable.ForeColor = Color.White;
            btnDeleteTable.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnEditTable.BackColor = ThemeColor.PrimaryColor;
            btnEditTable.ForeColor = Color.White;
            btnEditTable.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnShowTable.BackColor = ThemeColor.PrimaryColor;
            btnShowTable.ForeColor = Color.White;
            btnShowTable.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }
    }
}
