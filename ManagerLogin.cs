using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAGASCO
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void siticoneLabel2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

            ManagerDashboard dashboard = new ManagerDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void siticoneLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void ManagerLabel_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createaccBtn_Click(object sender, EventArgs e)
        {
            CreateAcc createacc = new CreateAcc();
            createacc.Show();
            this.Hide();
        }

        private void LoginExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void LoginBackBtn_Click(object sender, EventArgs e)
        {
            UserChoiceMenu choiceMenu = new UserChoiceMenu();
           choiceMenu.Show();
            this.Hide();
        }
    }
}
