using StudentHousingBV.Classes;
using StudentHousingBV.Student_App;

namespace StudentHousingBV
{
    public partial class StudentNavigator : Form
    {
        private readonly DataManager dataManager;
        private readonly Student student;

        public StudentNavigator(DataManager dataManager, Student student)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.dataManager = dataManager;
            this.student = student;
            LoadStudentNavigator();
        }

        private void LoadStudentNavigator()
        {
            lblContractId.Text = student.StudentId;
            lblUserName.Text = student.Name;
            lblLocation.Text = $"{dataManager.GetBuilding(student.BuildingId)?.Address} - Flat {dataManager.GetFlat(student.FlatId)?.FlatNumber}";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new(dataManager);
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
                        LoadFormIntoPanel(new StudentHouserules(dataManager));
                        lblTitle.Text = "House Rules";
                        break;
                    case "btnAgreements":
                        MessageBox.Show("This feature is not implemented yet.");
                        lblTitle.Text = "Agreements";
                        pShowForm.Controls.Clear();
                        break;
                    case "btnChores":
                        LoadFormIntoPanel(new StudentChores(dataManager));
                        lblTitle.Text = "Chores";
                        break;
                    case "btnGroceries":
                        MessageBox.Show("This feature is not implemented yet.");
                        lblTitle.Text = "Groceries";
                        pShowForm.Controls.Clear();
                        break;
                    case "btnFileComplaint":
                        LoadFormIntoPanel(new StudentComplaint(dataManager));
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
