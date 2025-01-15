using StudentHousingBV.Classes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.Custom_Controls
{
    public partial class ComplaintControl : UserControl
    {
        private Complaint complaint;
        public ComplaintControl(Complaint complaint)
        {
            InitializeComponent();
            this.complaint = complaint;
            PopulateFields();
        }

        private void PopulateFields()
        {
            lblId.Text = complaint.ComplaintId.ToString();
            lblIssue.Text = complaint.Issue;
        }
    }
}
