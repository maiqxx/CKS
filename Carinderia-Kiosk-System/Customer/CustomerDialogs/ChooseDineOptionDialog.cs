﻿using System;
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
    public partial class ChooseDineOptionDialog : Form
    {
        public ChooseDineOptionDialog()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChooseDineOptionDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
