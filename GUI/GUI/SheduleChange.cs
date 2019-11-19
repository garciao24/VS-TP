﻿using System;
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
    public partial class SheduleChange : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wolf1\source\repos\VS-TP\GUI\GUI\Database.mdf;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public SheduleChange()
        {
            InitializeComponent();
        }

        private void SheduleChange_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            sda = new SqlDataAdapter(@"SELECT   courseID, StudentID, grade
             FROM         enrollment", sqlConnection);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}