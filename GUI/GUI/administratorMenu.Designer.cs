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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secretlabel
            // 
            this.secretlabel.AutoSize = true;
            this.secretlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secretlabel.Location = new System.Drawing.Point(12, 114);
            this.secretlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secretlabel.Name = "secretlabel";
            this.secretlabel.Size = new System.Drawing.Size(0, 20);
            this.secretlabel.TabIndex = 19;
            this.secretlabel.Visible = false;
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(334, 106);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(112, 35);
            this.logoutbutton.TabIndex = 18;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // gpabutton
            // 
            this.gpabutton.Location = new System.Drawing.Point(280, 62);
            this.gpabutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpabutton.Name = "gpabutton";
            this.gpabutton.Size = new System.Drawing.Size(166, 35);
            this.gpabutton.TabIndex = 17;
            this.gpabutton.Text = "Edit Current student";
            this.gpabutton.UseVisualStyleBackColor = true;
            this.gpabutton.Click += new System.EventHandler(this.gpabutton_Click);
            // 
            // enrolledclassesbutton
            // 
            this.enrolledclassesbutton.Location = new System.Drawing.Point(124, 62);
            this.enrolledclassesbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enrolledclassesbutton.Name = "enrolledclassesbutton";
            this.enrolledclassesbutton.Size = new System.Drawing.Size(147, 35);
            this.enrolledclassesbutton.TabIndex = 16;
            this.enrolledclassesbutton.Text = "Add New Course";
            this.enrolledclassesbutton.UseVisualStyleBackColor = true;
            this.enrolledclassesbutton.Click += new System.EventHandler(this.enrolledclassesbutton_Click);
            // 
            // ViewInfo
            // 
            this.ViewInfo.Location = new System.Drawing.Point(12, 62);
            this.ViewInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewInfo.Name = "ViewInfo";
            this.ViewInfo.Size = new System.Drawing.Size(104, 35);
            this.ViewInfo.TabIndex = 15;
            this.ViewInfo.Text = "View Info";
            this.ViewInfo.UseVisualStyleBackColor = true;
            this.ViewInfo.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Location = new System.Drawing.Point(12, 23);
            this.welcomelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(75, 20);
            this.welcomelabel.TabIndex = 13;
            this.welcomelabel.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Admin";
            // 
            // administratorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secretlabel);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.gpabutton);
            this.Controls.Add(this.enrolledclassesbutton);
            this.Controls.Add(this.ViewInfo);
            this.Controls.Add(this.welcomelabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label label1;
    }
}