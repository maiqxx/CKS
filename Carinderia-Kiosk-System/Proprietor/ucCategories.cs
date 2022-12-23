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

        //Populate Data Method - Populates data grid view
        private void PopulateData()
        {
            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
            conn = new MySqlConnection(connectionString);

            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT MENU_TYPE_ID, TYPE_NAME, DESCRIPTION, CREATED_AT, UPDATED_AT FROM MENU_TYPE WHERE EMAIL_ADDRESS = '" + emailAddress + "'", conn);
            adapter.Fill(dt);
            dgvMenuCategories.DataSource = dt;

            //Column header names
            dgvMenuCategories.Columns[0].HeaderText = "No.";
            dgvMenuCategories.Columns[1].HeaderText = "Category Name";
            dgvMenuCategories.Columns[2].HeaderText = "Description";
            dgvMenuCategories.Columns[3].HeaderText = "Created At";
            dgvMenuCategories.Columns[4].HeaderText = "Updated At";

            conn.Close();
        }

        //Add new category button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var emailAddress = AdminInfo.EmailAddress;
            var categoryName = txtCategoryName.Text;
            var description = txtDescription.Text;

            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
            conn = new MySqlConnection(connectionString);

            try
            {
                if (categoryName != "" && description != "")
                {
                    conn.Open();

                    //adds new menu category
                    string addCategory = "INSERT INTO MENU_TYPE(TYPE_NAME, DESCRIPTION, EMAIL_ADDRESS) " +
                    "VALUES('" + categoryName + "', '" + description + "', '" + emailAddress + "')";

                    MySqlCommand cmd = new MySqlCommand(addCategory, conn);
                    var ctr = cmd.ExecuteNonQuery();
                    MessageBox.Show("Added New Menu Category!");
                }
                else
                {
                    MessageBox.Show("Please provide category details!");
                }
            }
            catch
            {
                MessageBox.Show("Oops! Cannot add category...");
            }
        }

        //Update category button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var categoryName = txtCategoryName.Text;
            var description = txtDescription.Text;

            try
            {
                //Database connection
                string connectionString = null;
                MySqlConnection conn;
                connectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
                conn = new MySqlConnection(connectionString);

                if (categoryName != "" && description != "")
                {
                    //updates category
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = new MySqlCommand("UPDATE MENU_TYPE SET TYPE_NAME = @cName, DESCRIPTION = @cDesc WHERE MENU_TYPE_ID = @ID", conn);
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
            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
            conn = new MySqlConnection(connectionString);

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
                        cmd = new MySqlCommand("DELETE FROM MENU_TYPE WHERE MENU_TYPE_ID = @ID", conn);
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
            //Database connection
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                //Search category
                string searchCategory = "SELECT MENU_TYPE_ID, TYPE_NAME, DESCRIPTION, CREATED_AT, UPDATED_AT FROM MENU_TYPE WHERE TYPE_NAME = '" + txtSearchCategory.Text + "' AND EMAIL_ADDRESS = '" + emailAddress + "' ";
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
    }
}
