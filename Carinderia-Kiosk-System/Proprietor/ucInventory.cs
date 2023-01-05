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
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using System.Data;

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucInventory : UserControl
    {
        //Database connection
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");
        int ID = 0;

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
            //generated stock ID
            GetStockID();

            //Binds data for the combobox category
            SelectCategory();

            //Calls method that populates data
            PopulateData();
        }

        //Populates data gridview
        void PopulateData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT STOCK_CODE, FOOD_NAME, DESCRIPTION, STOCK_QUANTITY, PRICE, CATEGORY, UNIT, INV_VALUE, CREATED_AT, UPDATED_AT, IMAGE FROM INVENTORY WHERE PROPRIETOR_ID = (SELECT PROPRIETOR_ID FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "')", conn);
            adapter.Fill(dt);

            //dgvInventory properties
            dgvInventory.RowTemplate.Height = 60;
            dgvInventory.AllowUserToAddRows = false;

            dgvInventory.DataSource = dt;

            //dgvInventory column "Image" properties
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dgvInventory.Columns[10];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Column header names
            dgvInventory.Columns[0].HeaderText = "Stock Code";
            dgvInventory.Columns[1].HeaderText = "Food Name";
            dgvInventory.Columns[2].HeaderText = "Description";
            dgvInventory.Columns[3].HeaderText = "Stock Quantity";
            dgvInventory.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventory.Columns[4].HeaderText = "Unit Price";
            dgvInventory.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventory.Columns[5].HeaderText = "Category";
            dgvInventory.Columns[6].HeaderText = "Unit";
            dgvInventory.Columns[7].HeaderText = "Inventory Value";
            dgvInventory.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInventory.Columns[8].HeaderText = "Created At";
            dgvInventory.Columns[9].HeaderText = "Updated At";
            dgvInventory.Columns[10].HeaderText = "Image";

            conn.Close();
        }

        //Browse button - opens computer files
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif;) | *.jpg; *.jpeg; *.png; *.gif;";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = opf.FileName.ToString();
                    pbFoodImage.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //pbFoodImage_Click Event - opens computer files
        private void pbFoodImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif;) | *.jpg; *.jpeg; *.png; *.gif;";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = opf.FileName.ToString();
                    pbFoodImage.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //txtImagePath_Click Event - opens computer files
        private void txtImagePath_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif;) | *.jpg; *.jpeg; *.png; *.gif;";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = opf.FileName.ToString();
                    pbFoodImage.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Display a generated code in txtStockCode textbox
        void GetStockID()
        {
            string stockID;
            try
            {
                conn.Open();
                string query = "SELECT STOCK_ID " +
                                "FROM INVENTORY " +
                                "ORDER BY STOCK_ID DESC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    stockID = id.ToString("STK00000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    stockID = ("STK00001");
                }
                else
                {
                    stockID = ("STK00001");
                }

                conn.Close();
                txtStockCode.Text = stockID.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Add button - Add new stock
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double unitPrice = double.Parse(txtUnitPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            double inventoryValue = unitPrice * quantity;

            //FileStream fs;
            //BinaryReader br;

            try
            {
                if (txtFoodName.Text.Length > 0 && txtImagePath.Text.Length > 0)
                {
                    conn.Open();

                    byte[] img = null;
                    FileStream fs = new FileStream(txtImagePath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    string addStock = "INSERT INTO INVENTORY " +
                                        "SET STOCK_CODE = @stockCode, " +
                                        "FOOD_NAME = @foodName, " +
                                        "DESCRIPTION = @desc, " +
                                        "IMAGE = @image, " +
                                        "STOCK_QUANTITY = @quantity, " +
                                        "PRICE = @unitPrice, " +
                                        "CATEGORY = @category, " +
                                        "UNIT = @unit, " +
                                        "INV_VALUE = @invValue, " +
                                        "PROPRIETOR_ID = (SELECT PROPRIETOR_ID FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "')";
                    
                    MySqlCommand cmd = new MySqlCommand(addStock, conn);
                    cmd.Parameters.AddWithValue("@stockCode", txtStockCode.Text);
                    cmd.Parameters.AddWithValue("@foodName", txtFoodName.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@image", img);
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
                    File.Copy(txtImagePath.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pbFoodImage.ImageLocation));
                    PopulateData();
                    ClearData();
                    GetStockID();



                    //string FileName = txtImagePath.Text;
                    //byte[] ImageData;
                    //fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    //br = new BinaryReader(fs);
                    //ImageData = br.ReadBytes((int)fs.Length);
                    //br.Close();
                    //fs.Close();

                    ////adds new food item
                    //string addStock = "INSERT INTO INVENTORY " +
                    //                    "SET STOCK_CODE = @stockCode, " +
                    //                    "FOOD_NAME = @foodName, " +
                    //                    "DESCRIPTION = @desc, " +
                    //                    "IMAGE = @image, " +
                    //                    "STOCK_QUANTITY = @quantity, " +
                    //                    "PRICE = @unitPrice, " +
                    //                    "CATEGORY = @category, " +
                    //                    "UNIT = @unit, " +
                    //                    "INV_VALUE = @invValue, " +
                    //                    "PROPRIETOR_ID = (SELECT PROPRIETOR_ID FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "')";
                    //MySqlCommand cmd = new MySqlCommand(addStock, conn);

                    //cmd.Parameters.AddWithValue("@stockCode", txtStockCode.Text);
                    //cmd.Parameters.AddWithValue("@foodName", txtFoodName.Text);
                    //cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                    //cmd.Parameters.AddWithValue("@image", ImageData);
                    //cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    //cmd.Parameters.AddWithValue("@unitPrice", txtUnitPrice.Text);
                    //cmd.Parameters.AddWithValue("@category", cbCategory.Text);
                    //cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                    //cmd.Parameters.AddWithValue("@invValue", inventoryValue);

                    //int ctr = cmd.ExecuteNonQuery();
                    //if (ctr > 0)
                    //{
                    //    MessageBox.Show("Food item added successfully!");
                    //}
                    //conn.Close();
                    //File.Copy(txtImagePath.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pbFoodImage.ImageLocation));
                    //PopulateData();
                    //ClearData();
                    //GetStockID();
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

        //Edit/Update button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtStockCode.Text != "" && txtFoodName.Text != "" && txtDescription.Text != "" && cbCategory.Text != "" && txtUnitPrice.Text != "" && txtQuantity.Text != "" && txtUnit.Text != "")
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(txtImagePath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    MySqlCommand cmd = new MySqlCommand();
                    string Query = "update test set name=@name,image=@img where id=@id ";
                    cmd = new MySqlCommand("UPDATE INVENTORY SET FOOD_NAME = @foodName, DESCRIPTION = @description, IMAGE = @image, STOCK_QUANTITY = @quantity, PRICE = @price, CATEGORY = @category, UNIT = @unit WHERE STOCK_CODE = (SELECT STOCK_ID FROM INVENTORY WHERE STOCK_CODE = '" + this.txtStockCode + "')", conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@stockCode", txtStockCode.Text);
                    cmd.Parameters.AddWithValue("@foodName", txtFoodName.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@image", img);
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@price", txtUnitPrice.Text);
                    cmd.Parameters.AddWithValue("@category", cbCategory.Text);
                    cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                    var ctr = cmd.ExecuteNonQuery();
                    if (ctr > 0)
                    {
                        MessageBox.Show("Food item updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Cannot update the selected food item.");
                    }
                    conn.Close();
                    PopulateData();
                    ClearData();


                    ////updates stock item
                    //MySqlCommand cmd = new MySqlCommand();
                    //cmd = new MySqlCommand("UPDATE INVENTORY SET FOOD_NAME = @foodName, DESCRIPTION = @description, IMAGE = @image, STOCK_QUANTITY = @quantity, PRICE = @price, CATEGORY = @category, UNIT = @unit WHERE STOCK_CODE = (SELECT STOCK_ID FROM INVENTORY WHERE STOCK_CODE = '" + this.txtStockCode + "')", conn);
                    //conn.Open();
                    //cmd.Parameters.AddWithValue("@stockCode", txtStockCode.Text);
                    //cmd.Parameters.AddWithValue("@foodName", txtFoodName.Text);
                    //cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    //cmd.Parameters.AddWithValue("@image", pbFoodImage.Image);
                    //cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    //cmd.Parameters.AddWithValue("@price", txtUnitPrice.Text);
                    //cmd.Parameters.AddWithValue("@category", cbCategory.Text);
                    //cmd.Parameters.AddWithValue("@unit", txtUnit.Text);

                    //var ctr = cmd.ExecuteNonQuery();
                    //if (ctr > 0)
                    //{
                    //    MessageBox.Show("Food item updated successfully!");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Cannot update the selected food item.");
                    //}
                    //conn.Close();
                    //PopulateData();
                    //ClearData();
                }
                else
                {
                    MessageBox.Show("Please select a food item to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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



        //Getting category values for combobox
        void SelectCategory()
        {
            try
            {
                conn.Open();
                string selectCategory = "SELECT CATEGORY FROM cks_db.CATEGORY_TBL";
                MySqlCommand cmd = new MySqlCommand(selectCategory, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string category = reader.GetString("CATEGORY");
                    cbCategory.Items.Add(category);
                }
                conn.Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //dgvInventory RowHeaderMouseClick Event
        private void dgvInventory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //when row is clicked, values are filled on textboxes
            //txtStockCode.Text = dgvInventory.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtFoodName.Text = dgvInventory.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtDescription.Text = dgvInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
            //MemoryStream ms = new MemoryStream((byte[])dgvInventory.CurrentRow.Cells[3].Value);
            //pbFoodImage.Image = Image.FromStream(ms);
            //txtQuantity.Text = dgvInventory.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtUnitPrice.Text = dgvInventory.Rows[e.RowIndex].Cells[5].Value.ToString();
            //cbCategory.Text = dgvInventory.Rows[e.RowIndex].Cells[6].Value.ToString();
            //txtUnit.Text = dgvInventory.Rows[e.RowIndex].Cells[7].Value.ToString();

            //Byte[] img = (Byte[])dgvInventory.CurrentRow.Cells[3].Value;
            //MemoryStream ms = new MemoryStream();
            ////img.Save(ms, ImageFormat.Jpeg);

            //pbFoodImage.Image = Image.FromStream(ms);
            //txtStockCode.Text = dgvInventory.CurrentRow.Cells[0].Value.ToString();
            //txtFoodName.Text = dgvInventory.CurrentRow.Cells[1].Value.ToString();
            //txtDescription.Text = dgvInventory.CurrentRow.Cells[2].Value.ToString();
            //txtQuantity.Text = dgvInventory.CurrentRow.Cells[3].Value.ToString();
            //txtUnitPrice.Text = dgvInventory.CurrentRow.Cells[4].Value.ToString();
            //cbCategory.Text = dgvInventory.CurrentRow.Cells[5].Value.ToString();
            //txtUnit.Text = dgvInventory.CurrentRow.Cells[6].Value.ToString();
        }

        //dgvInventory_CellClick event
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        //dgvInventory_Click event to select all cells 
        private void dgvInventory_Click(object sender, EventArgs e)
        {
            byte[] img = (byte[])dgvInventory.CurrentRow.Cells[10].Value;
            MemoryStream ms = new MemoryStream(img);
            //img.Save(ms, ImageFormat.Jpeg);

            pbFoodImage.Image = Image.FromStream(ms);
            txtStockCode.Text = dgvInventory.CurrentRow.Cells[0].Value.ToString();
            txtFoodName.Text = dgvInventory.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = dgvInventory.CurrentRow.Cells[2].Value.ToString();
            txtQuantity.Text = dgvInventory.CurrentRow.Cells[3].Value.ToString();
            txtUnitPrice.Text = dgvInventory.CurrentRow.Cells[4].Value.ToString();
            cbCategory.Text = dgvInventory.CurrentRow.Cells[5].Value.ToString();
            txtUnit.Text = dgvInventory.CurrentRow.Cells[6].Value.ToString();

        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInventory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
