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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class LogIn : Form
    {
        public static LogIn instance;

        public LogIn()
        {
            InitializeComponent();
            instance = this;
        }

        //Sign In Button
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var emailAddress = txtEmailAddress.Text;
            AdminInfo.EmailAddress = emailAddress;
            var password = txtPassword.Text;
            var id = AdminInfo.ID;

            try
            {
                if (emailAddress == "" && password == "")
                {
                    MessageBox.Show("Please enter your login credentials.");
                }
                else
                {
                    //Database connection
                    string connectionString = null;
                    MySqlConnection conn;
                    connectionString = "server=localhost; database=cks_db; uid=root; pwd=\"\";";
                    conn = new MySqlConnection(connectionString);

                    conn.Open();

                    //This query checks if the user credentials
                    string check = "SELECT * FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + emailAddress + "' AND PASSWORD = '" + password + "'";
                    MySqlCommand cmd1 = new MySqlCommand(check, conn);
                    MySqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.Read())
                    {
                        setAdminInfo();
                        AdminBoard board = new AdminBoard(emailAddress);
                        this.Hide();
                        board.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Back Button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            this.Hide();
            createAccount.Show();
        }

        //Not sure for this method, but trying to set the AdminInfo [might remove this stuff]
        void setAdminInfo()
        {
            //int id = 0;
            //string firstname = "";
            //string lastname = "";
            //string storeName = "";
            //string location = "";
            //string contactNum = "";
            //string emailAddress = "";
            //string password = "";
            //string createdAt = "";
            //string updatedAt = "";

            //AdminInfo.ID = id;
            //AdminInfo.Firstname = firstname;
            //AdminInfo.Lastname = lastname;
            //AdminInfo.StoreName = storeName;
            //AdminInfo.Location = location;
            //AdminInfo.ContactNum = contactNum;
            //AdminInfo.EmailAddress = emailAddress;
            //AdminInfo.Password = password;
            //AdminInfo.CreatedAt = createdAt;
            //AdminInfo.UpdatedAt = updatedAt;

            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root; pwd=\"\";";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                //This query checks if the user credentials
                string getAdminInfo = "SELECT * FROM PROPRIETOR";
                MySqlCommand cmd1 = new MySqlCommand(getAdminInfo, conn);
                MySqlDataReader reader = cmd1.ExecuteReader();

                if (reader.Read())
                {
                    AdminInfo.ID = (int)reader["PROPRIETOR_ID"];
                    AdminInfo.Firstname = reader["FIRSTNAME"].ToString();
                    AdminInfo.Lastname = reader["LASTNAME"].ToString();
                    AdminInfo.StoreName = reader["STORE_NAME"].ToString();
                    AdminInfo.Location = reader["LOCATION"].ToString();
                    AdminInfo.ContactNum = reader["CONTACT_NUMBER"].ToString();
                    AdminInfo.Password = reader["PASSWORD"].ToString();
                    AdminInfo.CreatedAt = reader["CREATED_AT"].ToString();
                    AdminInfo.UpdatedAt = reader["UPDATED_AT"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
