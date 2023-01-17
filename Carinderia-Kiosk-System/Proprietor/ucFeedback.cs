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
using Carinderia_Kiosk_System.Proprietor.ProprietorDialogs;
using MySql.Data.MySqlClient;

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucFeedback : UserControl
    {

        private static ucFeedback instance;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public static ucFeedback Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucFeedback();
                }
                return instance;
            }
        }

        public ucFeedback()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void ucFeedback_Load(object sender, EventArgs e)
        {
            GetFeedbacks();
        }

        //setting fonts
        Font SmallFontBold = new Font("Century Gothic", 9, FontStyle.Bold);
        Font SmallFont = new Font("Century Gothic", 9);
        Font MediumFontBold = new Font("Century Gothic", 10, FontStyle.Bold);
        Font LargeFontBold = new Font("Century Gothic", 12, FontStyle.Bold);

        //components
        private Panel feedback;
        private Label customerName;
        private Label orderNum;
        private TextBox comment;
        private Label dt;
        private Label dateTime;
        private Label ratings;
        private Label ratingNum;

        void GetFeedbacks()
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM FEEDBACK ", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //panel container
                feedback = new Panel();
                feedback.Width = 888;
                feedback.Height = 115;
                feedback.BackColor = Color.WhiteSmoke;
                feedback.Tag = dr["FEEDBACK_ID"].ToString();

                //displays customer name
                customerName = new Label();
                customerName.Text = dr["CUSTOMER_NAME"].ToString();
                customerName.ForeColor = Color.Black;
                customerName.Location = new Point(55, 22);
                customerName.Font = MediumFontBold;
                customerName.Tag = dr["FEEDBACK_ID"].ToString();

                //displays customer's order number/id
                orderNum = new Label();
                orderNum.Text = "Order No.: " + dr["ORDER_ID"].ToString();
                orderNum.ForeColor = Color.Black;
                orderNum.Location = new Point(55, 62);
                orderNum.Font = MediumFontBold;
                orderNum.Tag = dr["FEEDBACK_ID"].ToString();

                //displays customer's comment
                comment = new TextBox();
                comment.Text = dr["COMMENT"].ToString();
                comment.ForeColor = Color.Black;
                comment.BackColor = Color.White;
                comment.Multiline = true;
                comment.ReadOnly = true;
                comment.Width = 347;
                comment.Height = 75;
                comment.Location = new Point(240, 19);
                comment.Font = SmallFont;
                comment.Tag = dr["FEEDBACK_ID"].ToString();

                //displays label
                dt = new Label();
                dt.Text = "Date and Time: ";
                dt.ForeColor = Color.Black;
                dt.Location = new Point(634, 22);
                dt.Font = SmallFont;
                dt.Tag = dr["FEEDBACK_ID"].ToString();

                //displays dateTime
                dateTime = new Label();
                dateTime.Text = dr["CREATED_AT"].ToString();
                dateTime.ForeColor = Color.Black;
                dateTime.Location = new Point(730, 22);
                dateTime.Font = MediumFontBold;
                dateTime.Tag = dr["FEEDBACK_ID"].ToString();

                ////displays label
                //ratings = new Label();
                //ratings.Text = "Ratings: ";
                //ratings.ForeColor = Color.Black;
                //ratings.Location = new Point(634, 75);
                //ratings.Font = SmallFont;
                //ratings.Tag = dr["FEEDBACK_ID"].ToString();

                //displays rating
                ratingNum = new Label();
                ratingNum.Text = dr["RATING"].ToString() + " stars";
                ratingNum.ForeColor = Color.Goldenrod;
                ratingNum.Location = new Point(634, 75);
                ratingNum.Font = MediumFontBold;
                ratingNum.Tag = dr["FEEDBACK_ID"].ToString();


                //add to display controls in a panel
                feedback.Controls.Add(customerName);
                feedback.Controls.Add(orderNum);
                feedback.Controls.Add(comment);
                feedback.Controls.Add(dt);
                feedback.Controls.Add(dateTime);
                //feedback.Controls.Add(ratings);
                feedback.Controls.Add(ratingNum);

                //add componets in flowlayoutpanel
                flpFeedbacks.Controls.Add(feedback);
            }

            dr.Close();
            conn.Close();



        }



        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }


    }
}
