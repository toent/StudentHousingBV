using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Company_App
{

    public partial class CompanyAnnouncements : Form
    {
        private List<Announcement> announcements;
        private readonly HousingManager housingManager;
        private Building selectedBuilding;

        public CompanyAnnouncements(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            announcements = [];
            cbBuilding.DataSource = housingManager.GetBuildings();
            cbBuilding.DisplayMember = "Address";
        }

        private void LoadAnnouncements()
        {
            // Get global announcements (they are stored in the building)
            if (cbBuilding.SelectedItem is Building building)
            {
                // Get flat announcements
                if (cbFlat.SelectedItem is Flat flat)
                {
                    pAnnouncements.Controls.Clear();
                    announcements = [.. flat.Announcements];

                    foreach (Announcement announcement in announcements)
                    {
                        CompanyAnnouncementControl announcementControl = new(announcement);
                        announcementControl.DataChanged += CompanyAnnouncementControl_DataChanged!;
                        announcementControl.Deleted += CompanyAnnouncementsControl_Deleted!;
                        announcementControl.Margin = new Padding(0, 10, 0, 10);
                        pAnnouncements.Controls.Add(announcementControl);
                    }
                }
            }
        }

        private void CompanyAnnouncementControl_DataChanged(object sender, EventArgs e)
        {
            housingManager.SaveAllData();
            LoadAnnouncements();
            MessageBox.Show("Changes applied", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CompanyAnnouncementsControl_Deleted(object sender, EventArgs e)
        {
            CompanyAnnouncementControl announcementControl = (CompanyAnnouncementControl)sender;
            housingManager.DeleteAnnouncement(announcementControl.announcement);
            LoadAnnouncements();
            MessageBox.Show("Announcement deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuilding.SelectedItem is Building building)
            {
                selectedBuilding = building;
                cbFlat.DataSource = building.Flats;
                cbFlat.DisplayMember = "FlatNumber";
            }
            LoadAnnouncements();
        }

        private void cbFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFlat.SelectedItem is Flat flat)
            {
                LoadAnnouncements();
            }
        }

        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            CompanyAddAnnouncement companyAddAnnouncement = new(housingManager);
            companyAddAnnouncement.NewAnnouncement += AddAnnouncement;
            companyAddAnnouncement.ShowDialog();
        }

        private void AddAnnouncement(object sender, Announcement announcement)
        {
            housingManager.AddAnnouncement(announcement);
            housingManager.SaveAllData();
            LoadAnnouncements();
        }
    }
}
