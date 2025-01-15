using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Custom_Controls
{
    public partial class ComplaintControl : UserControl
    {
        public ComplaintControl(Complaint complaint)
        {
            InitializeComponent();
            lblIssue.Text = complaint.Issue;
            lblId.Text = complaint.ComplaintId.ToString();
        }
    }
}
