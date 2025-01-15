using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Student_App
{
    public partial class StudentAnnouncements : Form
    {
        private List<Announcement> announcements;
        private HousingManager housingManager;
        private Student student;

        public StudentAnnouncements(HousingManager housingManager, Student student)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            this.student = student;
            LoadAnnouncements();
            
        }

        private void LoadAnnouncements()
        {
            pAnnouncements.Controls.Clear();
            announcements = housingManager.GetAnnouncementsByFlat(student.AssignedFlat.FlatId);

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
