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
            disp_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into course values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "') ";
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
            dataGridView1.DataSource = dt;

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
            cmd.CommandText = "delete from course where ID'"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            disp_data();
            MessageBox.Show("Course deleted succesfully");
        }
    }
}
