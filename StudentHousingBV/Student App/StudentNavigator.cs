using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Student_App;

namespace StudentHousingBV
{
    public partial class StudentNavigator : Form
    {
        private readonly HousingManager housingManager;

        public StudentNavigator(HousingManager housingManager)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.housingManager = housingManager;
            LoadStudentNavigator();
        }

        private void LoadStudentNavigator()
        {
            if (housingManager.LoggedStudent is Student student)
            {
                lblContractId.Text = housingManager.LoggedStudent.StudentId;
                lblUserName.Text = student.Name;
                lblLocation.Text = $"{student.AssignedFlat?.AssignedBuilding.Address} - Flat {student.AssignedFlat?.FlatNumber}";
            }
            else
            {
                MessageBox.Show("Invalid contract id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new(housingManager);
            studentLogin.Show();
            Hide();
            studentLogin.FormClosed += (s, args) => Close();
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
                        LoadFormIntoPanel(new StudentHouserules(housingManager));
                        lblTitle.Text = "House Rules";
                        break;
                    case "btnAgreements":
                        MessageBox.Show("This feature is not implemented yet.");
                        lblTitle.Text = "Agreements";
                        pShowForm.Controls.Clear();
                        break;
                    case "btnChores":
                        LoadFormIntoPanel(new StudentChores(housingManager));
                        lblTitle.Text = "Chores";
                        break;
                    case "btnGroceries":
                        LoadFormIntoPanel(new StudentGroceries(dataManager));
                        lblTitle.Text = "Groceries";
                        pShowForm.Controls.Clear();
                        break;
                    case "btnFileComplaint":
                        LoadFormIntoPanel(new StudentComplaint(housingManager));
                        lblTitle.Text = "File Complaint";
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
