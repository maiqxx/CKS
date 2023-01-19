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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        //Back Button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StartUp startUp = new StartUp();
            this.Hide();
            startUp.Show();
        }

        //Sign In Button
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            LogIn LogIn = new LogIn();
            this.Hide();
            LogIn.Show();
        }

        //Create Account Button
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            
            //variables for creating proprietor's account
            var firstName = txtFirstname.Text;
            var lastName = txtLastname.Text;
            var storeName = txtStorename.Text;
            var location = txtlocation.Text;
            var contactNum = mTxtContactNum.Text;
            var emailAddress = txtEmailAddress.Text;
            var password = txtPassword.Text;
            var updatedAt = "";

            //Required fields
            if (firstName == "")
            {
                MessageBox.Show("Your first name is required.");
                return;
            }
            else if (lastName == "")
            {
                MessageBox.Show("Your last name is required.");
                return;
            }
            else if (storeName == "")
            {
                MessageBox.Show("Store's name is required.");
                return;
            }
            else if (location == "")
            {
                MessageBox.Show("Store's location is required.");
                return;
            }
            else if (contactNum == "")
            {
                MessageBox.Show("Contact number is required.");
                return;
            }
            else if (emailAddress == "")
            {
                MessageBox.Show("Email address is required.");
                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Password is required.");
                return;
            }

            //Email address regular expression
            var isEmail = new Regex(@"[a-z A-z 0-9_\-]+[@]+[a-z]+[\.][a-z]{3,4}$");

            //Validating email address
            if (!isEmail.IsMatch(emailAddress))
            {
                MessageBox.Show("Email address is invalid.");
                return;
            }

            //Password regular expressions
            var hasNumber = new Regex(@"[0-9]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            //Validating password
            if (!hasNumber.IsMatch(password))
            {
                MessageBox.Show("Password should contain at least one numeric value.");
                return;
            }
            else if (!hasMiniMaxChars.IsMatch(password))
            {
                MessageBox.Show("Password must be at least 8 characters.");
                return;
            }
            else if (!hasSymbols.IsMatch(password))
            {
                MessageBox.Show("Password should contain at least one special case characters.");
                return;
            }
            else
            {
                //Database connection
                string connectionString = null;
                MySqlConnection conn;
                connectionString = "server=localhost; database=cks_db; Convert Zero Datetime=True; uid=root; pwd=\"\";";
                conn = new MySqlConnection(connectionString);

                try
                {
                    
                    conn.Open();
                    
                    //This query checks if the user has already registered or not
                    string check = "SELECT * FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + emailAddress + "' ";
                    MySqlCommand cmd1 = new MySqlCommand(check, conn);
                    MySqlDataReader reader = cmd1.ExecuteReader();
                    reader.Close();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("This email is already registered!");
                        reader.Close();
                    }
                    else
                    {
                        //adds new user/proprietor
                        string addUser = "INSERT INTO `proprietor`(`FIRSTNAME`, `LASTNAME`, `STORE_NAME`, `LOCATION`, `CONTACT_NUMBER`, `EMAIL_ADDRESS`, `PASSWORD`)" +
                                                             " VALUES ('"+ txtFirstname.Text +"','"+txtLastname.Text+"','"+txtStorename.Text+"','"+txtlocation.Text+"','"+mTxtContactNum.Text+"','"+txtEmailAddress.Text+"','"+txtPassword.Text+"')";
                        MySqlCommand cmd2 = new MySqlCommand(addUser, conn);

                        var ctr = cmd2.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully!");
                        LogIn LogIn = new LogIn();
                        this.Hide();
                        LogIn.Show();
                        reader.Close();
                    }
                   
                    conn.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
