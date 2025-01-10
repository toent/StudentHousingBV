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
        private List<Grocery> groceries;

        public StudentAddGrocery(List<Grocery> groceries, HousingManager housingManager, Student student)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            this.student = student;
            this.groceries = groceries;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //https://cdn.apartmenttherapy.info/image/upload/v1559186495/k/archive/2d4ea32ed14a1f75cf1b454748dfa99cd4a1fa62.jpg

            string imgPath = tBoxImgPath.Text;
            string paymentURL = tBoxPaymentURL.Text;
            string groceryItems = richTextBoxGroceryItems.Text;

            if (imgPath == string.Empty)
            {
                imgPath = "C:\\Users\\tomas\\source\\repos\\StudentHousingBV\\StudentHousingBV\\bin\\Debug\\net8.0-windows\\Storage\\grocery.jpg";
            }

            if (paymentURL != string.Empty && imgPath != string.Empty && groceryItems != string.Empty)
            {
                Grocery grocery = new(housingManager.GetNextGroceryId(), student, imgPath, paymentURL, student.AssignedFlat!, groceryItems);
                groceries.Add(grocery);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please fill in all fields!");
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
