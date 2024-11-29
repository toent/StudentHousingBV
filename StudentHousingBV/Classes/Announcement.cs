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
        public Building Building { get; set; }
        public Flat Flat { get; set; }
        #endregion

        #region Constructors
        public Announcement()
        {
            Message = "";
            Building = new Building();
        }

        public Announcement(int announcementId, string message, int buildingId, DataManager dataManager)
        {
            AnnouncementId = dataManager.GetIdFromClass(this, buildingId);
            Message = message;
            BuildingId = buildingId;
            Building = dataManager.GetBuilding(buildingId);
            IsGlobal = false;
        }

        public Announcement(int announcementId, string message, int buildingId, int flatId, DataManager dataManager)
        {
            AnnouncementId = dataManager.GetIdFromClass(this, buildingId);
            Message = message;
            BuildingId = buildingId;
            FlatId = flatId;
            Building = dataManager.GetBuilding(buildingId);
            Flat = dataManager.GetFlat(buildingId, flatId);
            IsGlobal = false;
        }

        public Announcement(int announcementId, string message, bool isGlobal, DataManager dataManager)
        {
            if(isGlobal == true)
            {
                AnnouncementId = dataManager.GetIdFromClass(this);
                Message = message;
                IsGlobal = isGlobal;
            }
            else
            {
                //set announcement to being invalid
                this.AnnouncementId = -1;
            }
        }

        public Announcement(int announcementId, string message, int buildingId, bool isGlobal, DataManager dataManager)
        {
            if (isGlobal == true)
            {
                AnnouncementId = dataManager.GetIdFromClass(this);
            }
            else
            {
                AnnouncementId = dataManager.GetIdFromClass(this, buildingId);
            }

            Message = message;
            BuildingId = buildingId;
            Building = dataManager.GetBuilding(buildingId);
            IsGlobal = isGlobal;
        }

        public Announcement(int announcementId, string message, int buildingId, int flatId, bool isGlobal, DataManager dataManager)
        {
            if (isGlobal == true)
            {
                AnnouncementId = dataManager.GetIdFromClass(this);
            }
            else
            {
                AnnouncementId = dataManager.GetIdFromClass(this, buildingId);
            }
            Message = message;
            BuildingId = buildingId;
            FlatId = flatId;
            Building = dataManager.GetBuilding(buildingId);
            Flat = dataManager.GetFlat(buildingId, flatId);
            IsGlobal = isGlobal;
        }

        #endregion
    }
}
