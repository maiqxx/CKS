using Carinderia_Kiosk_System.Proprietor;
using Carinderia_Kiosk_System.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carinderia_Kiosk_System
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        //Admin Button
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            this.Hide();
        }

        //Customer Button
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            startScreen.Show();
            this.Hide();
        }
    }
}
