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
    public partial class createOrderForm : Form
    {
        public createOrderForm()
        {
            InitializeComponent();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && phoneTextBox.Text != "" && shopNumberTextBox.Text != "")
            {
                Order order = new Order(nameTextBox.Text, Int32.Parse(shopNumberTextBox.Text), Int32.Parse(phoneTextBox.Text));
                order.ItemsList = new List<Item>( FormProvider.ShoppingCart.MyShoppingCart.ItemsList);
                order.TotalPrice = FormProvider.ShoppingCart.MyShoppingCart.TotalPrice;
                FormProvider.StartPageForm.myAmmunition.OrdersList.Add(order);

                FormProvider.ShoppingCart.MyShoppingCart.ItemsList.Clear();
                FormProvider.CreateOrderForm.Hide();
                FormProvider.OrdersForm.Show();
            }
            else MessageBox.Show("You didnt enter all information.");
        }
    }
}
