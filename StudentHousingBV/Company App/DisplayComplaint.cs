using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Company_App
{
    public partial class DisplayComplaint : Form
    {
        private readonly HousingManager housingManager;
        public DisplayComplaint(HousingManager housingManager)
        {
            InitializeComponent();
            CreateDummyComplaints();
            UpdateListBoxComplaint();
            this.housingManager = housingManager;
        }

        private void CreateDummyComplaints()
        {
            //string description, int buildingId, int flatId, DataManager dataManager
            /*            Complaint complaint1 = new Complaint(1, "Mats annoyed me! he did this and that and bla bla bla.", 1, 1, dataManager);
                        Complaint complaint2 = new Complaint(2, "Aleix annoyed me! he did this and that and bla bla bla.", 1, 1, dataManager);
                        Complaint complaint3 = new Complaint(3, "Realgi annoyed me! he did this and that and bla bla bla.", 1, 2, dataManager);*/
        }

        private void UpdateListBoxComplaint()
        {
            lBoxComplaint.DataSource = null;
            lBoxComplaint.DataSource = housingManager.GetAllComplaints();
        }
    }
}
