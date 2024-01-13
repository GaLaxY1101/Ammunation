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
    public partial class productForm : Form
    {
        public Product myProduct { get; set; }
        public productForm()
        {
            InitializeComponent();
        }

        private void productForm_Load(object sender, EventArgs e)
        {

        }

        private void productForm_Activated(object sender, EventArgs e)
        {
            productNumericUpDown.Value = 1;
            titleValueLable.Text = myProduct.Weapon.Title;
            brandValueLabel.Text = myProduct.Weapon.Brand;
            countryValueLabel.Text = myProduct.Weapon.Country;
            purposeValueLabel.Text = myProduct.Weapon.Purpose.ToString();

            typeValueLabel.Text = myProduct.Weapon.Type;
            caliberValueLabel.Text = myProduct.Weapon.Caliber.ToString() + " mm";
            storeCapacityValueLabel.Text = myProduct.Weapon.StoreCapacity.ToString();
            barrelLengthValueLable.Text = myProduct.Weapon.BarrelLength.ToString() + " cm"; 
            massValueLabel.Text = myProduct.Weapon.Mass.ToString() + " kg";
            priceValueLabel.Text = "$"+ myProduct.Price.ToString();

            switch(myProduct.Weapon.Type)
            {
                case "Rifle":
                    uniqueLabel.Text = "Firerate:";

                    Rifle rifle = (Rifle)myProduct.Weapon;
                    uniqueValueLabel.Text = rifle.FireRate.ToString();
                    break;

                case "Gun":
                    uniqueLabel.Text = "Butt:";

                    Gun gun = (Gun)myProduct.Weapon;
                    if (gun.IsButt) uniqueValueLabel.Text = "Yes";
                    else uniqueValueLabel.Text = "No";

                    break;
                
                case "Shotgun":
                    uniqueLabel.Text = "Barrels count:";

                    Shotgun shotgun = (Shotgun)myProduct.Weapon;
                    uniqueValueLabel.Text = shotgun.BarrelCount.ToString();    

                    break;

                case "Sniper rifle":
                    uniqueLabel.Text = "ReplaceableBarrel:";

                    SniperRifle sniperRifle = (SniperRifle)myProduct.Weapon;
                    if (sniperRifle.ReplaceableBarrel) uniqueValueLabel.Text = "Yes";
                    else uniqueValueLabel.Text = "No";

                    break;

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormProvider.ProductForm.Hide();
            FormProvider.StartPageForm.Show();
        }

        private void addToTheCartButton_Click(object sender, EventArgs e)
        {
            Item item = new Item(this.myProduct, (int)productNumericUpDown.Value, myProduct.Price * (int)productNumericUpDown.Value);
            FormProvider.ShoppingCart.MyShoppingCart.AddItem(item);
            MessageBox.Show("The product have added to your shopping cart.");
        }
    }
}
