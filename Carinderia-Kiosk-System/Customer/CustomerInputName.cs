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
    public partial class CustomerInputName : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public CustomerInputName()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void pbBackIcon_Click(object sender, EventArgs e)
        {
            txtCustomerUniqueName.Clear();
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerUniqueName.Clear();
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
            this.Hide();

        }

        private void btnProceedToOrder_Click(object sender, EventArgs e)
        {
            string name = txtCustomerUniqueName.Text;

            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM CUSTOMER WHERE CUSTOMER_NAME = '" + name + "'", conn);
                cmd.Parameters.AddWithValue("@customer", txtCustomerUniqueName.Text);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    InputUniqueNameDialog uniqueNameDialog = new InputUniqueNameDialog();
                    uniqueNameDialog.ShowDialog();
                    txtCustomerUniqueName.Clear();
                }
                else
                {
                    CustomerInfo.Name = name; //sets current user

                    MenuBoard menuBoard = new MenuBoard();
                    menuBoard.Show();
                    this.Hide();
                }
                dr.Close();
                conn.Close();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
