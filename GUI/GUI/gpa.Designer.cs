namespace GUI
{
    partial class gpa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.secretlabel = new System.Windows.Forms.Label();
            this.currentgradesgroupbox = new System.Windows.Forms.GroupBox();
            this.viewgradegridview = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.gpalabel = new System.Windows.Forms.Label();
            this.calculategpagroupbox = new System.Windows.Forms.GroupBox();
            this.gpalabel2 = new System.Windows.Forms.Label();
            this.currentgradesgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewgradegridview)).BeginInit();
            this.calculategpagroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // secretlabel
            // 
            this.secretlabel.AutoSize = true;
            this.secretlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secretlabel.Location = new System.Drawing.Point(18, 446);
            this.secretlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secretlabel.Name = "secretlabel";
            this.secretlabel.Size = new System.Drawing.Size(0, 20);
            this.secretlabel.TabIndex = 1;
            this.secretlabel.Visible = false;
            // 
            // currentgradesgroupbox
            // 
            this.currentgradesgroupbox.Controls.Add(this.viewgradegridview);
            this.currentgradesgroupbox.ForeColor = System.Drawing.Color.White;
            this.currentgradesgroupbox.Location = new System.Drawing.Point(18, 18);
            this.currentgradesgroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentgradesgroupbox.Name = "currentgradesgroupbox";
            this.currentgradesgroupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentgradesgroupbox.Size = new System.Drawing.Size(724, 246);
            this.currentgradesgroupbox.TabIndex = 2;
            this.currentgradesgroupbox.TabStop = false;
            this.currentgradesgroupbox.Text = "Current Grades";
            // 
            // viewgradegridview
            // 
            this.viewgradegridview.AllowUserToAddRows = false;
            this.viewgradegridview.AllowUserToDeleteRows = false;
            this.viewgradegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewgradegridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.id,
            this.name,
            this.grade,
            this.grade2,
            this.grade3});
            this.viewgradegridview.GridColor = System.Drawing.Color.White;
            this.viewgradegridview.Location = new System.Drawing.Point(32, 29);
            this.viewgradegridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewgradegridview.Name = "viewgradegridview";
            this.viewgradegridview.ReadOnly = true;
            this.viewgradegridview.RowHeadersWidth = 62;
            this.viewgradegridview.Size = new System.Drawing.Size(684, 186);
            this.viewgradegridview.TabIndex = 0;
            this.viewgradegridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewgradegridview_CellContentClick);
            // 
            // department
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.department.DefaultCellStyle = dataGridViewCellStyle1;
            this.department.HeaderText = "Department";
            this.department.MinimumWidth = 8;
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 75;
            // 
            // id
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "Course Number";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // grade
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.grade.DefaultCellStyle = dataGridViewCellStyle4;
            this.grade.HeaderText = "Grade";
            this.grade.MinimumWidth = 8;
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            this.grade.Width = 50;
            // 
            // grade2
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.grade2.DefaultCellStyle = dataGridViewCellStyle5;
            this.grade2.HeaderText = "Grade2";
            this.grade2.MinimumWidth = 8;
            this.grade2.Name = "grade2";
            this.grade2.ReadOnly = true;
            this.grade2.Width = 50;
            // 
            // grade3
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.grade3.DefaultCellStyle = dataGridViewCellStyle6;
            this.grade3.HeaderText = "Grade3";
            this.grade3.MinimumWidth = 8;
            this.grade3.Name = "grade3";
            this.grade3.ReadOnly = true;
            this.grade3.Width = 50;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Location = new System.Drawing.Point(574, 331);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(112, 35);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "Logout";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Location = new System.Drawing.Point(574, 286);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(112, 35);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // calculatebutton
            // 
            this.calculatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.calculatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatebutton.ForeColor = System.Drawing.Color.Black;
            this.calculatebutton.Location = new System.Drawing.Point(258, 57);
            this.calculatebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(112, 35);
            this.calculatebutton.TabIndex = 4;
            this.calculatebutton.Text = "Calculate";
            this.calculatebutton.UseVisualStyleBackColor = false;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // gpalabel
            // 
            this.gpalabel.AutoSize = true;
            this.gpalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpalabel.ForeColor = System.Drawing.Color.White;
            this.gpalabel.Location = new System.Drawing.Point(68, 28);
            this.gpalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpalabel.Name = "gpalabel";
            this.gpalabel.Size = new System.Drawing.Size(139, 20);
            this.gpalabel.TabIndex = 5;
            this.gpalabel.Text = "Semester GPA:";
            // 
            // calculategpagroupbox
            // 
            this.calculategpagroupbox.Controls.Add(this.gpalabel2);
            this.calculategpagroupbox.Controls.Add(this.calculatebutton);
            this.calculategpagroupbox.Controls.Add(this.gpalabel);
            this.calculategpagroupbox.ForeColor = System.Drawing.Color.White;
            this.calculategpagroupbox.Location = new System.Drawing.Point(130, 274);
            this.calculategpagroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculategpagroupbox.Name = "calculategpagroupbox";
            this.calculategpagroupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculategpagroupbox.Size = new System.Drawing.Size(398, 108);
            this.calculategpagroupbox.TabIndex = 6;
            this.calculategpagroupbox.TabStop = false;
            this.calculategpagroupbox.Text = "Calculate GPA";
            // 
            // gpalabel2
            // 
            this.gpalabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gpalabel2.Location = new System.Drawing.Point(72, 57);
            this.gpalabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gpalabel2.Name = "gpalabel2";
            this.gpalabel2.Size = new System.Drawing.Size(134, 35);
            this.gpalabel2.TabIndex = 6;
            // 
            // gpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(867, 394);
            this.Controls.Add(this.calculategpagroupbox);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.currentgradesgroupbox);
            this.Controls.Add(this.secretlabel);
            this.Controls.Add(this.exitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "gpa";
            this.Text = "GPA Calculator";
            this.Load += new System.EventHandler(this.gpa_Load);
            this.currentgradesgroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewgradegridview)).EndInit();
            this.calculategpagroupbox.ResumeLayout(false);
            this.calculategpagroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label secretlabel;
        private System.Windows.Forms.GroupBox currentgradesgroupbox;
        private System.Windows.Forms.DataGridView viewgradegridview;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.Label gpalabel;
        private System.Windows.Forms.GroupBox calculategpagroupbox;
        private System.Windows.Forms.Label gpalabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade3;
    }
}