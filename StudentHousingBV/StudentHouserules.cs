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
            //calling the method for the rules to be displayed here i named it like this but u can change it
            DisplayRules();
        }

        private void DisplayRules()
        {
            //take the rules from whenever we will take it 
            List<string> rules = TakeRulesFromStorage();

            panelRules.Controls.Clear();

            int verticalPosition = 10; 
            foreach (string rule in rules)
            {
                Label ruleLabel = new Label
                //creating labels dynamically for each rules or whatever you also can change the font or whatever is these were already ready so i just copy pasted.
                {
                    Text = rule,               
                    AutoSize = true,            
                    Location = new Point(10, verticalPosition), 
                    Font = new Font("Arial", 18, FontStyle.Regular)
                };

                verticalPosition += 30;

                // Add the label that is created dynamically to the panel
                panelRules.Controls.Add(ruleLabel);
            }
        }

        private List<string> TakeRulesFromStorage()
        {
            //replace this thing with the data source wherever we get them
            return new List<string>
            {
                "1. ",
                "2. ",
                "3. ",
                "4. ",
                "5. ",
                "6. ",
                "7. ",
                "8. ",
                "9. ",
                "10. ",
                "11. ",
                "12.",
                "13.",
                "14"
            };
        }
    }
}

