namespace GUI
{
    partial class AdminCourse
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
            System.Windows.Forms.Label cIDLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label timestartLabel;
            System.Windows.Forms.Label timeendLabel;
            System.Windows.Forms.Label professorLabel;
            System.Windows.Forms.Label roomLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCourse));
            this.databaseDataSet = new GUI.DatabaseDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new GUI.DatabaseDataSetTableAdapters.courseTableAdapter();
            this.tableAdapterManager = new GUI.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.courseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.courseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cIDTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.timestartTextBox = new System.Windows.Forms.TextBox();
            this.timeendTextBox = new System.Windows.Forms.TextBox();
            this.professorTextBox = new System.Windows.Forms.TextBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            cIDLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            timestartLabel = new System.Windows.Forms.Label();
            timeendLabel = new System.Windows.Forms.Label();
            professorLabel = new System.Windows.Forms.Label();
            roomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).BeginInit();
            this.courseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cIDLabel
            // 
            cIDLabel.AutoSize = true;
            cIDLabel.Location = new System.Drawing.Point(1354, 54);
            cIDLabel.Name = "cIDLabel";
            cIDLabel.Size = new System.Drawing.Size(42, 20);
            cIDLabel.TabIndex = 3;
            cIDLabel.Text = "c ID:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(1354, 86);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(95, 20);
            departmentLabel.TabIndex = 5;
            departmentLabel.Text = "department:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(1354, 118);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 20);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "name:";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(1354, 150);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(64, 20);
            sectionLabel.TabIndex = 9;
            sectionLabel.Text = "section:";
            // 
            // timestartLabel
            // 
            timestartLabel.AutoSize = true;
            timestartLabel.Location = new System.Drawing.Point(1354, 182);
            timestartLabel.Name = "timestartLabel";
            timestartLabel.Size = new System.Drawing.Size(75, 20);
            timestartLabel.TabIndex = 11;
            timestartLabel.Text = "timestart:";
            // 
            // timeendLabel
            // 
            timeendLabel.AutoSize = true;
            timeendLabel.Location = new System.Drawing.Point(1354, 214);
            timeendLabel.Name = "timeendLabel";
            timeendLabel.Size = new System.Drawing.Size(70, 20);
            timeendLabel.TabIndex = 13;
            timeendLabel.Text = "timeend:";
            // 
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.Location = new System.Drawing.Point(1354, 246);
            professorLabel.Name = "professorLabel";
            professorLabel.Size = new System.Drawing.Size(80, 20);
            professorLabel.TabIndex = 15;
            professorLabel.Text = "professor:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new System.Drawing.Point(1354, 278);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(49, 20);
            roomLabel.TabIndex = 17;
            roomLabel.Text = "room:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.databaseDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.courseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.enrollmentTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseBindingNavigator
            // 
            this.courseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.courseBindingNavigator.BindingSource = this.courseBindingSource;
            this.courseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.courseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.courseBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.courseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.courseBindingNavigatorSaveItem});
            this.courseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.courseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.courseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.courseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.courseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.courseBindingNavigator.Name = "courseBindingNavigator";
            this.courseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.courseBindingNavigator.Size = new System.Drawing.Size(1583, 33);
            this.courseBindingNavigator.TabIndex = 0;
            this.courseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // courseBindingNavigatorSaveItem
            // 
            this.courseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.courseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("courseBindingNavigatorSaveItem.Image")));
            this.courseBindingNavigatorSaveItem.Name = "courseBindingNavigatorSaveItem";
            this.courseBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.courseBindingNavigatorSaveItem.Text = "Save Data";
            this.courseBindingNavigatorSaveItem.Click += new System.EventHandler(this.courseBindingNavigatorSaveItem_Click);
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.courseDataGridView.DataSource = this.courseBindingSource;
            this.courseDataGridView.Location = new System.Drawing.Point(21, 59);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.RowHeadersWidth = 62;
            this.courseDataGridView.RowTemplate.Height = 28;
            this.courseDataGridView.Size = new System.Drawing.Size(1264, 319);
            this.courseDataGridView.TabIndex = 1;
            this.courseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cID";
            this.dataGridViewTextBoxColumn1.HeaderText = "cID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "department";
            this.dataGridViewTextBoxColumn2.HeaderText = "department";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "section";
            this.dataGridViewTextBoxColumn4.HeaderText = "section";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "timestart";
            this.dataGridViewTextBoxColumn5.HeaderText = "timestart";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "timeend";
            this.dataGridViewTextBoxColumn6.HeaderText = "timeend";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "professor";
            this.dataGridViewTextBoxColumn7.HeaderText = "professor";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "room";
            this.dataGridViewTextBoxColumn8.HeaderText = "room";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1198, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cIDTextBox
            // 
            this.cIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "cID", true));
            this.cIDTextBox.Location = new System.Drawing.Point(1455, 51);
            this.cIDTextBox.Name = "cIDTextBox";
            this.cIDTextBox.Size = new System.Drawing.Size(100, 26);
            this.cIDTextBox.TabIndex = 4;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(1455, 83);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 26);
            this.departmentTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(1455, 115);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 8;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(1455, 147);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(100, 26);
            this.sectionTextBox.TabIndex = 10;
            // 
            // timestartTextBox
            // 
            this.timestartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "timestart", true));
            this.timestartTextBox.Location = new System.Drawing.Point(1455, 179);
            this.timestartTextBox.Name = "timestartTextBox";
            this.timestartTextBox.Size = new System.Drawing.Size(100, 26);
            this.timestartTextBox.TabIndex = 12;
            // 
            // timeendTextBox
            // 
            this.timeendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "timeend", true));
            this.timeendTextBox.Location = new System.Drawing.Point(1455, 211);
            this.timeendTextBox.Name = "timeendTextBox";
            this.timeendTextBox.Size = new System.Drawing.Size(100, 26);
            this.timeendTextBox.TabIndex = 14;
            // 
            // professorTextBox
            // 
            this.professorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "professor", true));
            this.professorTextBox.Location = new System.Drawing.Point(1455, 243);
            this.professorTextBox.Name = "professorTextBox";
            this.professorTextBox.Size = new System.Drawing.Size(100, 26);
            this.professorTextBox.TabIndex = 16;
            // 
            // roomTextBox
            // 
            this.roomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.courseBindingSource, "room", true));
            this.roomTextBox.Location = new System.Drawing.Point(1455, 275);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(100, 26);
            this.roomTextBox.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1098, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(cIDLabel);
            this.Controls.Add(this.cIDTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(sectionLabel);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(timestartLabel);
            this.Controls.Add(this.timestartTextBox);
            this.Controls.Add(timeendLabel);
            this.Controls.Add(this.timeendTextBox);
            this.Controls.Add(professorLabel);
            this.Controls.Add(this.professorTextBox);
            this.Controls.Add(roomLabel);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(this.courseBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminCourse";
            this.Text = "AdminCourse";
            this.Load += new System.EventHandler(this.AdminCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingNavigator)).EndInit();
            this.courseBindingNavigator.ResumeLayout(false);
            this.courseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private DatabaseDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator courseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton courseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cIDTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox timestartTextBox;
        private System.Windows.Forms.TextBox timeendTextBox;
        private System.Windows.Forms.TextBox professorTextBox;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.Button button2;
    }
}