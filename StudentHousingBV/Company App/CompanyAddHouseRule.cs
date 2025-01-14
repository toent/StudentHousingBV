using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyAddHouseRule : Form
    {
        private readonly HousingManager housingManager;
        private readonly Flat flat;
        private readonly Rule rule;
        private bool isUpdate;

        public CompanyAddHouseRule(HousingManager housingManager, Flat flat)
        {
            InitializeComponent();

            this.housingManager = housingManager;
            this.flat = flat;

            SetupVisuals(null);
        }

        public CompanyAddHouseRule(HousingManager housingManager, Flat flat, Rule rule)
        {
            InitializeComponent();

            tbxDescription.Text = rule.Description;
            this.housingManager = housingManager;
            this.flat = flat;
            this.rule = rule;

            SetupVisuals(rule.Description);
        }

        private void SetupVisuals(string? description)
        {
            if (description == null)
            {
                lblRuleAddPageTitle.Text = "Add A Rule:";
                btnAddUpdate.Text = "Add Rule";
                isUpdate = false;
            }
            else
            {
                lblRuleAddPageTitle.Text = "Update A Rule:";
                tbxDescription.Text = description;
                btnAddUpdate.Text = "Update Rule";
                isUpdate = true;
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxDescription.Text))
            {
                if (isUpdate)
                {
                    rule.Description = tbxDescription.Text;
                    if (housingManager.UpdateRule(rule))
                    {
                        MessageBox.Show("Rule updated successfully.");
                    }
                }
                else
                {
                    if (housingManager.AddRule(new(housingManager.GetNextRuleId(), flat, tbxDescription.Text)))
                    {
                        MessageBox.Show("Rule added successfully.");
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please fill in the description field.");
            }
        }
    }
}
