using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyComplaints : Form
    {
        private readonly HousingManager housingManager;

        public CompanyComplaints(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            LoadBuildings();
            if (cbSelectedBuilding.Items.Count > 0)
            {
                cbSelectedBuilding.SelectedIndex = 0;
            }
            if (cbSelectedBuilding.SelectedItem is Building building)
            {
                LoadFlats(building);
                if (cbSelectedFlat.Items.Count > 0)
                {
                    cbSelectedFlat.SelectedIndex = 0;
                }
            }
            if (cbSelectedFlat.SelectedItem is Flat flat)
            {
                LoadComplaints(flat);
            }
        }

        private void LoadBuildings()
        {
            List<Building> buildings = housingManager.GetBuildings();
            cbSelectedBuilding.Items.Clear();
            cbSelectedBuilding.Items.AddRange([.. buildings]);
        }

        private void LoadFlats(Building building)
        {
            cbSelectedFlat.Items.Clear();
            cbSelectedFlat.Items.AddRange([.. building.Flats]);
        }

        private void LoadComplaints(Flat flat)
        {
            List<Complaint> complaints = housingManager.GetComplaints(flat);
            pComplaints.Controls.Clear();
            foreach (Complaint complaint in complaints)
            {
                ComplaintControl complaintControl = new(complaint);
                pComplaints.Controls.Add(complaintControl);
            }
        }

        private void cbSelectedBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectedBuilding.SelectedItem is Building building)
            {
                LoadFlats(building);
                if (cbSelectedFlat.Items.Count > 0)
                {
                    cbSelectedFlat.SelectedIndex = 0;
                }
            }
        }

        private void cbSelectedFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectedFlat.SelectedItem is Flat flat)
            {
                LoadComplaints(flat);
            }
        }
    }
}
