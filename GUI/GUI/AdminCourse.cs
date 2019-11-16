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
    public partial class AdminCourse : Form
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wolf1\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");

        public AdminCourse()
        {
            InitializeComponent();
        }

        private void AdminCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.databaseDataSet.course);
            //disp_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into course values('" + cIDTextBox.Text + "','" + departmentTextBox.Text + "','" + nameTextBox.Text + "','" + sectionTextBox.Text + "','" + timestartTextBox.Text + "','" + timeendTextBox.Text + "','" + professorTextBox.Text + "','" + roomTextBox.Text + "') ";
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            disp_data();
            MessageBox.Show("Course added succesfully");

        }

        public void disp_data()
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from course";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            courseDataGridView.DataSource = dt;

            sqlConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new administratorMenu().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from course where section'"+sectionTextBox.Text+"'";
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            disp_data();
            MessageBox.Show("Course deleted succesfully");
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void courseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update course values('" + cIDTextBox.Text + "', '" + departmentTextBox.Text + "', '" + nameTextBox.Text + "', '" + sectionTextBox.Text + "', '" + timestartTextBox.Text + "', '" + timeendTextBox.Text + "', '" + professorTextBox.Text + "', '" + roomTextBox.Text + "') ";
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            disp_data();
            MessageBox.Show("Course deleted succesfully");
        }
    }
}
