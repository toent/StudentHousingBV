using StudentHousingBV.Classes.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentHousingBV.Custom_Controls
{
    public partial class AnnoucmentsControl : UserControl
    {
        private readonly Announcement _announcement;

        public AnnoucmentsControl(Announcement announcement)
        {
            InitializeComponent();
            _announcement = announcement;

            lblTimeUploaded.Text = DateTime.Now.ToString("HH:mm");
            lblAnnouncment.Text = "[Announcement]";
            lblContent.Text = _announcement.Message;

            if (_announcement.IsGlobal)
            {
                BackColor = Color.LightYellow;
            }
        }

        private void btnStatusChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Announcement '{_announcement.Message}' marked as read.");
            Parent?.Controls.Remove(this);
        }
    }
}
