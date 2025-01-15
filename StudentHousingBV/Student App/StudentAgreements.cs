using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;
using System.Data;

namespace StudentHousingBV.Student_App
{
    public partial class StudentAgreements : Form
    {
        private readonly Student loggedStudent;
        private readonly HousingManager housingManager;
        private List<Agreement> agreements;
        private List<Agreement> allAgreements;
        private List<AgreementControl> controls;

        public StudentAgreements(Student LoggedStudent, HousingManager HousingManager)
        {
            InitializeComponent();
            this.loggedStudent = LoggedStudent;
            this.housingManager = HousingManager;
            this.agreements = [];
            this.allAgreements = housingManager.GetAllAgreements().ToList();
            GetAgreements();
            SetUI_Elements();
        }

        private void SetUI_Elements()
        {
            dtpStartDate.Value = DateTime.Now.AddYears(-1);
            dtpEndDate.Value = DateTime.Now.AddMonths(1);

            GetAllAgreementCreators();
            cbxSelectAgreementCreator.SelectedIndex = 0;
        }

        private void GetAgreements()
        {

            this.agreements = allAgreements.Where(agreement => agreement.AssignedFlat.FlatId == loggedStudent.AssignedFlat.FlatId).ToList();
            LiveFilter(cbxSelectAgreementCreator.SelectedItem as Student, cbUnagreedOnly.Checked, dtpStartDate.Value, dtpEndDate.Value);
            UpdateAgreementVisual();
        }

        private void UpdateAgreementVisual()
        {
            pAgreements.Controls.Clear();
            this.controls = [];
            foreach (Agreement agreement in agreements)
            {
                AgreementControl newControl = new(agreement, loggedStudent);
                controls.Add(newControl);
                newControl.deleteAgreement += AgreementControl_deleteAgreement!;
                newControl.agreeToAgreement += AgreementControl_agreeToAgreement!;
            }
            pAgreements.Controls.AddRange(controls.ToArray());
        }

        private void GetAllAgreementCreators()
        {
            List<Agreement> allAgreements = housingManager.GetAllAgreements().Where(agreement => agreement.AssignedFlat.FlatId == loggedStudent.AssignedFlat.FlatId).ToList();
            List<Student> creators = [];
            List<String> creatorIds = allAgreements.Select(agreement => agreement.Student.StudentId).Distinct().ToList();
            foreach (string creatorId in creatorIds)
            {
                creators.Add(housingManager.GetStudent(creatorId));
            }
            creators.Insert(0, new Student("-1", "All"));

            if (!creators.Any(student => student.StudentId == loggedStudent.StudentId))
            {
                btnShowMine.Enabled = false;
            }
            else
            {
                btnShowMine.Enabled = true;
            }

            cbxSelectAgreementCreator.DataSource = creators;
            cbxSelectAgreementCreator.DisplayMember = "Name";
            cbxSelectAgreementCreator.ValueMember = "StudentId";
        }

        private void AgreementControl_deleteAgreement(object sender, EventArgs e)
        {
            if (sender is AgreementControl selectedControl)
            {
                Agreement selectedAgreement = selectedControl.agreementToControl;
                if (selectedAgreement.AgreedBy.Count <= 0)
                {
                    housingManager.DeleteAgreement(selectedAgreement);
                    allAgreements.Remove(selectedAgreement);
                    GetAgreements();
                }
                else
                { MessageBox.Show("Cannot delete an agreement that has active agreeing students!"); }
            }
        }

        private void AgreementControl_agreeToAgreement(object sender, EventArgs e)
        {
            if (sender is AgreementControl agreementControl)
            {
                if (housingManager.UpdateAgreement(agreementControl.agreementToControl))
                {
                    MessageBox.Show("Agreement accepted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    allAgreements[allAgreements.FindIndex(agreement => agreement.AgreementId == agreementControl.agreementToControl.AgreementId)] = agreementControl.agreementToControl;
                }
            }
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            StudentAddAgreement creationPage = new(housingManager, loggedStudent);
            creationPage.ShowDialog();

            if (creationPage.DialogResult == DialogResult.OK && creationPage.agreement is Agreement fetchedAgreement)
            {
                if (housingManager.AddAgreement(fetchedAgreement))
                {
                    MessageBox.Show("Agreement added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    allAgreements.Add(fetchedAgreement);
                    GetAgreements();
                    GetAllAgreementCreators();
                }
            }
        }

        private void cbxSelectAgreementCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAgreements();
        }

        private void cbUnagreedOnly_CheckedChanged(object sender, EventArgs e)
        {
            GetAgreements();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            GetAgreements();
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                dtpStartDate.Value = dtpEndDate.Value.AddDays(-1);
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            GetAgreements();
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                dtpStartDate.Value = dtpEndDate.Value.AddDays(-1);
            }
        }

        private void LiveFilter(Student? creator, bool unagreedOnly, DateTime startDate, DateTime endDate)
        {
            List<Agreement> filteredAgreements = agreements;

            if (creator is not null && creator.StudentId != "-1")
            {
                filteredAgreements = agreements.Where(agreement => agreement.Student.StudentId == creator.StudentId).ToList();
            }
            if (unagreedOnly)
            {
                filteredAgreements = filteredAgreements.Where(agreement => (!agreement.AgreedBy.Any(student => student.StudentId == loggedStudent.StudentId)) && agreement.Student.StudentId != loggedStudent.StudentId).ToList();
                
            }

            filteredAgreements = filteredAgreements.Where(agreement => agreement.DateCreated >= startDate && agreement.DateCreated <= endDate).ToList();

            this.agreements = filteredAgreements;
        }

        private void btnShowMine_Click(object sender, EventArgs e)
        {
            GetAllAgreementCreators();
            cbUnagreedOnly.Checked = false;
            cbxSelectAgreementCreator.SelectedValue = loggedStudent.StudentId; ;
            GetAgreements();
        }
    }
}
