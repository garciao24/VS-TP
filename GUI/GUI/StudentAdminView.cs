using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace GUI
{
    public partial class StudentAdminView : Form
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public StudentAdminView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentAdminView_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }


        public void disp_data()
        {
            sda = new SqlDataAdapter(@"SELECT   sID, username, password, firstname, lastname, DOB, phonenumber, gender, email
             FROM         student", sqlConnection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new administratorMenu().Show();
        }
    }
}
