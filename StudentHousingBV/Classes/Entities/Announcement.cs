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
        [JsonIgnore]
        public Flat? AssignedFlat { get; set; }

        #endregion

        #region Constructors
        public Announcement(int announcementId, string title, string message, DateTime date, Flat? assignedFlat)
        {
            AnnouncementId = announcementId;
            Title = title;
            Message = message;
            Date = date;
            AssignedFlat = assignedFlat;
        }
        #endregion
    }
}
