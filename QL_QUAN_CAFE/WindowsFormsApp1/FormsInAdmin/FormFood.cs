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

namespace WindowsFormsApp1.FormsInAdmin
{
    public partial class FormFood : Form
    {
        BindingSource foodList=new BindingSource();
        public FormFood()
        {
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            dtgvFood.DataSource = foodList;
            LoadTheme();
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbFoodCategory);
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
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text",dtgvFood.DataSource,"Name"));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID"));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price"));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                Category category = CategoryDAO.Instance.GetCategoryByID(id);
                cbFoodCategory.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (Category item in cbFoodCategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbFoodCategory.SelectedIndex = index;
            }
         
            
        }
    }
}
