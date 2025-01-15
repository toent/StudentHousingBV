using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Student_App
{
    public partial class StudentGroceries : Form
    {
        private readonly HousingManager housingManager;
        private readonly Student student;
        private List<Grocery> groceries;

        public StudentGroceries(HousingManager housingManager, Student student)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            this.student = student;
            LoadGroceries();
        }

        private void LoadGroceries()
        {
            groceries = housingManager.GetGroceryByFlat(student.AssignedFlat.FlatId).ToList(); 

            if (flowLayoutPanelGrocery != null && groceries != null)
            {
                // Clear existing controls to avoid duplicates
                flowLayoutPanelGrocery.Controls.Clear();

                foreach (Grocery grocery in groceries)
                {
                    GroceryControl groceryControl = new();
                    groceryControl.SetGrocery(grocery); 
                    groceryControl.Margin = new Padding(5);
                    MessageBox.Show(groceries.Count().ToString());

                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanelGrocery.Controls.Add(groceryControl);
                }
            }
        }

        private void btnAddGrocery_Click(object sender, EventArgs e)
        {

            StudentAddGrocery studentAddGrocery = new StudentAddGrocery(housingManager, student);

            studentAddGrocery.NewGrocery += (sender, grocery) =>
            {
                housingManager.AddGrocery(grocery);
                housingManager.GetAllGroceries();
            };

            studentAddGrocery.ShowDialog();

            if (studentAddGrocery.DialogResult == DialogResult.OK)
            {
                LoadGroceries();
            }
        }
    }
}
