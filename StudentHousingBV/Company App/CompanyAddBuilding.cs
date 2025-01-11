using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyAddBuilding : Form
    {
        public Building? Building { get; set; }
        private readonly HousingManager housingManager;

        public CompanyAddBuilding(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                MessageBox.Show("Please enter an address.");
            }
            else
            {
                Building = new Building(housingManager.GetNextBuildingId(), tbAddress.Text);
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}
