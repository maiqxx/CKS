using System;
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
            conn.Open();
            cmd = new MySqlCommand("SELECT ORDER_ID, CUSTOMER_NAME, TOTAL_AMOUNT, DINE_OPTION, ORDER_STATUS FROM ORDERS ", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //panel container
                orderListPanel = new Panel();
                orderListPanel.Width = 850;
                orderListPanel.Height = 55;
                orderListPanel.BackColor = Color.White;

                //displays order ID
                orderID = new Label();
                orderID.Text = dr["ORDER_ID"].ToString();
                orderID.ForeColor = Color.Black;
                orderID.Location = new Point(28, 22);
                orderID.Font = SmallFontBold;
                orderID.Tag = dr["ORDER_ID"].ToString();

                //displays customer's name
                customerName = new Label();
                customerName.Text = dr["CUSTOMER_NAME"].ToString();
                customerName.ForeColor = Color.Black;
                customerName.Location = new Point(140, 18);
                customerName.Font = SmallFontBold;
                customerName.Tag = dr["ORDER_ID"].ToString();

                //displays total amount
                totalAmount = new Label();
                totalAmount.Text = "₱ " + dr["TOTAL_AMOUNT"].ToString();
                totalAmount.ForeColor = Color.Black;
                totalAmount.TextAlign = ContentAlignment.MiddleCenter;
                totalAmount.Location = new Point(333, 18);
                totalAmount.Font = SmallFontBold;
                totalAmount.Tag = dr["ORDER_ID"].ToString();

                //displays dine option
                dineOption = new Label();
                dineOption.Text = dr["DINE_OPTION"].ToString();
                dineOption.ForeColor = Color.Black;
                dineOption.Location = new Point(505, 18);
                dineOption.Font = SmallFontBold;
                dineOption.Tag = dr["ORDER_ID"].ToString();

                //displays order status
                orderStatus = new ComboBox();
                orderStatus.Text = dr["ORDER_STATUS"].ToString();
                orderStatus.ForeColor = Color.Black;
                orderStatus.Location = new Point(650, 15);
                orderStatus.Font = SmallFontBold;
                orderStatus.Tag = dr["ORDER_ID"].ToString();

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

                //button events

            }
            dr.Close();
            conn.Close();

        }


    }
}
