namespace CoffeeStation
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.formSubMenu1 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.formSubMenu2 = new System.Windows.Forms.Button();
            this.pnTables = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pnBillings = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnTables.SuspendLayout();
            this.pnBillings.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(862, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // btnHam
            // 
            this.btnHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 33);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(45, 47);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.sidebar.Controls.Add(this.btnHam);
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnTables);
            this.sidebar.Controls.Add(this.pnBillings);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(291, 616);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.button1);
            this.pnDashboard.Location = new System.Drawing.Point(3, 86);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnDashboard.Size = new System.Drawing.Size(363, 64);
            this.pnDashboard.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-17, -28);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(415, 122);
            this.button1.TabIndex = 2;
            this.button1.Text = "               Dashboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel9);
            this.menuContainer.Controls.Add(this.panel8);
            this.menuContainer.Location = new System.Drawing.Point(0, 153);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(363, 61);
            this.menuContainer.TabIndex = 9;
            this.menuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.menuContainer_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.menu);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(363, 64);
            this.panel6.TabIndex = 7;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.Location = new System.Drawing.Point(-15, -28);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.menu.Size = new System.Drawing.Size(415, 122);
            this.menu.TabIndex = 2;
            this.menu.Text = "                Admin ";
            this.menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click_1);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.formSubMenu1);
            this.panel9.Location = new System.Drawing.Point(0, 64);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(363, 64);
            this.panel9.TabIndex = 11;
            // 
            // formSubMenu1
            // 
            this.formSubMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.formSubMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formSubMenu1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formSubMenu1.ForeColor = System.Drawing.Color.White;
            this.formSubMenu1.Image = ((System.Drawing.Image)(resources.GetObject("formSubMenu1.Image")));
            this.formSubMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formSubMenu1.Location = new System.Drawing.Point(-17, -28);
            this.formSubMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.formSubMenu1.Name = "formSubMenu1";
            this.formSubMenu1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.formSubMenu1.Size = new System.Drawing.Size(415, 122);
            this.formSubMenu1.TabIndex = 2;
            this.formSubMenu1.Text = "                Employees";
            this.formSubMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formSubMenu1.UseVisualStyleBackColor = false;
            this.formSubMenu1.Click += new System.EventHandler(this.formSubMenu1_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.formSubMenu2);
            this.panel8.Location = new System.Drawing.Point(0, 128);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(363, 64);
            this.panel8.TabIndex = 10;
            // 
            // formSubMenu2
            // 
            this.formSubMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.formSubMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formSubMenu2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formSubMenu2.ForeColor = System.Drawing.Color.White;
            this.formSubMenu2.Image = ((System.Drawing.Image)(resources.GetObject("formSubMenu2.Image")));
            this.formSubMenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formSubMenu2.Location = new System.Drawing.Point(-17, -28);
            this.formSubMenu2.Margin = new System.Windows.Forms.Padding(0);
            this.formSubMenu2.Name = "formSubMenu2";
            this.formSubMenu2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.formSubMenu2.Size = new System.Drawing.Size(415, 122);
            this.formSubMenu2.TabIndex = 2;
            this.formSubMenu2.Text = "                Inventory";
            this.formSubMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formSubMenu2.UseVisualStyleBackColor = false;
            this.formSubMenu2.Click += new System.EventHandler(this.formSubMenu2_Click);
            // 
            // pnTables
            // 
            this.pnTables.Controls.Add(this.button5);
            this.pnTables.Location = new System.Drawing.Point(3, 217);
            this.pnTables.Name = "pnTables";
            this.pnTables.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnTables.Size = new System.Drawing.Size(363, 64);
            this.pnTables.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-17, -28);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(415, 122);
            this.button5.TabIndex = 2;
            this.button5.Text = "               Tables";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnBillings
            // 
            this.pnBillings.Controls.Add(this.button3);
            this.pnBillings.Location = new System.Drawing.Point(3, 287);
            this.pnBillings.Name = "pnBillings";
            this.pnBillings.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnBillings.Size = new System.Drawing.Size(363, 64);
            this.pnBillings.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-17, -28);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(415, 122);
            this.button3.TabIndex = 2;
            this.button3.Text = "               Billings";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.button2);
            this.pnSettings.Location = new System.Drawing.Point(3, 357);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnSettings.Size = new System.Drawing.Size(363, 64);
            this.pnSettings.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-17, -28);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(415, 122);
            this.button2.TabIndex = 2;
            this.button2.Text = "               Settings";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.button6);
            this.pnLogout.Location = new System.Drawing.Point(3, 427);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnLogout.Size = new System.Drawing.Size(363, 64);
            this.pnLogout.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-17, -28);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(415, 122);
            this.button6.TabIndex = 2;
            this.button6.Text = "               Logout";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(985, 616);
            this.Controls.Add(this.nightControlBox1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnTables.ResumeLayout(false);
            this.pnBillings.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnBillings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button formSubMenu2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button formSubMenu1;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnTables;
        private System.Windows.Forms.Button button5;
    }
}

