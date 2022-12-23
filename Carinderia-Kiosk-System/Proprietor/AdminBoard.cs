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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Dashboard button
        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
        }

        //Orders button
        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        //Categories button
        private void btnCategories_Click(object sender, EventArgs e)
        {

        }

        //Inventory button
        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        //Staff button
        private void btnStaff_Click(object sender, EventArgs e)
        {

        }

        //Account button
        private void btnAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
