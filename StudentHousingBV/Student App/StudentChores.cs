using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Student_App
{
    public partial class StudentChores : Form
    {
        private readonly HousingManager housingManager;

        public StudentChores(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            LoadChores();
        }

        private void LoadChores()
        {
            pChores.Controls.Clear();

            foreach (Chore chore in housingManager.GetAllChores())
            {
                ChoreControl choreControl = new(chore);
                choreControl.StatusChanged += ChoreControl_StatusChanged;
                choreControl.Margin = new Padding(0, 10, 0, 10);

                pChores.Controls.Add(choreControl);
            }
        }

        private void ChoreControl_StatusChanged(object sender, EventArgs e)
        {
            housingManager.SaveAllData();
            LoadChores();
        }
    }
}
