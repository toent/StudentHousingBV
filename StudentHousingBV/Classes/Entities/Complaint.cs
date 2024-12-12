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
        public Complaint()
        {
            Issue = "";
            AssignedFlat = new();
        }

        public Complaint(int id, Flat assignedFlat)
        {
            ComplaintId = id;
            Issue = "";
            AssignedFlat = assignedFlat;
        }

        public Complaint(int id, Flat assignedFlat, string description)
        {
            ComplaintId = id;
            Issue = description;
            AssignedFlat = assignedFlat;
        }
        #endregion
    }
}
