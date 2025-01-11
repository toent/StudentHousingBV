using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (tbxDescription.Text != String.Empty)
            {
                if (isUpdate)
                {
                    rule.Description = tbxDescription.Text;
                }
                else
                {
                    Classes.Entities.Rule newRule = new Classes.Entities.Rule(housingManager.GetNextRuleId(), flat, tbxDescription.Text);
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
