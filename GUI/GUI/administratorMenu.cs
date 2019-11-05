using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class administratorMenu : Form
    {
        public administratorMenu()
        {
            InitializeComponent();
        }

        private void studentnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void administratorMenu_Load(object sender, EventArgs e)
        {

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new administrator().Show();
        }

        private void enrolledclassesbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
