using MySql.Data.MySqlClient;
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
        public static ucOrders instance;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

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
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void ucOrders_Load(object sender, EventArgs e)
        {
            GetPendingOrders();
            GetCompletedOrder();
            GetCancelledOrder();

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
            //if (!pnlManageOrdersContainer.Controls.Contains(ucCompletedOrders.Instance))
            //{
            //    pnlManageOrdersContainer.Controls.Add(ucCompletedOrders.Instance);
            //    ucCompletedOrders.Instance.Dock = DockStyle.Fill;
            //    ucCompletedOrders.Instance.BringToFront();
            //}
            //else
            //{
            //    ucCompletedOrders.Instance.BringToFront();
            //}
        }


        //Cancelled orders button
        private void btnCancelled_Click(object sender, EventArgs e)
        {
            //if (!pnlManageOrdersContainer.Controls.Contains(ucCancelledOrders.Instance))
            //{
            //    pnlManageOrdersContainer.Controls.Add(ucCancelledOrders.Instance);
            //    ucCancelledOrders.Instance.Dock = DockStyle.Fill;
            //    ucCancelledOrders.Instance.BringToFront();
            //}
            //else
            //{
            //    ucCancelledOrders.Instance.BringToFront();
            //}
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

        //Feedback button
        private void btnFeedbacks_Click(object sender, EventArgs e)
        {

            if (!pnlManageOrdersContainer.Controls.Contains(ucFeedback.Instance))
            {
                pnlManageOrdersContainer.Controls.Add(ucFeedback.Instance);
                ucFeedback.Instance.Dock = DockStyle.Fill;
                ucFeedback.Instance.BringToFront();
            }
            else
            {
                ucFeedback.Instance.BringToFront();
            }
        }

        //Live Orders

        //Counts the pending orders
        void GetPendingOrders()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT COUNT(ORDER_STATUS) FROM ORDERS WHERE ORDER_STATUS = '"+ "Pending" +"' ", conn);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
              //  lblCurrentNumOrders.Text = count.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Counts the complete orders
        void GetCompletedOrder()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT COUNT(ORDER_STATUS) FROM ORDERS WHERE ORDER_STATUS = '" + "Completed" + "' ", conn);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
             //   lblCompletedOrders.Text = count.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Counts the cancelled orders
        void GetCancelledOrder()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT COUNT(ORDER_STATUS) FROM ORDERS WHERE ORDER_STATUS = '" + "Cancelled" + "' ", conn);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
               // lblCancelledOrders.Text = count.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucTransactionList1_Load(object sender, EventArgs e)
        {

        }


    }
}
