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
using Carinderia_Kiosk_System.Customer.CustomerDialogs;

namespace Carinderia_Kiosk_System.Customer
{
    public partial class MenuBoard : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        double _total = 0.0; //variable for total amount for all food items

        //setting fonts
        Font SmallFont = new Font("Century Gothic", 8, FontStyle.Bold);
        Font MediumFont = new Font("Century Gothic", 10, FontStyle.Bold);
        Font LargeFont = new Font("Century Gothic", 12, FontStyle.Bold);

        public MenuBoard()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void MenuBoard_Load(object sender, EventArgs e)
        {
            GetUniqueID();
            GetData();
            SelectCategory();
            GetOrderList();
            TotalAmount();
            pnlUserControlFoodItemHolder.Visible = false;
        }

        //gets and sets CUST_ID
        void GetUniqueID()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM CUSTOMER", conn);
                dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    //set CUST_ID to CustomerInfo.ID
                    CustomerInfo.ID = int.Parse(dr["CUST_ID"].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private PictureBox item;
        private Label price;
        private Label foodName;

        //gets data from database to be displayed on flowlayoutpanel
        private void GetData()
        {
            flpMenuItems.Controls.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT STOCK_ID, STOCK_NAME, PRICE, IMAGE FROM INVENTORY WHERE STOCK_NAME LIKE '" + txtSearchFoodItem.Text + "%' ORDER BY STOCK_NAME", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //cast dr["IMAGE"] as byte[] 
                byte[] array = (byte[])dr["IMAGE"];

                //set food item design format
                item = new PictureBox();
                item.Width = 200;
                item.Height = 200;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.Tag = dr["STOCK_ID"].ToString(); //test to display stock ID when OnClick

                //displays price
                price = new Label();
                price.Text = "₱ " + double.Parse(dr["PRICE"].ToString()).ToString("#, ##0.00");
                price.BackColor = Color.FromArgb(39, 174, 96);
                price.ForeColor = Color.FromArgb(236, 240, 241);
                price.Font = MediumFont;
                price.TextAlign = ContentAlignment.MiddleCenter;
                //price.Dock = DockStyle.Bottom;
                price.Tag = dr["STOCK_ID"].ToString(); //test to display stock ID when OnClick

                //displays food name
                foodName = new Label();
                foodName.Text = dr["STOCK_NAME"].ToString();
                foodName.BackColor = Color.FromArgb(236, 240, 241);
                foodName.Font = MediumFont;
                foodName.TextAlign = ContentAlignment.MiddleCenter;
                foodName.Dock = DockStyle.Bottom;
                foodName.Tag = dr["STOCK_ID"].ToString(); //test to display stock ID when OnClick

                //gets image from database
                MemoryStream ms = new MemoryStream(array);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
                item.BackgroundImage = bitmap;

                //add to display controls
                item.Controls.Add(price);
                item.Controls.Add(foodName);
                flpMenuItems.Controls.Add(item);

                item.Cursor = Cursors.Hand;
                item.Click += new EventHandler(OnClick);
            }
            dr.Close();
            conn.Close();
        }

        //Food item OnClick Event
        public void OnClick(object sender, EventArgs e)
        {
            //MessageBox.Show(((PictureBox)sender).Tag.ToString()); //test get stock ID

            pnlUserControlFoodItemHolder.Visible = true;
            String tag = ((PictureBox)sender).Tag.ToString();

            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM INVENTORY WHERE STOCK_ID LIKE '" + tag + "' ", conn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //_total += double.Parse(dr["PRICE"].ToString());
                    //dataGridview1.Rows.Add(dataGridView1.Rows.Count + 1, dr["FOOD_NAME"].ToString(), double.Parse(dr["PRICE"].ToString()).ToString("#, ##0.00"));

                    //gets image from database
                    byte[] array = (byte[])dr["IMAGE"];
                    MemoryStream ms = new MemoryStream(array);
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
                    pbFoodImage.BackgroundImageLayout = ImageLayout.Stretch;
                    pbFoodImage.BackgroundImage = bitmap;

                    lblFoodName.Text = dr["STOCK_NAME"].ToString();
                    lblUnitPrice.Text = double.Parse(dr["PRICE"].ToString()).ToString("#, ##0.00");
                    lblUnit.Text = dr["UNIT"].ToString();
                    lblDesc.Text = dr["DESCRIPTION"].ToString();
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //Add To Cart button
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string foodname = lblFoodName.Text;
            double unitPrice = double.Parse(lblUnitPrice.Text);
            int quantity = Convert.ToInt32(Math.Round(NUPTxtQuantity.Value, 0));
            double totalAmount = unitPrice * quantity;

            try
            {
                if (quantity <= 0)
                {
                    SpecifyQuantityDialog specifyQuantity = new SpecifyQuantityDialog();
                    specifyQuantity.ShowDialog();

                    //MessageBox.Show("Please specify the quantity.");
                }
                else
                {
                    conn.Open();

                    cmd = new MySqlCommand("SELECT * FROM CUSTOMER WHERE FOOD_NAME = '" + foodname + "' AND CUSTOMER_NAME = '"+ CustomerInfo.Name.Trim() +"' ", conn);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        OnCartDialog onCart = new OnCartDialog();
                        onCart.ShowDialog();

                        //MessageBox.Show("Food item is already in order list. Check your cart!");
                        dr.Close();
                    }
                    else
                    {
                        dr.Close();

                        cmd = new MySqlCommand("INSERT INTO CUSTOMER SET CUSTOMER_NAME = '"+ CustomerInfo.Name +"', FOOD_NAME = @foodName,  UNIT_PRICE = @unitPrice, QUANTITY = @quantity, TOTAL_AMOUNT = @total ", conn);

                        cmd.Parameters.AddWithValue("@foodName", foodname);
                        cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@total", totalAmount);
         
                        int ctr = cmd.ExecuteNonQuery();

                        if (ctr > 0)
                        {
                            //MessageBox.Show("Added successfully!");
                            AddedToCartDialog added = new AddedToCartDialog();
                            added.ShowDialog();
                            SetCustomer(); //sets every food item with customer's name
                        }
                        dr.Close();
                        conn.Close();
                    }
                    dr.Close();
                    conn.Close();
                    TotalAmount();
                    GetOrderList();
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //sets every food item with customer's name
        void SetCustomer()
        {
            GetUniqueID(); 

            try
            {
                conn.Open();
                cmd = new MySqlCommand("UPDATE CUSTOMER SET CUSTOMER_NAME = '"+ CustomerInfo.Name +"' WHERE CUST_ID = '" + CustomerInfo.ID + "'", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("naa kos try-catch block sa set customer");
                //MessageBox.Show(ex.Message);
            }
        }

        //Gets total amoun to be paid by the customer
        void TotalAmount()
        {
            lblTotalPrice.Controls.Clear();
           
            try
            {
                conn.Open();

                cmd = new MySqlCommand("SELECT * FROM CUSTOMER WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "'", conn);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Close();
                    cmd = new MySqlCommand("SELECT SUM(QUANTITY * UNIT_PRICE) AS TOTAL FROM CUSTOMER WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "' ", conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    if (dr.HasRows)
                    {
                        _total = Convert.ToDouble(dr["TOTAL"]);
                        lblTotalPrice.Text = "₱ " + double.Parse(_total.ToString()).ToString("#, ##0.00");
                    }
                    else
                    {
                        lblTotalPrice.Text = "₱ 0.00";
                    }
                    dr.Close();
                    conn.Close();
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("naa kos try-catch block sa total amount");
                MessageBox.Show(ex.Message);
            }
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
            lblNoOrders.Visible = false;

            flpOrderListContainer.Controls.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT CUST_ID, FOOD_NAME, QUANTITY, UNIT_PRICE, TOTAL_AMOUNT FROM CUSTOMER WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "'", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                

                orderPanel = new Panel();
                orderPanel.Width = 523;
                orderPanel.Height = 87;
                orderPanel.BackColor = Color.White;

                //displays price
                cost = new Label();
                cost.Text = dr["UNIT_PRICE"].ToString();
                cost.Font = SmallFont;
                cost.ForeColor = Color.Black;
                cost.Location = new Point(33, 48);
                cost.Tag = dr["CUST_ID"].ToString();

                //displays food name
                foodItemName = new Label();
                foodItemName.Text = dr["FOOD_NAME"].ToString();
                foodItemName.ForeColor = Color.Black;
                foodItemName.Location = new Point(33, 20);
                foodItemName.Width = 180;
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

                flpOrderListContainer.Controls.Add(orderPanel);

                //item.Cursor = Cursors.Hand;
                remove.Click += new EventHandler(Remove_OnClick);
                //qty.ValueChanged += new EventHandler(Quantity_ValueChanged);
            }
            dr.Close();
            conn.Close();
            TotalAmount();
        }

        //Remove button
        public void Remove_OnClick(object sender, EventArgs e)
        {
            String tag = ((Button)sender).Tag.ToString();

            try
            {
                conn.Open();

                //Deletes the selected food item
                cmd = new MySqlCommand("DELETE FROM CUSTOMER WHERE CUST_ID LIKE '" + tag + "' AND CUSTOMER_NAME = '" + CustomerInfo.Name + "'  ", conn);

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
                MessageBox.Show("naa kos try-catch block sa Remove");
                MessageBox.Show(ex.Message);
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            StartUp startUp = new StartUp();
            startUp.Show();
            this.Hide();
        }

        //Opens Cart form to view current orders
        private void pbCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        //Search Food Item 
        private void txtSearchFoodItem_TextChanged(object sender, EventArgs e)
        {
            //displays the searched food item
            GetData();
        }

        //Gets category values for combobox for filtering food items
        void SelectCategory()
        {
            cbMenuCategoriesFilter.Items.Add("All");

            try
            {
                conn.Open();
                string selectCategory = "SELECT CATEGORY FROM cks_db.CATEGORY_TBL";
                MySqlCommand cmd = new MySqlCommand(selectCategory, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string category = reader.GetString("CATEGORY");
                    cbMenuCategoriesFilter.Items.Add(category);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This code is identical to GetData() method, but this acts as filtering food items by category
        void DisplayByCategory()
        {
            flpMenuItems.Controls.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT STOCK_ID, STOCK_NAME, PRICE, IMAGE FROM INVENTORY WHERE CATEGORY LIKE '" + cbMenuCategoriesFilter.Text + "%' ORDER BY STOCK_NAME", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //cast dr["IMAGE"] as byte[] 
                byte[] array = (byte[])dr["IMAGE"];

                //set food item design format
                item = new PictureBox();
                item.Width = 200;
                item.Height = 200;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.Tag = dr["STOCK_ID"].ToString(); //test to display stock ID when OnClick

                //displays price
                price = new Label();
                price.Text = "₱ " + double.Parse(dr["PRICE"].ToString()).ToString("#, ##0.00");
                price.BackColor = Color.FromArgb(39, 174, 96);
                price.ForeColor = Color.FromArgb(236, 240, 241);
                price.Font = MediumFont;
                price.TextAlign = ContentAlignment.MiddleCenter;
                //price.Dock = DockStyle.Bottom;
                price.Tag = dr["STOCK_ID"].ToString(); //test to display stock ID when OnClick

                //displays food name
                foodName = new Label();
                foodName.Text = dr["STOCK_NAME"].ToString();
                foodName.BackColor = Color.FromArgb(236, 240, 241);
                foodName.Font = MediumFont;
                foodName.TextAlign = ContentAlignment.MiddleCenter;
                foodName.Dock = DockStyle.Bottom;
                foodName.Tag = dr["STOCK_ID"].ToString(); //test to display stock ID when OnClick

                //gets image from database
                MemoryStream ms = new MemoryStream(array);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
                item.BackgroundImage = bitmap;

                //add to display controls
                item.Controls.Add(price);
                item.Controls.Add(foodName);
                flpMenuItems.Controls.Add(item);

                item.Cursor = Cursors.Hand;
                item.Click += new EventHandler(OnClick); //calls Onclick Event

                //item.Click += (sender, e) => OnClick(this, e, item.Tag.ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void cbMenuCategoriesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display filtered food items
            DisplayByCategory();

            if (cbMenuCategoriesFilter.Text.Equals("All"))
            {
                GetData();
            }
        }

        private void flpMenuItems_Paint(object sender, PaintEventArgs e)
        {
            GetOrderList(); //Loads current orders in a flowlayoutpanel
        }

        //Cart button - redirects to Cart form
        private void btnGoToCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }
    }
}
