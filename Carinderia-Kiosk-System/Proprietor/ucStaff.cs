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

namespace Carinderia_Kiosk_System.Proprietor
{
    public partial class ucStaff : UserControl
    {
        private static ucStaff instance;

        //Database connection
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

        public static ucStaff Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucStaff();
                }
                return instance;
            }
        }

        public ucStaff()
        {
            InitializeComponent();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            GetStaffID();

            PopulateData();

            
        }

        //Populates dgvStaff
        void PopulateData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT STAFF_ID, FIRSTNAME, LASTNAME, CONTACT_NUMBER, EMAIL_ADDRESS, ADDRESS, ROLE, HIRE_DATE, UPDATED_AT FROM STAFF", conn);
            adapter.Fill(dt);

            dgvStaff.RowTemplate.Height = 50;
            dgvStaff.DataSource = dt;

            //Column header names
            dgvStaff.Columns[0].HeaderText = "Staff ID";
            dgvStaff.Columns[1].HeaderText = "First Name";
            dgvStaff.Columns[2].HeaderText = "Last Name";
            dgvStaff.Columns[3].HeaderText = "Contact No.";
            dgvStaff.Columns[4].HeaderText = "Email Address";
            dgvStaff.Columns[5].HeaderText = "Address";
            dgvStaff.Columns[6].HeaderText = "Role";
            dgvStaff.Columns[7].HeaderText = "Date Hired";
            dgvStaff.Columns[8].HeaderText = "Last Update";

            conn.Close();
        }

        //Displays a generated code in txtStaffIDNum textbox for staff code/ID
        void GetStaffID()
        {
            string staffID;
            try
            {
                conn.Open();
                string query = "SELECT STAFF_NUM " +
                                "FROM STAFF " +
                                "ORDER BY STAFF_NUM DESC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    staffID = id.ToString("STF000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    staffID = ("STF001");
                }
                else
                {
                    staffID = ("STF001");
                }

                conn.Close();
                txtStaffIDNum.Text = staffID.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            var hireDate = DateTime.Parse(dateTimePicker1.Value.ToString("dd/MM/yyyy"));

            try
            {
                conn.Open();

                //saves new staff member
                string addStaff = "INSERT INTO STAFF " +
                                        "SET STAFF_ID = @staffID, " +
                                        "FIRSTNAME = @firstname, " +
                                        "LASTNAME = @lastname, " +
                                        "CONTACT_NUMBER = @conNum, " +
                                        "EMAIL_ADDRESS = @email, " +
                                        "ADDRESS = @address, " +
                                        "ROLE = @role, " +
                                        "HIRE_DATE = @hireDate, " +
                                        "PROPRIETOR_ID = (SELECT PROPRIETOR_ID FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "')";
                MySqlCommand cmd = new MySqlCommand(addStaff, conn);

                cmd.Parameters.AddWithValue("@staffID", txtStaffIDNum.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                cmd.Parameters.AddWithValue("@conNum", txtContactNum.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@role", txtRole.Text);
                cmd.Parameters.AddWithValue("@hireDate", hireDate);

                var ctr = cmd.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Staff added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add a staff member.");
                }
                conn.Close();
                PopulateData();
                GetStaffID();
                //ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                //updates staff info
                MySqlCommand cmd = new MySqlCommand();
                cmd = new MySqlCommand("UPDATE STAFF " +
                    "SET FIRSTNAME = @fname, " +
                    "LASTNAME = @lname, " +
                    "CONTACT_NUMBER = @conNum, " +
                    "EMAIL_ADDRESS = @email, " +
                    "ADDRESS = @address, " +
                    "ROLE = @role, " +
                    "HIRE_DATE = @hireDate " +
                    "WHERE STAFF_ID = @ID", conn);
                
                cmd.Parameters.AddWithValue("@ID", txtStaffIDNum);
                cmd.Parameters.AddWithValue("@fname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastname.Text);
                cmd.Parameters.AddWithValue("@conNum", txtContactNum.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@role", txtRole.Text);
                cmd.Parameters.AddWithValue("@hireDate", dateTimePicker1.Text);

                var ctr = cmd.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Staff information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Cannot update selected staff information.");
                }
                conn.Close();
                PopulateData();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Do you want to remove this staff member?";
                string title = "Remove Staff";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //deletes selected category
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = new MySqlCommand("DELETE FROM STAFF WHERE STAFF_ID = @ID", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ID", txtStaffIDNum.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Staff member removed successfully!");
                    PopulateData();
                    ClearData();
                }
                else
                {
                    //...
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                //Search category
                string searchCategory = "SELECT STAFF_ID, FIRSTNAME, LASTNAME, CONTACT_NUMBER, EMAIL_ADDRESS, ADDRESS, ROLE, HIRE_DATE FROM STAFF " +
                                         "WHERE STAFF_ID ='" + txtSearch.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(searchCategory, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                txtStaffIDNum.Text = dt.ToString();
                txtFirstname.Text = dt.ToString();
                txtLastname.Text = dt.ToString();
                txtContactNum.Text = dt.ToString();
                txtEmail.Text = dt.ToString();
                txtAddress.Text = dt.ToString();
                txtRole.Text = dt.ToString();
                dateTimePicker1.Text = dt.ToString();
                dgvStaff.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        //Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateData();
        }

        //dgvStaff RowHeaderMouseClick Event 
        private void dgvStaff_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtStaffIDNum.Text = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtFirstname.Text = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastname.Text = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtContactNum.Text = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtRole.Text = dgvStaff.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker1.Text = dgvStaff.Rows[e.RowIndex].Cells[7].Value.ToString();

            //DataGridViewRow dr = dgvStaff.SelectedRows[0];

            //txtStaffIDNum.Text = dr.Cells[0].Value.ToString();
            //txtFirstname.Text = dr.Cells[1].Value.ToString();
            //txtLastname.Text = dr.Cells[2].Value.ToString();
            //txtContactNum.Text = dr.Cells[3].Value.ToString();
            //txtEmail.Text = dr.Cells[4].Value.ToString();
            //txtAddress.Text = dr.Cells[5].Value.ToString();
            //txtRole.Text = dr.Cells[6].Value.ToString();
            //dateTimePicker1.Text = dr.Cells[7].Value.ToString();
        }

        //Clears text in textboxes
        void ClearData()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtContactNum.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtRole.Text = "";
            dateTimePicker1.Text = "";
        }

        void SearchStaff()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT STAFF_ID, FIRSTNAME, LASTNAME, CONTACT_NUMBER, EMAIL_ADDRESS, ADDRESS, ROLE, HIRE_DATE, UPDATED_AT FROM STAFF WHERE STAFF_ID LIKE '" + txtSearch.Text + "' ", conn);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);

            dgvStaff.RowTemplate.Height = 50;
            dgvStaff.DataSource = dt;

            //Column header names
            dgvStaff.Columns[0].HeaderText = "Staff ID";
            dgvStaff.Columns[1].HeaderText = "First Name";
            dgvStaff.Columns[2].HeaderText = "Last Name";
            dgvStaff.Columns[3].HeaderText = "Contact No.";
            dgvStaff.Columns[4].HeaderText = "Email Address";
            dgvStaff.Columns[5].HeaderText = "Address";
            dgvStaff.Columns[6].HeaderText = "Role";
            dgvStaff.Columns[7].HeaderText = "Date Hired";
            dgvStaff.Columns[8].HeaderText = "Last Update";

            conn.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchStaff();

            if (txtSearch.Text == "")
            {
                PopulateData();
            }
        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           //dgvStaff.CurrentCell.Value = dateTimePicker1.Text.ToString();
        }

        private void pbSearchIcon_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                //Search category
                string searchCategory = "SELECT STAFF_ID, FIRSTNAME, LASTNAME, CONTACT_NUMBER, EMAIL_ADDRESS, ADDRESS, ROLE, HIRE_DATE FROM STAFF " +
                                         "WHERE STAFF_ID ='" + txtSearch.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(searchCategory, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                txtStaffIDNum.Text = dt.ToString();
                txtFirstname.Text = dt.ToString();
                txtLastname.Text = dt.ToString();
                txtContactNum.Text = dt.ToString();
                txtEmail.Text = dt.ToString();
                txtAddress.Text = dt.ToString();
                txtRole.Text = dt.ToString();
                dateTimePicker1.Text = dt.ToString();
                dgvStaff.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
