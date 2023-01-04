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
        private static ucDashboard _instance;

        //Database connection
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

        public ucDashboard()
        {
            InitializeComponent();
            timerCurrTime.Start();
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

        }

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

        void LoadMenuStocks()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CATEGORY, COUNT(STOCK_ID) FROM INVENTORY GROUP BY CATEGORY", conn);
                adapter.Fill(dt);
                dgvMenuStocks.DataSource = dt;

                //Column names
                dgvMenuStocks.Columns[0].HeaderText = "Category";
                dgvMenuStocks.Columns[1].HeaderText = "No. Of Stocks";

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
    }
}
