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
    public partial class ucAccount : UserControl
    {
        private static ucAccount instance;

        //Database connection
        MySqlConnection conn = new MySqlConnection("server=localhost; database=cks_db; uid=root; Convert Zero Datetime=True; pwd=\"\";");

        public static ucAccount Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucAccount();
                }
                return instance;
            }
        }

        public ucAccount()
        {
            InitializeComponent();
        }

        private void ucAccount_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;

            //shows proprietor's data
            LoadInfo();

            //displays time format
            InitializeTimePicker();

        }
        //sets time format in dateTimePicker
        void InitializeTimePicker()
        {
            //opening time
            dtpOpeningTime.Format = DateTimePickerFormat.Custom;
            dtpOpeningTime.CustomFormat = "HH:mm tt";
            dtpOpeningTime.ShowUpDown = true;

            //closing time
            dtpClosingTime.Format = DateTimePickerFormat.Custom;
            dtpClosingTime.CustomFormat = "HH:mm tt";
            dtpClosingTime.ShowUpDown = true;
        }

        //Updates proprietor's information
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string dt;
            string dt2;
            DateTime date = DateTime.Now;
            DateTime date2 = DateTime.Now;
            dt = date.ToLongTimeString();      
            dt2 = date2.ToShortDateString();

            try
            {
                conn.Open();

                //MemoryStream ms = new MemoryStream();
                //pbProfile.Image.Save(ms, pbProfile.Image.RawFormat);
                //byte[] img = ms.ToArray();

                string message = "Are you sure you want to save changes??";
                string title = "Save Changes";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    InitializeTimePicker();

                    string updateAccount = "UPDATE PROPRIETOR " +
                                            "SET FIRSTNAME = @fname, " +
                                            "LASTNAME = @lname, " +
                                            "STORE_NAME = @storeName, " +
                                            "LOCATION = @location, " +
                                            "OPENING_TIME = @opening, " +
                                            "CLOSING_TIME = @closing, " +
                                            "CONTACT_NUMBER = @contactNum, " +
                                            "PASSWORD = @password, " +
                                            "UPDATED_AT = @now " +
                                           // "PROFILE_PIC = @img " +
                                            "WHERE EMAIL_ADDRESS  = '" + AdminInfo.EmailAddress + "'";

                    MySqlCommand cmd = new MySqlCommand(updateAccount, conn);
                    cmd.Parameters.AddWithValue("@fname", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@storeName", txtStoreName.Text);
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@opening", dtpOpeningTime.Text);
                    cmd.Parameters.AddWithValue("@closing", dtpClosingTime.Text);
                    cmd.Parameters.AddWithValue("@contactNum", txtContactNum.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@now", string.Concat(dt2, " ", dt));
                    //cmd.Parameters.AddWithValue("@img", img);


                    int ctr = cmd.ExecuteNonQuery();
                    if (ctr > 0)
                    {
                        MessageBox.Show("Changes Saved.");
                    }
                    else
                    {
                        MessageBox.Show("Cannot save changes.");
                    }
                    conn.Close();
                    LoadInfo();
                }
                else
                {
                    //...
                }   
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Loads proprietor's data
        void LoadInfo()
        {
            conn.Open();
            string query = "SELECT * FROM PROPRIETOR WHERE EMAIL_ADDRESS = '" + AdminInfo.EmailAddress + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                //gets image from database
                byte[] array = (byte[])reader["PROFILE_PIC"];
                MemoryStream ms = new MemoryStream(array);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
                pbProfile.BackgroundImageLayout = ImageLayout.Stretch;
                pbProfile.BackgroundImage = bitmap;

                txtFirstname.Text = reader["FIRSTNAME"].ToString();
                txtLastName.Text = reader["LASTNAME"].ToString();
                txtContactNum.Text = reader["CONTACT_NUMBER"].ToString();
                txtPassword.Text = reader["PASSWORD"].ToString();
                txtPassword.UseSystemPasswordChar = true;
                txtStoreName.Text = reader["STORE_NAME"].ToString();
                txtLocation.Text = reader["LOCATION"].ToString();
                lblCreatedAt.Text = reader["CREATED_AT"].ToString();
                lblUpdatedAt.Text = reader["UPDATED_AT"].ToString();
                dtpOpeningTime.Text = reader["OPENING_TIME"].ToString();
                dtpClosingTime.Text = reader["CLOSING_TIME"].ToString();
            }
            conn.Close();
        }

        private void lblStoreDescription_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        //Upload new profile
        private void btnUploadNew_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif;) | *.jpg; *.jpeg; *.png; *.gif;";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pbProfile.Image = Image.FromFile(opf.FileName);
                    btnSave.Visible = true;
                    btnUploadNew.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Save button for updating profile picture
        private void btnSave_Click(object sender, EventArgs e)
        {
            string dt;
            string dt2;
            DateTime date = DateTime.Now;
            DateTime date2 = DateTime.Now;
            dt = date.ToLongTimeString();
            dt2 = date2.ToShortDateString();

            try
            {
                conn.Open();

                MemoryStream ms = new MemoryStream();
                pbProfile.Image.Save(ms, pbProfile.Image.RawFormat);
                byte[] img = ms.ToArray();

                InitializeTimePicker();

                string updateAccount = "UPDATE PROPRIETOR " +
                                        "SET UPDATED_AT = @now, " +
                                        "PROFILE_PIC = @img " +
                                        "WHERE EMAIL_ADDRESS  = '" + AdminInfo.EmailAddress + "'";

                MySqlCommand cmd = new MySqlCommand(updateAccount, conn);
                cmd.Parameters.AddWithValue("@now", string.Concat(dt2, " ", dt));
                cmd.Parameters.AddWithValue("@img", img);

                int ctr = cmd.ExecuteNonQuery();
                if (ctr > 0)
                {
                    MessageBox.Show("Profile Saved.");
                }
                else
                {
                    MessageBox.Show("Cannot save changes.");
                }
                conn.Close();
                LoadInfo();
                btnSave.Visible = false;
                btnUploadNew.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
