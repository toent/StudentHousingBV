namespace StudentHousingBV.Classes
{
    public class Complaint
    {
        #region Properties
        public int ComplaintId { get; set; } // Primary Key
        public string Issue { get; set; }
        public int BuildingId { get; set; } // Foreign Key 
        public int FlatId { get; set; } //Foreign Key

        // Navigation properties
        public Building? Building { get; set; }
        public Flat? Flat { get; set; }
        #endregion

        #region Constructors
        public Complaint(DataManager dataManager)
        {
            ComplaintId = dataManager.GetNextComplaintId();
            Issue = "";
        }

        public Complaint(string description, int buildingId, int flatId, DataManager dataManager)
        {
            ComplaintId = dataManager.GetNextComplaintId();
            Issue = description;
            BuildingId = buildingId;
            FlatId = flatId;
            Building = dataManager.GetBuilding(buildingId);
            Flat = dataManager.GetFlat(flatId);
        }

        public Complaint(int id ,string description, int buildingId, int flatId, DataManager dataManager)
        {
            ComplaintId = id;
            Issue = description;
            BuildingId = buildingId;
            FlatId = flatId;
            Building = dataManager.GetBuilding(buildingId);
            Flat = dataManager.GetFlat(flatId);
        }
        #endregion
    }
}
