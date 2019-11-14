﻿namespace GUI
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.logingroupbox = new System.Windows.Forms.GroupBox();
            this.passwordcheckbox = new System.Windows.Forms.CheckBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.resetpasswordbutton = new System.Windows.Forms.Button();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.errormessagelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logingroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logingroupbox
            // 
            this.logingroupbox.Controls.Add(this.passwordcheckbox);
            this.logingroupbox.Controls.Add(this.exitbutton);
            this.logingroupbox.Controls.Add(this.loginbutton);
            this.logingroupbox.Controls.Add(this.resetpasswordbutton);
            this.logingroupbox.Controls.Add(this.passwordtextbox);
            this.logingroupbox.Controls.Add(this.usernametextbox);
            this.logingroupbox.Controls.Add(this.passwordlabel);
            this.logingroupbox.Controls.Add(this.usernamelabel);
            this.logingroupbox.Location = new System.Drawing.Point(80, 245);
            this.logingroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logingroupbox.Name = "logingroupbox";
            this.logingroupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logingroupbox.Size = new System.Drawing.Size(446, 145);
            this.logingroupbox.TabIndex = 0;
            this.logingroupbox.TabStop = false;
            this.logingroupbox.Text = "Login";
            // 
            // passwordcheckbox
            // 
            this.passwordcheckbox.AutoSize = true;
            this.passwordcheckbox.ForeColor = System.Drawing.Color.White;
            this.passwordcheckbox.Location = new System.Drawing.Point(344, 66);
            this.passwordcheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordcheckbox.Name = "passwordcheckbox";
            this.passwordcheckbox.Size = new System.Drawing.Size(75, 24);
            this.passwordcheckbox.TabIndex = 2;
            this.passwordcheckbox.Text = "Show";
            this.passwordcheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordcheckbox.UseVisualStyleBackColor = true;
            this.passwordcheckbox.CheckedChanged += new System.EventHandler(this.passwordcheckbox_CheckedChanged);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(322, 103);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(112, 35);
            this.exitbutton.TabIndex = 7;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Location = new System.Drawing.Point(201, 103);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(112, 35);
            this.loginbutton.TabIndex = 6;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // resetpasswordbutton
            // 
            this.resetpasswordbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.resetpasswordbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetpasswordbutton.Location = new System.Drawing.Point(9, 103);
            this.resetpasswordbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetpasswordbutton.Name = "resetpasswordbutton";
            this.resetpasswordbutton.Size = new System.Drawing.Size(183, 35);
            this.resetpasswordbutton.TabIndex = 5;
            this.resetpasswordbutton.Text = "Reset password";
            this.resetpasswordbutton.UseVisualStyleBackColor = false;
            this.resetpasswordbutton.Click += new System.EventHandler(this.resetpasswordbutton_Click);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(184, 63);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(148, 26);
            this.passwordtextbox.TabIndex = 3;
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(184, 20);
            this.usernametextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(148, 26);
            this.usernametextbox.TabIndex = 2;
            this.usernametextbox.TextChanged += new System.EventHandler(this.usernametextbox_TextChanged);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Location = new System.Drawing.Point(92, 63);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(82, 20);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password:";
            this.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordlabel.Click += new System.EventHandler(this.passwordlabel_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.ForeColor = System.Drawing.Color.White;
            this.usernamelabel.Location = new System.Drawing.Point(88, 25);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(87, 20);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "Username:";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errormessagelabel
            // 
            this.errormessagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessagelabel.ForeColor = System.Drawing.Color.Red;
            this.errormessagelabel.Location = new System.Drawing.Point(172, 226);
            this.errormessagelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errormessagelabel.Name = "errormessagelabel";
            this.errormessagelabel.Size = new System.Drawing.Size(430, 22);
            this.errormessagelabel.TabIndex = 1;
            this.errormessagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 217);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(477, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 175);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(598, 408);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errormessagelabel);
            this.Controls.Add(this.logingroupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "login";
            this.Text = "CS 3321 LMS";
            this.Load += new System.EventHandler(this.login_Load);
            this.logingroupbox.ResumeLayout(false);
            this.logingroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logingroupbox;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button resetpasswordbutton;
        public System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label errormessagelabel;
        private System.Windows.Forms.CheckBox passwordcheckbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

