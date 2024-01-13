using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ammunation_console;
using static AmmunationForm.Program;

namespace AmmunationForm
{
    public partial class shoppingCartForm : Form
    {
        public shoppingCartForm()
        {
            InitializeComponent();
            MyShoppingCart = new ShoppingCart();
        }

        private void shoppingCartForm_Load(object sender, EventArgs e)
        {
            shoppingCartDataGridView1.RowHeadersVisible = false;

            shoppingCartDataGridView1.ColumnCount = 3;
            shoppingCartDataGridView1.Columns[0].Name = "Product";
            shoppingCartDataGridView1.Columns[0].Width = 200;
            shoppingCartDataGridView1.Columns[1].Name = "Count";
            shoppingCartDataGridView1.Columns[1].Width = 50;

            shoppingCartDataGridView1.Columns[2].Name = "Price";
            shoppingCartDataGridView1.Columns[2].Width = 50;
        }

        private void shoppingCartForm_Activated(object sender, EventArgs e)
        {

            if (MyShoppingCart.ItemsList.Count == 0)
            {
                shoppingCartDataGridView1.Visible = false;
                shoppingCartLabel.Text = "Shopping cart is empty yet.";
                totalPriceLabel.Visible = false;
                toOrderButton.Visible= false;
            }
            else
            {
                toOrderButton.Visible = true;
                totalPriceLabel.Visible = true;
                totalPriceLabel.Text = "Total price: $" + MyShoppingCart.TotalPrice.ToString();
                shoppingCartDataGridView1.Visible = true;
                foreach(Item item in MyShoppingCart.ItemsList)
                {
                    string[] row = new String[] { item.Product.Weapon.Title, item.Count.ToString(), item.Price.ToString() };
                    shoppingCartDataGridView1.Rows.Add(row);
                }
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormProvider.ShoppingCart.Hide();
            FormProvider.StartPageForm.Show();
        }

        private void toOrderButton_Click(object sender, EventArgs e)
        {
            
            FormProvider.ShoppingCart.Hide();
            FormProvider.CreateOrderForm.Show();
        }
    }
}
