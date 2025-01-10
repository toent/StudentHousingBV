using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyBuildings : Form
    {
        private readonly HousingManager housingManager;

        public CompanyBuildings(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            CompanyAddBuilding addBuilding = new(housingManager);
            addBuilding.ShowDialog();

            if (addBuilding.DialogResult == DialogResult.OK && addBuilding.Building is not null && housingManager.AddBuilding(addBuilding.Building))
            {
                MessageBox.Show("Building added successfully.");
            }
            else
            {
                MessageBox.Show("There was an error adding the building.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBuilding_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbBuildings.SelectedItem is Building building)
                {
                    housingManager.DeleteBuilding(building);
                }
                else
                {
                    MessageBox.Show("Please select a building to delete.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
