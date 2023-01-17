using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carinderia_Kiosk_System.Proprietor.ProprietorDialogs
{
    public partial class InvalidCredentialsDialog : Form
    {
        public InvalidCredentialsDialog()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
