using StudentHousingBV.Classes.Entities;
using System.Diagnostics;

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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grocery.GroceryItems);
        }

        private void btnPaymentLink_Click(object sender, EventArgs e)
        {
            ProcessStartInfo paymentUrl = new ProcessStartInfo
            {
                FileName = $"{grocery.PaymentUrl}",
                UseShellExecute = true
            };
            Process.Start(paymentUrl);
        }
    }
}
