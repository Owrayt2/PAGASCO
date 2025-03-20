using System.Data.OleDb;
using System.Data;

namespace PAGASCO
{
    public partial class UserChoiceMenu : Form
    {

        public UserChoiceMenu()
        {
            InitializeComponent();
        }

        private void managaerBtn_Click(object sender, EventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Show();
            this.Hide();
        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserChoiceExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void cnnctBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.testconnection();
        }

        private void CostumerBtn_Click(object sender, EventArgs e)
        {
            CostumerMenu  costumermenu = new CostumerMenu();
           costumermenu.Show();
            this.Hide();
        }
    }
}
