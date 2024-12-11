using StudentHousingBV.Classes.Managers;

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
        public Announcement() { }
        public Announcement(HousingManager housingManager)
        {
            AnnouncementId = housingManager.GetNextAnnouncementId();
            Message = "";
            IsGlobal = false;
        }

        public Announcement(HousingManager housingManager, Flat assignedFlat)
        {
            AnnouncementId = housingManager.GetNextAnnouncementId();
            Message = "";
            IsGlobal = false;
            AssignedFlat = assignedFlat;
        }

        public Announcement(string message, HousingManager housingManager, Flat assignedFlat)
        {
            AnnouncementId = housingManager.GetNextAnnouncementId();
            Message = message;
            IsGlobal = false;
            AssignedFlat = assignedFlat;
        }

        public Announcement(string message, bool isGlobal, HousingManager housingManager, Flat assignedFlat)
        {
            AnnouncementId = housingManager.GetNextAnnouncementId();
            Message = message;
            IsGlobal = isGlobal;
            AssignedFlat = assignedFlat;
        }
        #endregion
    }
}
