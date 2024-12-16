using System.Text.Json.Serialization;

namespace StudentHousingBV.Classes.Entities
{
    public class Announcement
    {
        #region Properties
        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool IsGlobal { get; set; }
        [JsonIgnore]
        public Flat? AssignedFlat { get; set; }

        #endregion

        #region Constructors
        public Announcement(int announcementId, string title, string message, bool isGlobal, Flat? assignedFlat) 
        { 
            AnnouncementId = announcementId; 
            Title = title; 
            Message = message; 
            IsGlobal = isGlobal; 
            AssignedFlat = assignedFlat; 
        }
        #endregion
    }
}
