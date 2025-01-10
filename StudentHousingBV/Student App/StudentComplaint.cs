using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Student_App
{
    public partial class StudentComplaint : Form
    {
        private readonly HousingManager housingManager;
        private readonly Student student;

        public StudentComplaint(HousingManager housingManager, Student student)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            this.student = student;
        }

        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbComplaint.Text))
            {
                housingManager.SubmitComplaint(new Complaint(housingManager.GetNextComplaintId(), student.AssignedFlat, rtbComplaint.Text));
                rtbComplaint.Clear();
                MessageBox.Show("Complaint submitted successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a complaint before submitting.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
