using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using System.Data;

namespace StudentHousingBV.Custom_Controls
{
    public partial class AgreementControl : UserControl
    {
        private readonly Agreement agreementToControl;
        private readonly Student StudentLookingAt;
        private readonly Student Creator;
        private List<Student> Students = [];
        private readonly bool isOwner;
        private readonly HousingManager housingManager;

        public AgreementControl(Agreement agreement, Student studentLookingAt, HousingManager housingManager)
        {
            InitializeComponent();
            StudentLookingAt = studentLookingAt;
            agreementToControl = agreement;
            Creator = agreement.Student ?? new();
            Students = agreement.AgreedBy;
            isOwner = (Creator == StudentLookingAt);
            this.housingManager = housingManager;
            SetupVisuals();
        }

        private void SetupVisuals()
        {
            btnAgreeTo.Visible = !isOwner;
            btnAgreeTo.Enabled = !isOwner;
            btnDeleteAgreement.Visible = isOwner;
            btnDeleteAgreement.Enabled = isOwner;
            lblAgreementCreator.Text = Creator.Name;
            lblCreationDateTime.Text = agreementToControl.DateCreated.ToString();
            lblAgreementContent.Text = agreementToControl.Details;
            UpdateAgreedByVisual();
        }

        private void UpdateAgreedByVisual()
        {
            string agreedByString = string.Empty;
            Students.Select(student => student.Name).ToList().ForEach(name => { agreedByString = $"{agreedByString}, {name}"; });
            lblAgreedBy.Text = $"Agreed By: {agreedByString}";

            if (agreementToControl.AgreedBy.Contains(StudentLookingAt))
            {
                btnAgreeTo.Text = "Unagree";
            }
            else
            {
                btnAgreeTo.Text = "Agree";
            }
        }

        public void btnAgreeTo_Click(object sender, EventArgs e)
        {
            if (!isOwner)
            {
                if (!agreementToControl.AgreedBy.Contains(StudentLookingAt))
                {
                    agreementToControl.AddStudentAgreed(StudentLookingAt);
                }
                else
                {
                    agreementToControl.RemoveStudentAgreed(StudentLookingAt);
                }

                Students = agreementToControl.AgreedBy;
                UpdateAgreedByVisual();
            }
        }

        private void btnDeleteAgreement_Click(object sender, EventArgs e)
        {
            if (isOwner)
            {
                if (agreementToControl.AgreedBy.Count <= 0)
                {
                    //Delete Agreement
                    housingManager.GetAllAgreements().Remove(agreementToControl);
                }
                else
                {
                    MessageBox.Show("Cannot delete an agreement that has active agreeing students!");
                }
            }
        }
    }
}
