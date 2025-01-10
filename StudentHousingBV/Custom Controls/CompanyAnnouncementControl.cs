using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Custom_Controls
{
    public partial class CompanyAnnouncementControl : UserControl
    {
        internal readonly Announcement announcement;
        public event EventHandler? DataChanged;
        public event EventHandler? Deleted;

        public CompanyAnnouncementControl(Announcement announcement)
        {
            InitializeComponent();
            tbTitle.Text = announcement.Title;
            lblPublishedDate.Text = announcement.Date.ToString("dd-MM-yyyy");
            rtbContent.Text = announcement.Message;
            this.announcement = announcement;
            btnApplyChanges.Enabled = false;
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            btnApplyChanges.Enabled = true;
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {
            btnApplyChanges.Enabled = true;
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTitle.Text) && !string.IsNullOrEmpty(rtbContent.Text))
            {
                btnApplyChanges.Enabled = false;
                announcement.Title = tbTitle.Text;
                announcement.Message = rtbContent.Text;
                announcement.Date = DateTime.Now;
                DataChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Deleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
