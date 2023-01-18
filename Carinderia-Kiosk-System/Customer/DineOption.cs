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
    public partial class DineOption : Form
    {
        public DineOption()
        {
            InitializeComponent();
        }

        //Dine In button
        private void btnDineIn_Click(object sender, EventArgs e)
        {
            MenuBoard menuBoard = new MenuBoard();
            menuBoard.Show();
            this.Hide();

            lblDineIn.Text = CustomerDineOption.DineInOption;
        }

        //Take Out button
        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            MenuBoard menuBoard = new MenuBoard();
            menuBoard.Show();
            this.Hide();

            lblTakeOut.Text = CustomerDineOption.DineInOption;
        }

        private void DineOption_Load(object sender, EventArgs e)
        {

        }
    }
}
