using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carinderia_Kiosk_System.Customer.CustomerDialogs
{
    public partial class ThankYouDialog : Form
    {
        public ThankYouDialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            //set customer info to nothing for new user
            //CustomerInfo.ID = 0;
            //CustomerInfo.Name = "";

            StartScreen start = new StartScreen();
            start.Show();
        }
    }
}
