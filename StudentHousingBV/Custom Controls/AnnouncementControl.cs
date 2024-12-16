using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Custom_Controls
{
    public partial class AnnouncementControl : UserControl
    {
        private readonly Announcement announcement;

        public AnnouncementControl(Announcement announcement)
        {
            InitializeComponent();
            this.announcement = announcement;
            LoadAnnouncement();
        }

        private void LoadAnnouncement()
        {
            lblTitle.Text = announcement.Title;
            lblDescription.Text = announcement.Message;
            lblPublishedDate.Text = announcement.Date.ToString("dd/MM/yyyy");
        }
    }
}
