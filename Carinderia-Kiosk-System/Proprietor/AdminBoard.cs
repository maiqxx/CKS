using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carinderia_Kiosk_System.Proprietor;

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class AdminBoard : Form
    {
        public static AdminBoard instance;

        public AdminBoard(string emailAddress)
        {
            InitializeComponent();
            instance = this;
        }

        private void AdminBoard_Load(object sender, EventArgs e)
        {
            if (!pnlUserControlContainer.Controls.Contains(ucDashboard.Instance))
            {
                pnlUserControlContainer.Controls.Add(ucDashboard.Instance);
                ucDashboard.Instance.Dock = DockStyle.Fill;
                ucDashboard.Instance.BringToFront();
            }
            else
            {
                ucDashboard.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Dashboard button
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (!pnlUserControlContainer.Controls.Contains(ucDashboard.Instance))
            {
                pnlUserControlContainer.Controls.Add(ucDashboard.Instance);
                ucDashboard.Instance.Dock = DockStyle.Fill;
                ucDashboard.Instance.BringToFront();
            }
            else
            {
                ucDashboard.Instance.BringToFront();
            }
        }

        //Orders button
        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (!pnlUserControlContainer.Controls.Contains(ucOrders.Instance))
            {
                pnlUserControlContainer.Controls.Add(ucOrders.Instance);
                ucOrders.Instance.Dock = DockStyle.Fill;
                ucOrders.Instance.BringToFront();
            }
            else
            {
                ucOrders.Instance.BringToFront();
            }
        }

        //Categories button
        private void btnCategories_Click(object sender, EventArgs e)
        {
            if (!pnlUserControlContainer.Controls.Contains(ucCategories.Instance))
            {
                pnlUserControlContainer.Controls.Add(ucCategories.Instance);
                ucCategories.Instance.Dock = DockStyle.Fill;
                ucCategories.Instance.BringToFront();
            }
            else
            {
                ucCategories.Instance.BringToFront();
            }
        }

        //Inventory button
        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (!pnlUserControlContainer.Controls.Contains(ucInventory.Instance))
            {
                pnlUserControlContainer.Controls.Add(ucInventory.Instance);
                ucInventory.Instance.Dock = DockStyle.Fill;
                ucInventory.Instance.BringToFront();
            }
            else
            {
                ucInventory.Instance.BringToFront();
            }
        }

        //Staff button
        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (!pnlUserControlContainer.Controls.Contains(ucStaff.Instance))
            {
                pnlUserControlContainer.Controls.Add(ucStaff.Instance);
                ucStaff.Instance.Dock = DockStyle.Fill;
                ucStaff.Instance.BringToFront();
            }
            else
            {
                ucStaff.Instance.BringToFront();
            }
        }

        //Account button
        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (!pnlUserControlContainer.Controls.Contains(ucAccount.Instance))
            {
                pnlUserControlContainer.Controls.Add(ucAccount.Instance);
                ucAccount.Instance.Dock = DockStyle.Fill;
                ucAccount.Instance.BringToFront();
            }
            else
            {
                ucAccount.Instance.BringToFront();
            }
        }

        
    }
}
