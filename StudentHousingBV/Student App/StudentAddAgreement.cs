using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
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
    public partial class StudentAddAgreement : Form
    {
        internal Agreement agreement;
        private HousingManager housingManager;
        private Student studentLookingAt;

        public StudentAddAgreement(HousingManager housingManager, Student studentLookingAt)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            this.studentLookingAt = studentLookingAt;
        }

        private void btnCreateAgreement_Click(object sender, EventArgs e)
        {
            if (tbxAgreementTitle.Text != string.Empty && tbxAgreementContent.Text != string.Empty)
            {
                agreement = new (housingManager.GetNextAgreementId(), 
                    tbxAgreementTitle.Text, tbxAgreementContent.Text, new List<Student>(), 
                    studentLookingAt, studentLookingAt.AssignedFlat);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
