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
        public Building Building { get; set; }
        public Flat Flat { get; set; }
        #endregion

        #region Constructors
        public Complaint()
        {
            ComplaintId = -1;
            Issue = "";
            Building = new Building();
            Flat = new Flat();
        }

        public Complaint(string description, int buildingId, int flatId, DataManager dataManager)
        {
            Issue = description;
            BuildingId = buildingId;
            FlatId = flatId;
            Building = dataManager.GetBuilding(buildingId);
            Flat = dataManager.GetFlat(buildingId, flatId);
            ComplaintId = dataManager.GetIdFromClass(this, buildingId, flatId);
        }
        #endregion
    }
}
