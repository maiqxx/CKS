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

namespace Carinderia_Kiosk_System.Proprietor.ProprietorDialogs
{
    public partial class SalesReport : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataTable dt;
        string sql;

        public SalesReport()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            LoadDailySales();

            GetTimelySales(sql);
        }

        void LoadDailySales()
        {
            rbDaily.Checked = true;
            lblTimelySales.Text = "Daily Sales";

            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT ORDER_ID, DATE AS 'Date', TOTAL_AMOUNT AS 'TotalAmount' FROM TRANSACTION WHERE DATE(DATE) = CURDATE()");
                cmd.Connection = conn;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSales.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                da.Dispose();
            }
        }

        //gets report sales
        void GetTimelySales(string sql)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSales.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                da.Dispose();
            }
        }

        private void rbDaily_CheckedChanged(object sender, EventArgs e)
        {
            lblTimelySales.Text = "Daily Sales";

            sql = "SELECT ORDER_ID, DATE AS 'Date', TOTAL_AMOUNT AS 'TotalAmount' FROM TRANSACTION WHERE DATE(DATE) = CURDATE()";
            GetTimelySales(sql);
        }

        private void rbWeekly_CheckedChanged(object sender, EventArgs e)
        {
            rbDaily.Checked = false;
            lblTimelySales.Text = "Weekly Sales";

            sql = "SELECT ORDER_ID, DATE AS 'Date', TOTAL_AMOUNT AS 'TotalAmount' FROM TRANSACTION WHERE WEEK(DATE) = WEEK(NOW())";
            GetTimelySales(sql);
        }


        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            rbDaily.Checked = false;
            lblTimelySales.Text = "Monthly Sales";

            sql = "SELECT ORDER_ID, DATE AS 'Date', TOTAL_AMOUNT AS 'TotalAmount' FROM TRANSACTION WHERE MONTH(DATE) = MONTH(NOW())";
            GetTimelySales(sql);
        }

        private void rbYearly_CheckedChanged(object sender, EventArgs e)
        {
            rbDaily.Checked = false;
            lblTimelySales.Text = "Yearly Sales";

            sql = "SELECT ORDER_ID, DATE AS 'Date', TOTAL_AMOUNT AS 'TotalAmount' FROM TRANSACTION WHERE YEAR(DATE) = YEAR(NOW())";
            GetTimelySales(sql);
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
