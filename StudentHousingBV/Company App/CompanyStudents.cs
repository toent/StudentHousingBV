using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyStudents : Form
    {
        private readonly HousingManager housingManager;

        public CompanyStudents(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            LoadStudents();
            LoadBuildings();
        }

        private void LoadStudents()
        {
            lbStudents.Items.Clear();
            lbStudents.Items.AddRange([.. housingManager.GetAllStudents()]);
        }

        private void LoadBuildings()
        {
            lbStudentBuilding.Items.AddRange([.. housingManager.GetBuildings()]);
        }

        private void LoadFlats(Building building)
        {
            lbStudentFlat.Items.Clear();
            lbStudentFlat.Items.AddRange([.. building.Flats]);
        }

        private void tbFilterStudent_TextChanged(object sender, EventArgs e)
        {
            lbStudents.Items.Clear();
            lbStudents.Items.AddRange([.. housingManager.GetStudents(tbFilterStudent.Text)]);
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem is Student student)
            {
                tbStudentId.Text = student.StudentId;
                tbStudentName.Text = student.Name;
                lbStudentBuilding.SelectedItem = student.AssignedFlat.AssignedBuilding;
                LoadFlats(student.AssignedFlat.AssignedBuilding);
                lbStudentFlat.SelectedItem = student.AssignedFlat;
            }
        }

        private void tbBuildingFilter_TextChanged(object sender, EventArgs e)
        {
            lbStudentBuilding.Items.Clear();
            lbStudentBuilding.Items.AddRange([.. housingManager.GetBuildings(tbBuildingFilter.Text)]);
        }

        private void lbStudentBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudentBuilding.SelectedItem is Building building)
            {
                LoadFlats(building);
            }
        }

        private void tbFlatFilter_TextChanged(object sender, EventArgs e)
        {
            if (lbStudentBuilding.SelectedItem is Building building)
            {
                lbStudentFlat.Items.Clear();
                lbStudentFlat.Items.AddRange([.. HousingManager.GetFlats(building, tbFlatFilter.Text)]);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            CompanyAddStudent companyAddStudent = new(housingManager);
            companyAddStudent.ShowDialog();

            if (companyAddStudent.DialogResult == DialogResult.OK && companyAddStudent.Student is Student student)
            {
                if (housingManager.AddStudent(student))
                {
                    MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();
                }
            }
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem is Student student && lbStudentFlat.SelectedItem is Flat flat && ValidateStudent())
            {
                student.StudentId = tbStudentId.Text;
                student.Name = tbStudentName.Text;
                student.AssignedFlat = flat;
                if (housingManager.UpdateStudent(student))
                {
                    LoadStudents();
                    MessageBox.Show("Student updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a student and a flat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateStudent()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(tbStudentId.Text))
            {
                MessageBox.Show("Contract ID is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            else if (string.IsNullOrWhiteSpace(tbStudentName.Text))
            {
                MessageBox.Show("Student Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            else if (lbStudentFlat.SelectedItem is null)
            {
                MessageBox.Show("Flat is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItem is Student student)
            {
                if (MessageBox.Show("Are you sure you want to remove this student?\nAll data related to the student is also going to be deleted.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (housingManager.DeleteStudent(student))
                    {
                        LoadStudents();
                        MessageBox.Show("Student removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
