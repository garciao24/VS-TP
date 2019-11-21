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
    public partial class courselist : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wolf1\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");

        public courselist(string username)
        {
            InitializeComponent();

            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT sID FROM student WHERE username =@username", sqlConnection);
            dataAdapter.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            secretlabel.Text = dataTable.Rows[0].ToString(); //Bad code! :c
            int ID = int.Parse(dataTable.Rows[0][0].ToString());

            SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
            dataAdapter2.SelectCommand = new SqlCommand("SELECT cID, department, name, professor, grade, grade2, grade3 FROM course FULL OUTER JOIN enrollment ON course.cID = enrollment.courseID WHERE studentID =@sID", sqlConnection);
            dataAdapter2.SelectCommand.Parameters.Add("@sID", SqlDbType.Int).Value = ID;
            DataTable dataTable2 = new DataTable();
            dataAdapter2.Fill(dataTable2);
            foreach (DataRow item in dataTable2.Rows)
            {
                int n = enrolledcoursesgridview.Rows.Add();
                enrolledcoursesgridview.Rows[n].Cells[0].Value = item["department"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[1].Value = item["cID"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[2].Value = item["name"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[3].Value = item["professor"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[4].Value = item["grade"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[5].Value = item["grade2"].ToString();
                enrolledcoursesgridview.Rows[n].Cells[6].Value = item["grade3"].ToString();
            }
            sqlConnection.Close();
            secretlabel.Text = username;
        }

        public courselist()
        {
            throw new System.NotImplementedException();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainscreen(secretlabel.Text).Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private void Enrolledcoursesgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void courselist_Load(object sender, EventArgs e)
        {

        }
    }
}
