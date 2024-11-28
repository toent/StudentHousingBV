using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHousingBV.Classes;

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
                dataManager.SaveToStorage();

                // Update the UI to reflect the new list of buildings
                lbCurrentBuildings.Items.Clear();
                foreach (Building building in dataManager.GetBuildings())
                {
                    lbCurrentBuildings.Items.Add($"ID: {building.Id}, Address: {building.Address}");
                }

                // Optionally display the serialized JSON for debugging purposes
                lblJsonDebug.Text = dataManager.GetJsonBuilding();
            }
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            //Load avaiable buildings from storage
            dataManager.LoadFromStorage();

            // Update the UI to show the saved buildings
            lbCurrentBuildings.Items.Clear();
            foreach (Building building in dataManager.GetBuildings())
            {
                lbCurrentBuildings.Items.Add($"ID: {building.Id}, Address: {building.Address}");
            }

            lblJsonDebug.Text = dataManager.GetJsonBuilding();
        }
    }
}
