using Carinderia_Kiosk_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucCompletedOrders : UserControl
    {
        private static ucCompletedOrders instance;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public static ucCompletedOrders Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucCompletedOrders();
                }
                return instance;
            }
        }

        //setting fonts
        Font SmallFontBold = new Font("Century Gothic", 9, FontStyle.Bold);
        Font SmallFont = new Font("Century Gothic", 8);
        Font MediumFontBold = new Font("Century Gothic", 10, FontStyle.Bold);
        Font LargeFontBold = new Font("Century Gothic", 12, FontStyle.Bold);

        public ucCompletedOrders()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void ucCompletedOrders_Load(object sender, EventArgs e)
        {
            GetOrderList();
            pnlDetails.Visible = false;
        }

        //declaring components
        private Panel orderListPanel;
        private Label orderID;
        private Label customerName;
        private Label totalAmount;
        private Label dineOption;
        private ComboBox orderStatus;
        private PictureBox deleteIcon;
        private TextBox status;

        //gets the list of orders from database and display to flowlayoutpanel
        void GetOrderList()
        {
            flpOrderList.Controls.Clear();

            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM ORDERS WHERE ORDER_STATUS = '"+"Completed"+"' ", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //panel container
                orderListPanel = new Panel();
                orderListPanel.Width = 850;
                orderListPanel.Height = 55;
                orderListPanel.BackColor = Color.White;
                orderListPanel.Tag = dr["ORDER_ID"].ToString();

                //displays order ID
                orderID = new Label();
                orderID.Text = dr["ORDER_ID"].ToString();
                orderID.ForeColor = Color.Black;
                orderID.Location = new Point(25, 22);
                orderID.Font = MediumFontBold;
                orderID.Tag = dr["ORDER_ID"].ToString();

                //displays customer's name
                customerName = new Label();
                customerName.Text = dr["CUSTOMER_NAME"].ToString();
                customerName.ForeColor = Color.Black;
                customerName.Location = new Point(140, 18);
                customerName.Font = MediumFontBold;
                customerName.Tag = dr["ORDER_ID"].ToString();

                //displays total amount
                totalAmount = new Label();
                totalAmount.Text = "₱ " + dr["TOTAL_AMOUNT"].ToString();
                totalAmount.ForeColor = Color.Black;
                totalAmount.TextAlign = ContentAlignment.MiddleCenter;
                totalAmount.Location = new Point(333, 18);
                totalAmount.Font = MediumFontBold;
                totalAmount.Tag = dr["ORDER_ID"].ToString();

                //displays dine option
                dineOption = new Label();
                dineOption.Text = dr["DINE_OPTION"].ToString();
                dineOption.ForeColor = Color.Black;
                dineOption.Location = new Point(505, 18);
                dineOption.Font = MediumFontBold;
                dineOption.Tag = dr["ORDER_ID"].ToString();

                //displays order status COMBOBOX
                orderStatus = new ComboBox();
                orderStatus.Text = dr["ORDER_STATUS"].ToString();
                orderStatus.ForeColor = Color.Black;
                orderStatus.Location = new Point(650, 15);
                orderStatus.Font = MediumFontBold;
                orderStatus.Tag = dr["ORDER_ID"].ToString();
                orderStatus.Items.Add("Pending");
                orderStatus.Items.Add("Completed");
                orderStatus.Items.Add("Cancelled");

                //displays order status
                status = new TextBox();
                status.Text = dr["ORDER_STATUS"].ToString();
                status.ForeColor = Color.Black;
                status.BackColor = Color.Honeydew;
                status.Location = new Point(650, 15);
                status.Font = MediumFontBold;
                status.Tag = dr["ORDER_ID"].ToString();

                //delete icon
                deleteIcon = new PictureBox();
                deleteIcon.Image = Resources.move_folder_25x19;
                deleteIcon.SizeMode = PictureBoxSizeMode.CenterImage;
                deleteIcon.Location = new Point(765, 3);
                deleteIcon.Tag = dr["ORDER_ID"].ToString();

                //add to display controls in orderListPanel
                orderListPanel.Controls.Add(orderID);
                orderListPanel.Controls.Add(customerName);
                orderListPanel.Controls.Add(totalAmount);
                orderListPanel.Controls.Add(dineOption);
                orderListPanel.Controls.Add(status);
                orderListPanel.Controls.Add(deleteIcon);

                //add to display controls dynamically in flowlayout
                flpOrderList.Controls.Add(orderListPanel);

                //Turns hand cursor when hovered
                orderListPanel.Cursor = Cursors.Hand;

                //click events
                orderListPanel.Click += new EventHandler(orderListPanel_OnClick);
                //orderListPanel.MouseHover += new EventHandler(orderListPanel_MouseHover);
                //orderStatus.SelectedIndexChanged += new EventHandler(orderStatus_SelectedIndexChanged);
                //deleteIcon.Click += new EventHandler(RemoveFromOrderlist_OnClick);

            }
            dr.Close();
            conn.Close();
        }


        //displays the details of orders  when a specified orderListPanel is being cicked
        public void orderListPanel_OnClick(object sender, EventArgs e)
        {
            String tag = ((Panel)sender).Tag.ToString();
            flpDetailedOrders.Controls.Clear();
            pnlDetails.Visible = true;
            //btnConfirmSold.Visible = false;

            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM ORDERS WHERE ORDER_ID LIKE '" + tag + "' ", conn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblOrderNum.Text = dr["ORDER_ID"].ToString();
                    lblCustomer.Text = dr["CUSTOMER_NAME"].ToString();
                    lblDateTime.Text = dr["CREATED_AT"].ToString();
                    lblOption.Text = dr["DINE_OPTION"].ToString();
                    lblOrderStatus.Text = dr["ORDER_STATUS"].ToString();
                    lblTotalPayment.Text = "₱ " + dr["TOTAL_AMOUNT"].ToString();
                }
                dr.Close();
                conn.Close();

                //GetOrders();
                GetDetailedOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
        }

        private Panel order;
        private Label product;
        private Label qty;
        private Label price;

        //lists orders of the specific customer - using flowlayoutpanel
        void GetDetailedOrders()
        {
            //pnlDetails.Controls.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT FOOD_NAME, QUANTITY, UNIT_PRICE FROM CUSTOMER WHERE CUSTOMER_NAME = '" + lblCustomer.Text.Trim() + "' ", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //panel container
                order = new Panel();
                order.Width = 332;
                order.Height = 50;
                order.BackColor = Color.WhiteSmoke;
                order.Tag = dr["FOOD_NAME"].ToString();

                //displays food name
                product = new Label();
                product.Text = dr["FOOD_NAME"].ToString();
                product.ForeColor = Color.Black;
                product.Location = new Point(3, 16);
                product.Font = MediumFontBold;
                product.Tag = dr["FOOD_NAME"].ToString();

                //displays quantity
                qty = new Label();
                qty.Text = dr["QUANTITY"].ToString();
                qty.ForeColor = Color.Black;
                qty.Location = new Point(175, 16);
                qty.Font = MediumFontBold;
                qty.Tag = dr["FOOD_NAME"].ToString();

                //displays price
                price = new Label();
                price.Text = "₱ " + dr["UNIT_PRICE"].ToString();
                price.ForeColor = Color.Black;
                price.TextAlign = ContentAlignment.MiddleRight;
                price.Location = new Point(230, 16);
                price.Font = MediumFontBold;
                price.Tag = dr["FOOD_NAME"].ToString();

                //add to display controls in a panel
                order.Controls.Add(product);
                order.Controls.Add(qty);
                order.Controls.Add(price);

                //add to display controls dynamically in flowlayout
                flpDetailedOrders.Controls.Add(order);
            }
            //flpDetailedOrders.Controls.Clear();
            dr.Close();
            conn.Close();
        }

        //Updates order status when changed in combobox
        private void orderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tag = ((ComboBox)sender).Tag.ToString();    //gets ORDER_ID using tag
            var newStat = (((ComboBox)sender).SelectedItem.ToString()); //gets the selected item from combobox 

            try
            {
                conn.Open();
                cmd = new MySqlCommand("UPDATE ORDERS SET ORDER_STATUS = '" + newStat + "' WHERE ORDER_ID = '" + tag + "' ", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order status updated to " + newStat);
                conn.Close();
                GetDetailedOrders(); //reloads details
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Removes order from order list and move to Transactions
        public void RemoveFromOrderlist_OnClick(object sender, EventArgs e)
        {
            String tag = ((PictureBox)sender).Tag.ToString();

            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                //Recorders transaction
                cmd = new MySqlCommand("INSERT INTO TRANSACTION (ORDER_ID, CUSTOMER_NAME, DINE_OPTION, TOTAL_AMOUNT, STATUS) " +
                                        "(SELECT ORDER_ID, CUSTOMER_NAME, DINE_OPTION, TOTAL_AMOUNT, ORDER_STATUS FROM ORDERS WHERE ORDER_ID = '" + tag + "') ", conn);

                int ctr = cmd.ExecuteNonQuery();
                if (ctr > 0)
                {
                    //MoveToTrasactsDialog move = new MoveToTrasactsDialog();
                    //move.ShowDialog();

                    cmd = new MySqlCommand("DELETE FROM ORDERS WHERE ORDER_ID = '" + tag + "' ", conn);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                else
                {
                    conn.Close();
                }
                conn.Close();
                GetOrderList();
            }
            catch (Exception ex)
            {
                //transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
        }

        //updates order status
        private void btnConfirmSold_Click(object sender, EventArgs e)
        {
            string newStat = "Completed";
            conn.Open();
            cmd = new MySqlCommand("UPDATE ORDERS SET ORDER_STATUS = '" + newStat + "' WHERE ORDER_ID = '" + lblOrderNum.Text + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order status updated to " + newStat);
            conn.Close();
            UpdateInventory();
        }

        //updates stock quantity in inventory
        void UpdateInventory()
        {
            try
            {
                var arrayList1 = new ArrayList();
               // bool updated = false;

                conn.Open();
                cmd = new MySqlCommand("SELECT QUANTITY, STOCK_QUANTITY, STOCK_NAME FROM CUSTOMER, INVENTORY WHERE CUSTOMER.FOOD_NAME = INVENTORY.STOCK_NAME ", conn);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //List<Tuple<string, int>> results = new List<Tuple<string, int>>();
                    while (dr.Read())
                    {
                        string foodName = dr["STOCK_NAME"].ToString();
                        int orderQty = Convert.ToInt32(dr["QUANTITY"]);
                        int stockQty = Convert.ToInt32(dr["STOCK_QUANTITY"]);
                        int updatedQty = stockQty - orderQty;

                        //results.Add(new Tuple<string, int>(foodName, updatedQty));
                        var arrayList2 = new ArrayList()
                        {
                            foodName, updatedQty
                        };
                        arrayList1.AddRange(arrayList2);
                    }
                    dr.Close();
                }
                dr.Close();

                for (int i = 0; i < arrayList1.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        var foodName = arrayList1[i];
                        var updatedQty = arrayList1[i + 1];

                        cmd = new MySqlCommand("UPDATE INVENTORY SET STOCK_QUANTITY = '" + updatedQty + "' WHERE STOCK_NAME = '" + foodName + "' ", conn);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            var updatedStock = dr["STOCK_QUANTITY"];
                            lblOrderStatus.Text = "Completed";
                            //MessageBox.Show("Stock updated!");
                        }
                        dr.Close();
                    }
                    //updated = true;
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("di ma update ang stocks");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //Textbox search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetSearchedOrder();

            if (txtSearch.Text == "")
            {
                GetOrderList();
            }
        }

        void GetSearchedOrder()
        {
            flpOrderList.Controls.Clear();

            conn.Open();
            cmd = new MySqlCommand("SELECT ORDER_ID, CUSTOMER_NAME, TOTAL_AMOUNT, DINE_OPTION, ORDER_STATUS FROM ORDERS WHERE ORDER_ID LIKE '" + txtSearch.Text + "' ORDER BY ORDER_ID ", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //panel container
                orderListPanel = new Panel();
                orderListPanel.Width = 850;
                orderListPanel.Height = 55;
                orderListPanel.BackColor = Color.White;
                orderListPanel.Tag = dr["ORDER_ID"].ToString();

                //displays order ID
                orderID = new Label();
                orderID.Text = dr["ORDER_ID"].ToString();
                orderID.ForeColor = Color.Black;
                orderID.Location = new Point(25, 22);
                orderID.Font = MediumFontBold;
                orderID.Tag = dr["ORDER_ID"].ToString();

                //displays customer's name
                customerName = new Label();
                customerName.Text = dr["CUSTOMER_NAME"].ToString();
                customerName.ForeColor = Color.Black;
                customerName.Location = new Point(140, 18);
                customerName.Font = MediumFontBold;
                customerName.Tag = dr["ORDER_ID"].ToString();

                //displays total amount
                totalAmount = new Label();
                totalAmount.Text = "₱ " + dr["TOTAL_AMOUNT"].ToString();
                totalAmount.ForeColor = Color.Black;
                totalAmount.TextAlign = ContentAlignment.MiddleCenter;
                totalAmount.Location = new Point(333, 18);
                totalAmount.Font = MediumFontBold;
                totalAmount.Tag = dr["ORDER_ID"].ToString();

                //displays dine option
                dineOption = new Label();
                dineOption.Text = dr["DINE_OPTION"].ToString();
                dineOption.ForeColor = Color.Black;
                dineOption.Location = new Point(505, 18);
                dineOption.Font = MediumFontBold;
                dineOption.Tag = dr["ORDER_ID"].ToString();

                //displays order status
                orderStatus = new ComboBox();
                orderStatus.Text = dr["ORDER_STATUS"].ToString();
                orderStatus.ForeColor = Color.Black;
                orderStatus.Location = new Point(650, 15);
                orderStatus.Font = MediumFontBold;
                orderStatus.Tag = dr["ORDER_ID"].ToString();
                orderStatus.Items.Add("Pending");
                orderStatus.Items.Add("Completed");
                orderStatus.Items.Add("Cancelled");

                //delete icon
                deleteIcon = new PictureBox();
                deleteIcon.Image = Resources.move_folder_25x19;
                deleteIcon.SizeMode = PictureBoxSizeMode.CenterImage;
                deleteIcon.Location = new Point(765, 3);
                deleteIcon.Tag = dr["ORDER_ID"].ToString();

                //add to display controls in orderListPanel
                orderListPanel.Controls.Add(orderID);
                orderListPanel.Controls.Add(customerName);
                orderListPanel.Controls.Add(totalAmount);
                orderListPanel.Controls.Add(dineOption);
                orderListPanel.Controls.Add(orderStatus);
                orderListPanel.Controls.Add(deleteIcon);

                //add to display controls dynamically in flowlayout
                flpOrderList.Controls.Add(orderListPanel);

                //Turns hand cursor when hovered
                orderListPanel.Cursor = Cursors.Hand;

                //click events
                orderListPanel.Click += new EventHandler(orderListPanel_OnClick);
                orderListPanel.MouseHover += new EventHandler(orderListPanel_MouseHover);
                orderStatus.SelectedIndexChanged += new EventHandler(orderStatus_SelectedIndexChanged);
                deleteIcon.Click += new EventHandler(RemoveFromOrderlist_OnClick);

            }
            dr.Close();
            conn.Close();
        }

        //hover event
        public void orderListPanel_MouseHover(object sender, EventArgs e)
        {
            // String tag = ((Panel)sender).Tag.ToString();
            orderListPanel.BackColor = Color.WhiteSmoke;
        }

    }
}
