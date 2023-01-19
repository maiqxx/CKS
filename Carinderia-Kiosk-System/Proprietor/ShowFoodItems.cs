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

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ShowFoodItems : Form
    {
        //database connection
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        //setting fonts
        Font SmallFont = new Font("Century Gothic", 8, FontStyle.Bold);
        Font MediumFont = new Font("Century Gothic", 10, FontStyle.Bold);
        Font LargeFont = new Font("Century Gothic", 12, FontStyle.Bold);

        public ShowFoodItems()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void ShowFoodItems_Load(object sender, EventArgs e)
        {
            GetData();  //displays food items
            SelectCategory(); //loads filter combobox
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
                price.BackColor = Color.SteelBlue;
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
                //item.Click += new EventHandler(OnClick);

                //item.Click += (sender, e) => OnClick(this, e, item.Tag.ToString());
                //price.Click += (sender, e) => OnClick(this, e, price.Tag.ToString());
                //foodName.Click += (sender, e) => OnClick(this, e, foodName.Tag.ToString());

            }
            dr.Close();
            conn.Close();
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
                price.BackColor = Color.SteelBlue;
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
                //item.Click += new EventHandler(OnClick); //calls Onclick Event

                //item.Click += (sender, e) => OnClick(this, e, item.Tag.ToString());
                //price.Click += (sender, e) => OnClick(this, e, price.Tag.ToString());
                //foodName.Click += (sender, e) => OnClick(this, e, foodName.Tag.ToString());

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

        private void txtSearchFoodItem_TextChanged(object sender, EventArgs e)
        {
            //displays the searched food item
            GetData();
        }
    }
}
