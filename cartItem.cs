using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeStation
{
    public partial class cartItem : UserControl
    {
        public cartItem()
        {
            InitializeComponent();
        }
        public string ItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }

        public decimal ItemPrice
        {
            get { return decimal.Parse(lblItemPrice.Text.Trim('$')); }
            set { lblItemPrice.Text = $"${value}"; }
        }

        public int Quantity
        {
            get { return int.Parse(lblQuantity.Text); }
            set { lblQuantity.Text = value.ToString(); }
        }

    }
}
