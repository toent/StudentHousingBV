using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class StudentHouserules : Form
    {
        public StudentHouserules()
        {
            InitializeComponent();
        }

        private void StudentHouserules_Load(object sender, EventArgs e)
        {
            DisplayRules();
        }

        //displaying rules dynamically on the form
        private void DisplayRules()
        {
            List<Rule> rules = TakeRulesFromStorage();

            panelRules.Controls.Clear(); //everytime i refresh the page new labels will be added without removing the old ones (CHATGPT generated)

            int verticalPosition = 10;
            foreach (Rule rule in rules) //go through each rule and create a new label 
            {
                Label ruleLabel = new Label
                {
                    Text = $"{rule.Id}. {rule.Description} (Created on: {rule.CreateTime:yyyy-MM-dd})",

                    //ignore these are just to make the text fit in the label so we dont have problems
                    AutoSize = true,
                    Location = new Point(10, verticalPosition),
                    Font = new Font("Arial", 12, FontStyle.Regular)
                };

                verticalPosition += 30;

                panelRules.Controls.Add(ruleLabel);
            }
        }

        //simulates retrieving rules from database or whatever we gonna use
        private List<Rule> TakeRulesFromStorage()
        {

            return new List<Rule>
        {
        new Rule("No loud noises after 10 PM."),
        new Rule("Keep common areas clean."),
        new Rule("Guests must leave by midnight."),
        new Rule("Report maintenance issues promptly."),
        new Rule("No smoking in the building."),
        new Rule("Respect others' privacy."),
        new Rule("Pay rent by the 5th of each month."),
        new Rule("Use of illegal substances is prohibited."),
        new Rule("No pets without prior approval."),
        new Rule("Keep emergency exits clear."),
        new Rule("No tampering with fire alarms."),
        new Rule("Utilities must be used responsibly."),
        new Rule("No unauthorized room changes."),
        new Rule("Follow all posted safety guidelines.")
            };
        }
    }
}

