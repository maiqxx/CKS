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
using MySql.Data.MySqlClient;
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

        //Add button - Add new stock
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string numCode = "";
            int num;

            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root;  Convert Zero Datetime=True; pwd=\"\";";
            conn = new MySqlConnection(connectionString);

            try
            {

            }catch (Exception ex)
            {

            }

            conn.Open();


        }

        private void pbFoodImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = openFileDialog1.FileName;
                    pbFoodImage.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtImagePath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = openFileDialog1.FileName;
                    pbFoodImage.Image = Image.FromFile(openFileDialog1.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
