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
            this.welcomelabel.Location = new System.Drawing.Point(18, 14);
            this.welcomelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(75, 20);
            this.welcomelabel.TabIndex = 0;
            this.welcomelabel.Text = "Welcome";
            // 
            // studentnamelabel
            // 
            this.studentnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnamelabel.Location = new System.Drawing.Point(105, 14);
            this.studentnamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentnamelabel.Name = "studentnamelabel";
            this.studentnamelabel.Size = new System.Drawing.Size(328, 20);
            this.studentnamelabel.TabIndex = 1;
            this.studentnamelabel.Click += new System.EventHandler(this.studentnamelabel_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(18, 52);
            this.updatebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(174, 35);
            this.updatebutton.TabIndex = 8;
            this.updatebutton.Text = "Update Information";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // enrolledclassesbutton
            // 
            this.enrolledclassesbutton.Location = new System.Drawing.Point(201, 52);
            this.enrolledclassesbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enrolledclassesbutton.Name = "enrolledclassesbutton";
            this.enrolledclassesbutton.Size = new System.Drawing.Size(112, 35);
            this.enrolledclassesbutton.TabIndex = 9;
            this.enrolledclassesbutton.Text = "Courses";
            this.enrolledclassesbutton.UseVisualStyleBackColor = true;
            this.enrolledclassesbutton.Click += new System.EventHandler(this.enrolledclassesbutton_Click);
            // 
            // gpabutton
            // 
            this.gpabutton.Location = new System.Drawing.Point(321, 52);
            this.gpabutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpabutton.Name = "gpabutton";
            this.gpabutton.Size = new System.Drawing.Size(112, 35);
            this.gpabutton.TabIndex = 10;
            this.gpabutton.Text = "GPA";
            this.gpabutton.UseVisualStyleBackColor = true;
            this.gpabutton.Click += new System.EventHandler(this.gpabutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(340, 97);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(112, 35);
            this.logoutbutton.TabIndex = 11;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // secretlabel
            // 
            this.secretlabel.AutoSize = true;
            this.secretlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secretlabel.Location = new System.Drawing.Point(18, 105);
            this.secretlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secretlabel.Name = "secretlabel";
            this.secretlabel.Size = new System.Drawing.Size(0, 20);
            this.secretlabel.TabIndex = 12;
            this.secretlabel.Visible = false;
            // 
            // mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 146);
            this.Controls.Add(this.secretlabel);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.gpabutton);
            this.Controls.Add(this.enrolledclassesbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.studentnamelabel);
            this.Controls.Add(this.welcomelabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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