using StudentHousingBV.Classes;
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
    public partial class StudentGroceries : Form
    {
        private readonly DataManager dataManager;
        public StudentGroceries(DataManager dataManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
        }

        private void btnAddGrocery_Click(object sender, EventArgs e)
        {
            //https://cdn.apartmenttherapy.info/image/upload/v1559186495/k/archive/2d4ea32ed14a1f75cf1b454748dfa99cd4a1fa62.jpg
            
            string imgPath = tBoxImgPath.Text;
            string paymentURL = tBoxPaymentURL.Text;

            if (imgPath != string.Empty && paymentURL != string.Empty)
            {
                Grocery grocery = new Grocery("test_student", imgPath, paymentURL, 1, dataManager);
                MessageBox.Show("Grocery created successfully!");
            }
            else
            {
                MessageBox.Show("Please fill in all fields!");
            }
        }
    }
}
