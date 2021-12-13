﻿using System;
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
          
            LoadTheme();
            LoadListTable();
            dtgvTable.DataSource = tableList;
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
            //dtgvTable.Columns[0].HeaderText = "Mã bàn";
            //dtgvTable.Columns[0].DataPropertyName = "ID";
            //dtgvTable.Columns[1].HeaderText = "Tên bàn";
            //dtgvTable.Columns[1].DataPropertyName = "Name";
            //dtgvTable.Columns[2].HeaderText = "Trạng thái";
            //dtgvTable.Columns[2].DataPropertyName = "Status";
        }

        void AddTableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID",true,DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name",true,DataSourceUpdateMode.Never));
            cbTableStatus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Status",true,DataSourceUpdateMode.Never));
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Xóa bàn thất bại");
            }    
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }

        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            int status = Convert.ToInt32 (cbTableStatus.SelectedItem.ToString());
            int id = int.Parse(txbTableID.Text);
            if (TableDAO.Instance.UpdateTable(name, status, id))
            {
                MessageBox.Show("Cập nhật thành công");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }    
        }
    }
}
