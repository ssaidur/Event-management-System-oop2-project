using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Event_management_System
{
    public partial class booking : Form
    {
        SqlConnection connect = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=MyDB;
              Integrated Security=True;
              TrustServerCertificate=True");
        public booking()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Calculat_Budget_Click(object sender, EventArgs e)
        {
            if (txtGuest.Text == "")
            {
                MessageBox.Show("Please Enter your gust number",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int total = 0;

            // Venue (fixed)
            total += 20000;

            // Guests
            int guest = int.Parse(txtGuest.Text);

            // Services
            if (chkDecoration.Checked)
                total += 10000;

            if (chkPhotography.Checked)
                total += 8000;

            if (chkVideography.Checked)
                total += 10000;

            if (chkSound.Checked)
                total += 8000;

            if (chkLighting.Checked)
                total += 8000;

            if (chkHost.Checked)
                total += 10000;

            // Catering (per person)
            if (chkCatering.Checked)
            {
                total += guest * 500;
            }

            txtBudget.Text = total.ToString();

        }

        private void txtBudget_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Booking_Click(object sender, EventArgs e)
        {
            {
                if (txtName.Text == "" || Cphone.Text == "" || txtBudget.Text == "")
                {
                    MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Venue.Text == "" || Event_Date.Value == null)
                {
                    MessageBox.Show("Please select Venue and Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Cphone.Text.Length != 11)
                {
                    MessageBox.Show("Invalid phone number for Customer Information",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }



                if (Transation_id.Text == "")
                {
                    MessageBox.Show("Please select Payment Method and enter transaction ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    connect.Open();

                    // Check venue availability
                    string checkQuery =
                    "SELECT COUNT(*) FROM bookings WHERE event_date=@date AND venue=@venue";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                    {
                        checkCmd.Parameters.AddWithValue("@date", Event_Date.Value.Date);
                        checkCmd.Parameters.AddWithValue("@venue", Venue.Text);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show(
                                "This venue is already booked on selected date!",
                                "Booking Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Get selected services
                    string services = "";


                    if (chkDecoration.Checked)
                        services += "Decoration, ";

                    if (chkCatering.Checked)
                        services += "Catering, ";

                    if (chkPhotography.Checked)
                        services += "Photography, ";

                    if (chkVideography.Checked)
                        services += "Videography, ";

                    if (chkSound.Checked)
                        services += "Sound, ";

                    if (chkLighting.Checked)
                        services += "Lighting, ";

                    if (chkHost.Checked)
                        services += "Event Host, ";

                    // last comma remove
                    if (services != "")
                        services = services.Substring(0, services.Length - 2);
                    if (services == "")
                    {
                        MessageBox.Show("Please select at least one service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert booking
                    string insertQuery = @"
    INSERT INTO bookings
    (id, customer_name, phone, event_type, event_date, venue, guest_count,
     services, total_budget, payment_method, payment_phone, transaction_id,
     payment_status, booking_status, booking_date)
    VALUES
    (@id, @name, @phone, @event_type, @event_date, @venue, @guest_count,
     @services, @budget, @payment_method, @payment_phone, @transaction_id,
     @payment_status, @booking_status, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", Cphone.Text.Trim());
                        cmd.Parameters.AddWithValue("@event_type", Event_type.Text);
                        cmd.Parameters.AddWithValue("@event_date", Event_Date.Value.Date);
                        cmd.Parameters.AddWithValue("@venue", Venue.Text);
                        cmd.Parameters.AddWithValue("@guest_count", txtGuest.Text.Trim());
                        cmd.Parameters.AddWithValue("@services", services);
                        cmd.Parameters.AddWithValue("@budget", txtBudget.Text.Trim());
                        cmd.Parameters.AddWithValue("@payment_method", Payment_Method.Text);
                        cmd.Parameters.AddWithValue("@payment_phone", Pay_phone.Text.Trim());
                        cmd.Parameters.AddWithValue("@transaction_id", Transation_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@payment_status", "Paid"); 
                        cmd.Parameters.AddWithValue("@booking_status", "Confirmed");
                        cmd.Parameters.AddWithValue("@id", login.UserSession.UserId);


                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Booking Confirmed Successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Thanks_for_booking tForm = new Thanks_for_booking();
                    tForm.Show();
                    this.Hide();

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
        }

        private void Bk_logout_Click(object sender, EventArgs e)
        {
            login LForm = new login();
            LForm.Show();
            this.Hide();
        }

        private void Booking_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPay_Now_Click(object sender, EventArgs e)
        {

            if (Payment_Method.Text == "")
            {
                MessageBox.Show("Please select Payment Method",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }



            if (txtBudget.Text == "")
            {
                MessageBox.Show("Please Calculat your budget",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }


            if (Pay_phone.Text == "")
            {
                MessageBox.Show("Please enter phone number",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            
            if (pay_pin.Text == "")
            {
                MessageBox.Show("Please enter PIN",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }


            if (Pay_phone.Text.Length != 11)
            {
                MessageBox.Show("Invalid phone number for Payment",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }



            MessageBox.Show("Your payment is successful",
                    "Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            Transation_id.Text = GenerateUniqueTransactionID();
        }

        private string GenerateUniqueTransactionID()
        {
            
            return Guid.NewGuid()
                       .ToString("N")
                       .Substring(0, 8)
                       .ToUpper();
        }

        private void Payment_Method_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void user_infobtn_Click(object sender, EventArgs e)
        {
            UserInfoForm uuForm = new UserInfoForm();
            uuForm.Show();
            this.Hide();
        }
    }
    }

