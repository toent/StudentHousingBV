namespace StudentHousingBV.Classes.Entities
{
    public class Announcement
    {
        #region Properties
        public int AnnouncementId { get; set; } // Primary key
        public string Message { get; set; }
        public bool IsGlobal { get; set; }
        public Flat? AssignedFlat { get; set; } // Cross-reference
        #endregion

        #region Constructors
        public Announcement()
        {
            Message = "";
        }
        public Announcement(int id)
        {
            AnnouncementId = id;
            Message = "";
            IsGlobal = false;
        }

        public Announcement(int id, Flat assignedFlat)
        {
            AnnouncementId = id;
            Message = "";
            IsGlobal = false;
            AssignedFlat = assignedFlat;
        }

        public Announcement(int id, Flat assignedFlat, string message)
        {
            AnnouncementId = id;
            Message = message;
            IsGlobal = false;
            AssignedFlat = assignedFlat;
        }

        public Announcement(int id, Flat assignedFlat, string message, bool isGlobal)
        {
            AnnouncementId = id;
            Message = message;
            IsGlobal = isGlobal;
            AssignedFlat = assignedFlat;
        }
        #endregion
    }
}
