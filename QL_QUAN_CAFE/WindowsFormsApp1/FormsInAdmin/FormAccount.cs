using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.FormsInAdmin
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
            LoadTheme();
            LoadAcountList();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            btnAddAccount.BackColor = ThemeColor.PrimaryColor;
            btnAddAccount.ForeColor = Color.White;
            btnAddAccount.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnDeleteAccount.BackColor = ThemeColor.PrimaryColor;
            btnDeleteAccount.ForeColor = Color.White;
            btnDeleteAccount.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnEditAccount.BackColor = ThemeColor.PrimaryColor;
            btnEditAccount.ForeColor = Color.White;
            btnEditAccount.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnResetPassword.BackColor = ThemeColor.PrimaryColor;
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnShowAccount.BackColor = ThemeColor.PrimaryColor;
            btnShowAccount.ForeColor = Color.White;
            btnShowAccount.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }

        void LoadAcountList()
        {
            string query = "exec dbo.USP_GetListAccountByUserName @username ";

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff"});
        }
    }
}
