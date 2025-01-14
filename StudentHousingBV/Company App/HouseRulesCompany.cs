using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Company_App;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV
{
    public partial class HouseRulesCompany : Form
    {
        private readonly HousingManager housingManager;

        public HouseRulesCompany(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            SetupBuildingBox();
        }

        private void SetupBuildingBox()
        {
            cbxBuilding.DataSource = housingManager.GetBuildings();
            cbxBuilding.DisplayMember = "Address";
            cbxBuilding.ValueMember = "BuildingId";
            Building selectedBuilding = cbxBuilding.SelectedItem as Building;
            SetupFlatbox(selectedBuilding);
        }

        private void SetupFlatbox(Building building)
        {
            if (building.Flats.Count > 0)
            {
                cbxFlat.DataSource = building.Flats;
            }
            else
            {
                cbxFlat.DataSource = null;
            }
        }

        private void LoadRules(Flat flat)
        {
            if (flat != null)
            {
                flpRules.Controls.Clear();
                foreach (Rule rule in flat.Rules)
                {
                    HouserulesControl ruleControl = new(rule, false);
                    ruleControl.modifyRule += HouserulesControl_btnModify!;
                    ruleControl.deleteRule += HouserulesControl_btnDelete!;
                    flpRules.Controls.Add(ruleControl);
                }
            }
            else
            {
                flpRules.Controls.Clear();
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CompanyAddHouseRule housingRuleWindow = new(housingManager, cbxFlat.SelectedItem as Flat);
            housingRuleWindow.ShowDialog();
            if (housingRuleWindow.DialogResult == DialogResult.OK)
            {
                LoadRules(cbxFlat.SelectedItem as Flat);
            }

        }

        private void HouserulesControl_btnModify(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(HouserulesControl))
            {
                HouserulesControl ruleControl = sender as HouserulesControl;
                CompanyAddHouseRule housingRuleWindow = new(housingManager, cbxFlat.SelectedItem as Flat, ruleControl.rule);

                housingRuleWindow.ShowDialog();

                if (housingRuleWindow.DialogResult == DialogResult.OK)
                {
                    LoadRules(cbxFlat.SelectedItem as Flat);
                }
            }
        }

        private void HouserulesControl_btnDelete(object sender, EventArgs e)
        {
            if (sender is HouserulesControl ruleControl && cbxFlat.SelectedItem is Flat flat)
            {
                if (housingManager.RemoveRule(ruleControl.rule))
                {
                    LoadRules(flat);
                    MessageBox.Show("Rule deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupFlatbox(cbxBuilding.SelectedItem as Building);
        }

        private void cbxFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRules(cbxFlat.SelectedItem as Flat);
        }
    }
}