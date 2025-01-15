using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;
using System.Data;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyAgreements : Form
    {
        private readonly HousingManager housingManager;
        List<Agreement> agreements;
        List<AgreementControl> controls;

        public CompanyAgreements(HousingManager HousingManager)
        {
            InitializeComponent();
            this.housingManager = HousingManager;
            this.agreements = [];
            SetUI_Elements();
        }

        private void SetUI_Elements()
        {
            dtpStartDate.Value = DateTime.Now.AddYears(-1);
            dtpEndDate.Value = DateTime.Now.AddMonths(1);

            ResetCbxSelectedBuilding();

            if (cbxSelectedBuilding.SelectedItem is Building building)
            {
                cbxSelectedBuilding.SelectedIndex = 0;
                cbxSelectedFlat.SelectedIndex = building.Flats.Count > 0 ? 0 : -1;
                cbxSelectedCreator.SelectedIndex = building.Flats.Count > 0 ? 0 : -1;
            }
        }

        private void ResetCbxSelectedBuilding()
        {
            cbxSelectedBuilding.DataSource = housingManager.GetBuildings();
            cbxSelectedBuilding.DisplayMember = "Address";
            cbxSelectedBuilding.ValueMember = "BuildingID";
        }

        private void ResetCbxSelectedFlat()
        {
            Building building = cbxSelectedBuilding.SelectedItem as Building;
            if (building != null)
            {
                cbxSelectedFlat.DataSource = building.Flats;
                cbxSelectedFlat.DisplayMember = "FlatNumber";
                cbxSelectedFlat.ValueMember = "FlatID";
            }
            else
            {
                cbxSelectedFlat.DataSource = null;
            }
        }

        private void ResetCbxSelectedCreator()
        {
            Flat flat = cbxSelectedFlat.SelectedItem as Flat;
            List<Student> creators = [];
            if (flat != null)
            {
                creators = housingManager.GetAllAgreements().Where(agreement => agreement.AssignedFlat.FlatId == flat.FlatId).Select(agreement => agreement.Student).Distinct().ToList();
                creators.Insert(0, new Student("-1", "All"));

                cbxSelectedCreator.DataSource = creators;
                cbxSelectedCreator.DisplayMember = "Name";
                cbxSelectedCreator.ValueMember = "StudentId";
            }
            else
            {
                cbxSelectedCreator.DataSource = null;
            }

            LoadAllAgreements();

        }

        private void LoadAllAgreements()
        {
            Flat flat = cbxSelectedFlat.SelectedItem as Flat;
            if (flat != null)
            {
                this.agreements = housingManager.GetAllAgreements().Where(agreement => agreement.AssignedFlat.FlatId == flat.FlatId).ToList();
            }
            else
            {
                this.agreements = [];
            }
        }

        private void LiveFilter(Student creator, DateTime StartDate, DateTime EndDate)
        {
            List<Agreement> filteredAgreements = this.agreements;

            if (creator is not null && creator.StudentId != "-1")
            {
                filteredAgreements = filteredAgreements.Where(agreement => agreement.Student.StudentId == creator.StudentId).ToList();
            }

            filteredAgreements = filteredAgreements.Where(agreement => agreement.DateCreated >= StartDate && agreement.DateCreated <= EndDate).ToList();

            this.agreements = filteredAgreements;

            LoadAgreementControls();
        }


        private void cbxSelectedBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCbxSelectedFlat();
        }

        private void cbxSelectedFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCbxSelectedCreator();
        }

        private void cbxSelectedCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllAgreements();
            LiveFilter(cbxSelectedCreator.SelectedItem as Student, dtpStartDate.Value, dtpEndDate.Value);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                dtpStartDate.Value = dtpEndDate.Value.AddDays(-1);
            }

            if (cbxSelectedCreator.SelectedItem != null)
            {
                LoadAllAgreements();
                LiveFilter(cbxSelectedCreator.SelectedItem as Student, dtpStartDate.Value, dtpEndDate.Value);
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                dtpStartDate.Value = dtpEndDate.Value.AddDays(-1);
            }

            if (cbxSelectedCreator.SelectedItem != null)
            {
                LoadAllAgreements();
                LiveFilter(cbxSelectedCreator.SelectedItem as Student, dtpStartDate.Value, dtpEndDate.Value);
            }
        }

        private void LoadAgreementControls()
        {
            pAgreements.Controls.Clear();
            controls = [];

            foreach (Agreement agreement in agreements)
            {
                AgreementControl control = new(agreement, null);
                controls.Add(control);
                pAgreements.Controls.Add(control);
            }
        }
    }
}
