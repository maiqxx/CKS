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
    public partial class ucCancelledOrders : UserControl
    {
        private static ucCancelledOrders instance;

        public static ucCancelledOrders Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucCancelledOrders();

                }
                return instance;
            }
        }

        public ucCancelledOrders()
        {
            InitializeComponent();
        }
    }
}
