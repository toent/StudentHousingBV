using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using System.Data;

namespace StudentHousingBV.Custom_Controls
{
    public partial class AgreementControl : UserControl
    {
        public readonly Agreement agreementToControl;
        private readonly Student StudentLookingAt;
        private readonly Student Creator;
        private List<Student> Students = [];
        private readonly bool isOwner;
        public event EventHandler deleteAgreement;

        public AgreementControl(Agreement agreement, Student studentLookingAt)
        {
            InitializeComponent();
            StudentLookingAt = studentLookingAt;
            agreementToControl = agreement;
            Creator = agreement.Student ?? new();
            Students = agreement.AgreedBy;
            isOwner = (Creator == StudentLookingAt);
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
            { deleteAgreement?.Invoke(this, EventArgs.Empty); }
        }
    }
}
