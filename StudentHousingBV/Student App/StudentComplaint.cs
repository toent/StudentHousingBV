using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Student_App
{
    public partial class StudentComplaint : Form
    {
        private readonly HousingManager housingManager;

        public StudentComplaint(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
        }

        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complaint submitted successfully!");
        }

        private void changeSelectedTabBgColor()
        {

        }
    }
}
