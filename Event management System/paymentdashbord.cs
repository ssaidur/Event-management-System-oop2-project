using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_management_System
{
    public partial class paymentdashbord : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;
                                    Initial Catalog=MyDB;
                                    Integrated Security=True;
                                    TrustServerCertificate=True";
        public paymentdashbord()
        {
            InitializeComponent();
            Loadpayment();
        }

        private void Loadpayment()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    string query = @"SELECT  booking_id, total_budget, payment_method, payment_phone,transaction_id, payment_status,booking_date FROM bookings;
";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    payment.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login LForm = new login();
            LForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void payment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                edit_pay_status.Text =
                payment.Rows[e.RowIndex].Cells["payment_status"].Value.ToString();
            }
        }

        private void btn_edit_payment_status_Click(object sender, EventArgs e)
        {
            if (payment.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Payment");
                return;
            }

            if (string.IsNullOrWhiteSpace(edit_pay_status.Text))
            {
                MessageBox.Show("Please enter new payment status");
                return;
            }

            int bookingId = Convert.ToInt32(
                payment.SelectedRows[0].Cells["booking_id"].Value);

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "UPDATE bookings SET payment_status=@pay_status WHERE booking_id=@id";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.Add("@pay_status", SqlDbType.VarChar).Value = edit_pay_status.Text;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = bookingId;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Payment Status Updated Successfully");
                Loadpayment(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnadmindash_Click(object sender, EventArgs e)
        {
            AdminDashboard adForm = new AdminDashboard();
            adForm.Show();
            this.Hide();
        }
    }
}
