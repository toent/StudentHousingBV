using StudentHousingBV.Classes;

namespace StudentHousingBV.Student_App
{
    public partial class StudentLogin : Form
    {
        readonly DataManager dataManager;

        public StudentLogin()
        {
            InitializeComponent();
            dataManager = new DataManager();
            InitializeTestingDataset();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public StudentLogin(DataManager dataManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput() && dataManager.GetStudent(txtStudentId.Text) is Student student)
            {
                StudentNavigator studentNavigator = new(dataManager, student);
                studentNavigator.Show();
                Hide();
                studentNavigator.FormClosed += (s, args) => Close();
            }
            else
            {
                MessageBox.Show("Invalid contract id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txtStudentId.Text))
            {
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        private void InitializeTestingDataset()
        {
            dataManager.Buildings.Add(new Building(dataManager)
            {
                BuildingId = 1,
                Address = "123 Main St"
            });
            dataManager.Flats.Add(new Flat(dataManager)
            {
                BuildingId = 1,
                FlatId = 1,
                FlatNumber = 101
            });
            dataManager.Students.Add(new Student()
            {
                StudentId = "F93756",
                BuildingId = 1,
                FlatId = 1,
                Name = "Jane Doe",
            });
        }
    }
}
