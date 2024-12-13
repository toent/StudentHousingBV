using System;
using System.Drawing;
using System.Windows.Forms;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls; // Make sure to include this for the AnnoucmentsControl class

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
            panelAnnoucmentControls.Controls.Clear();

            foreach (var announcement in housingManager.GetAllAnnouncements()) 
            {
                AnnoucmentsControl announcementControl = new(announcement);
                announcementControl.Margin = new Padding(0, 10, 0, 10); 

                panelAnnoucmentControls.Controls.Add(announcementControl);
            }
        }

        private void InitializeComponent()
        {
            panelAnnoucmentControls = new Panel
            {
                AutoScroll = true, 
                Location = new Point(10, 44),
                Margin = new Padding(2),
                Name = "panelAnnoucmentControls",
                Size = new Size(1259, 611), 
                TabIndex = 3
            };

            SuspendLayout();

            // Set up the main form
            ClientSize = new Size(1278, 699);
            Controls.Add(panelAnnoucmentControls);
            Name = "StudentAnnouncements";
            Text = "Student Announcements";
            ResumeLayout(false);
        }

        private Panel panelAnnoucmentControls;
    }
}
