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
            InitializeTestingDataset();
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
            housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the bathroom", "Clean the bathroom with the broom.", DateTime.Now.AddDays(1), housingManager.Buildings[0].Flats[0]));
            housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the kitchen", "Clean the kitchen with the mop.", DateTime.Now.AddDays(2), housingManager.Buildings[0].Flats[0]));
            housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the living room", "Clean the living room with the vacuum cleaner.", DateTime.Now.AddDays(3), housingManager.Buildings[0].Flats[0]));
            housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the bedroom", "Clean the bedroom with the duster.", DateTime.Now.AddDays(4), housingManager.Buildings[0].Flats[0]));
            housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the hallway", "Clean the hallway with the broom.", DateTime.Now.AddDays(5), housingManager.Buildings[0].Flats[0]));
            housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the balcony", "Clean the balcony with the mop.", DateTime.Now.AddDays(6), housingManager.Buildings[0].Flats[0]));
            housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the garden", "Clean the garden with the vacuum cleaner.", DateTime.Now.AddDays(7), housingManager.Buildings[0].Flats[0]));
            housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the garage", "Clean the garage with the duster.", DateTime.Now.AddDays(8), housingManager.Buildings[0].Flats[0]));
            housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the attic", "Clean the attic with the broom.", DateTime.Now.AddDays(9), housingManager.Buildings[0].Flats[0]));
        }
    }
}
