using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Student_App
{
    public partial class StudentGroceries : Form
    {
        private readonly HousingManager housingManager;
        private readonly List<Grocery> groceries;
        private readonly Student student;

        public StudentGroceries(HousingManager housingManager, Student student)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            this.student = student;
            groceries = new List<Grocery>(); // Correctly initialize the list
            UpdateGroceryControl();
        }


        private void btnAddGrocery_Click(object sender, EventArgs e)
        {

            StudentAddGrocery studentAddGrocery = new StudentAddGrocery(groceries, housingManager, student);
            studentAddGrocery.ShowDialog();
            if (studentAddGrocery.DialogResult == DialogResult.OK)
            {
                UpdateGroceryControl();
            }
        }

        private void UpdateGroceryControl()
        {
            if (flowLayoutPanelGrocery != null)
            {
                // Clear existing controls to avoid duplicates
                flowLayoutPanelGrocery.Controls.Clear();

                foreach (Grocery grocery in groceries)
                {
                    GroceryControl groceryControl = new();
                    groceryControl.SetGrocery(grocery); // Pass Grocery object to the control
                    groceryControl.Margin = new Padding(5);
                    MessageBox.Show(groceries.Count().ToString());

                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanelGrocery.Controls.Add(groceryControl);
                }
            }
        }


    }
}
