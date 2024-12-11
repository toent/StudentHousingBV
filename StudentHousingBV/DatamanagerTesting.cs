using System;
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
        DataManager dataManager = new DataManager();
        public DatamanagerTesting()
        {
            InitializeComponent();
        }

        private void btnCreateBuilding_Click(object sender, EventArgs e)
        {
            if (tbBuildingAddress.Text != string.Empty)
            {
                // Create a new building with the current address and the DataManager instance
                Building newBuilding = new Building(tbBuildingAddress.Text, dataManager);

                // Add the new building to the list of buildings
                dataManager.GetBuildings().Add(newBuilding);

                // Save the updated list back to storage
                dataManager.SaveAllData();

                lblJsonDebug.Text = dataManager.GetFilePath();

                // Update the UI to reflect the new list of buildings
                lbCurrentBuildings.Items.Clear();
                cbBuildingIdFlat.Items.Clear();
                cbBuildingIdRule.Items.Clear();
                cbBuildingIdStudent.Items.Clear();
                foreach (Building building in dataManager.GetBuildings())
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
            dataManager.LoadAllData();

            lblJsonDebug.Text = dataManager.GetFilePath();

            // Update the UI to show the saved buildings
            lbCurrentBuildings.Items.Clear();
            cbBuildingIdFlat.Items.Clear();
            cbBuildingIdRule.Items.Clear();
            cbBuildingIdStudent.Items.Clear();
            foreach (Building building in dataManager.GetBuildings())
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
                int buildingId = int.Parse(cbBuildingIdFlat.GetItemText(cbBuildingIdFlat.SelectedItem));
                Flat newFlat = new Flat(buildingId, int.Parse(tbFlatNumber.Text), dataManager);

                dataManager.GetFlats().Add(newFlat);

                dataManager.SaveAllData();

                lbCurrentFlats.Items.Clear();
                foreach (Flat flat in dataManager.GetFlatsFromBuilding(buildingId))
                {
                    lbCurrentFlats.Items.Add($"Building ID: {buildingId} - Flat ID: {flat.FlatId} - Flat Number: {flat.FlatNumber}");
                }
            }

            //lblJsonDebug.Text = dataManager.GetJsonBuilding();
        }

        private void cbBuildingIdStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedBuildingId = int.Parse(cbBuildingIdStudent.GetItemText(cbBuildingIdStudent.SelectedItem));

            cbFlatIdStudent.Items.Clear();
            cbFlatIdStudent.SelectedValue = null;
            cbFlatIdStudent.Text = string.Empty;
            foreach (Flat flat in dataManager.GetFlatsFromBuilding(selectedBuildingId))
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

                Student newStudent = new Student(tbContractId.Text, tbStudentName.Text);
                Flat selectedFlat = dataManager.GetFlat(selectedFlatId);

                selectedFlat.Students.Add(newStudent);

                dataManager.SaveAllData();

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
            foreach (Flat flat in dataManager.GetFlatsFromBuilding(selectedBuildingId))
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
                

                if (cbRuleIsForBuilding.Checked)
                {
                    Classes.Entities.Rule newRule = new Classes.Rule(tbRuleContent.Text, dataManager, selectedBuildingId);

                    dataManager.GetAllRules().Add(newRule);

                    dataManager.SaveAllData();

                    lbCurrentRules.Items.Clear();
                    foreach (Classes.Entities.Rule rule in dataManager.GetRulesFlat(selectedBuildingId))
                    {
                        lbCurrentRules.Items.Add($"Rule ID: {rule.RuleId} - Content: {rule.Description} ");
                    }
                }
                else
                {
                    int selectedFlatId = int.Parse(cbFlatIdRule.GetItemText(cbFlatIdRule.SelectedItem));

                    Classes.Entities.Rule newRule = new Classes.Rule(tbRuleContent.Text, dataManager, selectedBuildingId, selectedFlatId);

                    dataManager.GetAllRules().Add(newRule);

                    dataManager.SaveAllData();

                    lbCurrentRules.Items.Clear();
                    foreach (Classes.Entities.Rule rule in dataManager.GetRulesFlatBuilding(selectedBuildingId, selectedFlatId))
                    {
                        lbCurrentRules.Items.Add($"Rule ID: {rule.RuleId} - Content: {rule.Description} ");
                    }
                }

            }
        }
    }
}
