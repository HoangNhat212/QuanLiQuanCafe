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
    public partial class FormTable : Form
    {
        BindingSource tableList = new BindingSource();
        public FormTable()
        {
            InitializeComponent();
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            dtgvTable.DataSource = tableList;
            LoadTheme();
            LoadListTable();
            AddTableBinding();
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

        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.GetListTable();
        }

        void AddTableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID"));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name"));
            cbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Status"));
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }
    }
}
