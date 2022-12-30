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
        //MySqlConnection conn = new MySqlConnection(@"server=localhost; database=cks_db; uid=root;  Convert Zero Datetime=True; pwd=""");

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
            //Binds data for the combobox category
            SelectCategory();

            //Calls method that populates data
            PopulateData();

            //Set AutoGenerateColumns False.
            //dgvInventory.AutoGenerateColumns = false;

            //Set Columns Count.
            //dgvInventory.ColumnCount = 10;

        }

        void PopulateData()
        {
            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
            conn = new MySqlConnection(connectionString);

            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT STOCK_ID, FOOD_NAME, DESCRIPTION, IMAGE, STOCK_QUANTITY, PRICE, CATEGORY, UNIT, INV_VALUE, CREATED_AT, UPDATED_AT FROM INVENTORY", conn);
            adapter.Fill(dt);
            dgvInventory.DataSource = dt;

            //Column header names
            dgvInventory.Columns[0].HeaderText = "Stock No.";
            dgvInventory.Columns[1].HeaderText = "Food Name";
            dgvInventory.Columns[2].HeaderText = "Description";
            dgvInventory.Columns[3].HeaderText = "Image";
            dgvInventory.Columns[4].HeaderText = "Stock Quantity";
            dgvInventory.Columns[5].HeaderText = "Unit Price";
            dgvInventory.Columns[6].HeaderText = "Category";
            dgvInventory.Columns[7].HeaderText = "Unit";
            dgvInventory.Columns[8].HeaderText = "Inventory Value";
            dgvInventory.Columns[9].HeaderText = "Created At";
            dgvInventory.Columns[10].HeaderText = "Updated At";

            conn.Close();
        }

        //Add button - Add new stock
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = "STK0000000";
            double unitPrice = double.Parse(txtUnitPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            double inventoryValue = unitPrice * quantity;

            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
            conn = new MySqlConnection(connectionString);
            FileStream fs;
            BinaryReader br;

            try
            {
                conn.Open();

                if (txtFoodName.Text.Length > 0 && txtImagePath.Text.Length > 0)
                {
                    string FileName = txtImagePath.Text;
                    byte[] ImageData;
                    fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    //adds new food item
                    string addStock = "INSERT INTO INVENTORY " +
                                        "SET FOOD_NAME = @foodName, " +
                                        "DESCRIPTION = @desc, " +
                                        "IMAGE = @image, " +
                                        "STOCK_QUANTITY = @quantity, " +
                                        "PRICE = @unitPrice, " +
                                        "CATEGORY = @category, " +
                                        "UNIT = @unit, " +
                                        "INV_VALUE = @invValue, " +
                                        "PROPRIETOR_ID = (SELECT PROPRIETOR_ID FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "')";
                    MySqlCommand cmd = new MySqlCommand(addStock, conn);

                    cmd.Parameters.AddWithValue("@foodName", txtFoodName.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@image", ImageData);
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
                    cmd.Parameters.AddWithValue("@category", cbCategory.Text);
                    cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                    cmd.Parameters.AddWithValue("@invValue", inventoryValue);

                    int ctr = cmd.ExecuteNonQuery();
                    if (ctr > 0)
                    {
                        MessageBox.Show("Food item added successfully!");
                    }
                    conn.Close();
                    PopulateData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        //Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        //Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        void DisplayStockCode()
        {

        }

        //Clears data in textboxes
        void ClearData()
        {
            txtFoodName.Text = "";
            txtDescription.Text = "";
            cbCategory.Text = "";
            txtUnitPrice.Text = "";
            txtQuantity.Text = "";
            txtUnit.Text = "";
            txtImagePath.Text = "";
            pbFoodImage.Image = null;
        }

        //Get Stock code
        void getStockCode()
        {
            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root;  Convert Zero Datetime=True; pwd=\"\";";
            conn = new MySqlConnection(connectionString);
        }

        //Getting category values for combobox
        void SelectCategory()
        {
            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root;  Convert Zero Datetime=True; pwd=\"\";";
            conn = new MySqlConnection(connectionString);

            string selectCategory = "SELECT TYPE_NAME FROM cks_db.MENU_TYPE";
            MySqlCommand cmd = new MySqlCommand(selectCategory, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string category = reader.GetString("TYPE_NAME");
                    cbCategory.Items.Add(category);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //pbFoodImage_Click Event
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

        //txtImagePath_Click Event
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateData();
        }
    }
}
