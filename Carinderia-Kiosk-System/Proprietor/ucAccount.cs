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
    }
}
