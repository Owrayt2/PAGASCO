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
    public partial class ManagerDashboard : Form
    {
        private Dictionary<string, FuelStock> branchStocks = new Dictionary<string, FuelStock>();
        private DataGridView dataGridView;
        private ComboBox branchComboBox;
        bool sidebarExpand = true;

        public ManagerDashboard()
        {
            InitializeComponent();



        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 37)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 382)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void loginBtn_Click(object sender, EventArgs e) //branchbtn
        {
            branchPanel.BringToFront();
            sidebar.BringToFront();
        }

        private void branchesComBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddFuelTbx_Click(object sender, EventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

        }

        private void FuelStocksDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashBoardExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)  //addstockBtn
        {
            
        }

        private void addbranchBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveStockBtn_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PagascoLabel_Click(object sender, EventArgs e)
        {

        }


        private void siticonePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                ManagerLogin managerlogin = new ManagerLogin();
                managerlogin.ShowDialog();
                this.Close();
            }
        }



        private void SalesBtn_Click(object sender, EventArgs e)
        {
            SalesPanel.BringToFront();
            sidebar.BringToFront();
        }

        private void siticoneShimmerLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SalesPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void siticoneShimmerLabel2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void BranchBtn_Paint(object sender, PaintEventArgs e)
        {



        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneLabel3_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
            sidebar.BringToFront();

        }

        private void SalesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DateSalesCombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AboutPGSCBtn_Click(object sender, EventArgs e)
        {
            AboutUsPanel.BringToFront();
            sidebar.BringToFront();
        }

        private void AccountSetPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccSettingsBtn_Click(object sender, EventArgs e)
        {
            AccountSetPanel.BringToFront();
            sidebar.BringToFront();
        }
    }

    public class FuelStock
    {
        public int Diesel { get; set; }
        public int Regular { get; set; }
        public int Premium { get; set; }

        public FuelStock(int diesel, int regular, int premium)
        {
            Diesel = diesel;
            Regular = regular;
            Premium = premium;
        }
    }
}