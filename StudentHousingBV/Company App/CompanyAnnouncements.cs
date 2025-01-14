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
            LoadAnnouncements();
            this.housingManager = housingManager;
            announcements = [];
            cbBuilding.DataSource = housingManager.GetBuildings();
            cbFlat.DataSource = selectedBuilding.Flats;
            cbFlat.SelectedIndex = 0;
            cbBuilding.DisplayMember = "Address";
        }

        private void LoadAnnouncements()
        {
            if (cbBuilding.SelectedItem is Building && cbFlat.SelectedItem is Flat flat)
            {
                MessageBox.Show("im here");
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

        private void CompanyAnnouncementControl_DataChanged(object sender, EventArgs e)
        {
            if (sender is CompanyAnnouncementControl announcementControl)
            {
                if (housingManager.UpdateAnnouncement(announcementControl.announcement))
                {
                    LoadAnnouncements();
                    MessageBox.Show("Changes applied", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to apply changes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CompanyAnnouncementsControl_Deleted(object sender, EventArgs e)
        {
            CompanyAnnouncementControl announcementControl = (CompanyAnnouncementControl)sender;
            housingManager.DeleteAnnouncement(announcementControl.announcement);
            LoadAnnouncements();
            MessageBox.Show("Announcement deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LoadAnnouncements();
        }

        private void cbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuilding.SelectedItem is Building building)
            {
                selectedBuilding = building;
                cbFlat.DataSource = building.Flats;
                cbFlat.DisplayMember = "FlatNumber";
                cbFlat.SelectedIndex = 0;
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
    }
}
