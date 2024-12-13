using StudentHousingBV.Classes.Managers;


namespace StudentHousingBV.Student_App
{
    public partial class StudentAnnouncements : Form
    {
        private readonly HousingManager housingManager;

        public StudentAnnouncements(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            LoadAnnouncements();
        }

        private void LoadAnnouncements()
        {
            var announcements = new[]
            {
        new { Title = "New Library Hours", Timestamp = DateTime.Now.AddHours(-3), Content = "Library hours extended to 10 PM starting next week." },
        new { Title = "Exam Schedule Update", Timestamp = DateTime.Now.AddDays(-1), Content = "Final exams will begin on January 2nd. Check the portal for details." },
        new { Title = "Holiday Event", Timestamp = DateTime.Now.AddDays(-5), Content = "Join us for a holiday event in the main auditorium on December 20th!" },
        new { Title = "Maintenance Notice", Timestamp = DateTime.Now.AddHours(-10), Content = "The dormitory water supply will be off on December 15th from 10 AM to 2 PM." },
        new { Title = "Fire Drill", Timestamp = DateTime.Now.AddDays(-2), Content = "There will be a mandatory fire drill on December 16th at 3 PM. Attendance is required." },
        new { Title = "Fire Drill", Timestamp = DateTime.Now.AddDays(-2), Content = "There will be a mandatory fire drill on December 16th at 3 PM. Attendance is required." },
        new { Title = "Fire Drill", Timestamp = DateTime.Now.AddDays(-2), Content = "There will be a mandatory fire drill on December 16th at 3 PM. Attendance is required." },
        new { Title = "Fire Drill", Timestamp = DateTime.Now.AddDays(-2), Content = "There will be a mandatory fire drill on December 16th at 3 PM. Attendance is required." },
        new { Title = "Fire Drill", Timestamp = DateTime.Now.AddDays(-2), Content = "There will be a mandatory fire drill on December 16th at 3 PM. Attendance is required." },
        new { Title = "Fire Drill", Timestamp = DateTime.Now.AddDays(-2), Content = "There will be a mandatory fire drill on December 16th at 3 PM. Attendance is required." },

    };

            int yOffset = 10;

            foreach (var announcement in announcements)
            {
                var announcementPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(10, yOffset),
                    Width = panelAnnoucmentControls.ClientSize.Width - 20,
                    AutoSize = true
                };

                var titleLabel = new Label
                {
                    Text = announcement.Title,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(5, 5)
                };
                announcementPanel.Controls.Add(titleLabel);

                var timestampLabel = new Label
                {
                    Text = announcement.Timestamp.ToString("g"),
                    Font = new Font("Arial", 9, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Location = new Point(5, titleLabel.Bottom + 5)
                };
                announcementPanel.Controls.Add(timestampLabel);

                var contentLabel = new Label
                {
                    Text = announcement.Content,
                    Font = new Font("Arial", 10),
                    AutoSize = true,
                    Location = new Point(5, timestampLabel.Bottom + 5)
                };
                announcementPanel.Controls.Add(contentLabel);

                panelAnnoucmentControls.Controls.Add(announcementPanel);

                yOffset += announcementPanel.Height + 10;
            }

            panelAnnoucmentControls.AutoScrollMinSize = new Size(0, yOffset);
        }

        private void InitializeComponent()
        {
            panelAnnoucmentControls = new Panel();
            SuspendLayout();
            panelAnnoucmentControls.AutoScroll = true;
            panelAnnoucmentControls.Location = new Point(10, 44);
            panelAnnoucmentControls.Margin = new Padding(2);
            panelAnnoucmentControls.Name = "panelAnnoucmentControls";
            panelAnnoucmentControls.Size = new Size(1259, 611);
            panelAnnoucmentControls.TabIndex = 3;

            ClientSize = new Size(1278, 699);
            Controls.Add(panelAnnoucmentControls);
            Name = "StudentAnnouncements";
            ResumeLayout(false);
        }

        private Panel panelAnnoucmentControls;

    }
}
