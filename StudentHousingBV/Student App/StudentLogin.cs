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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
