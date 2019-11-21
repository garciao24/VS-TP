﻿namespace GUI
{
    partial class SheduleChange
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label courseIDLabel;
            System.Windows.Forms.Label studentIDLabel;
            System.Windows.Forms.Label gradeLabel;
            System.Windows.Forms.Label grade2Label;
            System.Windows.Forms.Label grade3Label;
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new GUI.DatabaseDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.enrollmentTableAdapter = new GUI.DatabaseDataSet1TableAdapters.enrollmentTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.enrollmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new GUI.DatabaseDataSet1TableAdapters.TableAdapterManager();
            this.databaseDataSet2 = new GUI.DatabaseDataSet2();
            this.enrollmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.enrollmentTableAdapter1 = new GUI.DatabaseDataSet2TableAdapters.enrollmentTableAdapter();
            this.tableAdapterManager1 = new GUI.DatabaseDataSet2TableAdapters.TableAdapterManager();
            this.enrollmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.grade2TextBox = new System.Windows.Forms.TextBox();
            this.grade3TextBox = new System.Windows.Forms.TextBox();
            courseIDLabel = new System.Windows.Forms.Label();
            studentIDLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            grade2Label = new System.Windows.Forms.Label();
            grade3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataMember = "enrollment";
            this.enrollmentBindingSource.DataSource = this.databaseDataSet1BindingSource;
            // 
            // databaseDataSet1BindingSource
            // 
            this.databaseDataSet1BindingSource.DataSource = this.databaseDataSet1;
            this.databaseDataSet1BindingSource.Position = 0;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // enrollmentTableAdapter
            // 
            this.enrollmentTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // enrollmentBindingSource1
            // 
            this.enrollmentBindingSource1.DataMember = "enrollment";
            this.enrollmentBindingSource1.DataSource = this.databaseDataSet1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.enrollmentTableAdapter = this.enrollmentTableAdapter;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enrollmentBindingSource2
            // 
            this.enrollmentBindingSource2.DataMember = "enrollment";
            this.enrollmentBindingSource2.DataSource = this.databaseDataSet2;
            // 
            // enrollmentTableAdapter1
            // 
            this.enrollmentTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.courseTableAdapter = null;
            this.tableAdapterManager1.enrollmentTableAdapter = this.enrollmentTableAdapter1;
            this.tableAdapterManager1.studentTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GUI.DatabaseDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // enrollmentDataGridView
            // 
            this.enrollmentDataGridView.AutoGenerateColumns = false;
            this.enrollmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrollmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.enrollmentDataGridView.DataSource = this.enrollmentBindingSource2;
            this.enrollmentDataGridView.Location = new System.Drawing.Point(12, 23);
            this.enrollmentDataGridView.Name = "enrollmentDataGridView";
            this.enrollmentDataGridView.Size = new System.Drawing.Size(501, 220);
            this.enrollmentDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "courseID";
            this.dataGridViewTextBoxColumn1.HeaderText = "courseID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "studentID";
            this.dataGridViewTextBoxColumn2.HeaderText = "studentID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "grade";
            this.dataGridViewTextBoxColumn3.HeaderText = "grade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "grade2";
            this.dataGridViewTextBoxColumn4.HeaderText = "grade2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "grade3";
            this.dataGridViewTextBoxColumn5.HeaderText = "grade3";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // courseIDLabel
            // 
            courseIDLabel.AutoSize = true;
            courseIDLabel.Location = new System.Drawing.Point(577, 74);
            courseIDLabel.Name = "courseIDLabel";
            courseIDLabel.Size = new System.Drawing.Size(56, 13);
            courseIDLabel.TabIndex = 4;
            courseIDLabel.Text = "course ID:";
            // 
            // courseIDTextBox
            // 
            this.courseIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource2, "courseID", true));
            this.courseIDTextBox.Location = new System.Drawing.Point(642, 71);
            this.courseIDTextBox.Name = "courseIDTextBox";
            this.courseIDTextBox.ReadOnly = true;
            this.courseIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.courseIDTextBox.TabIndex = 5;
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Location = new System.Drawing.Point(577, 100);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new System.Drawing.Size(59, 13);
            studentIDLabel.TabIndex = 6;
            studentIDLabel.Text = "student ID:";
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource2, "studentID", true));
            this.studentIDTextBox.Location = new System.Drawing.Point(642, 97);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.ReadOnly = true;
            this.studentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextBox.TabIndex = 7;
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new System.Drawing.Point(577, 126);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(37, 13);
            gradeLabel.TabIndex = 8;
            gradeLabel.Text = "grade:";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource2, "grade", true));
            this.gradeTextBox.Location = new System.Drawing.Point(642, 123);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeTextBox.TabIndex = 9;
            // 
            // grade2Label
            // 
            grade2Label.AutoSize = true;
            grade2Label.Location = new System.Drawing.Point(577, 152);
            grade2Label.Name = "grade2Label";
            grade2Label.Size = new System.Drawing.Size(43, 13);
            grade2Label.TabIndex = 10;
            grade2Label.Text = "grade2:";
            // 
            // grade2TextBox
            // 
            this.grade2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource2, "grade2", true));
            this.grade2TextBox.Location = new System.Drawing.Point(642, 149);
            this.grade2TextBox.Name = "grade2TextBox";
            this.grade2TextBox.Size = new System.Drawing.Size(100, 20);
            this.grade2TextBox.TabIndex = 11;
            // 
            // grade3Label
            // 
            grade3Label.AutoSize = true;
            grade3Label.Location = new System.Drawing.Point(577, 178);
            grade3Label.Name = "grade3Label";
            grade3Label.Size = new System.Drawing.Size(43, 13);
            grade3Label.TabIndex = 12;
            grade3Label.Text = "grade3:";
            // 
            // grade3TextBox
            // 
            this.grade3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enrollmentBindingSource2, "grade3", true));
            this.grade3TextBox.Location = new System.Drawing.Point(642, 175);
            this.grade3TextBox.Name = "grade3TextBox";
            this.grade3TextBox.Size = new System.Drawing.Size(100, 20);
            this.grade3TextBox.TabIndex = 13;
            // 
            // SheduleChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(courseIDLabel);
            this.Controls.Add(this.courseIDTextBox);
            this.Controls.Add(studentIDLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(gradeLabel);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(grade2Label);
            this.Controls.Add(this.grade2TextBox);
            this.Controls.Add(grade3Label);
            this.Controls.Add(this.grade3TextBox);
            this.Controls.Add(this.enrollmentDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "SheduleChange";
            this.Text = "SheduleChange";
            this.Load += new System.EventHandler(this.SheduleChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource databaseDataSet1BindingSource;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private DatabaseDataSet1TableAdapters.enrollmentTableAdapter enrollmentTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource enrollmentBindingSource1;
        private DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource enrollmentBindingSource2;
        private DatabaseDataSet2TableAdapters.enrollmentTableAdapter enrollmentTableAdapter1;
        private DatabaseDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView enrollmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox courseIDTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.TextBox grade2TextBox;
        private System.Windows.Forms.TextBox grade3TextBox;
    }
}