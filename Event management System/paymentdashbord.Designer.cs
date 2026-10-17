namespace Event_management_System
{
    partial class paymentdashbord
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit_payment_status = new System.Windows.Forms.Button();
            this.btnadmindash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.edit_pay_status = new System.Windows.Forms.ComboBox();
            this.payment = new System.Windows.Forms.DataGridView();
            this.login_close = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_edit_payment_status);
            this.panel1.Controls.Add(this.btnadmindash);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.edit_pay_status);
            this.panel1.Controls.Add(this.payment);
            this.panel1.Controls.Add(this.login_close);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 644);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Payment Dashbord";
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
            // btn_edit_payment_status
            // 
            this.btn_edit_payment_status.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_edit_payment_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_payment_status.FlatAppearance.BorderSize = 0;
            this.btn_edit_payment_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_payment_status.ForeColor = System.Drawing.Color.White;
            this.btn_edit_payment_status.Location = new System.Drawing.Point(588, 600);
            this.btn_edit_payment_status.Name = "btn_edit_payment_status";
            this.btn_edit_payment_status.Size = new System.Drawing.Size(170, 35);
            this.btn_edit_payment_status.TabIndex = 5;
            this.btn_edit_payment_status.Text = "Edit Payment Status";
            this.btn_edit_payment_status.UseVisualStyleBackColor = false;
            this.btn_edit_payment_status.Click += new System.EventHandler(this.btn_edit_payment_status_Click);
            // 
            // btnadmindash
            // 
            this.btnadmindash.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnadmindash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadmindash.FlatAppearance.BorderSize = 0;
            this.btnadmindash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmindash.ForeColor = System.Drawing.Color.White;
            this.btnadmindash.Location = new System.Drawing.Point(767, 600);
            this.btnadmindash.Name = "btnadmindash";
            this.btnadmindash.Size = new System.Drawing.Size(148, 35);
            this.btnadmindash.TabIndex = 6;
            this.btnadmindash.Text = "Booking Dashbord";
            this.btnadmindash.UseVisualStyleBackColor = false;
            this.btnadmindash.Click += new System.EventHandler(this.btnadmindash_Click);
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
            // edit_pay_status
            // 
            this.edit_pay_status.FormattingEnabled = true;
            this.edit_pay_status.Items.AddRange(new object[] {
            "Pending",
            "Paid",
            "Unpaid",
            "Cancelled"});
            this.edit_pay_status.Location = new System.Drawing.Point(31, 578);
            this.edit_pay_status.Name = "edit_pay_status";
            this.edit_pay_status.Size = new System.Drawing.Size(306, 24);
            this.edit_pay_status.TabIndex = 10;
            // 
            // payment
            // 
            this.payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment.Location = new System.Drawing.Point(11, 70);
            this.payment.Name = "payment";
            this.payment.RowHeadersWidth = 51;
            this.payment.RowTemplate.Height = 24;
            this.payment.Size = new System.Drawing.Size(1005, 468);
            this.payment.TabIndex = 9;
            this.payment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payment_CellContentClick);
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
            this.label4.Size = new System.Drawing.Size(143, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Payment status";
            // 
            // paymentdashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 638);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paymentdashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentdashbord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit_payment_status;
        private System.Windows.Forms.Button btnadmindash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox edit_pay_status;
        private System.Windows.Forms.DataGridView payment;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.Label label4;
    }
}