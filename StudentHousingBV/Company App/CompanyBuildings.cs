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
            LoadBuildings();
        }

        private void LoadBuildings()
        {
            lbBuildings.Items.Clear();
            ClearFields();
            lbBuildings.Items.AddRange([.. housingManager.Buildings]);
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            CompanyAddBuilding addBuilding = new(housingManager);
            addBuilding.ShowDialog();

            if (addBuilding.DialogResult == DialogResult.OK && addBuilding.Building is not null && housingManager.AddBuilding(addBuilding.Building))
            {
                LoadBuildings();
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
                    if (housingManager.DeleteBuilding(building))
                    {
                        LoadBuildings();
                        MessageBox.Show("Building deleted successfully.");
                    }
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

        private void lbBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBuildings.SelectedItem is Building building)
            {
                tbBuildingId.Text = building.BuildingId.ToString();
                tbAddress.Text = building.Address;
                lbFlatOverview.Items.Clear();
                lbFlatOverview.Items.AddRange([.. building.Flats]);
            }
        }

        private void ClearFields()
        {
            tbBuildingId.Clear();
            tbAddress.Clear();
            lbFlatOverview.Items.Clear();
        }

        private void btnModifyBuilding_Click(object sender, EventArgs e)
        {
            if (lbBuildings.SelectedItem is Building building && ValidateBuilding())
            {
                building.Address = tbAddress.Text;

                if (housingManager.UpdateBuilding(building))
                {
                    MessageBox.Show("Building updated successfully.");
                    LoadBuildings();
                }
            }
        }

        private bool ValidateBuilding()
        {
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                MessageBox.Show("Please enter a valid address.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
