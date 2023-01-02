﻿using System;
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
        }

        //Populates dgvStaff
        void PopulateData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT STAFF_ID, FIRSTNAME, LASTNAME, CONTACT_NUMBER, EMAIL_ADDRESS, ADDRESS, ROLE, HIRE_DATE, UPDATED_AT FROM STAFF", conn);
            adapter.Fill(dt);
            dgvStaff.DataSource = dt;
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
                cmd.Parameters.AddWithValue("@conNum", txtContactNum);
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

        }

        //Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void pnlForm_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
