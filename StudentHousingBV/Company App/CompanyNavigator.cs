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
            LoadFormIntoPanel(new CompanyBuildings(housingManager));
        }

        private void Navigation_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "btnBuildings":
                        LoadFormIntoPanel(new CompanyBuildings(housingManager));
                        lblTitle.Text = "Buildings";
                        break;
                    case "btnFlats":
                        LoadFormIntoPanel(new CompanyFlats(housingManager));
                        lblTitle.Text = "Flats";
                        break;
                    case "btnAnnouncements":
                        LoadFormIntoPanel(new CompanyAnnouncements(housingManager));
                        lblTitle.Text = "Announcements";
                        break;
                    case "btnHouseRules":
                        LoadFormIntoPanel(new HouseRulesCompany(housingManager));
                        lblTitle.Text = "House Rules";
                        break;
                    case "btnAgreements":
                        LoadFormIntoPanel(new CompanyAgreements(housingManager));
                        lblTitle.Text = "Agreements";
                        break;
                    case "btnFiledComplaint":
                        LoadFormIntoPanel(new DisplayComplaint(housingManager));
                        lblTitle.Text = "Filed Complaints";
                        break;
                    case "btnStudents":
                        LoadFormIntoPanel(new CompanyStudents(housingManager));
                        lblTitle.Text = "Students";
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
