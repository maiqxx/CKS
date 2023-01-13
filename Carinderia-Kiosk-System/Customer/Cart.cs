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
    public partial class Cart : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        double _total = 0.0; //variable for total amount for all food items

        //setting fonts
        Font SmallFontBold = new Font("Century Gothic", 8, FontStyle.Bold);
        Font SmallFont = new Font("Century Gothic", 8);
        Font MediumFontBold = new Font("Century Gothic", 10, FontStyle.Bold);
        Font LargeFontBold = new Font("Century Gothic", 12, FontStyle.Bold);

        public Cart()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            //btnPlaceOrder.Visible = false;
            GetOrderList();
            TotalAmount();
        }

        private Panel orderPanel;
        private Label foodItemName;
        private Label cost;
        private Label quantity;
        private NumericUpDown qty;
        private Button remove;
        private TextBox finalQty;

        //Gets current orders in the cart
        void GetOrderList()
        {
            flpOrders.Controls.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT CUST_ID, FOOD_NAME, QUANTITY, UNIT_PRICE, TOTAL_AMOUNT FROM CUSTOMER WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "' ", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                //panel container
                orderPanel = new Panel();
                orderPanel.Width = 646;
                orderPanel.Height = 92;
                orderPanel.BackColor = Color.Honeydew;

                //displays food name
                foodItemName = new Label();
                foodItemName.Text = dr["FOOD_NAME"].ToString();
                foodItemName.ForeColor = Color.Black;
                foodItemName.Location = new Point(72, 19);
                foodItemName.Font = MediumFontBold;
                foodItemName.Width = 180;
                foodItemName.Tag = dr["CUST_ID"].ToString();

                //displays price
                cost = new Label();
                cost.Text = dr["UNIT_PRICE"].ToString();
                cost.Font = SmallFontBold;
                cost.ForeColor = Color.Black;
                cost.Location = new Point(72, 49);
                cost.Tag = dr["CUST_ID"].ToString();

                //quantity label
                quantity = new Label();
                quantity.Text = "Quantity:";
                quantity.Font = SmallFont;
                quantity.AutoSize = false;
                quantity.Width = 60;
                quantity.ForeColor = Color.Black;
                quantity.Location = new Point(251, 41);
                quantity.Tag = dr["CUST_ID"].ToString();


                //NumericUpDown for quantity
                qty = new NumericUpDown();
                qty.Text = dr["QUANTITY"].ToString();
                qty.Width = 90;
                qty.Height = 35;
                qty.Minimum = 0;
                qty.Maximum = 25;
                qty.Font = LargeFontBold;
                qty.TextAlign = HorizontalAlignment.Center;
                qty.Location = new Point(306, 30);
                qty.Tag = dr["CUST_ID"].ToString();


                //final quantity on textbox
                finalQty = new TextBox();
                finalQty.Text = dr["QUANTITY"].ToString();
                finalQty.Width = 65;
                finalQty.Height = 28;
                finalQty.TextAlign = HorizontalAlignment.Center;
                finalQty.Font = MediumFontBold;
                finalQty.ForeColor = Color.Black;
                finalQty.Location = new Point(320, 35);
                finalQty.Tag = dr["CUST_ID"].ToString();


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
                //orderPanel.Controls.Add(quantity);
                //orderPanel.Controls.Add(finalQty);
                orderPanel.Controls.Add(remove);

                //display controls over the flowlayout
                flpOrders.Controls.Add(orderPanel);

                //item.Cursor = Cursors.Hand;
                remove.Click += new EventHandler(Remove_OnClick);
                qty.Click += new EventHandler(UpdateQty_OnClick);
            }
            dr.Close();
            conn.Close();
        }

        //Updates food quantity
        public void UpdateQty_OnClick(object sender, EventArgs e)
        {
            String tag = ((NumericUpDown)sender).Tag.ToString();    //gets CUST_ID using tag
            var value = (((NumericUpDown)sender).Value.ToString()); //gets the value from numericUpDown controls

            try
            {
                conn.Open();
                cmd = new MySqlCommand("UPDATE CUSTOMER " +
                                        "SET QUANTITY = '" + value + "' " +
                                        "WHERE CUST_ID = '" + tag + "' ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                TotalAmount();  //to reload the total amount after updating quantity
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Remove button - to remove food item from cart
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

                RemovedFoodItemDialog removed = new RemovedFoodItemDialog();
                removed.ShowDialog();

                //MessageBox.Show("Food item removed successfully!");
                GetOrderList(); //to reload the order list after deleting
                TotalAmount();  //to reload the total amount after deleting
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Gets total amoun to be paid by the customer
        void TotalAmount()
        {
            lblTotalPrice.Controls.Clear();
            conn.Open();

            cmd = new MySqlCommand("SELECT * FROM CUSTOMER WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "'", conn);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Close();
                cmd = new MySqlCommand("SELECT SUM(QUANTITY * UNIT_PRICE) AS TOTAL FROM CUSTOMER WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                { 
                    _total = double.Parse(dr["TOTAL"].ToString());
                    lblTotalPrice.Text = "₱ " + double.Parse(_total.ToString()).ToString("#, ##0.00");
                }
                dr.Close();
                conn.Close();

            }
            conn.Close();
        }

        void DineOption()
        {
            if (checkBoxDineIn.Checked && checkBoxTakeOut.Checked)
            {
                OneDineOptionDialog oneDineOption = new OneDineOptionDialog();
                oneDineOption.ShowDialog();

                //MessageBox.Show("Choose only one method.");
                checkBoxDineIn.Checked = false;
                checkBoxTakeOut.Checked = false;
            }

        }

        //Place Order button
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //btnOrderNow.Visible = false;

            DineOption();
            //string orderStatus = "Pending";

            if (checkBoxDineIn.Checked)
            {
                string dineOption = "Dine In";

                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("INSERT INTO ORDERS " +
                                            "SET CUSTOMER_NAME = '" + CustomerInfo.Name + "', " +
                                            "TOTAL_AMOUNT = (SELECT SUM(QUANTITY * UNIT_PRICE) FROM CUSTOMER WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "'), " +
                                            "DINE_OPTION = '" + dineOption + "' ", conn);

                    int ctr = cmd.ExecuteNonQuery();
                    if (ctr > 0)
                    {
                        this.Hide();
                        PlacedOrderDialog orderSuccessfully = new PlacedOrderDialog();
                        orderSuccessfully.ShowDialog();
                        this.Close();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (checkBoxTakeOut.Checked)
            {
                string dineOption = "Take Out";

                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("INSERT INTO ORDERS " +
                                            "SET CUSTOMER_NAME = '" + CustomerInfo.Name + "', " +
                                            "TOTAL_AMOUNT = (SELECT SUM(QUANTITY * UNIT_PRICE) FROM CUSTOMER WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "'), " +
                                            "DINE_OPTION = '" + dineOption + "' ", conn);

                    int ctr = cmd.ExecuteNonQuery();
                    if (ctr > 0)
                    {
                        this.Hide();
                        PlacedOrderDialog orderSuccessfully = new PlacedOrderDialog();
                        orderSuccessfully.ShowDialog();
                        this.Close();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (!checkBoxDineIn.Checked && checkBoxTakeOut.Checked)
            {
                ChooseDineOptionDialog chooseDineOption = new ChooseDineOptionDialog();
                chooseDineOption.ShowDialog();

                //MessageBox.Show("Choose only one method.");
                //checkBoxDineIn.Checked = false;
                //checkBoxTakeOut.Checked = false;
            }
            conn.Close();
        }

        void RemoveRecord()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("DELETE * FROM CUSTOMER ", conn);

                int ctr = cmd.ExecuteNonQuery();
                if (ctr > 0)
                {
                    PlacedOrderDialog orderSuccessfully = new PlacedOrderDialog();
                    orderSuccessfully.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //arrow back to menu
        private void pbBackToMenu_Click(object sender, EventArgs e)
        {
            MenuBoard menuBoard = new MenuBoard();
            menuBoard.Show();
            this.Hide();
        }

        //Back to menu button - add more food item
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            MenuBoard menuBoard = new MenuBoard();
            menuBoard.Show();
            this.Hide();
        }

        private void pbCart_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            CustomerInputName inputName = new CustomerInputName();
            inputName.ShowDialog();

            btnPlaceOrder.Visible = true;
        }
    }
}
