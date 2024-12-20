﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV
{
    public partial class DatamanagerTesting : Form
    {
        readonly DataManager dataManager = new();

        readonly HousingManager housingManager = new();

        public DatamanagerTesting()
        {
            InitializeComponent();
        }

        private void btnCreateBuilding_Click(object sender, EventArgs e)
        {
            if (tbBuildingAddress.Text != string.Empty)
            {
                // Create a new building with the current address and the DataManager instance
                Building newBuilding = new(housingManager.GetNextBuildingId(), tbBuildingAddress.Text);

                // Add the new building to the list of buildings
                housingManager.Buildings.Add(newBuilding);

                // Save the updated list back to storage
                housingManager.SaveAllData();

                lblJsonDebug.Text = dataManager.GetFilePath();

                // Update the UI to reflect the new list of buildings
                lbCurrentBuildings.Items.Clear();
                cbBuildingIdFlat.Items.Clear();
                cbBuildingIdRule.Items.Clear();
                cbBuildingIdStudent.Items.Clear();
                foreach (Building building in housingManager.Buildings)
                {
                    lbCurrentBuildings.Items.Add($"ID: {building.BuildingId}, Address: {building.Address}");
                    cbBuildingIdFlat.Items.Add(building.BuildingId);
                    cbBuildingIdRule.Items.Add(building.BuildingId);
                    cbBuildingIdStudent.Items.Add(building.BuildingId);
                }

                // Optionally display the serialized JSON for debugging purposes
                //lblJsonDebug.Text = dataManager.GetJsonBuilding();
            }
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            //Load avaiable buildings from storage
            housingManager.LoadAllData();

            lblJsonDebug.Text = dataManager.GetFilePath();

            // Update the UI to show the saved buildings
            lbCurrentBuildings.Items.Clear();
            cbBuildingIdFlat.Items.Clear();
            cbBuildingIdRule.Items.Clear();
            cbBuildingIdStudent.Items.Clear();
            foreach (Building building in housingManager.Buildings)
            {
                lbCurrentBuildings.Items.Add($"Building ID: {building.BuildingId} - Address: {building.Address}");
                cbBuildingIdFlat.Items.Add(building.BuildingId);
                cbBuildingIdRule.Items.Add(building.BuildingId);
                cbBuildingIdStudent.Items.Add(building.BuildingId);
            }

            //lblJsonDebug.Text = dataManager.GetJsonBuilding();
        }

        private void btnCreateFlat_Click(object sender, EventArgs e)
        {
            if (tbFlatNumber.Text != string.Empty)
            {
                int selectedBuildingId = int.Parse(cbBuildingIdFlat.GetItemText(cbBuildingIdFlat.SelectedItem));
                Building selectedBuilding = housingManager.Buildings.FirstOrDefault(building => building.BuildingId == selectedBuildingId);
                Flat newFlat = new(housingManager.GetNextFlatId(), selectedBuilding);

                housingManager.GetAllFlats().Add(newFlat);

                housingManager.SaveAllData();

                lbCurrentFlats.Items.Clear();
                foreach (Flat flat in selectedBuilding.Flats)
                {
                    lbCurrentFlats.Items.Add($"Building ID: {flat.AssignedBuilding.BuildingId} - Flat ID: {flat.FlatId} - Flat Number: {flat.FlatNumber}");
                }
            }

            //lblJsonDebug.Text = dataManager.GetJsonBuilding();
        }

        private void cbBuildingIdStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedBuildingId = int.Parse(cbBuildingIdStudent.GetItemText(cbBuildingIdStudent.SelectedItem));
            Building selectedBuilding = housingManager.Buildings.FirstOrDefault(Building => Building.BuildingId == selectedBuildingId);

            cbFlatIdStudent.Items.Clear();
            cbFlatIdStudent.SelectedValue = null;
            cbFlatIdStudent.Text = string.Empty;
            foreach (Flat flat in selectedBuilding.Flats)
            {
                cbFlatIdStudent.Items.Add(flat.FlatId);
            }
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {

            if (tbContractId.Text != string.Empty && tbStudentName.Text != string.Empty &&
                cbBuildingIdStudent.GetItemText(cbBuildingIdStudent.SelectedItem) != null &&
                cbFlatIdStudent.GetItemText(cbFlatIdStudent.SelectedItem) != null)
            {
                int selectedBuildingId = int.Parse(cbBuildingIdStudent.GetItemText(cbBuildingIdStudent.SelectedItem));
                int selectedFlatId = int.Parse(cbFlatIdStudent.GetItemText(cbFlatIdStudent.SelectedItem));

                Flat selectedFlat = housingManager.Buildings.FirstOrDefault(building => building.BuildingId == selectedBuildingId)
                    .Flats.FirstOrDefault(flat => flat.FlatId == selectedFlatId);

                Student newStudent = new(tbContractId.Text, tbStudentName.Text, selectedFlat);

                housingManager.GetStudents().Add(newStudent);

                housingManager.SaveAllData();

                lbCurrentStudents.Items.Clear();
                foreach (Student student in selectedFlat.Students)
                {
                    lbCurrentStudents.Items.Add($"Contract ID: {student.StudentId} - Name: {student.Name}");
                }

            }
        }

        private void cbBuildingIdRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedBuildingId = int.Parse(cbBuildingIdRule.GetItemText(cbBuildingIdRule.SelectedItem));

            cbFlatIdRule.Items.Clear();
            cbFlatIdRule.SelectedValue = null;
            cbFlatIdRule.Text = string.Empty;
            foreach (Flat flat in housingManager.Buildings.FirstOrDefault(building => building.BuildingId == selectedBuildingId).Flats)
            {
                cbFlatIdRule.Items.Add(flat.FlatId);
            }
        }

        private void btnCreateRule_Click(object sender, EventArgs e)
        {
            if (tbRuleContent.Text != string.Empty &&
            cbBuildingIdStudent.GetItemText(cbBuildingIdStudent.SelectedItem) != null &&
            (cbFlatIdRule.GetItemText(cbFlatIdRule.SelectedItem) != null || cbRuleIsForBuilding.Checked))
            {
                int selectedBuildingId = int.Parse(cbBuildingIdStudent.GetItemText(cbBuildingIdRule.SelectedItem));
                Building selectedBuilding = housingManager.Buildings.FirstOrDefault(building =>building.BuildingId == selectedBuildingId);

                if (cbRuleIsForBuilding.Checked)
                {
                    Classes.Entities.Rule newRule = new(housingManager.GetNextRuleId(), selectedBuilding, tbRuleContent.Text);

                    housingManager.GetAllRules().Add(newRule);

                    housingManager.SaveAllData();

                    lbCurrentRules.Items.Clear();
                    foreach (Classes.Entities.Rule rule in selectedBuilding.Rules)
                    {
                        lbCurrentRules.Items.Add($"Rule ID: {rule.RuleId} - Content: {rule.Description} ");
                    }
                }
                else
                {
                    int selectedFlatId = int.Parse(cbFlatIdRule.GetItemText(cbFlatIdRule.SelectedItem));
                    Flat selectedFlat = selectedBuilding.Flats.FirstOrDefault(flat => flat.FlatId == selectedFlatId);

                    Classes.Entities.Rule newRule = new(housingManager.GetNextRuleId(), selectedFlat, tbRuleContent.Text);

                    housingManager.GetAllRules().Add(newRule);

                    housingManager.SaveAllData();

                    lbCurrentRules.Items.Clear();
                    List<Classes.Entities.Rule> combinedRuleList = [.. selectedBuilding.Rules, .. selectedFlat.Rules];
                    foreach (Classes.Entities.Rule rule in combinedRuleList)
                    {
                        lbCurrentRules.Items.Add($"Rule ID: {rule.RuleId} - Content: {rule.Description} ");
                    }
                }

            }
        }
    }
}
