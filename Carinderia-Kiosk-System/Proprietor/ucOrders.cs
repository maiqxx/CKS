using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucOrders : UserControl
    {
        private static ucOrders instance;

        public static ucOrders Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucOrders();

                }
                return instance;
            }
        }

        public ucOrders()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Order List button
        private void btnOrderList_Click(object sender, EventArgs e)
        {
            if (!pnlManageOrdersContainer.Controls.Contains(ucOrderList.Instance))
            {
                pnlManageOrdersContainer.Controls.Add(ucOrderList.Instance);
                ucOrderList.Instance.Dock = DockStyle.Fill;
                ucOrderList.Instance.BringToFront();
            }
            else
            {
                ucOrderList.Instance.BringToFront();
            }
        }


        //Completed orders button
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            if (!pnlManageOrdersContainer.Controls.Contains(ucCompletedOrders.Instance))
            {
                pnlManageOrdersContainer.Controls.Add(ucCompletedOrders.Instance);
                ucCompletedOrders.Instance.Dock = DockStyle.Fill;
                ucCompletedOrders.Instance.BringToFront();
            }
            else
            {
                ucCompletedOrders.Instance.BringToFront();
            }
        }


        //Cancelled orders button
        private void btnCancelled_Click(object sender, EventArgs e)
        {
            if (!pnlManageOrdersContainer.Controls.Contains(ucCancelledOrders.Instance))
            {
                pnlManageOrdersContainer.Controls.Add(ucCancelledOrders.Instance);
                ucCancelledOrders.Instance.Dock = DockStyle.Fill;
                ucCancelledOrders.Instance.BringToFront();
            }
            else
            {
                ucCancelledOrders.Instance.BringToFront();
            }
        }


        //Transaction List button
        private void btnTransacts_Click(object sender, EventArgs e)
        {
            if (!pnlManageOrdersContainer.Controls.Contains(ucTransactionList.Instance))
            {
                pnlManageOrdersContainer.Controls.Add(ucTransactionList.Instance);
                ucTransactionList.Instance.Dock = DockStyle.Fill;
                ucTransactionList.Instance.BringToFront();
            }
            else
            {
                ucTransactionList.Instance.BringToFront();
            }
        }
    }
}
