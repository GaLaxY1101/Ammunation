using Ammunation_console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AmmunationForm.Program;

namespace AmmunationForm
{
    public partial class ordersForm : Form
    {
        public ordersForm()
        {
            InitializeComponent();
        }

        private void ordersForm_Load(object sender, EventArgs e)
        {
            ordersDataGridView.ColumnCount = 5;

            ordersDataGridView.Columns[0].Name = "Name";
            ordersDataGridView.Columns[0].Width = 100;

            ordersDataGridView.Columns[1].Name = "Phone Number";
            ordersDataGridView.Columns[1].Width = 70;

            ordersDataGridView.Columns[2].Name = "Shop Number";
            ordersDataGridView.Columns[2].Width = 50;

            ordersDataGridView.Columns[3].Name = "Titles";
            ordersDataGridView.Columns[3].Width = 200;

            ordersDataGridView.Columns[4].Name = "Price";
            ordersDataGridView.Columns[4].Width = 50;


            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void ordersForm_Activated(object sender, EventArgs e)
        {
            if (FormProvider.StartPageForm.myAmmunition.OrdersList.Count == 0)
            {
                ordersDataGridView.Visible = false;
            }
            else
            {
                ordersDataGridView.Rows.Clear();

                List<string> items = new List<string>();
                foreach (Order order in FormProvider.StartPageForm.myAmmunition.OrdersList)
                {
                    foreach (Item item in order.ItemsList)
                    {
                        items.Add(item.Product.Weapon.Title);

                    }
                    string[] row = new String[] { order.CustomerName,order.CustomerPhoneNumber.ToString(), order.ShopNumber.ToString() ,string.Join(",", items),order.TotalPrice.ToString() };
                    ordersDataGridView.Rows.Add(row);
                    items.Clear();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormProvider.OrdersForm.Hide();
            FormProvider.StartPageForm.Show();
        }
    }
}
