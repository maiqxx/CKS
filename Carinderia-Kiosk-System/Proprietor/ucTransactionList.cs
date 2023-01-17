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
    public partial class ucTransactionList : UserControl
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        private static ucTransactionList instance;

        public static ucTransactionList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucTransactionList();

                }
                return instance;
            }
        }

        public ucTransactionList()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void ucTransactionList_Load(object sender, EventArgs e)
        {
            GetTransactions();
        }

        //populates grid view
        void GetTransactions()
        {
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM TRANSACTION", conn);
            adapter.Fill(dt);

            //dgvInventory properties
            dgvTransactions.RowTemplate.Height = 25;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.DataSource = dt;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Column header names
            dgvTransactions.Columns[0].HeaderText = "Transaction No.";
            dgvTransactions.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[1].HeaderText = "Order No.";
            dgvTransactions.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[2].HeaderText = "Customer's Name";
            dgvTransactions.Columns[3].HeaderText = "Dine Option";
            dgvTransactions.Columns[4].HeaderText = "Total Payment";
            dgvTransactions.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[5].HeaderText = "Type";
            dgvTransactions.Columns[6].HeaderText = "Date & Time";

            dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);

            conn.Close();
        }

        //Searches data between range
        private void btnGo_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM TRANSACTION WHERE `DATE` BETWEEN @d1 AND @d2", conn);

            //add values to the parameters form dateTimePickers
            cmd.Parameters.Add("@d1", MySqlDbType.Date).Value = dateTimePicker1.Value;
            cmd.Parameters.Add("@d2", MySqlDbType.Date).Value = dateTimePicker2.Value;
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            //dgvInventory properties
            dgvTransactions.RowTemplate.Height = 25;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.DataSource = dt;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Column header names
            dgvTransactions.Columns[0].HeaderText = "Transaction No.";
            dgvTransactions.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[1].HeaderText = "Order No.";
            dgvTransactions.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[2].HeaderText = "Customer's Name";
            dgvTransactions.Columns[3].HeaderText = "Dine Option";
            dgvTransactions.Columns[4].HeaderText = "Total Payment";
            dgvTransactions.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[5].HeaderText = "Type";
            dgvTransactions.Columns[6].HeaderText = "Date & Time";

            dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);

            conn.Close();
        }

        //Search transaction by transaction ID
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM TRANSACTION WHERE TRANSACT_ID LIKE '" + txtSearch.Text + "' ", conn);
            adapter.Fill(dt);

            //dgvInventory properties
            dgvTransactions.RowTemplate.Height = 25;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.DataSource = dt;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Column header names
            dgvTransactions.Columns[0].HeaderText = "Transaction No.";
            dgvTransactions.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[1].HeaderText = "Order No.";
            dgvTransactions.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[2].HeaderText = "Customer's Name";
            dgvTransactions.Columns[3].HeaderText = "Dine Option";
            dgvTransactions.Columns[4].HeaderText = "Total Payment";
            dgvTransactions.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTransactions.Columns[5].HeaderText = "Type";
            dgvTransactions.Columns[6].HeaderText = "Date & Time";

            dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);

            conn.Close();

            if (txtSearch.Text == "")
            {
                GetTransactions();
            }
        }

        private void pbReload_Click(object sender, EventArgs e)
        {
            GetTransactions();
        }


        private void lblTransactNum_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
