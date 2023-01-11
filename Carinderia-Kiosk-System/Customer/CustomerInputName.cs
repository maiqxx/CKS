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
            //StartScreen startScreen = new StartScreen();
            //startScreen.Show();
            //this.Hide();

            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerUniqueName.Clear();
            //StartScreen startScreen = new StartScreen();
            //startScreen.Show();
            //this.Hide();

            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void btnProceedToOrder_Click(object sender, EventArgs e)
        {
            CustomerInfo.Name = txtCustomerUniqueName.Text;

            try
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO CUSTOMER (CUSTOMER_NAME) VALUES(@customer)", conn);
                cmd.Parameters.AddWithValue("@customer", txtCustomerUniqueName.Text);

                int ctr = cmd.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MenuBoard menuBoard = new MenuBoard();
                    menuBoard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wa na insert si name");
                    StartScreen startScreen = new StartScreen();
                    startScreen.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
