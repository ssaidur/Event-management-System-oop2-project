namespace Event_management_System
{
    partial class adminlogin
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
            this.admin_to_login = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.login_close = new System.Windows.Forms.Label();
            this.admin_showpass = new System.Windows.Forms.CheckBox();
            this.adminlogin_btn = new System.Windows.Forms.Button();
            this.admin_password = new System.Windows.Forms.TextBox();
            this.admin_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.admin_to_login);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.login_close);
            this.panel1.Controls.Add(this.admin_showpass);
            this.panel1.Controls.Add(this.adminlogin_btn);
            this.panel1.Controls.Add(this.admin_password);
            this.panel1.Controls.Add(this.admin_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 459);
            this.panel1.TabIndex = 1;
            // 
            // admin_to_login
            // 
            this.admin_to_login.AutoSize = true;
            this.admin_to_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_to_login.ForeColor = System.Drawing.SystemColors.GrayText;
            this.admin_to_login.Location = new System.Drawing.Point(628, 421);
            this.admin_to_login.Name = "admin_to_login";
            this.admin_to_login.Size = new System.Drawing.Size(87, 18);
            this.admin_to_login.TabIndex = 10;
            this.admin_to_login.Text = "Login here";
            this.admin_to_login.Click += new System.EventHandler(this.admin_to_login_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(448, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Have an user accunt ?";
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.Location = new System.Drawing.Point(773, 6);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(22, 25);
            this.login_close.TabIndex = 8;
            this.login_close.Text = "x";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // admin_showpass
            // 
            this.admin_showpass.AutoSize = true;
            this.admin_showpass.BackColor = System.Drawing.Color.Transparent;
            this.admin_showpass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.admin_showpass.Location = new System.Drawing.Point(619, 286);
            this.admin_showpass.Name = "admin_showpass";
            this.admin_showpass.Size = new System.Drawing.Size(124, 20);
            this.admin_showpass.TabIndex = 7;
            this.admin_showpass.Text = "Show password";
            this.admin_showpass.UseVisualStyleBackColor = false;
            this.admin_showpass.CheckedChanged += new System.EventHandler(this.admin_showpass_CheckedChanged);
            // 
            // adminlogin_btn
            // 
            this.adminlogin_btn.BackColor = System.Drawing.Color.Navy;
            this.adminlogin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminlogin_btn.FlatAppearance.BorderSize = 0;
            this.adminlogin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminlogin_btn.ForeColor = System.Drawing.Color.White;
            this.adminlogin_btn.Location = new System.Drawing.Point(439, 320);
            this.adminlogin_btn.Name = "adminlogin_btn";
            this.adminlogin_btn.Size = new System.Drawing.Size(95, 35);
            this.adminlogin_btn.TabIndex = 5;
            this.adminlogin_btn.Text = "LOGIN";
            this.adminlogin_btn.UseVisualStyleBackColor = false;
            this.adminlogin_btn.Click += new System.EventHandler(this.adminlogin_btn_Click);
            // 
            // admin_password
            // 
            this.admin_password.Location = new System.Drawing.Point(439, 258);
            this.admin_password.Name = "admin_password";
            this.admin_password.PasswordChar = '*';
            this.admin_password.Size = new System.Drawing.Size(300, 22);
            this.admin_password.TabIndex = 4;
            // 
            // admin_name
            // 
            this.admin_name.Location = new System.Drawing.Point(439, 187);
            this.admin_name.Name = "admin_name";
            this.admin_name.Size = new System.Drawing.Size(300, 22);
            this.admin_name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Admin name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 459);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event";
            // 
            // adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminlogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label admin_to_login;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.CheckBox admin_showpass;
        private System.Windows.Forms.Button adminlogin_btn;
        private System.Windows.Forms.TextBox admin_password;
        private System.Windows.Forms.TextBox admin_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}