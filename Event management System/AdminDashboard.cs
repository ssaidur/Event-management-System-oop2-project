using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace Event_management_System
{
    public partial class AdminDashboard : Form
    {
        
        string connectionString = @"Data Source=.\SQLEXPRESS;
                                    Initial Catalog=MyDB;
                                    Integrated Security=True;
                                    TrustServerCertificate=True";

        public AdminDashboard()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    string query = @"SELECT booking_id, customer_name, phone,
                                     event_type, event_date, venue, guest_count,
                                     services, total_budget, booking_status, booking_date
                                     FROM bookings";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    bookin.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (bookin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this booking?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            int bookingId = Convert.ToInt32(
                bookin.SelectedRows[0].Cells["booking_id"].Value);

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "DELETE FROM bookings WHERE booking_id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = bookingId;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Booking Deleted Successfully");
                LoadBookings(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bookin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                edit_booking_status.Text =
                bookin.Rows[e.RowIndex].Cells["booking_status"].Value.ToString();
            }
        }

        private void edit_booking_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_booking_status_Click(object sender, EventArgs e)
        {
            if (bookin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking");
                return;
            }

            if (string.IsNullOrWhiteSpace(edit_booking_status.Text))
            {
                MessageBox.Show("Please select new status");
                return;
            }

            int bookingId = Convert.ToInt32(
                bookin.SelectedRows[0].Cells["booking_id"].Value);

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "UPDATE bookings SET booking_status=@booking_status WHERE booking_id=@id";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.Add("@booking_status", SqlDbType.VarChar).Value = edit_booking_status.Text;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = bookingId;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Booking Status Updated Successfully");
                LoadBookings(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login LForm = new login();
            LForm.Show();
            this.Hide();
        }

        private void btnpay_das_Click(object sender, EventArgs e)
        {
            paymentdashbord pdForm = new paymentdashbord();
            pdForm.Show();
            this.Hide();
        }
    }
}
