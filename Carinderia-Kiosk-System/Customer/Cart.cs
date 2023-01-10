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
        private Button set;
        private Button remove;
        private Button numDown;
        private Button numUp;
        private TextBox itemQuantity;

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
                orderPanel.Width = 646;
                orderPanel.Height = 92;
                orderPanel.BackColor = Color.Honeydew;

                //displays food name
                foodItemName = new Label();
                foodItemName.Text = dr["FOOD_NAME"].ToString();
                foodItemName.ForeColor = Color.Black;
                foodItemName.Location = new Point(72, 19);
                foodItemName.Font = MediumFont;
                foodItemName.Tag = dr["CUST_ID"].ToString();

                //displays price
                cost = new Label();
                cost.Text = "₱ " + double.Parse(dr["UNIT_PRICE"].ToString()).ToString("#, ##0.00");
                cost.Font = SmallFont;
                cost.ForeColor = Color.Black;
                cost.Location = new Point(72, 49);
                cost.Tag = dr["CUST_ID"].ToString();


                //NumericUpDown for quantity
                qty = new NumericUpDown();
                qty.Text = dr["QUANTITY"].ToString();
                qty.Width = 120;
                qty.Height = 30;
                qty.Font = MediumFont;
                qty.Location = new Point(264, 30);
                qty.Tag = dr["CUST_ID"].ToString();


                //remove button
                remove = new Button();
                remove.Text = "Remove";
                remove.Width = 80;
                remove.Height = 30;
                remove.Location = new Point(487, 30);
                remove.ForeColor = Color.Maroon;
                remove.BackColor = Color.FromArgb(255, 192, 192);
                remove.Font = SmallFont;
                remove.Tag = dr["CUST_ID"].ToString();


                //add to display controls
                orderPanel.Controls.Add(foodItemName);
                orderPanel.Controls.Add(cost);
                orderPanel.Controls.Add(qty);
                orderPanel.Controls.Add(remove);

                //display controls over the flowlayout
                flpOrders.Controls.Add(orderPanel);

                //item.Cursor = Cursors.Hand;
                remove.Click += new EventHandler(Remove_OnClick);
                qty.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
                //qty.ValueChanged += new EventHandler(Quantity_ValueChanged);


            }
            dr.Close();
            conn.Close();

        }

        void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();
            String itemQuantityTag = ((Button)sender).Tag.ToString();

            MessageBox.Show(((Button)sender).Tag.ToString()); //test get stock ID
        }

        //Set button
        public void Set_OnClick(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();
            String itemQuantityTag = ((Button)sender).Tag.ToString();

            //MessageBox.Show(((Button)sender).Tag.ToString()); //test get stock ID

            try
            {
                conn.Open();

                //Deletes the selected food item
                cmd = new MySqlCommand("UPDATE CUSTOMER SET QUANTITY = '" + itemQuantityTag.Trim() + "' WHERE CUST_ID LIKE '" + tag + "' ", conn);
                //dr = cmd.ExecuteReader();
                int ctr = cmd.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Food item removed successfully!");
                }
                dr.Close();
                conn.Close();
                //MessageBox.Show("Food item removed successfully!");
                GetOrderList(); //to reload the order list after deleting
                //TotalAmount();  //to reload the total amount after deleting
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public void Quantity_ValueChanged(object sender, EventArgs e)
        {
            String tag = ((NumericUpDown)sender).Tag.ToString();
            String qty = ((NumericUpDown)sender).Tag.ToString();

            try
            {
                conn.Open();

                //Updates the selected food item
                cmd = new MySqlCommand("UPDATE CUSTOMER SET QUANTITY = '"+ qty +"' WHERE CUST_ID LIKE '" + tag + "' ", conn);

                dr = cmd.ExecuteReader();
                dr.Close();
                conn.Close();
                //MessageBox.Show("Food item updated successfully!");
                GetOrderList(); //to reload the order list after deleting
                //TotalAmount();  //to reload the total amount after deleting
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        public void NumDown_OnClick(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();

            

            try
            {
                conn.Open();

                //Deletes the selected food item
                //cmd = new MySqlCommand("UPDATE CUSTOMER WHERE CUST_ID LIKE '" + tag + "' ", conn);

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


        public void NumUp_OnClick(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();
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
