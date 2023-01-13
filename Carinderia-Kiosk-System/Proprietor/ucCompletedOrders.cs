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
    public partial class ucCompletedOrders : UserControl
    {
        private static ucCompletedOrders instance;

        public static ucCompletedOrders Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucCompletedOrders();

                }
                return instance;
            }
        }

        public ucCompletedOrders()
        {
            InitializeComponent();
        }
    }
}
