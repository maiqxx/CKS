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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void btnOrderSummary_Click(object sender, EventArgs e)
        {
            OrderSummary summary = new OrderSummary();
            summary.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
