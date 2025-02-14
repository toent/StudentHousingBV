﻿using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyAddHouseRule : Form
    {
        private readonly HousingManager housingManager;
        private readonly Flat flat;
        private readonly Classes.Entities.Rule rule;
        private bool isUpdate;

        public CompanyAddHouseRule(HousingManager housingManager, Flat flat)
        {
            InitializeComponent();

            this.housingManager = housingManager;
            this.flat = flat;
            StartPosition = FormStartPosition.CenterScreen;

            SetupVisuals(null);
        }

        public CompanyAddHouseRule(HousingManager housingManager, Flat flat, Classes.Entities.Rule rule)
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
            if (tbxDescription.Text != string.Empty)
            {
                if (isUpdate)
                {
                    rule.Description = tbxDescription.Text;
                }
                else
                {
                    Classes.Entities.Rule newRule = new(housingManager.GetNextRuleId(), flat, tbxDescription.Text);
                    flat.Rules.Add(newRule);
                }
                housingManager.SaveAllData();
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
