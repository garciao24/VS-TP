namespace GUI
{
    partial class mainscreen
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
            this.welcomelabel = new System.Windows.Forms.Label();
            this.studentnamelabel = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.enrolledclassesbutton = new System.Windows.Forms.Button();
            this.gpabutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.secretlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.ForeColor = System.Drawing.Color.White;
            this.welcomelabel.Location = new System.Drawing.Point(12, 9);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(52, 13);
            this.welcomelabel.TabIndex = 0;
            this.welcomelabel.Text = "Welcome";
            // 
            // studentnamelabel
            // 
            this.studentnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnamelabel.ForeColor = System.Drawing.Color.White;
            this.studentnamelabel.Location = new System.Drawing.Point(70, 9);
            this.studentnamelabel.Name = "studentnamelabel";
            this.studentnamelabel.Size = new System.Drawing.Size(219, 13);
            this.studentnamelabel.TabIndex = 1;
            this.studentnamelabel.Click += new System.EventHandler(this.studentnamelabel_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Location = new System.Drawing.Point(12, 34);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(116, 23);
            this.updatebutton.TabIndex = 8;
            this.updatebutton.Text = "Update Information";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // enrolledclassesbutton
            // 
            this.enrolledclassesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.enrolledclassesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrolledclassesbutton.Location = new System.Drawing.Point(134, 34);
            this.enrolledclassesbutton.Name = "enrolledclassesbutton";
            this.enrolledclassesbutton.Size = new System.Drawing.Size(75, 23);
            this.enrolledclassesbutton.TabIndex = 9;
            this.enrolledclassesbutton.Text = "Courses";
            this.enrolledclassesbutton.UseVisualStyleBackColor = false;
            this.enrolledclassesbutton.Click += new System.EventHandler(this.enrolledclassesbutton_Click);
            // 
            // gpabutton
            // 
            this.gpabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.gpabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpabutton.Location = new System.Drawing.Point(214, 34);
            this.gpabutton.Name = "gpabutton";
            this.gpabutton.Size = new System.Drawing.Size(75, 23);
            this.gpabutton.TabIndex = 10;
            this.gpabutton.Text = "GPA";
            this.gpabutton.UseVisualStyleBackColor = false;
            this.gpabutton.Click += new System.EventHandler(this.gpabutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbutton.Location = new System.Drawing.Point(227, 63);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(75, 23);
            this.logoutbutton.TabIndex = 11;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // secretlabel
            // 
            this.secretlabel.AutoSize = true;
            this.secretlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secretlabel.Location = new System.Drawing.Point(12, 68);
            this.secretlabel.Name = "secretlabel";
            this.secretlabel.Size = new System.Drawing.Size(0, 13);
            this.secretlabel.TabIndex = 12;
            this.secretlabel.Visible = false;
            // 
            // mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(314, 95);
            this.Controls.Add(this.secretlabel);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.gpabutton);
            this.Controls.Add(this.enrolledclassesbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.studentnamelabel);
            this.Controls.Add(this.welcomelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainscreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.mainscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Label studentnamelabel;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button enrolledclassesbutton;
        private System.Windows.Forms.Button gpabutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Label secretlabel;
    }
}