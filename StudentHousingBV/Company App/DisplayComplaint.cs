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
    public partial class DisplayComplaint : Form
    {
        private readonly DataManager dataManager = new DataManager();
        private List<Complaint> complaints = new List<Complaint>();
        private Complaint selectedComplaint;
        public DisplayComplaint()
        {
            InitializeComponent();
            InitializeTestingDataset();
            UpdateListBoxComplaint();

        }

        private void UpdateListBoxComplaint()
        {
            lBoxComplaint.DataSource = null;
            lBoxComplaint.DataSource = GetComplaints();
        }


        private List<Complaint> GetComplaints()
        {
            complaints = dataManager.GetAllComplaints();
            return complaints;
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
            dataManager.Complaints.Add(new Complaint()
            {
                ComplaintId = 1,
                Issue = "Realg was mean to the special kids. \nPunish him!",
                BuildingId = 1,
                FlatId = 1,
            });
        }

        private void lBoxComplaint_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedComplaint = (Complaint)lBoxComplaint.SelectedItem;
            richTextBoxComplaint.Text = selectedComplaint.Issue;
        }
    }
}
