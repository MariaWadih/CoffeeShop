namespace CoffeeStation
{
    partial class cartItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnDelete = new ReaLTaiizor.Controls.Button();
            this.SuspendLayout();
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.White;
            this.lblItemPrice.Location = new System.Drawing.Point(214, 30);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(41, 15);
            this.lblItemPrice.TabIndex = 38;
            this.lblItemPrice.Text = "$ 2.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "x";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(92, 30);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(17, 15);
            this.lblQuantity.TabIndex = 41;
            this.lblQuantity.Text = " 1";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(28, 9);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(84, 17);
            this.lblItemName.TabIndex = 40;
            this.lblItemName.Text = "name prod 1";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(111)))), ((int)(((byte)(44)))));
            this.btnDelete.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = null;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDelete.Location = new System.Drawing.Point(32, 30);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(111)))), ((int)(((byte)(44)))));
            this.btnDelete.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(111)))), ((int)(((byte)(44)))));
            this.btnDelete.Size = new System.Drawing.Size(42, 26);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblItemPrice);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "cartItem";
            this.Size = new System.Drawing.Size(260, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemName;
        private ReaLTaiizor.Controls.Button btnDelete;
    }
}
