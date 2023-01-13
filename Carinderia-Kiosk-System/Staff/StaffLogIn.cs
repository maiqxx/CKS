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

namespace Carinderia_Kiosk_System.Staff
{
    public partial class StaffLogIn : Form
    {
        public StaffLogIn()
        {
            InitializeComponent();
        }

        //Right arrow button - redirect back to startUp form
        private void pbBackIcon_Click(object sender, EventArgs e)
        {
            StartUp st = new StartUp();
            st.Show();
            this.Hide();
        }

        //Staff sign in button
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var emailAddress = txtEmailAddress.Text;
            AdminInfo.EmailAddress = emailAddress;
            var password = txtPasscode.Text;
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
                    string check = "SELECT * FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "' AND PASSWORD = '" + password + "'";
                    MySqlCommand cmd1 = new MySqlCommand(check, conn);
                    MySqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.Read())
                    {

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
    }
}
