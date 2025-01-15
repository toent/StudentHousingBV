using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyComplaints : Form
    {
        private readonly HousingManager housingManager;
        private List<Complaint> complaints;

        public CompanyComplaints(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            InitializeForm();
        }

        private void InitializeForm()
        {
            checkBoxViewAll.Checked = true;
            LoadComplaints();
            PopulateComboBoxes();
            SetupEventHandlers();
            UpdateFilterVisibility();
        }

        private void SetupEventHandlers()
        {
            checkBoxViewAll.CheckedChanged += checkBoxViewAll_CheckedChanged;
            cbBuilding.SelectedIndexChanged += cbBuilding_SelectedIndexChanged;
            cbFlat.SelectedIndexChanged += cbFlat_SelectedIndexChanged;
        }

        private void LoadComplaints()
        {
            complaints = housingManager.GetAllComplaints();
            DisplayComplaintControls();
        }

        private void DisplayComplaintControls()
        {
            pComplaints.Controls.Clear(); // Clear existing controls
            foreach (Complaint complaint in complaints)
            {
                ComplaintControl complaintControl = new ComplaintControl(complaint); // Assuming ComplaintControl constructor takes Complaint object
                pComplaints.Controls.Add(complaintControl);
            }
        }

        private void PopulateComboBoxes()
        {
            cbBuilding.DataSource = housingManager.GetBuildings();
            UpdateFlatComboBox();
        }

        private void UpdateFlatComboBox()
        {
            if (cbBuilding.SelectedItem is Building building)
            {
                cbFlat.DataSource = building.Flats;
            }
        }

        private void UpdateFilterVisibility()
        {
            cbBuilding.Enabled = !checkBoxViewAll.Checked;
            cbFlat.Enabled = !checkBoxViewAll.Checked && cbBuilding.SelectedItem is Building;
        }

        private void checkBoxViewAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterVisibility();

            if (checkBoxViewAll.Checked)
            {
                LoadComplaints();
            }
            else
            {
                LoadComplaintsByFlat();
            }
        }


        private void cbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFlatComboBox();
            LoadComplaintsByFlat();
        }

        private void cbFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComplaintsByFlat();
        }

        private void LoadComplaintsByFlat()
        {
            if (!checkBoxViewAll.Checked && cbFlat.SelectedItem is Flat flat)
            {
                complaints = housingManager.GetComplaints(flat);
                DisplayComplaintControls();
            }
        }
    }
}
