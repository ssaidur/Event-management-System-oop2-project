using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Event_management_System
{
    public partial class adminlogin : Form
    {
        SqlConnection connect = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=MyDB;
              Integrated Security=True;
              TrustServerCertificate=True");
        public adminlogin()
        {
            InitializeComponent();
        }

        private void admin_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (admin_showpass.Checked)
            {
                admin_password.PasswordChar = '\0';
            }
            else
            {
                admin_password.PasswordChar = '*';
            }
        }

        private void adminlogin_btn_Click(object sender, EventArgs e)
        {

            if (admin_name.Text == "" || admin_password.Text == "")
            {
                MessageBox.Show("Please enter admin name and password",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();

                string query =
                "SELECT COUNT(*) FROM admin_login WHERE admin_name=@name AND admin_password=@pass";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@name", admin_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", admin_password.Text.Trim());

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("Admin Login Successful",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AdminDashboard adForm = new AdminDashboard();
                        adForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Admin Name or Password",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }


        }

        private void admin_to_login_Click(object sender, EventArgs e)
        {
            login LForm = new login();
            LForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
