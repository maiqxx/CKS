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

namespace Carinderia_Kiosk_System.Proprietor.ProprietorDialogs
{
    public partial class AddStock : Form
    {
        //Database connection
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");
        int ID = 0;

        public AddStock()
        {
            InitializeComponent();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            //generated stock ID
            GetStockID();

            //Binds data for the combobox category
            SelectCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double unitPrice = double.Parse(txtUnitPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);
            double inventoryValue = unitPrice * quantity;

            try
            {
                if (txtFoodName.Text.Length > 0)
                {
                    conn.Open();

                    MemoryStream ms = new MemoryStream();
                    pbFoodImage.Image.Save(ms, pbFoodImage.Image.RawFormat);
                    byte[] img = ms.ToArray();


                    string addStock = "INSERT INTO INVENTORY " +
                                        "SET STOCK_CODE = @stockCode, " +
                                        "STOCK_NAME = @foodName, " +
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
                        UpdatedFoodItemDialog updatedFoodItem = new UpdatedFoodItemDialog();
                        updatedFoodItem.ShowDialog();
                    }
                    else
                    {
                        FailedToAddProductDialog failedToAddProductDialog = new FailedToAddProductDialog();
                        failedToAddProductDialog.ShowDialog();
                    }
                    conn.Close();
                    GetStockID();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif;) | *.jpg; *.jpeg; *.png; *.gif;";
                if (opf.ShowDialog() == DialogResult.OK)
                {
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

        //Gets category values for combobox
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

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
