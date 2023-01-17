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

        //Database connection
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

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

        private void ucCategories_Load(object sender, EventArgs e)
        {
            //Loads category list
            PopulateData();

            //Loads menu categories with number of stocks available
            LoadMenuStocks();
        }

        //Populate Data Method - Populates data grid view
        public void PopulateData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CATEGORY_ID, CATEGORY, DESCRIPTION, CREATED_AT, UPDATED_AT FROM CATEGORY_TBL WHERE EMAIL_ADDRESS = '" + emailAddress + "'", conn);
            adapter.Fill(dt);

            dgvMenuCategories.RowTemplate.Height = 60;
            dgvMenuCategories.DataSource = dt;

            //Column header names
            dgvMenuCategories.Columns[0].HeaderText = "No.";
            dgvMenuCategories.Columns[1].HeaderText = "Category Name";
            dgvMenuCategories.Columns[2].HeaderText = "Description";
            dgvMenuCategories.Columns[3].HeaderText = "Created At";
            dgvMenuCategories.Columns[4].HeaderText = "Last Update";

            conn.Close();
        }

        //Add new category button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var emailAddress = AdminInfo.EmailAddress;
            var categoryName = txtCategoryName.Text;
            var description = txtDescription.Text;

            try
            {
                if (categoryName != "" && description != "")
                {
                    conn.Open();

                    //adds new menu category
                    string addCategory = "INSERT INTO CATEGORY_TBL(CATEGORY, DESCRIPTION, EMAIL_ADDRESS) " +
                    "VALUES('" + categoryName + "', '" + description + "', '" + emailAddress + "')";

                    MySqlCommand cmd = new MySqlCommand(addCategory, conn);
                    var ctr = cmd.ExecuteNonQuery();
                    if(ctr > 0)
                    {
                        MessageBox.Show("Added New Menu Category!");
                    }
                    conn.Close();
                    PopulateData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please provide category details!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Update category button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var categoryName = txtCategoryName.Text;
            var description = txtDescription.Text;

            try
            {
                if (categoryName != "" && description != "")
                {
                    //updates category
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = new MySqlCommand("UPDATE CATEGORY_TBL SET CATEGORY = @cName, DESCRIPTION = @cDesc WHERE CATEGORY_ID = @ID", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@cName", txtCategoryName.Text);
                    cmd.Parameters.AddWithValue("@cDesc", txtDescription.Text);

                    var ctr = cmd.ExecuteNonQuery();
                    if (ctr > 0)
                    {
                        MessageBox.Show("Category updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Cannot update selected category");
                    }
                    conn.Close();
                    PopulateData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please select category to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Remove or delete category button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    string message = "Do you want to remove this category?";
                    string title = "Remove Category";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        //deletes selected category
                        MySqlCommand cmd = new MySqlCommand();
                        cmd = new MySqlCommand("DELETE FROM CATEGORY_TBL WHERE CATEGORY_ID = @ID", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Category removed successfully!");
                        PopulateData();
                        ClearData();
                    }
                    else
                    {
                        //...
                    }
                }
                else
                {
                    MessageBox.Show("Select category to remove.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Search category button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                //Search category
                string searchCategory = "SELECT CATEGORY_ID, CATEGORY, DESCRIPTION, CREATED_AT, UPDATED_AT FROM CATEGORY_TBL WHERE CATEGORY LIKE '%" + txtSearchCategory.Text + "%' AND EMAIL_ADDRESS = '" + emailAddress + "' ";
                MySqlCommand cmd = new MySqlCommand(searchCategory, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                txtCategoryName.Text = dt.ToString();
                txtDescription.Text = dt.ToString();
                dgvMenuCategories.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Refresh categories button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateData();
                LoadMenuStocks();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cannot load data.");
                MessageBox.Show(ex.Message);
            }
        }

        //dgvMenuCategories RowHeaderMouseClick Event 
        private void dgvMenuCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //when row is clicked, values are shown on textboxes
            ID = Convert.ToInt32(dgvMenuCategories.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCategoryName.Text = dgvMenuCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvMenuCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvMenuCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateData();
        }

        //Clear Data  
        private void ClearData()
        {
            txtCategoryName.Text = "";
            txtDescription.Text = "";
        }

        //Loads menu categories with number of stocks available
        void LoadMenuStocks()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CATEGORY, COUNT(STOCK_ID) FROM INVENTORY GROUP BY CATEGORY", conn);
                adapter.Fill(dt);

                dgvMenuStocks.RowTemplate.Height = 50;
                dgvMenuStocks.DataSource = dt;

                //Column names
                dgvMenuStocks.Columns[0].HeaderText = "Category";
                dgvMenuStocks.Columns[1].HeaderText = "Products";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //txtSearchCategory Live Search
        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter;
            DataTable table;
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT CATEGORY_ID, CATEGORY, DESCRIPTION, CREATED_AT, UPDATED_AT FROM CATEGORY_TBL WHERE CATEGORY LIKE '%" + this.txtSearchCategory.Text + "%' ", conn);
            table = new DataTable();
            adapter.Fill(table);
            dgvMenuCategories.RowTemplate.Height = 60;
            dgvMenuCategories.DataSource = table;
            conn.Close();
        }
    }
}
