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
    public partial class startPageForm : Form
    {
        public Ammunation myAmmunition { get; set; }
        public startPageForm()
        {
            InitializeComponent();
            string file = @"MyXmlFiles\Ammunation.xml";
            myAmmunition = Ammunation.ReadFromFile(file);
        }

        private void startPageForm_Load(object sender, EventArgs e)
        {
            chooseTypeOfWeaponComboBox.SelectedIndex = 0;
            searchedWeaponsDataGridView.RowHeadersVisible = false;

            searchedWeaponsDataGridView.ColumnCount = 6;
            searchedWeaponsDataGridView.Columns[0].Name = "Name";
            searchedWeaponsDataGridView.Columns[0].Width = 200;
            searchedWeaponsDataGridView.Columns[1].Name = "Brand";
            searchedWeaponsDataGridView.Columns[1].Width = 150;

            searchedWeaponsDataGridView.Columns[2].Name = "Type";
            searchedWeaponsDataGridView.Columns[3].Name = "Caliber";
            searchedWeaponsDataGridView.Columns[4].Name = "Purpose";
            searchedWeaponsDataGridView.Columns[5].Name = "Price";
                

            searchedWeaponsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchedWeaponsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            searchedWeaponsDataGridView.AllowUserToResizeRows = false;

            foreach (Product product in myAmmunition.ProductsList)
            {
                string[] row = new String[] { product.Weapon.Title, product.Weapon.Brand, product.Weapon.Type, product.Weapon.Caliber.ToString(),product.Weapon.Purpose.ToString(),product.Price.ToString()};
                searchedWeaponsDataGridView.Rows.Add(row);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            if (chooseTypeOfWeaponComboBox.SelectedIndex == 0 && searchWeaponTextBox.Text == "")
            {
                MessageBox.Show("You didn't enter any of search parameters.");
            }
            else if (chooseTypeOfWeaponComboBox.SelectedIndex == 0 && searchWeaponTextBox.Text != "")
            {

                // MyBookStore.filter(MyBookStore.ProductsList, Product => Product.Edition.Book.Name.StartsWith(searchBookTextBox.Text));
                var filteredList = myAmmunition.ProductsList.Where(Product => Product.Weapon.Title.StartsWith(searchWeaponTextBox.Text));


                if (filteredList.Count() == 0) MessageBox.Show("No results found.");
                else
                {
                    searchedWeaponsDataGridView.Rows.Clear();
                    foreach (Product product in filteredList)
                    {
                        string[] row = new String[] { product.Weapon.Title, product.Weapon.Brand, product.Weapon.Type, product.Weapon.Caliber.ToString(), product.Weapon.Purpose.ToString(), product.Price.ToString() };
                        searchedWeaponsDataGridView.Rows.Add(row);
                    }
                }
            }
            else
            {
                var filteredList2 = myAmmunition.ProductsList.Where(Product =>  (Product.Weapon.Type.ToString() == chooseTypeOfWeaponComboBox.Text) && (Product.Weapon.Title.StartsWith(searchWeaponTextBox.Text)));



                if (filteredList2.Count() == 0) MessageBox.Show("No results found.");
                else
                {
                    searchedWeaponsDataGridView.Rows.Clear();
                    foreach (Product product in filteredList2)
                    {
                        string[] row = new String[] { product.Weapon.Title, product.Weapon.Brand, product.Weapon.Type, product.Weapon.Caliber.ToString(), product.Weapon.Purpose.ToString(), product.Price.ToString() };
                        searchedWeaponsDataGridView.Rows.Add(row);
                    }
                }
            }
        }

        private void searchedWeaponsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string weaponName = searchedWeaponsDataGridView.SelectedRows[0].Cells[0].Value.ToString();



            List<Product> filteredList = myAmmunition.ProductsList.Where(Product => Product.Weapon.Title.StartsWith(weaponName)).ToList<Product>();


            FormProvider.ProductForm.myProduct = filteredList[0];

            FormProvider.StartPageForm.Hide();
            FormProvider.ProductForm.Show();

        }

        private void shoppingCartButton_Click(object sender, EventArgs e)
        {
            FormProvider.StartPageForm.Hide();
            FormProvider.ShoppingCart.Show();
        }

        private void ordersListButton_Click(object sender, EventArgs e)
        {
            FormProvider.StartPageForm.Hide();
            FormProvider.OrdersForm.Show();
        }
    }
}
