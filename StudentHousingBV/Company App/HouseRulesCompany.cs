using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV
{
    public partial class HouseRulesCompany : Form
    {
        private int ruleCount = 0;
        private readonly List<Control> ruleControls = [];
        private readonly HousingManager housingManager;

        public HouseRulesCompany(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            UpdateComboBox();
            panelRules.AutoScroll = true;
            panelRules.BorderStyle = BorderStyle.FixedSingle;
            btnCreate.Click += (s, e) => CreateRule();
        }

        private void UpdateComboBox()
        {
            cbFlat.DataSource = housingManager.GetFlats();
        }

        private void CreateRule()
        {
            ruleCount++;
            var lblRule = CreateLabel();
            var btnPanel = CreateButtonPanel(lblRule);

            panelRules.Controls.Add(lblRule);
            panelRules.Controls.Add(btnPanel);

            ruleControls.Add(lblRule);
            ruleControls.Add(btnPanel);

            ReorganizeRules();
        }

        private Label CreateLabel()
        {
            return new Label
            {
                Text = $"Rule {ruleCount}: Input and modify your rules",
                AutoSize = true,
                Location = new Point(10, 10 + ruleCount * 60)
            };
        }

        private Panel CreateButtonPanel(Label lblRule)
        {
            var btnPanel = new Panel { Location = new Point(lblRule.Right + 10, lblRule.Top), Size = new Size(160, 30) };

            var btnModify = new Button { Text = "Modify", Size = new Size(75, 30) };
            btnModify.Click += (s, e) => ModifyRule(lblRule);
            btnPanel.Controls.Add(btnModify);

            var btnRemove = new Button { Text = "Remove", Size = new Size(75, 30) };
            btnRemove.Click += (s, e) => RemoveRule(lblRule, btnPanel);
            btnPanel.Controls.Add(btnRemove);

            btnModify.Location = new Point(0, 0);
            btnRemove.Location = new Point(btnModify.Width, 0);

            return btnPanel;
        }

        private void ModifyRule(Label lblRule)
        {
            string input = Prompt.ShowDialog("Modify Rule:", lblRule.Text);
            if (!string.IsNullOrEmpty(input)) lblRule.Text = input;
            ReorganizeRules();
        }

        private void RemoveRule(Label lblRule, Panel btnPanel)
        {
            panelRules.Controls.Remove(lblRule);
            panelRules.Controls.Remove(btnPanel);
            ruleControls.Remove(lblRule);
            ruleControls.Remove(btnPanel);
            ReorganizeRules();
        }

        private void ReorganizeRules()
        {
            int yPos = 10;
            foreach (Control ctrl in ruleControls)
            {
                ctrl.Location = new Point(10, yPos);
                yPos += ctrl.Height + 10;
            }
            panelRules.AutoScrollMinSize = new Size(panelRules.Width, yPos);
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            var prompt = new Form
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            var textBox = new TextBox { Left = 10, Top = 50, Width = 260 };
            var confirmation = new Button { Text = "OK", Left = 200, Width = 70, Top = 80, DialogResult = DialogResult.OK };

            confirmation.Click += (s, e) => prompt.Close();

            prompt.Controls.Add(new Label { Left = 10, Top = 20, Text = text, Width = 260 });
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}