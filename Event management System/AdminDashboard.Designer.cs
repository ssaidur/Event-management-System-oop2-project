namespace Event_management_System
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.bookin = new System.Windows.Forms.DataGridView();
            this.login_close = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_edit_booking_status = new System.Windows.Forms.Button();
            this.edit_booking_status = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpay_das = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnpay_das);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_edit_booking_status);
            this.panel1.Controls.Add(this.btnDeleteBooking);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.edit_booking_status);
            this.panel1.Controls.Add(this.bookin);
            this.panel1.Controls.Add(this.login_close);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 644);
            this.panel1.TabIndex = 2;
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBooking.FlatAppearance.BorderSize = 0;
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.Location = new System.Drawing.Point(794, 600);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(121, 35);
            this.btnDeleteBooking.TabIndex = 6;
            this.btnDeleteBooking.Text = "Delete Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // bookin
            // 
            this.bookin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookin.Location = new System.Drawing.Point(11, 70);
            this.bookin.Name = "bookin";
            this.bookin.RowHeadersWidth = 51;
            this.bookin.RowTemplate.Height = 24;
            this.bookin.Size = new System.Drawing.Size(1015, 468);
            this.bookin.TabIndex = 9;
            this.bookin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookin_CellContentClick);
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.ForeColor = System.Drawing.Color.White;
            this.login_close.Location = new System.Drawing.Point(1001, 15);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(22, 25);
            this.login_close.TabIndex = 8;
            this.login_close.Text = "x";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Booking status";
            // 
            // btn_edit_booking_status
            // 
            this.btn_edit_booking_status.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_edit_booking_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_booking_status.FlatAppearance.BorderSize = 0;
            this.btn_edit_booking_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_booking_status.ForeColor = System.Drawing.Color.White;
            this.btn_edit_booking_status.Location = new System.Drawing.Point(610, 600);
            this.btn_edit_booking_status.Name = "btn_edit_booking_status";
            this.btn_edit_booking_status.Size = new System.Drawing.Size(170, 35);
            this.btn_edit_booking_status.TabIndex = 5;
            this.btn_edit_booking_status.Text = "Edit Booking Status";
            this.btn_edit_booking_status.UseVisualStyleBackColor = false;
            this.btn_edit_booking_status.Click += new System.EventHandler(this.btn_edit_booking_status_Click);
            // 
            // edit_booking_status
            // 
            this.edit_booking_status.FormattingEnabled = true;
            this.edit_booking_status.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled",
            "Completed"});
            this.edit_booking_status.Location = new System.Drawing.Point(31, 581);
            this.edit_booking_status.Name = "edit_booking_status";
            this.edit_booking_status.Size = new System.Drawing.Size(306, 24);
            this.edit_booking_status.TabIndex = 10;
            this.edit_booking_status.SelectedIndexChanged += new System.EventHandler(this.edit_booking_status_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(921, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Event Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Booking Dashbord";
            // 
            // btnpay_das
            // 
            this.btnpay_das.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnpay_das.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpay_das.FlatAppearance.BorderSize = 0;
            this.btnpay_das.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpay_das.ForeColor = System.Drawing.Color.White;
            this.btnpay_das.Location = new System.Drawing.Point(868, 559);
            this.btnpay_das.Name = "btnpay_das";
            this.btnpay_das.Size = new System.Drawing.Size(148, 35);
            this.btnpay_das.TabIndex = 13;
            this.btnpay_das.Text = "Payment Dashbord";
            this.btnpay_das.UseVisualStyleBackColor = false;
            this.btnpay_das.Click += new System.EventHandler(this.btnpay_das_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 641);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.Button btn_edit_booking_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView bookin;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.ComboBox edit_booking_status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpay_das;
    }
}