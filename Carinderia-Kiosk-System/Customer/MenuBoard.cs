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

            //displays category items to menu strip
            //LoadCategoryItems();

        }

        //gets data from database to be displayed on flowlayoutpanel
        private void GetData()
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT FOOD_NAME, PRICE, IMAGE FROM INVENTORY", conn);
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

                //displays price
                price = new Label();
                price.Text = "₱ " + dr["PRICE"].ToString();
                price.BackColor = Color.FromArgb(39, 174, 96);
                price.ForeColor = Color.FromArgb(236, 240, 241);
                price.Font = MediumFont;
                price.TextAlign = ContentAlignment.MiddleCenter;
                //price.Dock = DockStyle.Bottom;

                //displays food name
                foodName = new Label();
                foodName.Text = dr["FOOD_NAME"].ToString();
                foodName.BackColor = Color.FromArgb(236, 240, 241);
                foodName.Font = MediumFont;
                foodName.TextAlign = ContentAlignment.MiddleCenter;
                foodName.Dock = DockStyle.Bottom;


                //gets image from database
                MemoryStream ms = new MemoryStream(array);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
                item.BackgroundImage = bitmap;

                //add to display controls
                item.Controls.Add(price);
                item.Controls.Add(foodName);
                flpMenuItems.Controls.Add(item);

            }
            dr.Close();
            conn.Close();

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
    }
}
