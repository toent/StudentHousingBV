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

        private void loadRules(Flat flat)
        {
            if(flat != null)
            {
                flpRules.Controls.Clear();
                foreach (Rule rule in flat.Rules)
                {
                    HouserulesControl ruleControl = new HouserulesControl(rule, false);
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
            CompanyAddHouseRule housingRuleWindow = new CompanyAddHouseRule(housingManager, cbxFlat.SelectedItem as Flat);
            housingRuleWindow.ShowDialog();
            if(housingRuleWindow.DialogResult == DialogResult.OK)
            {
                loadRules(cbxFlat.SelectedItem as Flat);
            }

        }

        private void HouserulesControl_btnModify(object sender, EventArgs e)
        {
            if(sender.GetType() == typeof(HouserulesControl))
            {
                HouserulesControl ruleControl = sender as HouserulesControl;
                CompanyAddHouseRule housingRuleWindow = new CompanyAddHouseRule(housingManager, cbxFlat.SelectedItem as Flat, ruleControl.rule);

                housingRuleWindow.ShowDialog();

                if (housingRuleWindow.DialogResult == DialogResult.OK)
                {
                    loadRules(cbxFlat.SelectedItem as Flat);
                }
            }
        }

        private void HouserulesControl_btnDelete(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(HouserulesControl))
            {
                HouserulesControl ruleControl = sender as HouserulesControl;
                Flat flat = cbxFlat.SelectedItem as Flat;
                flat.Rules.Remove(ruleControl.rule);
                housingManager.SaveAllData();
                loadRules(flat);
            }
        }

        private void cbxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupFlatbox(cbxBuilding.SelectedItem as Building);
        }

        private void cbxFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRules(cbxFlat.SelectedItem as Flat);
        }
    }
}