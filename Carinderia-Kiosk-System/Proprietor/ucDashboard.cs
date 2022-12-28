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
            string emailAddress;
            emailAddress = AdminInfo.EmailAddress.Trim();

            try
            {
                //Database connection
                string connectionString = null;
                MySqlConnection conn;
                connectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
                conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT * FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + emailAddress + "'";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timerCurrTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblTime.Text = dateTime.ToString("hh:mm:ss tt");
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
