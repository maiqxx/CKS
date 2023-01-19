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
    public partial class ucDashboard : UserControl
    {

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        private static ucDashboard _instance;

        //Database connection
       // MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

        public ucDashboard()
        {
            InitializeComponent();
            timerCurrTime.Start();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
            Dashboard();
        }

        public static ucDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDashboard();
                return _instance;
            }
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            //Loads data for store description
            LoadStoreDescription();

            //Loads menu categories with number of stocks available
            LoadMenuStocks();

            //Live Orders
            GetPendingOrders();
            GetCompletedOrder();
            GetCancelledOrder();
            GetFeedbacks();
            LoadAvailableStocks();
            GetTotalStocks();
        }    

        //returns total income
        public double GetTotal(string sql)
        {
            double _total = 0;

            try
            {
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                _total = double.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            //returns total of income
            return _total;
        }

        //displays daily, weekly, monthly, and yearly income
        public void Dashboard()
        {
            lblDaily.Text = "₱ " + GetTotal("SELECT IFNULL(SUM(TOTAL_AMOUNT),0) FROM TRANSACTION WHERE DATE = CURDATE()").ToString("#,##0.00");

            lblWeekly.Text = "₱ " + GetTotal("SELECT IFNULL(SUM(TOTAL_AMOUNT),0) FROM TRANSACTION WHERE WEEK(DATE) = WEEK(NOW())").ToString("#,##0.00");

            lblMonthly.Text = "₱ " + GetTotal("SELECT IFNULL(SUM(TOTAL_AMOUNT),0) FROM TRANSACTION WHERE MONTH(DATE) = MONTH(NOW())").ToString("#,##0.00");

            lblYearly.Text = "₱ " + GetTotal("SELECT IFNULL(SUM(TOTAL_AMOUNT),0) FROM TRANSACTION WHERE YEAR(DATE) = YEAR(NOW())").ToString("#,##0.00");
        }


        //Loads data for store description
        void LoadStoreDescription()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblStoreName.Text = reader["STORE_NAME"].ToString();
                    lblLocation.Text = reader["LOCATION"].ToString();
                    lblEmailAddress.Text = reader["EMAIL_ADDRESS"].ToString();
                    lblContactNum.Text = reader["CONTACT_NUMBER"].ToString();
                    lblOpeningTime.Text = reader["OPENING_TIME"].ToString();
                    lblClosingTime.Text = reader["CLOSING_TIME"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Loads menu categories with number of stocks available
        void LoadMenuStocks()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CATEGORY, COUNT(STOCK_ID) FROM INVENTORY GROUP BY CATEGORY", conn);
                adapter.Fill(dt);

                dgvMenuStocks.RowTemplate.Height = 50;
                dgvMenuStocks.DataSource = dt;

                //Column names
                dgvMenuStocks.Columns[0].HeaderText = "Category";
                dgvMenuStocks.Columns[1].HeaderText = "Products";
                dgvMenuStocks.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //data gridview for Inventory Summary
        void LoadAvailableStocks()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT STOCK_NAME, STOCK_QUANTITY FROM INVENTORY WHERE PROPRIETOR_ID = (SELECT PROPRIETOR_ID FROM PROPRIETOR WHERE EMAIL_ADDRESS = '"+ AdminInfo.EmailAddress +"' )", conn);
                adapter.Fill(dt);

                dgvInventorySum.RowTemplate.Height = 20;
                dgvInventorySum.DataSource = dt;

                //Column names
                dgvInventorySum.Columns[0].HeaderText = "Product";
                dgvInventorySum.Columns[1].HeaderText = "Available Stocks";
                dgvInventorySum.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //displays the total number of available stocks
        void GetTotalStocks()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT IFNULL(SUM(STOCK_QUANTITY), 0) FROM INVENTORY WHERE PROPRIETOR_ID = (SELECT PROPRIETOR_ID FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "' ) ", conn);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblTotalStocks.Text = count.ToString() + " stocks";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Displays current time
        private void timerCurrTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblTime.Text = dateTime.ToString("hh:mm tt");
        }

        //Refresh dashboard button
        private void btnRefreshDashboard_Click(object sender, EventArgs e)
        {
            LoadStoreDescription();
            LoadMenuStocks();
            GetPendingOrders();
            GetCompletedOrder();
            GetCancelledOrder();
            GetFeedbacks();
            GetTotalStocks();
            LoadAvailableStocks();
            Dashboard();
        }

        //////Live Orders
        ///GetPendingOrders()
        ///GetCompletedOrder()
        ///GetCancelledOrder()
        ///GetFeedbacks()

        //Counts the pending orders
        void GetPendingOrders()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT COUNT(ORDER_STATUS) FROM ORDERS WHERE ORDER_STATUS = '" + "Pending" + "' ", conn);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblCurrentNumOrders.Text = count.ToString();
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
                lblCompletedOrders.Text = count.ToString();
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
                cmd = new MySqlCommand("SELECT COUNT(STATUS) FROM TRANSACTION WHERE STATUS = '" + "Cancelled" + "' ", conn);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblCancelledOrders.Text = count.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Counts feedbacks
        void GetFeedbacks()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT COUNT(RATING) FROM FEEDBACK", conn);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                lblFeedbacks.Text = count.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblLocation_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblYearly_Click(object sender, EventArgs e)
        {

        }
    }
}
