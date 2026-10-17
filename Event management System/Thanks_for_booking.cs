using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_management_System
{
    public partial class Thanks_for_booking : Form
    {
        public Thanks_for_booking()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Thanks_to_logout_btn_Click(object sender, EventArgs e)
        {
            login LForm = new login();
            LForm.Show();
            this.Hide();
        }
    }
}
