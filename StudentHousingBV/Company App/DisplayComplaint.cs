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
        private readonly DataManager dataManager;
        public DisplayComplaint()
        {
            InitializeComponent();
            CreateDummyComplaints();
            UpdateListBoxComplaint();
        }

        private void CreateDummyComplaints()
        {
            //string description, int buildingId, int flatId, DataManager dataManager
            Complaint complaint1 = new Complaint(1, "Mats annoyed me! he did this and that and bla bla bla.", 1, 1, dataManager);
            Complaint complaint2 = new Complaint(2, "Aleix annoyed me! he did this and that and bla bla bla.", 1, 1, dataManager);
            Complaint complaint3 = new Complaint(3, "Realgi annoyed me! he did this and that and bla bla bla.", 1, 2, dataManager);
        }

        private void UpdateListBoxComplaint()
        {
            lBoxComplaint.DataSource = null;
            lBoxComplaint.DataSource = dataManager.GetAllComplaints();
        }
    }
}
