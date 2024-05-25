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
    public partial class Form1 : Form
    {
        //Windows Forms 
        formDashboard dashboard;
        formSubMenu1 sub1;
        formSubMenu2 sub2;
        formBillings bill;
        formTables tab;
        formSettings sett;

        public Form1()
        {
            InitializeComponent();
            //DO NOT TOUCH
            mdiProp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        // Tabel Expand 
        bool menuExpand = false;
        //DO NOT TOUCH
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(42,42,42);
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            //Menu Expand Open
            if (menuExpand == false)
            {
                menuContainer.Height += 5;
                if (menuContainer.Height >= 187)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            //Menu Expand Closed
            else
            {
                menuContainer.Height -= 5;
                if (menuContainer.Height <= 64)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        //Start Menu Expand Function
        private void menu_Click_1(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        //Sidebar Expand 
        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //Sidebar Expand Closed
                sidebar.Width -= 10;
                if (sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnDashboard.Width = sidebar.Width;
                    pnBillings.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    pnTables.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            //SideBar Expand Open
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 300)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;  
                    pnBillings.Width = sidebar.Width;   
                    pnSettings.Width = sidebar.Width;
                    pnTables.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        //Start Sidebar Expand Function
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        //Open Dashboard on Click
        private void button1_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }else
            {
                dashboard.Activate();
            }
        }

        //Dismis Dashboard after open another
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        //Open Table 1 on Click (Remenber change the names)
        private void formSubMenu1_Click(object sender, EventArgs e)
        {
            if (sub1 == null )
            {
                sub1 = new formSubMenu1();
                sub1.FormClosed += Sub1_FormClosed;
                sub1.MdiParent = this;
                sub1.Dock = DockStyle.Fill;
                sub1.Show();    

            }else
            {
                sub1.Activate();
            }
        }

        //Dismis Table 1 after open another 
        private void Sub1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub1 = null;
        }

        //Open Billings on Click
        private void button3_Click(object sender, EventArgs e)
        {
            if (bill == null)
            {
                bill = new formBillings();
                bill.FormClosed += Bill_FormClosed;
                bill.MdiParent = this;  
                bill.Dock = DockStyle.Fill; 
                bill.Show();
            }else
            {
                bill.Activate();
            }
        }

        //Dismis Billings after open another
        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            bill = null;
        }

        //Open Settings on Click
        private void button2_Click(object sender, EventArgs e)
        {
            if (sett == null)
            {
                sett = new formSettings();
                sett.FormClosed += Sett_FormClosed;
                sett.MdiParent = this;
                sett.Dock = DockStyle.Fill;
                sett.Show();
            }else
            {
                sett.Activate();
            }
        }

        //Dismis Settings after open another
        private void Sett_FormClosed(object sender, FormClosedEventArgs e)
        {
            sett = null;
        }

        
      

        //Logout of the POS
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tab == null)
            {
                tab = new formTables();
                tab.FormClosed += Tab_FormClosed;
                tab.MdiParent = this;
                tab.Dock = DockStyle.Fill;
                tab.Show();
            }
            else
            {
                tab.Activate();
            }
        }

        private void Tab_FormClosed(object sender, FormClosedEventArgs e)
        {
            tab = null;
        }

        private void formSubMenu2_Click(object sender, EventArgs e)
        {
            if (sub2 == null)
            {
                sub2 = new formSubMenu2();
                sub2.FormClosed += Sub_FormClosed;
                sub2.MdiParent = this;
                sub2.Dock = DockStyle.Fill;
                sub2.Show();
            }
            else
            {
                sub2.Activate();
            }
        }

        private void Sub_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub2 = null;
        }
    }
}
