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

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucCategories : UserControl
    {
        private static ucCategories instance;

        string emailAddress = AdminInfo.EmailAddress;
        int ID = 0; //variable for menu_type_id

        public static ucCategories Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucCategories();
                }
                return instance;
            }
        }

        public ucCategories()
        {
            InitializeComponent();
        }

        //Add new category button
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        //Update category button
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        //Remove or delete category button
        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        //Search category button
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        //Refresh categories button
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
