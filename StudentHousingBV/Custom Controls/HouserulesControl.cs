
using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Custom_Controls
{
    public partial class HouserulesControl : UserControl
    {
        private readonly bool? studentViewing;
        public readonly Rule rule;
        public EventHandler modifyRule;
        public EventHandler deleteRule;

        public HouserulesControl(Rule rule)
        {
            InitializeComponent();
            this.rule = rule;
            lblDescription.Text = rule.Description;
            studentViewing = null;
            SetButtonVisibility();
        }

        public HouserulesControl(Rule rule, bool? isStudent)
        {
            InitializeComponent();
            this.rule = rule;
            lblDescription.Text = rule.Description;
            studentViewing = isStudent;
            SetButtonVisibility();
        }

        private void SetButtonVisibility()
        {
            if (studentViewing == true || studentViewing == null)
            {
                btnModify.Visible = false;
                btnDelete.Visible = false;
                lblDescription.Width = 1019;
            }
            else if (studentViewing == false && studentViewing != null)
            {
                btnModify.Visible = true;
                btnDelete.Visible = true;
                lblDescription.Width = 750;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modifyRule?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRule?.Invoke(this, EventArgs.Empty);
        }
    }
}
