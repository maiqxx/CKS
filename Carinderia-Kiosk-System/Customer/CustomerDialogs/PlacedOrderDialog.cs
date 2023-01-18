using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carinderia_Kiosk_System.Customer
{
    public partial class PlacedOrderDialog : Form
    {
        public PlacedOrderDialog()
        {
            InitializeComponent();
        }

        private void btnOrderSummary_Click(object sender, EventArgs e)
        {
            OrderSummary summary = new OrderSummary();
            summary.Show();
            this.Close();
        }

        private void btnAddFeedback_Click(object sender, EventArgs e)
        {
            Feedback fb = new Feedback();
            fb.Show();
            this.Close();
        }

        private void PlacedOrderDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
