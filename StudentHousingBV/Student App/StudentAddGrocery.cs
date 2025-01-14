using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.Student_App
{
    public partial class StudentAddGrocery : Form
    {
        private readonly HousingManager housingManager;
        private readonly Student student;
        private string imgPath;

        internal EventHandler<Grocery> NewGrocery;

        public StudentAddGrocery(HousingManager housingManager, Student student)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            this.student = student;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string paymentURL = tBoxPaymentURL.Text;
            string groceryItems = richTextBoxGroceryItems.Text;

            if (paymentURL != string.Empty && imgPath != string.Empty)
            {
                Grocery grocery = new(housingManager.GetNextGroceryId(), DateTime.Today , student, imgPath, paymentURL, student.AssignedFlat!, groceryItems);
                DialogResult = DialogResult.OK;

                NewGrocery?.Invoke(this, grocery);
            }
            else
            {
                MessageBox.Show("Please fill in all fields!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"; // File filters
                openFileDialog.FilterIndex = 1; // Default filter
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    imgPath = openFileDialog.FileName;
                    pictureBoxReceipt.Image = Image.FromFile(imgPath);
                }
            }
        }

        private void btnRemoveRecepit_Click(object sender, EventArgs e)
        {
            imgPath = string.Empty;
        }
    }
}
