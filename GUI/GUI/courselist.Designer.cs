namespace GUI
{
    partial class courselist
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
            this.enrolledcoursesgridview = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolledcoursesgroupbox = new System.Windows.Forms.GroupBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.secretlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enrolledcoursesgridview)).BeginInit();
            this.enrolledcoursesgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enrolledcoursesgridview
            // 
            this.enrolledcoursesgridview.AllowUserToAddRows = false;
            this.enrolledcoursesgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledcoursesgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.id,
            this.name,
            this.professor,
            this.grade});
            this.enrolledcoursesgridview.Location = new System.Drawing.Point(20, 29);
            this.enrolledcoursesgridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enrolledcoursesgridview.Name = "enrolledcoursesgridview";
            this.enrolledcoursesgridview.RowHeadersWidth = 62;
            this.enrolledcoursesgridview.Size = new System.Drawing.Size(852, 214);
            this.enrolledcoursesgridview.TabIndex = 0;
            this.enrolledcoursesgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Enrolledcoursesgridview_CellContentClick);
            // 
            // department
            // 
            this.department.HeaderText = "Department";
            this.department.MinimumWidth = 8;
            this.department.Name = "department";
            this.department.Width = 75;
            // 
            // id
            // 
            this.id.FillWeight = 125F;
            this.id.HeaderText = "Course Number";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // professor
            // 
            this.professor.HeaderText = "Professor";
            this.professor.MinimumWidth = 8;
            this.professor.Name = "professor";
            this.professor.Width = 150;
            // 
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.MinimumWidth = 8;
            this.grade.Name = "grade";
            this.grade.Width = 50;
            // 
            // enrolledcoursesgroupbox
            // 
            this.enrolledcoursesgroupbox.Controls.Add(this.enrolledcoursesgridview);
            this.enrolledcoursesgroupbox.Location = new System.Drawing.Point(18, 18);
            this.enrolledcoursesgroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enrolledcoursesgroupbox.Name = "enrolledcoursesgroupbox";
            this.enrolledcoursesgroupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enrolledcoursesgroupbox.Size = new System.Drawing.Size(892, 262);
            this.enrolledcoursesgroupbox.TabIndex = 1;
            this.enrolledcoursesgroupbox.TabStop = false;
            this.enrolledcoursesgroupbox.Text = "Enrolled Courses";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(676, 289);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(112, 35);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Location = new System.Drawing.Point(798, 289);
            this.logoutbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(112, 35);
            this.logoutbutton.TabIndex = 3;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // secretlabel
            // 
            this.secretlabel.AutoSize = true;
            this.secretlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secretlabel.Location = new System.Drawing.Point(14, 309);
            this.secretlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secretlabel.Name = "secretlabel";
            this.secretlabel.Size = new System.Drawing.Size(0, 20);
            this.secretlabel.TabIndex = 4;
            this.secretlabel.Visible = false;
            // 
            // courselist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 343);
            this.Controls.Add(this.secretlabel);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.enrolledcoursesgroupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "courselist";
            this.Text = "Current Courses";
            ((System.ComponentModel.ISupportInitialize)(this.enrolledcoursesgridview)).EndInit();
            this.enrolledcoursesgroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView enrolledcoursesgridview;
        private System.Windows.Forms.GroupBox enrolledcoursesgroupbox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Label secretlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
    }
}