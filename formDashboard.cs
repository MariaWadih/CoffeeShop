using System;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeStation
{
    public partial class formDashboard : Form
    {
        private int currentYPosition = 0; // Initial Y-position for the first CartItem
        private Dictionary<string, cartItem> cartItems = new Dictionary<string, cartItem>();

        public formDashboard()
        {
            InitializeComponent();
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button6.Click += new System.EventHandler(this.button6_Click);

            // Attach TextChanged event handler to the discountTxt TextBox
            this.discountTxt.TextChanged += new System.EventHandler(this.discountTxt_TextChanged);
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string itemName = label1.Text;
            string itemPriceText = label15.Text;
            decimal itemPrice;

            // Ensure that the item price is a valid decimal
            if (decimal.TryParse(itemPriceText, NumberStyles.Currency, CultureInfo.InvariantCulture, out itemPrice))
            {
                AddOrUpdateCartItem("CustomItem", itemName, itemPrice);
            }
            else
            {
                MessageBox.Show("The item price is not in a correct format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string itemName = label24.Text;
            string itemPriceText = label23.Text;
            decimal itemPrice;

            // Ensure that the item price is a valid decimal
            if (decimal.TryParse(itemPriceText, NumberStyles.Currency, CultureInfo.InvariantCulture, out itemPrice))
            {
                AddOrUpdateCartItem("AnotherCustomItem", itemName, itemPrice);
            }
            else
            {
                MessageBox.Show("The item price is not in a correct format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddOrUpdateCartItem(string itemKey, string itemName, decimal itemPrice)
        {
            if (cartItems.ContainsKey(itemKey))
            {
                // Update existing item
                var existingItem = cartItems[itemKey];
                existingItem.Quantity += 1;
                existingItem.ItemPrice += itemPrice;
            }
            else
            {
                // Add new item
                cartItem cartItemControl = new cartItem
                {
                    ItemName = itemName,
                    ItemPrice = itemPrice,
                    Quantity = 1,
                    Location = new Point(0, currentYPosition)
                };

                productsPanel.Controls.Add(cartItemControl);
                cartItemControl.BringToFront();
                cartItems[itemKey] = cartItemControl;

                // Increment the Y-position for the next control
                currentYPosition += cartItemControl.Height;
            }

            // Update total price after adding or updating item
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal subtotalPrice = 0;

            foreach (var item in cartItems.Values)
            {
                subtotalPrice += item.ItemPrice;
            }

            decimal discountPrice = 0;
            if (!string.IsNullOrEmpty(discountTxt.Text))
            {
                // Ensure that the discount value is a valid decimal
                if (decimal.TryParse(discountTxt.Text, out decimal discountValue))
                {
                    discountPrice = discountValue;
                }
                else
                {
                    MessageBox.Show("The discount value is not in a correct format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            decimal totalPrice = subtotalPrice - discountPrice;

            // Multiply the total price by 90,000
            decimal totalInLeb = totalPrice * 90000;

            // Update label10 with the subtotal price in dollars
            label10.Text = "$" + subtotalPrice.ToString("#,##0.00", CultureInfo.InvariantCulture);
            // Update totaldollars with the total price in dollars after discount
            totaldollars.Text = "$" + totalPrice.ToString("#,##0.00", CultureInfo.InvariantCulture);
            // Update totalLeb with the total price in Lebanese pounds
            totalLeb.Text = totalInLeb.ToString("C0", CultureInfo.GetCultureInfo("ar-LB"));
        }

        private void discountTxt_TextChanged(object sender, EventArgs e)
        {
            // Recalculate the total price whenever the discount text changes
            UpdateTotalPrice();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
