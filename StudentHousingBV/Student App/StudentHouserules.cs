using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Student_App
{
    public partial class StudentHouserules : Form
    {
        private readonly List<Rule> houserules;

        public StudentHouserules(List<Rule> houserules)
        {
            InitializeComponent();
            this.houserules = houserules;
            LoadHouserules();
        }

        private void LoadHouserules()
        {
            pHouserules.Controls.Clear();

            foreach (Rule rule in houserules)
            {
                HouserulesControl houserulesControl = new(rule)
                {
                    Margin = new Padding(0, 10, 0, 10)
                };
                pHouserules.Controls.Add(houserulesControl);
            }
        }
    }
}
