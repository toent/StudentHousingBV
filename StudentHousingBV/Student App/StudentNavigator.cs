using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Student_App;

namespace StudentHousingBV
{
    public partial class StudentNavigator : Form
    {
        private readonly HousingManager housingManager;
        private readonly Student student;

        public StudentNavigator(HousingManager housingManager, Student student)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.housingManager = housingManager;
            this.student = student;
            btnAnnouncements.BackColor = Color.FromArgb(240, 243, 255);
            LoadStudentNavigator();
        }

        private void LoadStudentNavigator()
        {
            lblContractId.Text = student.StudentId;
            lblUserName.Text = student.Name;
            lblLocation.Text = $"{student.AssignedFlat?.AssignedBuilding.Address} - Flat {student.AssignedFlat?.FlatNumber}";
            LoadFormIntoPanel(new StudentAnnouncements([.. student.AssignedFlat.Announcements]));
            lblTitle.Text = "Announcements";
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
                btnAgreements.BackColor = Color.FromArgb(255,255,255);
                btnAnnouncements.BackColor = Color.FromArgb(255,255,255);
                btnChores.BackColor = Color.FromArgb(255,255,255);
                btnFileComplaint.BackColor = Color.FromArgb(255,255,255);
                btnGroceries.BackColor = Color.FromArgb(255,255,255);
                btnHouseRules.BackColor = Color.FromArgb(255,255,255);

                button.BackColor = Color.FromArgb(240, 243, 255);

                switch (button.Name)
                {
                    case "btnAnnouncements":
                        LoadFormIntoPanel(new StudentAnnouncements([.. student.AssignedFlat.Announcements]));
                        lblTitle.Text = "Announcements";
                        break;
                    case "btnHouseRules":
                        LoadFormIntoPanel(new StudentHouserules([.. student.AssignedFlat.Rules]));
                        lblTitle.Text = "House Rules";
                        break;
                    case "btnAgreements":
                        LoadFormIntoPanel(new StudentAgreements(student, housingManager));
                        lblTitle.Text = "Agreements";
                        break;
                    case "btnChores":
                        LoadFormIntoPanel(new StudentChores(housingManager, student));
                        lblTitle.Text = "Chores";
                        break;
                    case "btnGroceries":
                        LoadFormIntoPanel(new StudentGroceries(housingManager, student));
                        lblTitle.Text = "Groceries";
                        break;
                    case "btnFileComplaint":
                        LoadFormIntoPanel(new StudentComplaint(housingManager, student));
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
