using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Custom_Controls
{
    public partial class GroceryControl : UserControl
    {
        private Grocery? grocery;
        public GroceryControl()
        {
            InitializeComponent();
        }

        public void SetGrocery(Grocery grocery)
        {
            this.grocery = grocery;

            lblName.Text = grocery.GroceryId.ToString();
            lblDate.Text = grocery.Date.ToShortDateString();
            pictureBoxGrocery.Image = Image.FromFile(grocery.ImagePath);

        }
    }
}
