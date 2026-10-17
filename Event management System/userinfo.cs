using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Event_management_System
{
    public partial class UserInfoForm : Form
    {
        SqlConnection connect = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;TrustServerCertificate=True");

        public UserInfoForm()
        {
            InitializeComponent();

            

            LoadUserInfo();
            LoadUserBookings();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            // Debug: Check if user is logged in
            MessageBox.Show("User ID: " + login.UserSession.UserId + "\nUsername: " + login.UserSession.UserName);

            if (login.UserSession.UserId == 0)
            {
                MessageBox.Show("ERROR: No user logged in! UserId is 0");
                return;
            }

            LoadUserInfo();
            LoadUserBookings();
        }

        private void LoadUserInfo()
        {
            try
            {
                connect.Open();

                string userQuery =
                    "SELECT username, name, email FROM admin WHERE id=@uid";

                using (SqlCommand cmd = new SqlCommand(userQuery, connect))
                {
                    cmd.Parameters.Add("@uid", SqlDbType.Int)
                                   .Value = login.UserSession.UserId;

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtUsername.Text = dr["username"].ToString();
                        txtName.Text = dr["name"].ToString();
                        txtPhone.Text = dr["email"].ToString();
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user info: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }


        private void LoadUserBookings()
        {
            try
            {
                // Debug: Check user ID first
                if (login.UserSession.UserId == 0)
                {
                    MessageBox.Show("No user logged in!");
                    return;
                }

                connect.Open();

                // First, let's see what's in the table
                string debugQuery = "SELECT TOP 5 * FROM bookings";
                using (SqlCommand debugCmd = new SqlCommand(debugQuery, connect))
                {
                    SqlDataAdapter debugDa = new SqlDataAdapter(debugCmd);
                    DataTable debugDt = new DataTable();
                    debugDa.Fill(debugDt);

                    // Show column names
                    string columns = "Columns: ";
                    foreach (DataColumn col in debugDt.Columns)
                    {
                        columns += col.ColumnName + ", ";
                    }
                    //MessageBox.Show(columns);
                }

                connect.Close();
                connect.Open();

                // Now query with correct column name (replace 'id' with actual column name)
                string bookingQuery = @"
            SELECT event_type, event_date, venue,
                   guest_count, services, total_budget, booking_status
            FROM bookings
            WHERE id=@uid";

                using (SqlCommand cmd = new SqlCommand(bookingQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@uid", login.UserSession.UserId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //MessageBox.Show("Rows found: " + dt.Rows.Count);

                    dataGridViewBookings.DataSource = dt;
                    dataGridViewBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void Bookinfbtn_Click(object sender, EventArgs e)
        {
            booking bFrom = new booking();
            bFrom.Show();
            this.Hide();
        }

        private void ulogout_btn_Click(object sender, EventArgs e)
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
