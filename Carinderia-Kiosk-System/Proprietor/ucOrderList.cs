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
using Carinderia_Kiosk_System.Properties;
using MySql.Data.MySqlClient;

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucOrderList : UserControl
    {
        private static ucOrderList instance;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public static ucOrderList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucOrderList();

                }
                return instance;
            }
        }

        public ucOrderList()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void ucOrderList_Load(object sender, EventArgs e)
        {
            GetOrderList();
            pnlDetails.Visible = false;
        }

        //setting fonts
        Font SmallFontBold = new Font("Century Gothic", 9, FontStyle.Bold);
        Font SmallFont = new Font("Century Gothic", 8);
        Font MediumFontBold = new Font("Century Gothic", 10, FontStyle.Bold);
        Font LargeFontBold = new Font("Century Gothic", 12, FontStyle.Bold);

        //declaring components
        private Panel orderListPanel;
        private Label orderID;
        private Label customerName;
        private Label totalAmount;
        private Label dineOption;
        private ComboBox orderStatus;
        private PictureBox deleteIcon;

        //gets the list of orders from database and display to flowlayoutpanel
        void GetOrderList()
        {
            flpOrderList.Controls.Clear();

            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM ORDERS ", conn);
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
                deleteIcon.Image = Resources.remove_16x16;
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


        //displays the details of orders  when a specified orderListPanel is being cicked
        public void orderListPanel_OnClick(object sender, EventArgs e)
        {
            String tag = ((Panel)sender).Tag.ToString();
            flpDetailedOrders.Controls.Clear();
            pnlDetails.Visible = true;
            btnConfirmSold.Visible = false;

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

                if (lblOrderStatus.Text == "Completed")
                {
                    btnConfirmSold.Visible = true;

                    //UpdateInventory();

                }
                else
                {
                    //do nothing...
                }

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

        //When order status is changed
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

            try
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO TRANSACTION (ORDER_ID, CUSTOMER_NAME, DINE_OPTION, TOTAL_AMOUNT, STATUS) " +
                                        "(SELECT ORDER_ID, CUSTOMER_NAME, DINE_OPTION, TOTAL_AMOUNT, ORDER_STATUS FROM ORDERS WHERE ORDER_ID = '"+ tag+"') ", conn);

                int ctr = cmd.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Moved to transactions!");
                }
                else
                {
                    conn.Close();
                }

                cmd = new MySqlCommand("DELETE * FROM ORDERS WHERE ORDER_ID = '" + tag + "' ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                GetOrderList();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmSold_Click(object sender, EventArgs e)
        {
            UpdateInventory();
        }

        /// <summary>
        /// HERE'S MY ATTEMPT IN UPDATING INVENTORY STOCK_QUANTITY
        /// </summary>

        void UpdateInventory()
        {
            try
            {
                var arrayList1 = new ArrayList();
                bool updated = false;

                conn.Open();
                cmd = new MySqlCommand("SELECT QUANTITY, STOCK_QUANTITY, STOCK_NAME AS FOOD_ITEM FROM CUSTOMER, INVENTORY WHERE CUSTOMER.STOCK_NAME = INVENTORY.FOOD_ITEM ", conn);
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

                    
                }

                for (int i = 0; i < arrayList1.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        var foodName = arrayList1[i];
                        var updatedQty = arrayList1[i + 1];

                        cmd = new MySqlCommand("UPDATE INVENTORY SET STOCK_QUANTY = '" + updatedQty + "' WHERE STOCK_NAME = '" + foodName + "' ", conn);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            var updatedStock = dr["STOCK_QUANTY"];
                            MessageBox.Show("Stock updated!");
                        }
                    }
                    updated = true;
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


            //conn.Open();
            //cmd = new MySqlCommand("SELECT * FROM CUSTOMERS WHERE CUSTOMER_NAME = '" + lblCustomer.Text + "' ", conn);
            //dr = cmd.ExecuteReader();

            //if (dr.Read())
            //{
            //    var quantity = Convert.ToInt32(dr["QUANTITY"]);
            //    var foodName = dr["STOCK_NAME"].ToString();

            //    // Update stock quantity in inventory
            //    cmd = new MySqlCommand("UPDATE INVENTOTY SET STOCK_QUANTITY = STOCK_QUANTITY - '" + quantity + "' " +
            //                          "WHERE STOCK_NAME = '" + foodName + "' ", conn);
            //    cmd.ExecuteNonQuery();
            //}
            //dr.Close();
            //conn.Close();


            //conn.Open();
            //MySqlCommand cmd = new MySqlCommand("UPDATE inventory SET quantity = quantity - @quantity WHERE id = @id");
            //cmd.Prepare();

            //foreach (var item in items)
            //{
            //    cmd.Parameters.Clear();
            //    cmd.Parameters.AddWithValue("@quantity", item.Quantity);
            //    cmd.Parameters.AddWithValue("@id", item.Id);
            //    cmd.ExecuteNonQuery();
            //}
            //conn.Close();
        }

        //hover event
        public void orderListPanel_MouseHover(object sender, EventArgs e)
        {
           // String tag = ((Panel)sender).Tag.ToString();
           orderListPanel.BackColor = Color.WhiteSmoke;
        }


        private void btnRecordToInvoice_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                // Record to INVOICE table
                cmd = new MySqlCommand("INSERT INTO INVOICE " +
                                        "SET CUSTOMER_NAME = '" + lblCustomer.Text + "', " +
                                        "STOCK_NAME = (SELECT STOCK_NAME FROM CUSTOMER WHERE CUSTOMER_NAME = '" + lblCustomer.Text + "'), " +
                                        "QUANTITY = (SELECT QUANTITY FROM CUSTOMER WHERE CUSTOMER_NAME = '" + lblCustomer.Text + "'), " +
                                        "UNIT_PRICE = (SELECT UNIT_PRICE FROM CUSTOMER WHERE CUSTOMER_NAME = '" + lblCustomer.Text + "')," +
                                        "TOTAL_AMOUNT = (SELECT TOTAL_AMOUNT FROM ORDERS WHERE ORDER_ID = '" + lblOrderNum.Text + "')," +
                                        "DINE_OPTION = (SELECT DINE_OPTION FROM ORDERS WHERE ORDER_ID = '" + lblOrderNum.Text + "')," +
                                        "ORDER_ID = (SELECT ORDER_ID FROM ORDERS WHERE ORDER_ID = '" + lblOrderNum.Text + "') ", conn);

                cmd.ExecuteNonQuery();
                conn.Close();

                // UpdateInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sad, wa na record.");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// lists orders of the specific customer - using datagridview [this is an alternative way]
        /// </summary>

        void GetOrders()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT FOOD_NAME, QUANTITY, UNIT_PRICE FROM CUSTOMER WHERE CUSTOMER_NAME = '" + lblCustomer.Text.Trim() + "'", conn);
                adapter.Fill(dt);

                //Set the column header style.
                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.SteelBlue;
                columnHeaderStyle.ForeColor = Color.White;
                columnHeaderStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);

                //dgvInventory properties
                //dgvOrderList.RowTemplate.Height = 35;
                //dgvOrderList.AllowUserToAddRows = false;

                //dgvOrderList.DataSource = dt;
                //dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                ////Column header names
                //dgvOrderList.Columns[0].HeaderText = "Food Name";
                //dgvOrderList.Columns[1].HeaderText = "Quantity";
                //dgvOrderList.Columns[2].HeaderText = "Unit Price";
                //dgvOrderList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


                //DataRow dr = dt.Rows[i];
                //ListViewItem listitem = new ListViewItem(dr["STOCK_NAME"].ToString());
                //    listitem.SubItems.Add(dr["QUANTITY"].ToString());
                //    listitem.SubItems.Add(dr["UNIT_PRICE"].ToString());
                //    lvCustomerOrderList.Items.Add(listitem);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


    }
}
