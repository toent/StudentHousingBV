using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyAddFlat : Form
    {
        public Flat? Flat { get; set; }
        private readonly HousingManager housingManager;
        private readonly Building building;

        public CompanyAddFlat(HousingManager housingManager, Building building)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            StartPosition = FormStartPosition.CenterScreen;
            this.building = building;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nudFlatNumber.Value < 0)
            {
                MessageBox.Show("Please enter a flat number.");
            }
            else if (building.Flats.Any(f => f.FlatNumber == (int)nudFlatNumber.Value))
            {
                MessageBox.Show("A flat with this number already exists in this building.");
            }
            else
            {
                Flat = new(housingManager.GetNextFlatId(), (int)nudFlatNumber.Value, building);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
