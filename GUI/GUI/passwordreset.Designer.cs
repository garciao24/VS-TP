namespace GUI
{
    partial class changepassword
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
            this.newpasswordlabel = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.changepasswordgroupbox = new System.Windows.Forms.GroupBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.passwordcheckbox = new System.Windows.Forms.CheckBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.newpasswordtextbox = new System.Windows.Forms.TextBox();
            this.errormessagelabel = new System.Windows.Forms.Label();
            this.changepasswordgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newpasswordlabel
            // 
            this.newpasswordlabel.AutoSize = true;
            this.newpasswordlabel.Location = new System.Drawing.Point(10, 66);
            this.newpasswordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newpasswordlabel.Name = "newpasswordlabel";
            this.newpasswordlabel.Size = new System.Drawing.Size(116, 20);
            this.newpasswordlabel.TabIndex = 1;
            this.newpasswordlabel.Text = "New password:";
            this.newpasswordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(138, 26);
            this.idtextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(148, 26);
            this.idtextbox.TabIndex = 2;
            // 
            // changepasswordgroupbox
            // 
            this.changepasswordgroupbox.Controls.Add(this.exitbutton);
            this.changepasswordgroupbox.Controls.Add(this.passwordcheckbox);
            this.changepasswordgroupbox.Controls.Add(this.backbutton);
            this.changepasswordgroupbox.Controls.Add(this.resetbutton);
            this.changepasswordgroupbox.Controls.Add(this.usernamelabel);
            this.changepasswordgroupbox.Controls.Add(this.newpasswordlabel);
            this.changepasswordgroupbox.Controls.Add(this.newpasswordtextbox);
            this.changepasswordgroupbox.Controls.Add(this.idtextbox);
            this.changepasswordgroupbox.Location = new System.Drawing.Point(18, 46);
            this.changepasswordgroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changepasswordgroupbox.Name = "changepasswordgroupbox";
            this.changepasswordgroupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changepasswordgroupbox.Size = new System.Drawing.Size(418, 146);
            this.changepasswordgroupbox.TabIndex = 4;
            this.changepasswordgroupbox.TabStop = false;
            this.changepasswordgroupbox.Text = "Reset Password";
            this.changepasswordgroupbox.Enter += new System.EventHandler(this.changepasswordgroupbox_Enter);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(297, 102);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(112, 35);
            this.exitbutton.TabIndex = 7;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // passwordcheckbox
            // 
            this.passwordcheckbox.AutoSize = true;
            this.passwordcheckbox.Location = new System.Drawing.Point(297, 60);
            this.passwordcheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordcheckbox.Name = "passwordcheckbox";
            this.passwordcheckbox.Size = new System.Drawing.Size(75, 24);
            this.passwordcheckbox.TabIndex = 6;
            this.passwordcheckbox.Text = "Show";
            this.passwordcheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordcheckbox.UseVisualStyleBackColor = true;
            this.passwordcheckbox.CheckedChanged += new System.EventHandler(this.passwordcheckbox_CheckedChanged_1);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(176, 102);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(112, 35);
            this.backbutton.TabIndex = 5;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(54, 102);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(112, 35);
            this.resetbutton.TabIndex = 4;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(98, 31);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(30, 20);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "ID:";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newpasswordtextbox
            // 
            this.newpasswordtextbox.Location = new System.Drawing.Point(138, 62);
            this.newpasswordtextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newpasswordtextbox.Name = "newpasswordtextbox";
            this.newpasswordtextbox.Size = new System.Drawing.Size(148, 26);
            this.newpasswordtextbox.TabIndex = 3;
            // 
            // errormessagelabel
            // 
            this.errormessagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessagelabel.ForeColor = System.Drawing.Color.Red;
            this.errormessagelabel.Location = new System.Drawing.Point(14, 14);
            this.errormessagelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errormessagelabel.Name = "errormessagelabel";
            this.errormessagelabel.Size = new System.Drawing.Size(423, 28);
            this.errormessagelabel.TabIndex = 6;
            this.errormessagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errormessagelabel.Click += new System.EventHandler(this.errormessagelabel_Click);
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 211);
            this.Controls.Add(this.errormessagelabel);
            this.Controls.Add(this.changepasswordgroupbox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "changepassword";
            this.Text = "Password Reset Window";
            this.Load += new System.EventHandler(this.changepassword_Load);
            this.changepasswordgroupbox.ResumeLayout(false);
            this.changepasswordgroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label newpasswordlabel;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.GroupBox changepasswordgroupbox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label errormessagelabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox newpasswordtextbox;
        private System.Windows.Forms.CheckBox passwordcheckbox;
        private System.Windows.Forms.Button exitbutton;
    }
}