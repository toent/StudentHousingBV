using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using System.Data;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyFlats : Form
    {
        private readonly HousingManager housingManager;

        public CompanyFlats(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            LoadBuildingFilter();
            if (lbBuildingFilter.Items.Count > 0)
            {
                lbBuildingFilter.SelectedIndex = 0;
                LoadFlats(lbBuildingFilter.SelectedItem as Building);
            }
        }

        private void btnAddFlat_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbBuildingFilter.SelectedItem is Building building)
                {
                    CompanyAddFlat addFlat = new(housingManager, building);
                    addFlat.ShowDialog();

                    if (addFlat.DialogResult == DialogResult.OK && addFlat.Flat is not null && housingManager.AddFlat(addFlat.Flat))
                    {
                        LoadFlats(building);
                        MessageBox.Show("Flat added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("There was an error adding the flat.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a building to add a flat to.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadFlats(Building? building)
        {
            if (building is not null)
            {
                lbFlats.Items.Clear();
                ClearFields();
                lbFlats.Items.AddRange([.. building.Flats]);
            }
        }

        private void lbBuildingFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBuildingFilter.SelectedItem is Building building)
            {
                LoadFlats(building);
            }
        }

        private void lbFlats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFlats.SelectedItem is Flat flat)
            {
                tbFlatId.Text = flat.FlatId.ToString();
                nudFlatNumber.Value = flat.FlatNumber;
                lbStudentOverview.Items.Clear();
                lbStudentOverview.Items.AddRange([.. flat.Students]);
            }
        }

        private void btnDeleteFlat_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbFlats.SelectedItem is Flat flat)
                {
                    if (housingManager.DeleteFlat(flat))
                    {
                        LoadFlats(lbBuildingFilter.SelectedItem as Building);
                        MessageBox.Show("Flat deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("There was an error deleting the flat.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a flat to delete.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbBuildingFilter_TextChanged(object sender, EventArgs e)
        {
            lbBuildingFilter.Items.Clear();
            lbBuildingFilter.Items.AddRange([.. housingManager.Buildings.Where(b => b.Address.Contains(tbBuildingFilter.Text, StringComparison.CurrentCultureIgnoreCase))]);
        }

        private void btnModifyFlat_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbFlats.SelectedItem is Flat flat && ValidateFlat())
                {

                    flat.FlatNumber = (int)nudFlatNumber.Value;

                    if (housingManager.UpdateFlat(flat))
                    {
                        MessageBox.Show("Flat updated successfully.");
                        LoadFlats(lbBuildingFilter.SelectedItem as Building);
                    }
                    else
                    {
                        MessageBox.Show("There was an error updating the flat.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFlat()
        {
            if (nudFlatNumber.Value < 0)
            {
                MessageBox.Show("Please enter a flat number.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            tbFlatId.Text = string.Empty;
            nudFlatNumber.Value = 0;
            lbStudentOverview.Items.Clear();
        }

        private void LoadBuildingFilter()
        {
            lbBuildingFilter.Items.Clear();
            lbBuildingFilter.Items.AddRange([.. housingManager.Buildings]);
        }
    }
}
