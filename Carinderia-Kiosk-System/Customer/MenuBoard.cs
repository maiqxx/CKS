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

namespace Carinderia_Kiosk_System.Customer
{
    public partial class MenuBoard : Form
    {
        //Database connection
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

        public MenuBoard()
        {
            InitializeComponent();
        }

        private void MenuBoard_Load(object sender, EventArgs e)
        {
            //displays category items to menu strip
            //LoadCategoryItems();

        }

        //displays category items to menu strip
        void LoadCategoryItems()
        {
            //MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CATEGORY FROM CATEGORY_TBL", conn);
            //DataTable table = new DataTable();
            //adapter.Fill(table);


            //for (int i = 0; i < table.Rows.Count - 1; i++)
            //{
            //    ToolStripMenuItem category = new ToolStripMenuItem(table.Rows[i][0].ToString());
            //    menuCategories.Items.Add(category);
            //}
        }

        private void menuCategories_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
