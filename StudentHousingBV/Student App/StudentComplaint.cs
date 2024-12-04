﻿using StudentHousingBV.Classes;

namespace StudentHousingBV.Student_App
{
    public partial class StudentComplaint : Form
    {
        private readonly DataManager dataManager;

        public StudentComplaint(DataManager dataManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
        }

        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complaint submitted successfully!");
        }

        private void changeSelectedTabBgColor()
        {

        }
    }
}
