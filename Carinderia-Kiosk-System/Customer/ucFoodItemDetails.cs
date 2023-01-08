using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Carinderia_Kiosk_System.Customer
{
    public partial class ucFoodItemDetails : UserControl
    {
        //Database connection
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

        public ucFoodItemDetails()
        {
            InitializeComponent();
        }

        void SelectedFoodItem()
        {

        }
    }
}
