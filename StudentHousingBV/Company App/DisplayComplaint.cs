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

namespace StudentHousingBV.Company_App
{
    //private List<Complaint> complaints = new List<Complaint>
    public partial class DisplayComplaint : Form
    {
        private readonly DataManager dataManager;
        public DisplayComplaint()
        {
            InitializeComponent();
            InitializeTestingDataset();
            UpdateListBoxComplaint();

        }

        private void UpdateListBoxComplaint()
        {
            lBoxComplaint.DataSource = null;
            lBoxComplaint.DataSource = dataManager.GetAllComplaints();
        }

        private void InitializeTestingDataset()
        {
            dataManager.Buildings.Add(new Building(dataManager)
            {
                BuildingId = 1,
                Address = "123 Main St"
            });
            dataManager.Flats.Add(new Flat(dataManager)
            {
                BuildingId = 1,
                FlatId = 1,
                FlatNumber = 101
            });
            dataManager.Students.Add(new Student()
            {
                StudentId = "F93756",
                BuildingId = 1,
                FlatId = 1,
                Name = "Jane Doe",
            });
        }
    }
}
