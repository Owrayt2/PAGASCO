using Microsoft.Win32;
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
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void createBackBtn_Click(object sender, EventArgs e)
        {
            ManagerLogin mlogin = new ManagerLogin();
            mlogin.Show();
            this.Hide();
        }
    }
}
