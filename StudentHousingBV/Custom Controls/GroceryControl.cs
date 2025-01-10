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
            pictureBoxGrocery.Cursor = Cursors.Hand;
        }

        public void SetGrocery(Grocery grocery)
        {
            this.grocery = grocery;

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

        private void pictureBoxGrocery_Click(object sender, EventArgs e)
        {
            if (grocery != null && !string.IsNullOrEmpty(grocery.ImagePath))
            {
                // Create a new form to act as the modal
                Form modalForm = new Form
                {
                    FormBorderStyle = FormBorderStyle.None,
                    StartPosition = FormStartPosition.CenterScreen,
                    BackColor = Color.Black,
                    Size = new Size(800, 600),
                    TopMost = true,
                };

                PictureBox modalPictureBox = new PictureBox
                {
                    Image = Image.FromFile(grocery.ImagePath),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill,
                    Cursor = Cursors.Hand // Indicate it's clickable
                };

                // Add the PictureBox to the form
                modalForm.Controls.Add(modalPictureBox);

                // Close the modal when the PictureBox or outside area is clicked
                modalPictureBox.Click += (s, args) => modalForm.Close();
                modalForm.Click += (s, args) => modalForm.Close();

                modalForm.ShowDialog();
            }
        }
    }
}
