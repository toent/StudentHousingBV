using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Student_App
{
    public partial class StudentGroceries : Form
    {
        private readonly HousingManager housingManager;
        private readonly List<Grocery> groceries;
        public StudentGroceries(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
        }

        private void btnAddGrocery_Click(object sender, EventArgs e)
        {
            //https://cdn.apartmenttherapy.info/image/upload/v1559186495/k/archive/2d4ea32ed14a1f75cf1b454748dfa99cd4a1fa62.jpg

            string imgPath = tBoxImgPath.Text;
            string paymentURL = tBoxPaymentURL.Text;

            if (imgPath != string.Empty && paymentURL != string.Empty && housingManager.LoggedStudent is Student student)
            {
                Grocery grocery = new(housingManager.LoggedStudent, imgPath, paymentURL, housingManager, student.AssignedFlat!);
                groceries.Add(grocery);
                MessageBox.Show("Grocery created successfully!");
                UpdateGroceryControl();
            }
            else
            {
                MessageBox.Show("Please fill in all fields!");
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

                    // Add the control to the FlowLayoutPanel
                    flowLayoutPanelGrocery.Controls.Add(groceryControl);
                }
            }
        }


    }
}
