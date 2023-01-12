using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using Carinderia_Kiosk_System.Customer.CustomerDialogs;

namespace Carinderia_Kiosk_System.Customer
{
    public partial class OrderSummary : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public OrderSummary()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void OrderSummary_Load(object sender, EventArgs e)
        {
            PopulateData();
            GetDetails();
        }

        //Get details from ORDERS
        void GetDetails()
        {
            try
            {
                conn.Open();

                cmd = new MySqlCommand("SELECT * FROM ORDERS WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "' ", conn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblDTValue.Text = dr["CREATED_AT"].ToString();
                    lblOrderNumValue.Text = dr["ORDER_ID"].ToString();
                    lblCustomerName.Text = dr["CUSTOMER_NAME"].ToString();
                    lblDineOption.Text = dr["DINE_OPTION"].ToString();
                    lblTotalPayment.Text = "₱ " + double.Parse(dr["TOTAL_AMOUNT"].ToString()).ToString("#, ##0.00");
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //Gets data and populates the listView
        void PopulateData()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT FOOD_NAME, QUANTITY, UNIT_PRICE, TOTAL_AMOUNT FROM CUSTOMER WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "'", conn);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["FOOD_NAME"].ToString());
                    listitem.SubItems.Add(dr["QUANTITY"].ToString());
                    listitem.SubItems.Add(dr["UNIT_PRICE"].ToString());
                    listitem.SubItems.Add(dr["TOTAL_AMOUNT"].ToString());
                    lvOrderList.Items.Add(listitem);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {

        }
    }
}
