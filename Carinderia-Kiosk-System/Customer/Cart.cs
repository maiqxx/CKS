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
    public partial class Cart : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        //setting fonts
        Font SmallFont = new Font("Century Gothic", 8, FontStyle.Bold);
        Font MediumFont = new Font("Century Gothic", 10, FontStyle.Bold);
        Font LargeFont = new Font("Century Gothic", 12, FontStyle.Bold);

        public Cart()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            GetOrderList();
        }

        private Panel orderPanel;
        private Label foodItemName;
        private Label cost;
        private Label quantity;
        private NumericUpDown qty;
        private Button remove;

        //Gets current orders in the cart
        void GetOrderList()
        {
            flpOrders.Controls.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT CUST_ID, FOOD_NAME, QUANTITY, UNIT_PRICE, TOTAL_AMOUNT FROM CUSTOMER", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                orderPanel = new Panel();
                orderPanel.Width = 523;
                orderPanel.Height = 87;
                orderPanel.BackColor = Color.Honeydew;

                //displays price
                cost = new Label();
                cost.Text = "₱ " + double.Parse(dr["UNIT_PRICE"].ToString()).ToString("#, ##0.00");
                cost.Font = SmallFont;
                cost.ForeColor = Color.Black;
                cost.Location = new Point(33, 48);
                cost.Tag = dr["CUST_ID"].ToString();

                //displays food name
                foodItemName = new Label();
                foodItemName.Text = dr["FOOD_NAME"].ToString();
                foodItemName.ForeColor = Color.Black;
                foodItemName.Location = new Point(33, 20);
                foodItemName.Font = MediumFont;
                foodItemName.Tag = dr["CUST_ID"].ToString();

                //displays food quantity
                quantity = new Label();
                quantity.Text = "x " + dr["QUANTITY"].ToString();
                quantity.Location = new Point(247, 48);
                quantity.Font = MediumFont;
                quantity.Tag = dr["CUST_ID"].ToString();

                //remove button
                remove = new Button();
                remove.Text = "Remove";
                remove.Width = 80;
                remove.Height = 30;
                remove.Location = new Point(391, 29);
                remove.ForeColor = Color.Maroon;
                remove.BackColor = Color.FromArgb(255, 192, 192);
                remove.Font = SmallFont;
                remove.Tag = dr["CUST_ID"].ToString();


                //add to display controls
                orderPanel.Controls.Add(cost);
                orderPanel.Controls.Add(foodItemName);
                orderPanel.Controls.Add(quantity);
                orderPanel.Controls.Add(remove);
                //orderPanel.Controls.Add(qty);

                flpOrders.Controls.Add(orderPanel);

                //item.Cursor = Cursors.Hand;
                remove.Click += new EventHandler(Remove_OnClick);
                //qty.ValueChanged += new EventHandler(Quantity_ValueChanged);


            }
            dr.Close();
            conn.Close();

        }

        //Remove button
        public void Remove_OnClick(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();

            try
            {
                conn.Open();

                //Deletes the selected food item
                cmd = new MySqlCommand("DELETE FROM CUSTOMER WHERE CUST_ID LIKE '" + tag + "' ", conn);

                dr = cmd.ExecuteReader();
                dr.Close();
                conn.Close();
                MessageBox.Show("Food item removed successfully!");
                GetOrderList(); //to reload the order list after deleting
                //TotalAmount();  //to reload the total amount after deleting
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbBackToMenu_Click(object sender, EventArgs e)
        {
            MenuBoard menuBoard = new MenuBoard();
            menuBoard.Show();
            this.Hide();
        }

        private void pbCart_Click(object sender, EventArgs e)
        {

        }
    }
}
