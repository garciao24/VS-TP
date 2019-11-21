using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GUI
{
    public partial class mainscreen : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wolf1\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");
        public mainscreen(string username)
        {
            InitializeComponent();
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT firstname, lastname FROM student WHERE username =@username", sqlConnection);
            dataAdapter.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            sqlConnection.Open();
            dataAdapter.Fill(dataSet);
            studentnamelabel.Text = dataSet.Tables[0].Rows[0][0].ToString() + " " + dataSet.Tables[0].Rows[0][1].ToString();
            sqlConnection.Close();
            secretlabel.Text = username; //Bad code! :c
        }

        private void mainscreen_Load(object sender, EventArgs e)
        {
            
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new updateinformation(secretlabel.Text).Show();
        }

        private void enrolledclassesbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new courselist(secretlabel.Text).Show();
        }

        private void gpabutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new gpa(secretlabel.Text).Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        private void studentnamelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
