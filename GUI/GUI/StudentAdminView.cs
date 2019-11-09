using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StudentAdminView : Form
    {
        public StudentAdminView()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void StudentAdminView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.databaseDataSet.student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new administratorMenu().Show();
        }
    }
}
