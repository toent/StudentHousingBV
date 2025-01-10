using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.Student_App
{
    public partial class StudentAgreements : Form
    {
        private readonly Student loggedStudent;
        private readonly HousingManager housingManager;
        List<Agreement> agreements;
        List<AgreementControl> controls;

        public StudentAgreements(Student LoggedStudent, HousingManager HousingManager)
        {
            InitializeComponent();
            this.loggedStudent = LoggedStudent;
            this.housingManager = HousingManager;
            this.agreements = new List<Agreement>();
            this.controls = new List<AgreementControl>();
            GetAgreements();
        }

        private void GetAgreements()
        {
            this.agreements = housingManager.GetAllAgreements().Where(agreement => agreement.AssignedFlat == loggedStudent.AssignedFlat).ToList();
            foreach (Agreement agreement in agreements)
            {
                AgreementControl newControl = new AgreementControl(agreement, loggedStudent);
                controls.Add(newControl);
                newControl.deleteAgreement += AgreementControl_deleteAgreement!;
            }
            pAgreements.Controls.AddRange(controls.ToArray());
        }

        private void AgreementControl_deleteAgreement(object sender, EventArgs e)
        {
            if (sender is AgreementControl selectedControl)
            {
                Agreement selectedAgreement = selectedControl.agreementToControl;
                if (selectedAgreement.AgreedBy.Count() <= 0)
                { 
                    housingManager.GetAllAgreements().Remove(selectedAgreement);
                    GetAgreements();
                }
                else
                { MessageBox.Show("Cannot delete an agreement that has active agreeing students!"); }
            }
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            StudentAddAgreement creationPage = new StudentAddAgreement(housingManager, loggedStudent);
            creationPage.ShowDialog();
            if (creationPage.DialogResult == DialogResult.OK && creationPage.agreement is Agreement fetchedAgreement)
            {
                this.loggedStudent.AssignedFlat.Agreements.Add(fetchedAgreement);
                this.housingManager.SaveAllData();
                GetAgreements();
            }
        }
    }
}
