using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucInventory : UserControl
    {
        private static ucInventory instance;

        public static ucInventory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucInventory();

                }
                return instance;
            }
        }

        public ucInventory()
        {
            InitializeComponent();
        }

        private void ucInventory_Load(object sender, EventArgs e)
        {
            //Set AutoGenerateColumns False.
            dgvInventory.AutoGenerateColumns = false;

            //Set Columns Count.
            dgvInventory.ColumnCount = 10;

        }
    }
}
