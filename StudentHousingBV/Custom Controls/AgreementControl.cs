using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Custom_Controls
{
    public partial class AgreementControl : UserControl
    {
        private Agreement agreementToControl;
        private Student StudentLookingAt;
        private Student Creator;
        private List<Student> Students = new List<Student>();
        private bool isOwner;

        public AgreementControl(Agreement agreement, Student studentLookingAt)
        {
            InitializeComponent();
            this.StudentLookingAt = studentLookingAt;
            this.agreementToControl = agreement;
            this.Creator = agreement.Student;
            this.Students = agreement.AgreedBy;
            this.isOwner = (this.Creator == this.StudentLookingAt);
            SetupVisuals();
        }

        private void SetupVisuals()
        {
            btnAgreeTo.Visible = !this.isOwner;
            btnAgreeTo.Enabled = !this.isOwner;
            btnDeleteAgreement.Visible = this.isOwner;
            btnDeleteAgreement.Enabled = this.isOwner;
            lblAgreementCreator.Text = this.Creator.Name;
            lblCreationDateTime.Text = this.agreementToControl.DateCreated.ToString();
            lblAgreementContent.Text = this.agreementToControl.Details;
            UpdateAgreedByVisual();
        }

        private void UpdateAgreedByVisual()
        {
            string agreedByString = string.Empty;
            this.Students.Select(student => student.Name).ToList().ForEach(name => { agreedByString = $"{agreedByString}, {name}"; });
            lblAgreedBy.Text = $"Agreed By: {agreedByString}";

            if (this.agreementToControl.AgreedBy.Contains(StudentLookingAt))
            { btnAgreeTo.Text = "Unagree"; }
            else
            { btnAgreeTo.Text = "Agree"; }
        }

        public void btnAgreeTo_Click(object sender, EventArgs e)
        {
            if (!this.isOwner)
            {
                if (!this.agreementToControl.AgreedBy.Contains(StudentLookingAt))
                { this.agreementToControl.AddStudentAgreed(StudentLookingAt); }
                else
                { this.agreementToControl.RemoveStudentAgreed(StudentLookingAt); }

                this.Students = agreementToControl.AgreedBy;
                UpdateAgreedByVisual();
            }
        }

        private void btnDeleteAgreement_Click(object sender, EventArgs e)
        {
            if (this.isOwner)
            {
                if (this.agreementToControl.AgreedBy.Count <= 0)
                {
                    //Delete Agreement
                }
                else
                {
                    MessageBox.Show("Cannot delete an agreement that has active agreeing students!");
                }
            }
        }
    }
}
