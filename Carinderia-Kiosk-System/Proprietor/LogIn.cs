﻿using System;
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
using Carinderia_Kiosk_System.Proprietor.ProprietorDialogs;

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
            var emailAddress = txtEmailAddress.Text.Trim();
            AdminInfo.EmailAddress = emailAddress;
            var password = txtPassword.Text;
            var id = AdminInfo.ID;

            try
            {
                if (emailAddress == "" && password == "")
                {
                    MessageBox.Show("Please enter your log in credentials.");
                }
                else
                {
                    //Database connection
                    string connectionString = null;
                    MySqlConnection conn;
                    connectionString = "server=localhost; database=cks_db; uid=root; pwd=\"\";";
                    conn = new MySqlConnection(connectionString);

                    conn.Open();

                    //This query checks the user credentials
                    string check = "SELECT * FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "' AND PASSWORD = '" + password + "'";
                    MySqlCommand cmd1 = new MySqlCommand(check, conn);
                    MySqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.Read())
                    {
                        AdminBoard board = new AdminBoard(emailAddress);
                        this.Hide();
                        board.Show();

                        LogInSuccessDialog log = new LogInSuccessDialog();
                        log.ShowDialog();
                    }
                    else
                    {
                        InvalidCredentialsDialog invalid = new InvalidCredentialsDialog();
                        invalid.ShowDialog();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
