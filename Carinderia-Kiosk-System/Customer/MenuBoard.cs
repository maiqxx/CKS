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
    public partial class MenuBoard : Form
    {
        //Database connection
        //MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        double _total;
        private PictureBox item;
        private Label price;
        private Label foodName;

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
            GetData();

            pnlUserControlFoodItemHolder.Visible = false;

            //displays category items to menu strip
            //LoadCategoryItems();

        }

        //gets data from database to be displayed on flowlayoutpanel
        private void GetData()
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT STOCK_ID, FOOD_NAME, PRICE, IMAGE FROM INVENTORY", conn);
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
                foodName.Text = dr["FOOD_NAME"].ToString();
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

                //item.Click += (sender, e) => OnClick(this, e, item.Tag.ToString());
                //price.Click += (sender, e) => OnClick(this, e, price.Tag.ToString());
                //foodName.Click += (sender, e) => OnClick(this, e, foodName.Tag.ToString());

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

                lblFoodName.Text = dr["FOOD_NAME"].ToString();
                lblUnitPrice.Text = double.Parse(dr["PRICE"].ToString()).ToString("#, ##0.00");
                lblUnit.Text = dr["UNIT"].ToString();
                lblDesc.Text = dr["DESCRIPTION"].ToString();
            }
            dr.Close();
            conn.Close();


        }

        //Add To Cart button
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string foodname = lblFoodName.Text;
            double unitPrice = double.Parse(lblUnitPrice.Text);
            int quantity = Convert.ToInt32(Math.Round(NUPTxtQuantity.Value, 0));

            try
            {
                conn.Open();

                cmd = new MySqlCommand("SELECT * FROM CUSTOMER WHERE FOOD_NAME = '" + foodname + "' ", conn);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Food item is already in order list.");
                    dr.Close();
                    conn.Open();
                }
                else
                {
                    dr.Close();
                    cmd = new MySqlCommand("INSERT INTO CUSTOMER(FOOD_NAME, UNIT_PRICE, QUANTITY) VALUES('" + foodname + "', '" + unitPrice + "', '" + quantity + "') ", conn);
                    int ctr = cmd.ExecuteNonQuery();

                    if (ctr > 0)
                    {
                        MessageBox.Show("Added successfully!");
                    }
                }
                conn.Close();

                //add here the function that gets the customers' current order
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //displays category items to menu strip
        void LoadCategoryItems()
        {
            //MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CATEGORY FROM CATEGORY_TBL", conn);
            //DataTable table = new DataTable();
            //adapter.Fill(table);


            //for (int i = 0; i < table.Rows.Count - 1; i++)
            //{
            //    ToolStripMenuItem category = new ToolStripMenuItem(table.Rows[i][0].ToString());
            //    menuCategories.Items.Add(category);
            //}
        }

        private void menuCategories_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            StartUp startUp = new StartUp();
            startUp.Show();
            this.Hide();
        }


    }
}
