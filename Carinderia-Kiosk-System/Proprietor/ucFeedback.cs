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
            FilterRatingItems();
        }

        private void pbReload_Click(object sender, EventArgs e)
        {
            GetFeedbacks();
        }

        //setting fonts
        Font SmallFontBold = new Font("Century Gothic", 9, FontStyle.Bold);
        Font SmallFont = new Font("Century Gothic", 9);
        Font MediumFontBold = new Font("Century Gothic", 10, FontStyle.Bold);
        Font MediumFontBold2 = new Font("Century Gothic", 11, FontStyle.Bold);
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
        private PictureBox star;

        void GetFeedbacks()
        {
            flpFeedbacks.Controls.Clear();

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
                orderNum.Location = new Point(55, 75);
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
                ratingNum.Text = dr["RATING"].ToString();
                ratingNum.ForeColor = Color.Goldenrod;
                ratingNum.Location = new Point(681, 71);
                ratingNum.Font = MediumFontBold;
                ratingNum.Tag = dr["FEEDBACK_ID"].ToString();

                star = new PictureBox();
                star.Image = Resources.yellow_star;
                star.Width = 37;
                star.Height = 32;
                star.SizeMode = PictureBoxSizeMode.StretchImage;
                star.Location = new Point(638, 62);
                star.Tag = dr["FEEDBACK_ID"].ToString();

                //add to display controls in a panel
                feedback.Controls.Add(customerName);
                feedback.Controls.Add(orderNum);
                feedback.Controls.Add(comment);
                feedback.Controls.Add(dt);
                feedback.Controls.Add(dateTime);
                feedback.Controls.Add(star);
                feedback.Controls.Add(ratingNum);

                //add componets in flowlayoutpanel
                flpFeedbacks.Controls.Add(feedback);
            }

            dr.Close();
            conn.Close();
        }



        void FilterFeedback()
        {
            flpFeedbacks.Controls.Clear();

            conn.Open();
            cmd = new MySqlCommand("SELECT * FROM FEEDBACK WHERE RATING LIKE '" + cbRating.Text + "%' ORDER BY FEEDBACK_ID", conn);
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
                orderNum.Location = new Point(55, 75);
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

                //displays rating
                ratingNum = new Label();
                ratingNum.Text = dr["RATING"].ToString();
                ratingNum.ForeColor = Color.Goldenrod;
                ratingNum.Location = new Point(681, 71);
                ratingNum.Font = MediumFontBold;
                ratingNum.Tag = dr["FEEDBACK_ID"].ToString();

                star = new PictureBox();
                star.Image = Resources.yellow_star;
                star.Width = 37;
                star.Height = 32;
                star.SizeMode = PictureBoxSizeMode.StretchImage;
                star.Location = new Point(638, 62);
                star.Tag = dr["FEEDBACK_ID"].ToString();

                //add to display controls in a panel
                feedback.Controls.Add(customerName);
                feedback.Controls.Add(orderNum);
                feedback.Controls.Add(comment);
                feedback.Controls.Add(dt);
                feedback.Controls.Add(dateTime);
                feedback.Controls.Add(star);
                feedback.Controls.Add(ratingNum);

                //add componets in flowlayoutpanel
                flpFeedbacks.Controls.Add(feedback);
            }

            dr.Close();
            conn.Close();

        }

        //Items in combobox
        void FilterRatingItems()
        {
            cbRating.Items.Add("All");
            cbRating.Items.Add("5 stars");
            cbRating.Items.Add("4 stars");
            cbRating.Items.Add("3 stars");
            cbRating.Items.Add("2 stars");
            cbRating.Items.Add("1 stars");
        }

        
        private void cbRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterFeedback();

            if (cbRating.Text.Equals("All"))
            {
                GetFeedbacks();
            }
        }

       
        private void btnGo_Click(object sender, EventArgs e)
        {
           // FilterFeedback();
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flpFeedbacks_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
