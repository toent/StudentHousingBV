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
            if (!DataManager.CheckIfDataExists())
            {
                housingManager.Buildings.Add(new Building(housingManager.GetNextBuildingId(), "123 Main St"));
                housingManager.Buildings[0].Flats.Add(new Flat(housingManager.GetNextFlatId(), 101, housingManager.Buildings[0]));
                housingManager.AddStudent(new Student("F12345", "John Doe", housingManager.Buildings[0].Flats[0]));
                housingManager.AddStudent(new Student("F54321", "Doe Doe", housingManager.Buildings[0].Flats[0]));

                housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the bathroom", "Clean the bathroom with the broom.", DateTime.Now.AddDays(1), housingManager.Buildings[0].Flats[0], housingManager.GetStudent("F12345")));
                housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the kitchen", "Clean the kitchen with the mop.", DateTime.Now.AddDays(2), housingManager.Buildings[0].Flats[0], housingManager.GetStudent("F12345")));
                housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the living room", "Clean the living room with the vacuum cleaner.", DateTime.Now.AddDays(3), housingManager.Buildings[0].Flats[0], housingManager.GetStudent("F12345")));
                housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the bedroom", "Clean the bedroom with the duster.", DateTime.Now.AddDays(4), housingManager.Buildings[0].Flats[0], housingManager.GetStudent("F12345")));
                housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the hallway", "Clean the hallway with the broom.", DateTime.Now.AddDays(5), housingManager.Buildings[0].Flats[0], housingManager.GetStudent("F12345")));
                housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the balcony", "Clean the balcony with the mop.", DateTime.Now.AddDays(6), housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the garden", "Clean the garden with the vacuum cleaner.", DateTime.Now.AddDays(7), housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the garage", "Clean the garage with the duster.", DateTime.Now.AddDays(8), housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Chores.Add(new Chore(housingManager.GetNextChoreId(), "Clean the attic", "Clean the attic with the broom.", DateTime.Now.AddDays(9), housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Announcements.Add(new Announcement(housingManager.GetNextAnnouncementId(), "Important Announcement", "Please do not leave the garbage outside as it may attract insects and rats. We will be monitoring garbage collection from now on. You could have to pay more if you don't throw the garbage away correctly.", DateTime.Today, housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Announcements.Add(new Announcement(housingManager.GetNextAnnouncementId(), "Garbage collection", "Please do not leave the garbage outside as it may attract insects and rats. We will be monitoring garbage collection from now on. You could have to pay more if you don't throw the garbage away correctly.", DateTime.Today, housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Announcements.Add(new Announcement(housingManager.GetNextAnnouncementId(), "New bike parrking rule", "Please do not leave the garbage outside as it may attract insects and rats. We will be monitoring garbage collection from now on. You could have to pay more if you don't throw the garbage away correctly.", DateTime.Today, housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Announcements.Add(new Announcement(housingManager.GetNextAnnouncementId(), "Updated parking notice", "Please do not leave the garbage outside as it may attract insects and rats. We will be monitoring garbage collection from now on. You could have to pay more if you don't throw the garbage away correctly.", DateTime.Today, housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Rules.Add(new Rule(housingManager.GetNextRuleId(), housingManager.Buildings[0].Flats[0], "Smoking is not allowed in the building."));
                housingManager.Buildings[0].Flats[0].Rules.Add(new Rule(housingManager.GetNextRuleId(), housingManager.Buildings[0].Flats[0], "Pets are not allowed in the building."));
                housingManager.Buildings[0].Flats[0].Rules.Add(new Rule(housingManager.GetNextRuleId(), housingManager.Buildings[0].Flats[0], "Parties are not allowed in the building."));
                housingManager.Buildings[0].Flats[0].Rules.Add(new Rule(housingManager.GetNextRuleId(), housingManager.Buildings[0].Flats[0], "Quiet hours are from 10pm to 6am."));
                housingManager.Buildings[0].Flats[0].Rules.Add(new Rule(housingManager.GetNextRuleId(), housingManager.Buildings[0].Flats[0], "Guests are not allowed to stay overnight."));
                housingManager.Buildings[0].Flats[0].Rules.Add(new Rule(housingManager.GetNextRuleId(), housingManager.Buildings[0].Flats[0], "Garbage must be thrown away in the designated area."));
                housingManager.Buildings[0].Flats[0].Rules.Add(new Rule(housingManager.GetNextRuleId(), housingManager.Buildings[0].Flats[0], "Bikes must be parked in the designated area."));
                housingManager.Buildings[0].Flats[0].Rules.Add(new Rule(housingManager.GetNextRuleId(), housingManager.Buildings[0].Flats[0], "Cars must be parked in the designated area."));
                // Add agreements
                housingManager.Buildings[0].Flats[0].Agreements.Add(new Agreement(housingManager.GetNextAgreementId(), "House rules", "I agree to follow the house rules.", [housingManager.GetStudent("F12345"), housingManager.GetStudent("F54321")], housingManager.GetStudent("F12345"), housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Agreements.Add(new Agreement(housingManager.GetNextAgreementId(), "Chores", "I agree to do the chores.", [housingManager.GetStudent("F12345")], housingManager.GetStudent("F12345"), housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Agreements.Add(new Agreement(housingManager.GetNextAgreementId(), "Garbage collection", "I agree to throw the garbage away correctly.", [housingManager.GetStudent("F12345")], housingManager.GetStudent("F12345"), housingManager.Buildings[0].Flats[0]));
                housingManager.Buildings[0].Flats[0].Agreements.Add(new Agreement(housingManager.GetNextAgreementId(), "Quiet hours", "I agree to be quiet during quiet hours.", [housingManager.GetStudent("F12345")], housingManager.GetStudent("F12345"), housingManager.Buildings[0].Flats[0]));
                housingManager.SaveAllData();
            }
        }
    }
}
