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
    public partial class login : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wolf1\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");
        public login()                                                                                              
        {
            InitializeComponent();
            string username = usernametextbox.Text;
            passwordtextbox.UseSystemPasswordChar = true;
        }

        public mainscreen username
        {
            get => default(mainscreen);
            set
            {
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (usernametextbox.Text == string.Empty || passwordtextbox.Text == string.Empty || (usernametextbox.Text == string.Empty && passwordtextbox.Text == string.Empty))
            {
                errormessagelabel.Text = "Feilds cannot be left blank.";
                usernametextbox.Text = string.Empty;
                passwordtextbox.Text = string.Empty;
            }
            else
            {
                errormessagelabel.Text = string.Empty;
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand("SELECT username, password FROM student WHERE username =@username AND password =@password", sqlConnection);
                dataAdapter.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = usernametextbox.Text;
                dataAdapter.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = passwordtextbox.Text;
                sqlConnection.Open();
                dataAdapter.Fill(dataSet, "student");
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    errormessagelabel.Text = "Username or password is incorrect.";
                    usernametextbox.Text = string.Empty;
                    passwordtextbox.Text = string.Empty;
                    sqlConnection.Close();
                }
                else if (dataSet.Tables[0].Rows[0][0].ToString() == "admin")
                {
                    this.Hide();
                    new administrator().Show();
                }
                else
                {
                    this.Hide();
                    new mainscreen(usernametextbox.Text).Show();
                }
            }
            sqlConnection.Close();
        } 

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void passwordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordcheckbox.Checked)
            {
                passwordtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextbox.UseSystemPasswordChar = true; 
            }
        }

        private void resetpasswordbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new changepassword().Show();
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void passwordlabel_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
