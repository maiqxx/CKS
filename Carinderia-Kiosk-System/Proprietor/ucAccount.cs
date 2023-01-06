using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.Data;


namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucAccount : UserControl
    {
        private static ucAccount instance;

        //Database connection
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

        public static ucAccount Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucAccount();
                }
                return instance;
            }
        }

        public ucAccount()
        {
            InitializeComponent();
        }

        private void ucAccount_Load(object sender, EventArgs e)
        {
            //shows proprietor's data
            LoadInfo();

            //displays time format
            InitializeTimePicker();

        }
        //sets time format in dateTimePicker
        void InitializeTimePicker()
        {
            //opening time
            dtpOpeningTime.Format = DateTimePickerFormat.Custom;
            dtpOpeningTime.CustomFormat = "HH:mm tt";
            dtpOpeningTime.ShowUpDown = true;

            //closing time
            dtpClosingTime.Format = DateTimePickerFormat.Custom;
            dtpClosingTime.CustomFormat = "HH:mm tt";
            dtpClosingTime.ShowUpDown = true;
        }

        //Updates proprietor's information
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        //Loads proprietor's data
        void LoadInfo()
        {
            conn.Open();
            string query = "SELECT * FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtFirstname.Text = reader["FIRSTNAME"].ToString();
                txtLastName.Text = reader["LASTNAME"].ToString();
                txtContactNum.Text = reader["CONTACT_NUMBER"].ToString();
                txtEmail.Text = reader["EMAIL_ADDRESS"].ToString();
                txtPassword.Text = reader["PASSWORD"].ToString();
                txtPassword.UseSystemPasswordChar = true;
                txtStoreName.Text = reader["STORE_NAME"].ToString();
                txtLocation.Text = reader["LOCATION"].ToString();
                lblCreatedAt.Text = reader["CREATED_AT"].ToString();
                lblUpdatedAt.Text = reader["UPDATED_AT"].ToString();
                dtpOpeningTime.Text = reader["OPENING_TIME"].ToString();
                dtpClosingTime.Text = reader["CLOSING_TIME"].ToString();
            }
            conn.Close();
        }

        private void lblStoreDescription_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
