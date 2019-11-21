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
            //disp_data();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {


            //scb = new SqlCommandBuilder(sda);
            //sda.Update(dt);
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            sqlConnection.Open();


            for (int i = 0; i < (enrollmentDataGridView.Rows.Count); ++i)
            {
            }
            dataAdapter.SelectCommand = new SqlCommand("UPDATE enrollment SET grade =@grade, grade2 =@grade2, grade3 =@grade3 WHERE courseID =@courseID AND studentID =@studentID", sqlConnection);

            dataAdapter.SelectCommand.Parameters.Add("@courseID", SqlDbType.NVarChar).Value = courseIDTextBox.Text;
            dataAdapter.SelectCommand.Parameters.Add("@studentID", SqlDbType.NVarChar).Value = studentIDTextBox.Text;
            dataAdapter.SelectCommand.Parameters.Add("@grade", SqlDbType.NVarChar).Value = gradeTextBox.Text;
            dataAdapter.SelectCommand.Parameters.Add("@grade2", SqlDbType.NVarChar).Value = grade2TextBox.Text;
            dataAdapter.SelectCommand.Parameters.Add("@grade3", SqlDbType.NVarChar).Value = grade3TextBox.Text;
            dataAdapter.SelectCommand.ExecuteNonQuery();

            this.enrollmentTableAdapter.Fill(this.databaseDataSet1.enrollment);
            sqlConnection.Close();


        }
                

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new administrator().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
