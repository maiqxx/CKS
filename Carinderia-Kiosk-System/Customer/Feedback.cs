using Carinderia_Kiosk_System.Customer.CustomerDialogs;
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
using Carinderia_Kiosk_System.Properties;

namespace Carinderia_Kiosk_System.Customer
{
    public partial class Feedback : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Feedback()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void btnOrderSummary_Click(object sender, EventArgs e)
        {
            OrderSummary summary = new OrderSummary();
            summary.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ThankYouDialog thankYou = new ThankYouDialog();
            thankYou.ShowDialog();
            this.Close();

            try
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO FEEDBACK SET RATING = '" + lblRatingNum.Text + "', " +
                                        "COMMENT = '"+ txtComment.Text + "',  " +
                                        "ORDER_ID = (SELECT ORDER_ID FROM ORDERS WHERE CUSTOMER_NAME = '" + CustomerInfo.Name + "') ", conn);

                int ctr = cmd.ExecuteNonQuery();

                if (ctr > 0)
                {
                    ThankYouDialog ty = new ThankYouDialog();
                    ty.ShowDialog();
                    this.Hide();
                }
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

        private void pbStar5_Click(object sender, EventArgs e)
        {
            pbStar5.Image = Resources.yellow_star;
            pbStar4.Image = Resources.yellow_star;
            pbStar3.Image = Resources.yellow_star;
            pbStar2.Image = Resources.yellow_star;
            pbStar1.Image = Resources.yellow_star;

            lblRatingNum.Text = "5";
        }

        private void pbStar4_Click(object sender, EventArgs e)
        {
            pbStar5.Image = Resources.white_star;

            pbStar4.Image = Resources.yellow_star;
            pbStar3.Image = Resources.yellow_star;
            pbStar2.Image = Resources.yellow_star;
            pbStar1.Image = Resources.yellow_star;

            lblRatingNum.Text = "4";
        }

        private void pbStar3_Click(object sender, EventArgs e)
        {
            pbStar5.Image = Resources.white_star;
            pbStar4.Image = Resources.white_star;

            pbStar3.Image = Resources.yellow_star;
            pbStar2.Image = Resources.yellow_star;
            pbStar1.Image = Resources.yellow_star;

            lblRatingNum.Text = "3";
        }

        private void pbStar2_Click(object sender, EventArgs e)
        {
            pbStar5.Image = Resources.white_star;
            pbStar4.Image = Resources.white_star;
            pbStar3.Image = Resources.white_star;

            pbStar2.Image = Resources.yellow_star;
            pbStar1.Image = Resources.yellow_star;

            lblRatingNum.Text = "2";
        }

        private void pbStar1_Click(object sender, EventArgs e)
        {
            pbStar5.Image = Resources.white_star;
            pbStar4.Image = Resources.white_star;
            pbStar3.Image = Resources.white_star;
            pbStar2.Image = Resources.yellow_star;

            pbStar1.Image = Resources.white_star;

            lblRatingNum.Text = "1";
        }


    }
}
