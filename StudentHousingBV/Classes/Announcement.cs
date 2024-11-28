namespace StudentHousingBV.Classes
{
    public class Announcement
    {
        #region Properties
        public int AnnouncementId { get; set; } // Primary Key
        public string Message { get; set; }
        public int BuildingId { get; set; } // Foreign Key 

        // Navigation property
        public Building Building { get; set; }
        #endregion

        #region Constructors
        public Announcement()
        {
            Message = "";
            Building = new Building();
        }

        public Announcement(int announcementId, string message, int buildingId, DataManager dataManager)
        {
            AnnouncementId = announcementId;
            Message = message;
            BuildingId = buildingId;
            Building = dataManager.GetBuildings()[buildingId];
        }
        #endregion
    }
}
