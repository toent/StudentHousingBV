using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV
{
    public partial class StudentHouserules : Form
    { 
        private readonly HousingManager housingManager;

        public StudentHouserules(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
        }

        private void StudentHouserules_Load(object sender, EventArgs e)
        {
            //DisplayRules();
        }
/*
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
        new Rule("No loud noises after 10 PM.", dataManager),
        new Rule("Keep common areas clean.", dataManager),
        new Rule("Guests must leave by midnight.", dataManager),
        new Rule("Report maintenance issues promptly.", dataManager),
        new Rule("No smoking in the building.", dataManager),
        new Rule("Respect others' privacy.", dataManager),
        new Rule("Pay rent by the 5th of each month.", dataManager),
        new Rule("Use of illegal substances is prohibited.", dataManager),
        new Rule("No pets without prior approval.", dataManager),
        new Rule("Keep emergency exits clear.", dataManager),
        new Rule("No tampering with fire alarms.", dataManager),
        new Rule("Utilities must be used responsibly.", dataManager),
        new Rule("No unauthorized room changes.", dataManager),
        new Rule("Follow all posted safety guidelines.", dataManager)
            };
        }*/
    }
}

