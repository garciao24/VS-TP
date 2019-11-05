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
    public partial class changepassword : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\garciao24\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");
        public changepassword()
        {
            InitializeComponent();
            newpasswordtextbox.UseSystemPasswordChar = true;
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            int numeric = 0;
            if (idtextbox.Text == string.Empty || newpasswordtextbox.Text == string.Empty || (idtextbox.Text == string.Empty && newpasswordtextbox.Text == string.Empty))
            {
                errormessagelabel.Text = "Fields cannot be left blank.";
                idtextbox.Text = string.Empty;
                newpasswordtextbox.Text = string.Empty;
            }
            else if (!(int.TryParse(idtextbox.Text, out numeric)))
            {
                errormessagelabel.Text = "Incorrect ID.";
                idtextbox.Text = string.Empty;
                newpasswordtextbox.Text = string.Empty;
            }
            else
            {
                errormessagelabel.Text = string.Empty;
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand("SELECT sID FROM student WHERE sID =@sID", sqlConnection);
                dataAdapter.SelectCommand.Parameters.Add("@sID", SqlDbType.Int).Value = idtextbox.Text;
                sqlConnection.Open();
                dataAdapter.Fill(dataSet, "student");
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    errormessagelabel.Text = "Incorrect ID.";
                    idtextbox.Text = string.Empty;
                    newpasswordtextbox.Text = string.Empty;
                    sqlConnection.Close();
                }
                else
                {
                    dataAdapter.SelectCommand = new SqlCommand("UPDATE student SET password =@password WHERE sID =@sID", sqlConnection);
                    dataAdapter.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = newpasswordtextbox.Text;
                    dataAdapter.SelectCommand.Parameters.Add("@sID", SqlDbType.Int).Value = idtextbox.Text;
                    dataAdapter.SelectCommand.ExecuteNonQuery();
                    errormessagelabel.Text = "Password Updated.";
                    sqlConnection.Close();
                }
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private void passwordcheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (passwordcheckbox.Checked)
            {
                newpasswordtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                newpasswordtextbox.UseSystemPasswordChar = true;
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void changepasswordgroupbox_Enter(object sender, EventArgs e)
        {

        }

        private void errormessagelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
