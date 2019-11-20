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

namespace GUI
{
    public partial class SheduleChange : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wolf1\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public SheduleChange()
        {
            InitializeComponent();
        }

        private void SheduleChange_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.enrollment' table. You can move, or remove it, as needed.
            this.enrollmentTableAdapter.Fill(this.databaseDataSet1.enrollment);
            disp_data();
        }
        public void disp_data()
        {
            sda = new SqlDataAdapter(@"SELECT   courseID, StudentID, grade, grade2, grade3
             FROM         enrollment", sqlConnection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //scb = new SqlCommandBuilder(sda);
            //sda.Update(dt);
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            sqlConnection.Open();
            int a,b,c;
            for (int i = 0; i < (dataGridView1.Rows.Count); ++i)
            {
                //dataGridView1.Rows[i].Cells[3].Value.ToString().Trim()
                //dataGridView1.Rows[i].Cells[5].Value
                a = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString().Trim());
                b = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString().Trim());
                c = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString().Trim());



            }
               

        }
                

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new administrator().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
