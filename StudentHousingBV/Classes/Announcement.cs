namespace StudentHousingBV.Classes
{
    public class Announcement
    {
        #region Properties
        public int AnnouncementId { get; set; } // Primary Key
        public string Message { get; set; }
        public bool IsGlobal { get; set; }
        public int BuildingId { get; set; } // Foreign Key 
        public int FlatId { get; set; } //Foreign Key

        // Navigation property
        public Building? Building { get; set; }
        public Flat? Flat { get; set; }
        #endregion

        #region Constructors
        public Announcement(DataManager dataManager)
        {
            AnnouncementId = dataManager.GetNextAnnouncementId();
            Message = "";
        }

        public Announcement(string message, int buildingId, DataManager dataManager)
        {
            AnnouncementId = dataManager.GetNextAnnouncementId();
            Message = message;
            BuildingId = buildingId;
            Building = dataManager.GetBuilding(buildingId);
            IsGlobal = false;
        }

        public Announcement(string message, int buildingId, int flatId, DataManager dataManager)
        {
            AnnouncementId = dataManager.GetNextAnnouncementId();
            Message = message;
            BuildingId = buildingId;
            FlatId = flatId;
            Building = dataManager.GetBuilding(buildingId);
            Flat = dataManager.GetFlat(flatId);
            IsGlobal = false;
        }

        public Announcement(string message, bool isGlobal, DataManager dataManager)
        {
            AnnouncementId = dataManager.GetNextAnnouncementId();
            Message = message;
            IsGlobal = isGlobal;
        }

        public Announcement(string message, int buildingId, bool isGlobal, DataManager dataManager)
        {
            AnnouncementId = dataManager.GetNextAnnouncementId();
            Message = message;
            BuildingId = buildingId;
            Building = dataManager.GetBuilding(buildingId);
            IsGlobal = isGlobal;
        }

        public Announcement(string message, int buildingId, int flatId, bool isGlobal, DataManager dataManager)
        {
            AnnouncementId = dataManager.GetNextAnnouncementId();
            Message = message;
            BuildingId = buildingId;
            FlatId = flatId;
            Building = dataManager.GetBuilding(buildingId);
            Flat = dataManager.GetFlat(flatId);
            IsGlobal = isGlobal;
        }

        #endregion
    }
}
