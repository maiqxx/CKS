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
    public partial class ucOrderList : UserControl
    {
        private static ucOrderList instance;

        public static ucOrderList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucOrderList();

                }
                return instance;
            }
        }

        public ucOrderList()
        {
            InitializeComponent();
        }
    }
}
