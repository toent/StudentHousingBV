using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Student_App
{
    public partial class StudentLogin : Form
    {
        readonly HousingManager housingManager;

        public StudentLogin()
        {
            InitializeComponent();
            housingManager = new HousingManager();
            //InitializeTestingDataset();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public StudentLogin(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput() && housingManager.GetStudent(txtStudentId.Text) is Student student)
            {
                StudentNavigator studentNavigator = new(housingManager, student);
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
            housingManager.Buildings.Add(new Building(housingManager.GetNextBuildingId(), "123 Main St"));
            housingManager.Buildings[0].Flats.Add(new Flat(housingManager.GetNextFlatId(), 101, housingManager.Buildings[0]));
            housingManager.Buildings[0].Flats[0].Students.Add(new Student("F12345", "John Doe", housingManager.Buildings[0].Flats[0]));
            housingManager.SaveAllData();
        }
    }
}
