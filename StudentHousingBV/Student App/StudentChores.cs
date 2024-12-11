using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Student_App
{
    public partial class StudentChores : Form
    {
        private readonly HousingManager housingManager;

        public StudentChores(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
        }
    }
}
