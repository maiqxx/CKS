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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        //Order redirect button
        private void btnOrder_Click(object sender, EventArgs e)
        {
            DineOption dineOption = new DineOption();
            dineOption.Show();
            this.Hide();

            //MenuBoard menuBoard = new MenuBoard();
            //menuBoard.Show();
            //this.Hide();
        }
    }
}
