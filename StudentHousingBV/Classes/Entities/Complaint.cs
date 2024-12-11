using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Classes.Entities
{
    public class Complaint
    {
        #region Properties
        public int ComplaintId { get; set; } // Primary Key
        public string Issue { get; set; }
        public Flat AssignedFlat { get; set; } // Cross-reference
        #endregion

        #region Constructors
        public Complaint() { }

        public Complaint(HousingManager housingManager, Flat assignedFlat)
        {
            ComplaintId = housingManager.GetNextComplaintId();
            Issue = "";
            AssignedFlat = assignedFlat;
        }

        public Complaint(string description, HousingManager housingManager, Flat assignedFlat)
        {
            ComplaintId = housingManager.GetNextComplaintId();
            Issue = description;
            AssignedFlat = assignedFlat;
        }
        #endregion
    }
}
