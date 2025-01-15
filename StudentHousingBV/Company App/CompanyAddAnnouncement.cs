using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyAddAnnouncement : Form
    {
        private readonly HousingManager housingManager;
        private Building selectedBuilding;
        internal EventHandler<Announcement> NewAnnouncement;
        public CompanyAddAnnouncement(HousingManager housingManager)
        {
            this.housingManager = housingManager;
            InitializeComponent();
            PopulateComboboxes();
        }

        private void PopulateComboboxes()
        {
            cbBuilding.DataSource = housingManager.GetBuildings();
            cbBuilding.DisplayMember = "Address";

            if (cbBuilding.SelectedItem is Building building)
            {
                cbFlat.DataSource = building.Flats;
                cbFlat.DisplayMember = "FlatNumber";
            }
        }

        private void cbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBuilding = (Building)cbBuilding.SelectedItem;
            cbFlat.DataSource = selectedBuilding.Flats;
        }

        private void cbGlobal_CheckedChanged(object sender, EventArgs e)
        {
            cbBuilding.Enabled = false;
            cbFlat.Enabled = false;

            cbBuilding.SelectedItem = null;
            cbFlat.SelectedItem = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbBuilding.SelectedItem is Building && cbFlat.SelectedItem is Flat flat)
            {
                Announcement announcement;
                announcement = new Announcement(housingManager.GetNextAnnouncementId(), tbTitle.Text, rtbMessage.Text, DateTime.Today, (Flat)cbFlat.SelectedItem);
                NewAnnouncement?.Invoke(this, announcement);
                Close();
            }
            else
            {
                MessageBox.Show("Please select a building and a flat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
