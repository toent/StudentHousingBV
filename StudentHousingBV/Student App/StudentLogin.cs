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
        }

        public StudentLogin(DataManager dataManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput() && dataManager.GetStudent(txtStudentId.Text) is Student student)
            {
                StudentNavigator studentNavigator = new(dataManager, student);
                studentNavigator.Show();
                Close();
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
    }
}
