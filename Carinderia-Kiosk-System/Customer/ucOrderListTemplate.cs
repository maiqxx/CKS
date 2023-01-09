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
    public partial class ucOrderListTemplate : UserControl
    {
        //Database connection
        //MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        Font SmallFont = new Font("Century Gothic", 8, FontStyle.Bold);
        Font MediumFont = new Font("Century Gothic", 10, FontStyle.Bold);
        Font LargeFont = new Font("Century Gothic", 12, FontStyle.Bold);

        public ucOrderListTemplate()
        {
            InitializeComponent();
        }

        //private Label foodName;
        //private Label price;
        //private NumericUpDown quantity;

        //Get data
        void GetFoodItem()
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT FOOD_NAME, QUANTITY, UNIT_PRICE FROM CUSTOMER", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lblFoodName = new Label();
                lblFoodName.Text = dr["FOOD_NAME"].ToString();
                lblFoodName.ForeColor = Color.Black;
                lblFoodName.Font = MediumFont;
                lblFoodName.Tag = dr["FOOD_NAME"].ToString(); //test to display stock ID when OnClick

                //displays price
                lblUnitPrice = new Label();
                lblUnitPrice.Text = "₱ " + double.Parse(dr["UNIT_PRICE"].ToString()).ToString("#, ##0.00");
                lblUnitPrice.ForeColor = Color.Black;
                lblUnitPrice.Tag = dr["FOOD_NAME"].ToString(); //test to display stock ID when OnClick

                numericTxtQuantity = new NumericUpDown();
                numericTxtQuantity.Value = Convert.ToInt32(dr["QUANTITY"].ToString());
                numericTxtQuantity.Tag = dr["FOOD_NAME"].ToString();
            }
            conn.Close();
        }



    }
}
