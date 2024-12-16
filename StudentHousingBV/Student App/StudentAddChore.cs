using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Student_App
{
    public partial class StudentAddChore : Form
    {
        internal Chore? chore;
        private readonly HousingManager housingManager;
        private readonly Student student;

        public StudentAddChore(List<Student> students, HousingManager housingManager, Student student)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.housingManager = housingManager;
            this.student = student;
            cbAssignee.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                chore = new(housingManager.GetNextChoreId(), tbTitle.Text, rtbDescription.Text, dtpDeadline.Value, student.AssignedFlat, (Student)cbAssignee.SelectedItem!);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInput()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                MessageBox.Show("Please enter a title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please enter a description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            if (dtpDeadline.Value < DateTime.Now)
            {
                MessageBox.Show("Deadline cannot be in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            if (cbAssignee.SelectedItem == null)
            {
                MessageBox.Show("Please select an assignee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }


    }
}
