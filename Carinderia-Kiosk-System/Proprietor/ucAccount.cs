using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucAccount : UserControl
    {
        private static ucAccount instance;

        public static ucAccount Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucAccount();
                }
                return instance;
            }
        }

        public ucAccount()
        {
            InitializeComponent();
        }

        private void ucAccount_Load(object sender, EventArgs e)
        {
            InitializeTimePicker();
        
        }

        void InitializeTimePicker()
        {
            //opening time
            dtpOpeningTime.Format = DateTimePickerFormat.Custom;
            dtpOpeningTime.CustomFormat = "HH:mm tt";
            dtpOpeningTime.ShowUpDown = true;

            //closing time
            dtpClosingTime.Format = DateTimePickerFormat.Custom;
            dtpClosingTime.CustomFormat = "HH:mm tt";
            dtpClosingTime.ShowUpDown = true;
        }

        private void lblStoreDescription_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
