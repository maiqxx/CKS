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
    public partial class ucTransactionList : UserControl
    {
        private static ucTransactionList instance;

        public static ucTransactionList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucTransactionList();

                }
                return instance;
            }
        }

        public ucTransactionList()
        {
            InitializeComponent();
        }
    }
}
