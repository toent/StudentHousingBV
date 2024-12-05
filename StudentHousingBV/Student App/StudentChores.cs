using StudentHousingBV.Classes;

namespace StudentHousingBV.Student_App
{
    public partial class StudentChores : Form
    {
        private readonly DataManager dataManager;

        public StudentChores(DataManager dataManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
        }
    }
}
