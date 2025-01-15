using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using System.Data;

namespace StudentHousingBV.Custom_Controls
{
    public partial class AgreementControl : UserControl
    {
        public readonly Agreement agreementToControl;
        private readonly Student? StudentLookingAt;
        private readonly Student Creator;
        private List<Student> Students = [];
        private readonly bool isOwner;
        public event EventHandler deleteAgreement;
        public event EventHandler agreeToAgreement;

        public AgreementControl(Agreement agreement, Student? studentLookingAt)
        {
            InitializeComponent();
            StudentLookingAt = studentLookingAt;
            agreementToControl = agreement;
            Creator = agreement.Student ?? new();
            Students = agreement.AgreedBy;
            if(StudentLookingAt != null)
            { isOwner = (Creator.StudentId == StudentLookingAt.StudentId); }
            else
            { isOwner = false; }
            SetupVisuals();
        }

        private void SetupVisuals()
        {
            if (StudentLookingAt != null)
            {
                btnAgreeTo.Visible = !isOwner;
                btnAgreeTo.Enabled = !isOwner;
            }
            else
            {
                btnAgreeTo.Visible = isOwner;
                btnAgreeTo.Enabled = isOwner;
            }
            btnDeleteAgreement.Visible = isOwner;
            btnDeleteAgreement.Enabled = isOwner;
            lblAgreementTitle.Text = agreementToControl.Title;
            lblAgreementCreator.Text = Creator.Name;
            lblCreationDateTime.Text = agreementToControl.DateCreated.ToString();
            lblAgreementContent.Text = agreementToControl.Details;
            UpdateAgreedByVisual();
        }

        private void UpdateAgreedByVisual()
        {
            string agreedByString = string.Empty;
            agreedByString = string.Join(", ", Students.Select(student => student.Name));
            lblAgreedBy.Text = $"Agreed By: {agreedByString}";

            if (agreementToControl.AgreedBy.Any(student => student.StudentId == StudentLookingAt.StudentId))
            {
                btnAgreeTo.Text = "Unagree";
            }
            else
            {
                btnAgreeTo.Text = "Agree";
            }

            AgreeToAgreement(this, EventArgs.Empty);
        }

        public void btnAgreeTo_Click(object sender, EventArgs e)
        {
            if (!isOwner)
            {
                if (!agreementToControl.AgreedBy.Any(student => student.StudentId == StudentLookingAt.StudentId))
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
            { deleteAgreement?.Invoke(this, EventArgs.Empty); }
        }
        
        private void AgreeToAgreement(object sender, EventArgs e)
        {
            if (!isOwner)
            { agreeToAgreement?.Invoke(this, EventArgs.Empty); }
        }
    }
}
