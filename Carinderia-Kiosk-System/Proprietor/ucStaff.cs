﻿using System;
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
    public partial class ucStaff : UserControl
    {
        private static ucStaff instance;

        public static ucStaff Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucStaff();
                }
                return instance;
            }
        }

        public ucStaff()
        {
            InitializeComponent();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {

        }

        //Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        //Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        //Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
