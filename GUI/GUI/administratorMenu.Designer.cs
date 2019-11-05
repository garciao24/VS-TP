namespace GUI
{
    partial class administratorMenu
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
            this.secretlabel = new System.Windows.Forms.Label();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.gpabutton = new System.Windows.Forms.Button();
            this.enrolledclassesbutton = new System.Windows.Forms.Button();
            this.ViewInfo = new System.Windows.Forms.Button();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secretlabel
            // 
            this.secretlabel.AutoSize = true;
            this.secretlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secretlabel.Location = new System.Drawing.Point(8, 74);
            this.secretlabel.Name = "secretlabel";
            this.secretlabel.Size = new System.Drawing.Size(0, 13);
            this.secretlabel.TabIndex = 19;
            this.secretlabel.Visible = false;
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(223, 69);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(75, 23);
            this.logoutbutton.TabIndex = 18;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            // 
            // gpabutton
            // 
            this.gpabutton.Location = new System.Drawing.Point(187, 40);
            this.gpabutton.Name = "gpabutton";
            this.gpabutton.Size = new System.Drawing.Size(111, 23);
            this.gpabutton.TabIndex = 17;
            this.gpabutton.Text = "Edit Current student";
            this.gpabutton.UseVisualStyleBackColor = true;
            // 
            // enrolledclassesbutton
            // 
            this.enrolledclassesbutton.Location = new System.Drawing.Point(83, 40);
            this.enrolledclassesbutton.Name = "enrolledclassesbutton";
            this.enrolledclassesbutton.Size = new System.Drawing.Size(98, 23);
            this.enrolledclassesbutton.TabIndex = 16;
            this.enrolledclassesbutton.Text = "Add New Course";
            this.enrolledclassesbutton.UseVisualStyleBackColor = true;
            this.enrolledclassesbutton.Click += new System.EventHandler(this.enrolledclassesbutton_Click);
            // 
            // ViewInfo
            // 
            this.ViewInfo.Location = new System.Drawing.Point(8, 40);
            this.ViewInfo.Name = "ViewInfo";
            this.ViewInfo.Size = new System.Drawing.Size(69, 23);
            this.ViewInfo.TabIndex = 15;
            this.ViewInfo.Text = "View Info";
            this.ViewInfo.UseVisualStyleBackColor = true;
            this.ViewInfo.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Location = new System.Drawing.Point(8, 15);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(52, 13);
            this.welcomelabel.TabIndex = 13;
            this.welcomelabel.Text = "Welcome";
            // 
            // administratorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 102);
            this.Controls.Add(this.secretlabel);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.gpabutton);
            this.Controls.Add(this.enrolledclassesbutton);
            this.Controls.Add(this.ViewInfo);
            this.Controls.Add(this.welcomelabel);
            this.Name = "administratorMenu";
            this.Text = "administratorMenu";
            this.Load += new System.EventHandler(this.administratorMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secretlabel;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button gpabutton;
        private System.Windows.Forms.Button enrolledclassesbutton;
        private System.Windows.Forms.Button ViewInfo;
        private System.Windows.Forms.Label welcomelabel;
    }
}