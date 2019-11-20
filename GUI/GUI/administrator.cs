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
    public partial class administrator : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wolf1\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");

        public administrator()
        {
            InitializeComponent();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM student WHERE username !=@username", sqlConnection);
            dataAdapter.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = "admin";
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow item in dataTable.Rows)
            {
                int n = enrolledstudentsgridview.Rows.Add();
                enrolledstudentsgridview.Rows[n].Cells[0].Value = item["sID"].ToString();
                enrolledstudentsgridview.Rows[n].Cells[1].Value = item["username"].ToString();
                enrolledstudentsgridview.Rows[n].Cells[2].Value = item["firstname"].ToString();
                enrolledstudentsgridview.Rows[n].Cells[3].Value = item["lastname"].ToString();
                enrolledstudentsgridview.Rows[n].Cells[4].Value = item["gender"].ToString();
                enrolledstudentsgridview.Rows[n].Cells[5].Value = item["dob"].ToString();
                enrolledstudentsgridview.Rows[n].Cells[6].Value = item["phonenumber"].ToString();
                enrolledstudentsgridview.Rows[n].Cells[7].Value = item["email"].ToString();
            }
            sqlConnection.Close();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new administratorMenu();
        }

        private void enrolledstudentsgridview_MouseClick(object sender, MouseEventArgs e)
        {
            enrolledcoursesgridview.Rows.Clear();
            string ID = enrolledstudentsgridview.SelectedRows[0].Cells[0].Value.ToString();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT cID, department, name, professor, grade, section, timestart, timeend FROM course FULL OUTER JOIN enrollment ON course.cID = enrollment.courseID WHERE studentID =@sID", sqlConnection);
            dataAdapter.SelectCommand.Parameters.Add("@sID", SqlDbType.Int).Value = ID;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow item in dataTable.Rows)
            {
                int n = enrolledcoursesgridview.Rows.Add();
                enrolledcoursesgridview.Rows[n].Cells[0].Value = item["cID"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[1].Value = item["department"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[2].Value = item["section"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[3].Value = item["name"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[4].Value = item["professor"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[5].Value = item["timestart"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[6].Value = item["timeend"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[7].Value = item["grade"].ToString();
            }
        }

        private void enrolledstudentsgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void enrolledstudentsgroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void enrolledcoursesgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void administrator_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void errormessagelabel_Click(object sender, EventArgs e)
        {

        }
    }
}