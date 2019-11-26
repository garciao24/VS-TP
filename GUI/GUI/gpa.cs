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
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wolf1\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");
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
            dataAdapter2.SelectCommand = new SqlCommand("SELECT cID, department, name, grade, grade2, grade3 FROM course FULL OUTER JOIN enrollment ON course.cID = enrollment.courseID WHERE studentID =@sID", sqlConnection);
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
                viewgradegridview.Rows[n].Cells[4].Value = item["grade2"].ToString();
                viewgradegridview.Rows[n].Cells[5].Value = item["grade3"].ToString();
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
            double grade1, grade2, grade3, t;

            double total = 0, hours = 0;
            for (int i = 0; i < (viewgradegridview.Rows.Count); ++i)
            {
                float credithour = ((Convert.ToInt32(viewgradegridview.Rows[i].Cells[1].Value))/ 100) % 10;
                
                grade1 = Convert.ToInt32(viewgradegridview.Rows[i].Cells[3].Value);
                grade2 = Convert.ToInt32(viewgradegridview.Rows[i].Cells[4].Value);
                grade3 = Convert.ToInt32(viewgradegridview.Rows[i].Cells[5].Value);

                t = (grade1 + grade2 + grade3);
                t = t / 3;
                hours++;

                if (t >= 90 && t <= 100)
                {
                    total = 4 + total;
                }
                else if (t >= 80 && t < 90)
                {
                    total = 3 + total;
                    
                }
                else if (t >= 70 && t < 80)
                {
                    total = 2 + total;
                }
                else if (t >= 60 && t < 70)
                {
                    total = 1 + total;
                }
                else if (t < 60)
                {
                    total = 0 + total;
                }
                double GPA = total / hours;
                GPA = Math.Round(GPA, 3, MidpointRounding.AwayFromZero);
                gpalabel2.Text = Convert.ToString(GPA);
            }
        }




        private void viewgradegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
