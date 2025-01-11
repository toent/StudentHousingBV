using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyAddStudent : Form
    {
        private readonly HousingManager housingManager;
        public Student? Student { get; private set; }

        public CompanyAddStudent(HousingManager housingManager)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.housingManager = housingManager;
            LoadBuildings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateStudent() && lbStudentFlat.SelectedItem is Flat flat)
            {
                Student = new Student(tbId.Text, tbName.Text, flat);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateStudent()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(tbId.Text))
            {
                MessageBox.Show("Please enter a contract id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            else if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lbStudentFlat.SelectedItem is null)
            {
                MessageBox.Show("Please select a flat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        private void LoadBuildings()
        {
            lbStudentFlat.Items.Clear();
            lbStudentBuilding.Items.AddRange([.. housingManager.GetBuildings()]);
        }

        private void lbStudentBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudentBuilding.SelectedItem is Building building)
            {
                LoadFlats(building);
            }
        }

        private void LoadFlats(Building building)
        {
            lbStudentFlat.Items.Clear();
            lbStudentFlat.Items.AddRange([.. building.Flats]);
        }

        private void tbBuildingFilter_TextChanged(object sender, EventArgs e)
        {
            lbStudentBuilding.Items.Clear();
            lbStudentBuilding.Items.AddRange([.. housingManager.GetBuildings(tbBuildingFilter.Text)]);
        }

        private void tbFlatFilter_TextChanged(object sender, EventArgs e)
        {
            if (lbStudentBuilding.SelectedItem is Building building)
            {
                lbStudentFlat.Items.Clear();
                lbStudentFlat.Items.AddRange([.. HousingManager.GetFlats(building, tbFlatFilter.Text)]);
            }
        }
    }
}
