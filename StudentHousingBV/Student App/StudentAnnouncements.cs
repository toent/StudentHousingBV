using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Student_App
{
    public partial class StudentAnnouncements : Form
    {
        private readonly List<Announcement> announcements;

        public StudentAnnouncements(List<Announcement> announcements)
        {
            InitializeComponent();
            this.announcements = [.. announcements.OrderByDescending(a => a.Date)];
            LoadAnnouncements();
        }

        private void LoadAnnouncements()
        {
            pAnnouncements.Controls.Clear();

            foreach (Announcement announcement in announcements)
            {
                AnnouncementControl announcementControl = new(announcement)
                {
                    Margin = new Padding(0, 10, 0, 10)
                };
                pAnnouncements.Controls.Add(announcementControl);
            }
        }
    }
}
