namespace GUI
{
    partial class updateinformation
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
            this.firstnametextbox = new System.Windows.Forms.TextBox();
            this.lastnametextbox = new System.Windows.Forms.TextBox();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.currentinformationdatagrid = new System.Windows.Forms.DataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateinformationgroupbox = new System.Windows.Forms.GroupBox();
            this.secretlabel = new System.Windows.Forms.Label();
            this.dobtextbox = new System.Windows.Forms.TextBox();
            this.phonenumberinformation = new System.Windows.Forms.Label();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.gendercombobox = new System.Windows.Forms.ComboBox();
            this.genderlabel = new System.Windows.Forms.Label();
            this.DOBlabelinformation = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.phonenumbertextbox = new System.Windows.Forms.TextBox();
            this.phonenumberlabel = new System.Windows.Forms.Label();
            this.DOBlabel = new System.Windows.Forms.Label();
            this.currentinformationgroupbox = new System.Windows.Forms.GroupBox();
            this.errormessagelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentinformationdatagrid)).BeginInit();
            this.updateinformationgroupbox.SuspendLayout();
            this.currentinformationgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstnametextbox
            // 
            this.firstnametextbox.Location = new System.Drawing.Point(136, 37);
            this.firstnametextbox.Name = "firstnametextbox";
            this.firstnametextbox.Size = new System.Drawing.Size(101, 20);
            this.firstnametextbox.TabIndex = 0;
            // 
            // lastnametextbox
            // 
            this.lastnametextbox.Location = new System.Drawing.Point(136, 61);
            this.lastnametextbox.Name = "lastnametextbox";
            this.lastnametextbox.Size = new System.Drawing.Size(101, 20);
            this.lastnametextbox.TabIndex = 1;
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Location = new System.Drawing.Point(70, 40);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(60, 13);
            this.firstnamelabel.TabIndex = 5;
            this.firstnamelabel.Text = "First Name:";
            this.firstnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Location = new System.Drawing.Point(69, 64);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(61, 13);
            this.lastnamelabel.TabIndex = 6;
            this.lastnamelabel.Text = "Last Name:";
            this.lastnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentinformationdatagrid
            // 
            this.currentinformationdatagrid.AllowUserToAddRows = false;
            this.currentinformationdatagrid.AllowUserToDeleteRows = false;
            this.currentinformationdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentinformationdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.gender,
            this.dob,
            this.phonenumber,
            this.email});
            this.currentinformationdatagrid.Location = new System.Drawing.Point(6, 19);
            this.currentinformationdatagrid.Name = "currentinformationdatagrid";
            this.currentinformationdatagrid.ReadOnly = true;
            this.currentinformationdatagrid.RowHeadersWidth = 62;
            this.currentinformationdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentinformationdatagrid.Size = new System.Drawing.Size(713, 79);
            this.currentinformationdatagrid.TabIndex = 7;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.MinimumWidth = 8;
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            this.firstname.Width = 150;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.MinimumWidth = 8;
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Width = 150;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 8;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 75;
            // 
            // dob
            // 
            this.dob.HeaderText = "Date of Birth";
            this.dob.MinimumWidth = 8;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 75;
            // 
            // phonenumber
            // 
            this.phonenumber.HeaderText = "Phone Number";
            this.phonenumber.MinimumWidth = 8;
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            this.phonenumber.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "E-Mail";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 175;
            // 
            // updateinformationgroupbox
            // 
            this.updateinformationgroupbox.Controls.Add(this.secretlabel);
            this.updateinformationgroupbox.Controls.Add(this.dobtextbox);
            this.updateinformationgroupbox.Controls.Add(this.phonenumberinformation);
            this.updateinformationgroupbox.Controls.Add(this.emailtextbox);
            this.updateinformationgroupbox.Controls.Add(this.emaillabel);
            this.updateinformationgroupbox.Controls.Add(this.gendercombobox);
            this.updateinformationgroupbox.Controls.Add(this.genderlabel);
            this.updateinformationgroupbox.Controls.Add(this.DOBlabelinformation);
            this.updateinformationgroupbox.Controls.Add(this.exitbutton);
            this.updateinformationgroupbox.Controls.Add(this.backbutton);
            this.updateinformationgroupbox.Controls.Add(this.updatebutton);
            this.updateinformationgroupbox.Controls.Add(this.clearbutton);
            this.updateinformationgroupbox.Controls.Add(this.phonenumbertextbox);
            this.updateinformationgroupbox.Controls.Add(this.phonenumberlabel);
            this.updateinformationgroupbox.Controls.Add(this.DOBlabel);
            this.updateinformationgroupbox.Controls.Add(this.lastnamelabel);
            this.updateinformationgroupbox.Controls.Add(this.firstnametextbox);
            this.updateinformationgroupbox.Controls.Add(this.lastnametextbox);
            this.updateinformationgroupbox.Controls.Add(this.firstnamelabel);
            this.updateinformationgroupbox.ForeColor = System.Drawing.Color.White;
            this.updateinformationgroupbox.Location = new System.Drawing.Point(12, 139);
            this.updateinformationgroupbox.Name = "updateinformationgroupbox";
            this.updateinformationgroupbox.Size = new System.Drawing.Size(725, 143);
            this.updateinformationgroupbox.TabIndex = 8;
            this.updateinformationgroupbox.TabStop = false;
            this.updateinformationgroupbox.Text = "Update Information";
            this.updateinformationgroupbox.Enter += new System.EventHandler(this.updateinformationgroupbox_Enter);
            // 
            // secretlabel
            // 
            this.secretlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secretlabel.Location = new System.Drawing.Point(16, 116);
            this.secretlabel.Name = "secretlabel";
            this.secretlabel.Size = new System.Drawing.Size(46, 13);
            this.secretlabel.TabIndex = 26;
            this.secretlabel.Visible = false;
            // 
            // dobtextbox
            // 
            this.dobtextbox.Location = new System.Drawing.Point(136, 85);
            this.dobtextbox.Name = "dobtextbox";
            this.dobtextbox.Size = new System.Drawing.Size(101, 20);
            this.dobtextbox.TabIndex = 25;
            // 
            // phonenumberinformation
            // 
            this.phonenumberinformation.AutoSize = true;
            this.phonenumberinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumberinformation.ForeColor = System.Drawing.Color.Gray;
            this.phonenumberinformation.Location = new System.Drawing.Point(282, 101);
            this.phonenumberinformation.Name = "phonenumberinformation";
            this.phonenumberinformation.Size = new System.Drawing.Size(61, 12);
            this.phonenumberinformation.TabIndex = 24;
            this.phonenumberinformation.Text = "###-###-####";
            this.phonenumberinformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(368, 62);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(234, 20);
            this.emailtextbox.TabIndex = 23;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(323, 65);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(39, 13);
            this.emaillabel.TabIndex = 22;
            this.emaillabel.Text = "E-Mail:";
            this.emaillabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gendercombobox
            // 
            this.gendercombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercombobox.FormattingEnabled = true;
            this.gendercombobox.Items.AddRange(new object[] {
            "",
            "Female",
            "Male",
            "Non-Binary"});
            this.gendercombobox.Location = new System.Drawing.Point(368, 37);
            this.gendercombobox.Name = "gendercombobox";
            this.gendercombobox.Size = new System.Drawing.Size(100, 21);
            this.gendercombobox.TabIndex = 21;
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Location = new System.Drawing.Point(317, 40);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(45, 13);
            this.genderlabel.TabIndex = 20;
            this.genderlabel.Text = "Gender:";
            this.genderlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DOBlabelinformation
            // 
            this.DOBlabelinformation.AutoSize = true;
            this.DOBlabelinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlabelinformation.ForeColor = System.Drawing.Color.Gray;
            this.DOBlabelinformation.Location = new System.Drawing.Point(62, 103);
            this.DOBlabelinformation.Name = "DOBlabelinformation";
            this.DOBlabelinformation.Size = new System.Drawing.Size(63, 12);
            this.DOBlabelinformation.TabIndex = 17;
            this.DOBlabelinformation.Text = "MM/DD/YYYY";
            this.DOBlabelinformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.ForeColor = System.Drawing.Color.Black;
            this.exitbutton.Location = new System.Drawing.Point(627, 106);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 16;
            this.exitbutton.Text = "Logout";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.ForeColor = System.Drawing.Color.Black;
            this.backbutton.Location = new System.Drawing.Point(627, 77);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 15;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.updatebutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.ForeColor = System.Drawing.Color.Black;
            this.updatebutton.Location = new System.Drawing.Point(627, 19);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 14;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.ForeColor = System.Drawing.Color.Black;
            this.clearbutton.Location = new System.Drawing.Point(627, 48);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 13;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // phonenumbertextbox
            // 
            this.phonenumbertextbox.Location = new System.Drawing.Point(368, 85);
            this.phonenumbertextbox.Name = "phonenumbertextbox";
            this.phonenumbertextbox.Size = new System.Drawing.Size(100, 20);
            this.phonenumbertextbox.TabIndex = 11;
            // 
            // phonenumberlabel
            // 
            this.phonenumberlabel.AutoSize = true;
            this.phonenumberlabel.Location = new System.Drawing.Point(281, 88);
            this.phonenumberlabel.Name = "phonenumberlabel";
            this.phonenumberlabel.Size = new System.Drawing.Size(81, 13);
            this.phonenumberlabel.TabIndex = 8;
            this.phonenumberlabel.Text = "Phone Number:";
            this.phonenumberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DOBlabel
            // 
            this.DOBlabel.AutoSize = true;
            this.DOBlabel.Location = new System.Drawing.Point(61, 90);
            this.DOBlabel.Name = "DOBlabel";
            this.DOBlabel.Size = new System.Drawing.Size(69, 13);
            this.DOBlabel.TabIndex = 7;
            this.DOBlabel.Text = "Date of Birth:";
            this.DOBlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentinformationgroupbox
            // 
            this.currentinformationgroupbox.Controls.Add(this.currentinformationdatagrid);
            this.currentinformationgroupbox.ForeColor = System.Drawing.Color.White;
            this.currentinformationgroupbox.Location = new System.Drawing.Point(12, 29);
            this.currentinformationgroupbox.Name = "currentinformationgroupbox";
            this.currentinformationgroupbox.Size = new System.Drawing.Size(725, 104);
            this.currentinformationgroupbox.TabIndex = 12;
            this.currentinformationgroupbox.TabStop = false;
            this.currentinformationgroupbox.Text = "Current Information";
            // 
            // errormessagelabel
            // 
            this.errormessagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessagelabel.ForeColor = System.Drawing.Color.Red;
            this.errormessagelabel.Location = new System.Drawing.Point(12, 13);
            this.errormessagelabel.Name = "errormessagelabel";
            this.errormessagelabel.Size = new System.Drawing.Size(725, 13);
            this.errormessagelabel.TabIndex = 13;
            this.errormessagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(749, 294);
            this.Controls.Add(this.errormessagelabel);
            this.Controls.Add(this.currentinformationgroupbox);
            this.Controls.Add(this.updateinformationgroupbox);
            this.Name = "updateinformation";
            this.Text = "Update Information";
            ((System.ComponentModel.ISupportInitialize)(this.currentinformationdatagrid)).EndInit();
            this.updateinformationgroupbox.ResumeLayout(false);
            this.updateinformationgroupbox.PerformLayout();
            this.currentinformationgroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstnametextbox;
        private System.Windows.Forms.TextBox lastnametextbox;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.DataGridView currentinformationdatagrid;
        private System.Windows.Forms.GroupBox updateinformationgroupbox;
        private System.Windows.Forms.Label phonenumberlabel;
        private System.Windows.Forms.Label DOBlabel;
        private System.Windows.Forms.TextBox phonenumbertextbox;
        private System.Windows.Forms.GroupBox currentinformationgroupbox;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label DOBlabelinformation;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.ComboBox gendercombobox;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label errormessagelabel;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.Label phonenumberinformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.TextBox dobtextbox;
        private System.Windows.Forms.Label secretlabel;
    }
}