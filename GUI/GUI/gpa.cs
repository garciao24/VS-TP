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
    public partial class gpa : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wolf1\source\repos\GUI\GUI\Database.mdf;Integrated Security=True");
        public gpa(string username)
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
            dataAdapter2.SelectCommand = new SqlCommand("SELECT cID, department, name, grade FROM course FULL OUTER JOIN enrollment ON course.cID = enrollment.courseID WHERE studentID =@sID", sqlConnection);
            dataAdapter2.SelectCommand.Parameters.Add("@sID", SqlDbType.Int).Value = ID;
            DataTable dataTable2 = new DataTable();
            dataAdapter2.Fill(dataTable2);
            foreach (DataRow item in dataTable2.Rows)
            {
                int n = viewgradegridview.Rows.Add();
                viewgradegridview.Rows[n].Cells[0].Value = item["department"].ToString();
                viewgradegridview.Rows[n].Cells[1].Value = item["cID"].ToString();
                viewgradegridview.Rows[n].Cells[2].Value = item["name"].ToString();
                viewgradegridview.Rows[n].Cells[3].Value = item["grade"].ToString();
            }
            sqlConnection.Close();
            secretlabel.Text = username;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainscreen(secretlabel.Text).Show();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            float total = 0, hours = 0;
            for (int i = 0; i < (viewgradegridview.Rows.Count); ++i)
            {
                float credithour = ((Convert.ToInt32(viewgradegridview.Rows[i].Cells[1].Value))/ 100) % 10;

                if (Convert.ToString(viewgradegridview.Rows[i].Cells[3].Value.ToString().Trim()) == "A")
                {
                    total = (4 * credithour) + total;
                    hours = credithour + hours;
                }
                if (Convert.ToString(viewgradegridview.Rows[i].Cells[3].Value.ToString().Trim()) == "B")
                {
                    total = (3 * credithour) + total;
                    hours = credithour + hours;
                }
                if (Convert.ToString(viewgradegridview.Rows[i].Cells[3].Value.ToString().Trim()) == "C")
                {
                    total = (2 * credithour) + total;
                    hours = credithour + hours;
                }
                if (Convert.ToString(viewgradegridview.Rows[i].Cells[3].Value.ToString().Trim()) == "D")
                {
                    total = (1 * credithour) + total;
                    hours = credithour + hours;
                }
                if (Convert.ToString(viewgradegridview.Rows[i].Cells[3].Value.ToString().Trim()) == "F")
                {
                    total = (0 * credithour) + total;
                    hours = credithour + hours;
                }
                float GPA = total / hours;
                gpalabel2.Text = Convert.ToString(GPA);
            }
        }

        private void viewgradegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
