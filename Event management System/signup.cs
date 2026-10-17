using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Event_management_System
{
    public partial class signup : Form
    {
        SqlConnection connect = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=MyDB;
              Integrated Security=True;
              TrustServerCertificate=True");

        public signup()
        {
            InitializeComponent();
        }

        private void signup_loginHere_Click(object sender, EventArgs e)
        {
            login LForm = new login();
            LForm.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            
            if(signup_name.Text==""|| signup_email.Text==""||
                signup_username.Text==""||signup_password.Text=="")
            {
                MessageBox.Show("Please fill all blank field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open(); 

                        string checkUsername =
                            "SELECT * FROM admin WHERE username = @username";

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue(
                                "@username", signup_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(
                                    signup_username.Text + " already exists",
                                    "Error Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData =
                                    "INSERT INTO admin (name, email, username, password, date_created) " +
                                    "VALUES (@name, @email, @username, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@name", signup_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show(
                                        "Register successfully",
                                        "Information Message",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                                    login LForm = new login();
                                    LForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error connecting Database: " + ex.Message,
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }


        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(signup_showpass.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
