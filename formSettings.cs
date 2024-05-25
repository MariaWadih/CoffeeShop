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
    public partial class formSettings : Form
    {
        private bool isDarkMode = false;
        public formSettings()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void formSettings_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            Color backColor;
            Color foreColor;

            if (isDarkMode)
            {
                backColor = Color.FromArgb(45, 45, 48);
                foreColor = Color.White;
            }
            else
            {
                backColor = Color.White;
                foreColor = Color.Black;
            }

            this.BackColor = backColor;
            this.ForeColor = foreColor;

            foreach (Control ctrl in this.Controls)
            {
                ApplyThemeToControl(ctrl, backColor, foreColor);
            }
        }
        private void ApplyThemeToControl(Control control, Color backColor, Color foreColor)
        {
            if (control is Button)
            {
                control.BackColor = isDarkMode ? Color.FromArgb(28, 28, 28) : SystemColors.Control;
                control.ForeColor = foreColor;
            }
            else
            {
                control.BackColor = backColor;
                control.ForeColor = foreColor;
            }

            foreach (Control childControl in control.Controls)
            {
                ApplyThemeToControl(childControl, backColor, foreColor);
            }
        }
    }
}
