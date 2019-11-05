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
    public partial class updateinformation : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\garciao24\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");
        public updateinformation(string username)
        {
            InitializeComponent();
            secretlabel.Text = username;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM student WHERE username =@username", sqlConnection);
            dataAdapter.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach(DataRow item in dataTable.Rows)
            {
                int n = currentinformationdatagrid.Rows.Add();
                currentinformationdatagrid.Rows[n].Cells[0].Value = item["firstname"].ToString();
                currentinformationdatagrid.Rows[n].Cells[1].Value = item["lastname"].ToString();
                currentinformationdatagrid.Rows[n].Cells[2].Value = item["gender"].ToString();
                currentinformationdatagrid.Rows[n].Cells[3].Value = item["dob"].ToString();
                currentinformationdatagrid.Rows[n].Cells[4].Value = item["phonenumber"].ToString();
                currentinformationdatagrid.Rows[n].Cells[5].Value = item["email"].ToString();
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            firstnametextbox.Text = string.Empty;
            lastnametextbox.Text = string.Empty;
            phonenumbertextbox.Text = string.Empty;
            dobtextbox.Text = string.Empty;
            gendercombobox.Text = "";
            firstnamelabel.Focus();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (firstnametextbox.Text == string.Empty || lastnametextbox.Text == string.Empty || dobtextbox.Text == string.Empty ||
                gendercombobox.Text == string.Empty || phonenumbertextbox.Text == string.Empty || emailtextbox.Text == string.Empty)
            {
                errormessagelabel.Text = "Cannot leave any fields blank.";
            }
            else
            {
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                sqlConnection.Open();
                dataAdapter.SelectCommand = new SqlCommand("UPDATE student SET firstname =@firstname, lastname =@lastname, DOB =@DOB, gender =@gender, phonenumber =@phonenumber, email =@email WHERE username =@username", sqlConnection);
                dataAdapter.SelectCommand.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = firstnametextbox.Text;
                dataAdapter.SelectCommand.Parameters.Add("@lastname", SqlDbType.NVarChar).Value = lastnametextbox.Text;
                dataAdapter.SelectCommand.Parameters.Add("@DOB", SqlDbType.NVarChar).Value = dobtextbox.Text;
                dataAdapter.SelectCommand.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gendercombobox.Text;
                dataAdapter.SelectCommand.Parameters.Add("@phonenumber", SqlDbType.NVarChar).Value = phonenumbertextbox.Text;
                dataAdapter.SelectCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = emailtextbox.Text;
                dataAdapter.SelectCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = secretlabel.Text;
                dataAdapter.SelectCommand.ExecuteNonQuery();
                errormessagelabel.Text = "Information Updated.";
                currentinformationdatagrid.Refresh();
                sqlConnection.Close();
            }
        }


       private void currentinformationdatagrid_MouseClick(object sender, MouseEventArgs e)
        {
            firstnametextbox.Text = currentinformationdatagrid.SelectedRows[0].Cells[0].Value.ToString();
            lastnametextbox.Text = currentinformationdatagrid.SelectedRows[0].Cells[1].Value.ToString();
            dobtextbox.Text = currentinformationdatagrid.SelectedRows[0].Cells[3].Value.ToString();
            phonenumbertextbox.Text = currentinformationdatagrid.SelectedRows[0].Cells[4].Value.ToString();
            emailtextbox.Text = currentinformationdatagrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainscreen(secretlabel.Text).Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private void updateinformationgroupbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
