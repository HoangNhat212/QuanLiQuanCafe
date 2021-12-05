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
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            label1.Text ="   " + DateTime.Now.ToString();
            LoadTable();
        }
        #region Method
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach(Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth,  Height=TableDAO.TableHeight };
                switch (item.Status)
                {
                    case "0":
                        {
                            item.Status = "Trống";
                            btn.BackColor = Color.Gold;
                            break;
                        }
                    default:
                        {
                            item.Status = "Đã có khách";
                            btn.BackColor = Color.Beige;
                            break;
                        }
                }
                btn.Text = item.Name + Environment.NewLine + item.Status;
                flpTable.Controls.Add(btn);

              
            }
        }
        #endregion
        #region Event
        private void btnOpenFormAdmin_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void btnOpenFormProfile_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text ="   " + DateTime.Now.ToString();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
