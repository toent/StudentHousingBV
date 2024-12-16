using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Custom_Controls
{
    public partial class HouserulesControl : UserControl
    {
        public HouserulesControl(Rule rule)
        {
            InitializeComponent();
            lblDescription.Text = rule.Description;
        }
    }
}
