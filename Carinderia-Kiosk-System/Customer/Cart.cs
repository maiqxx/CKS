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
                orderPanel.Width = 662;
                orderPanel.Height = 92;
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
                itemQuantity = new TextBox();
                itemQuantity.Text = dr["QUANTITY"].ToString();
                itemQuantity.Width = 59;
                itemQuantity.Height = 28;
                itemQuantity.Location = new Point(323, 39);
                itemQuantity.Font = MediumFont;
                itemQuantity.Tag = dr["CUST_ID"].ToString();
                itemQuantity.Tag = dr["QUANTITY"].ToString();

                //minus
                numDown = new Button();
                numDown.Text = "-";
                numDown.Width = 25;
                numDown.Height = 33;
                numDown.Font = MediumFont;
                numDown.Location = new Point(292, 35);
                numDown.Tag = dr["CUST_ID"].ToString();
                


                //add
                numUp = new Button();
                numUp.Text = "+";
                numUp.Width = 25;
                numUp.Height = 33;
                numUp.Font = MediumFont;
                numUp.Location = new Point(388, 34);
                numUp.Tag = dr["CUST_ID"].ToString();


                //NumericUpDown
                qty = new NumericUpDown();
                qty.Text = dr["QUANTITY"].ToString();
                qty.Width = 107;
                qty.Height = 28;
                qty.Font = MediumFont;
                qty.Location = new Point(301, 34);
                qty.Tag = dr["CUST_ID"].ToString();


                //set button
                set = new Button();
                set.Text = "Set";
                set.Width = 80;
                set.Height = 30;
                set.Location = new Point(435, 36);
                set.ForeColor = Color.ForestGreen;
                set.BackColor = Color.Honeydew;
                set.Font = SmallFont;
                set.Tag = dr["CUST_ID"].ToString();
                set.Tag = dr["QUANTITY"].ToString();

                //remove button
                remove = new Button();
                remove.Text = "Remove";
                remove.Width = 80;
                remove.Height = 30;
                remove.Location = new Point(516, 35);
                remove.ForeColor = Color.Maroon;
                remove.BackColor = Color.FromArgb(255, 192, 192);
                remove.Font = SmallFont;
                remove.Tag = dr["CUST_ID"].ToString();


                //add to display controls
                orderPanel.Controls.Add(cost);
                orderPanel.Controls.Add(foodItemName);
                //orderPanel.Controls.Add(itemQuantity);
                //orderPanel.Controls.Add(numDown);
                //orderPanel.Controls.Add(numUp);
                orderPanel.Controls.Add(set);
                orderPanel.Controls.Add(remove);
                orderPanel.Controls.Add(qty);
                //orderPanel.Controls.Add(qty);

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
