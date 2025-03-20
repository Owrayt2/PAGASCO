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
    public partial class CostumerMenu : Form
    {
        public CostumerMenu()
        {
            InitializeComponent();
        }

        private void CostumerExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void costumerBackBtn_Click(object sender, EventArgs e)
        {
            UserChoiceMenu choiceMenu = new UserChoiceMenu();
            choiceMenu.Show();
            this.Hide();
        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTbx_Click(object sender, EventArgs e)
        {

        }

        private void FuelCostumeracahoicesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LitterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
