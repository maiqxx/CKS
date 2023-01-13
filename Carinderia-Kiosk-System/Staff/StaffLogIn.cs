using Carinderia_Kiosk_System.Staff.StaffDialog;
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
            StaffInfo.EmailAddress = emailAddress;

            var passcode = txtPasscode.Text;
            StaffInfo.StaffCode = passcode;

            try
            {
                if (emailAddress == "" && passcode == "")
                {
                    MessageBox.Show("Please enter your log in credentials.");
                }
                else
                {
                    //Database connection
                    string connectionString = null;
                    MySqlConnection conn;
                    connectionString = "server=localhost; database=cks_db; Convert Zero Datetime=True; uid=root; pwd=\"\";";
                    conn = new MySqlConnection(connectionString);

                    conn.Open();

                    //This query checks the user credentials
                    string check = "SELECT * FROM STAFF WHERE EMAIL_ADDRESS = '" + StaffInfo.StaffCode + "' AND STAFF_ID = '" + passcode + "'";
                    MySqlCommand cmd1 = new MySqlCommand(check, conn);
                    MySqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.Read())
                    {
                        //redirects to another windows form

                        StaffLogInSuccessDialog successDialog = new StaffLogInSuccessDialog();
                        successDialog.ShowDialog();
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
