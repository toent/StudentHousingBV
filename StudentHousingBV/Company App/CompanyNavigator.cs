using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyNavigator : Form
    {
        private readonly HousingManager housingManager;

        public CompanyNavigator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            housingManager = new HousingManager();
        }

        private void Navigation_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "btnAnnouncements":
                        MessageBox.Show("This feature is not implemented yet.");
                        lblTitle.Text = "Announcements";
                        pShowForm.Controls.Clear();
                        break;
                    case "btnHouseRules":
                        LoadFormIntoPanel(new HouseRulesCompany(housingManager));
                        lblTitle.Text = "House Rules";
                        break;
                    case "btnAgreements":
                        MessageBox.Show("This feature is not implemented yet.");
                        lblTitle.Text = "Agreements";
                        pShowForm.Controls.Clear();
                        break;
                    case "btnFiledComplaint":
                        LoadFormIntoPanel(new DisplayComplaint(housingManager));
                        lblTitle.Text = "Filed Complaints";
                        break;
                    case "btnRegisterStudents":
                        MessageBox.Show("This feature is not implemented yet.");
                        lblTitle.Text = "Register Students";
                        pShowForm.Controls.Clear();
                        break;
                    default:
                        MessageBox.Show("This feature is not implemented yet.");
                        lblTitle.Text = "Home";
                        pShowForm.Controls.Clear();
                        break;
                }
            }
        }

        public void LoadFormIntoPanel(Form form)
        {
            pShowForm.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pShowForm.Controls.Add(form);
            form.Show();
        }
    }
}
