using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Classes.Entities
{
    public class Flat
    {
        #region Properties
        public int FlatId { get; set; } // Primary Key
        public int FlatNumber { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Complaint> Complaints { get; set; }
        public ICollection<Agreement> Agreements { get; set; }
        public ICollection<Announcement> Announcements { get; set; }
        public ICollection<Chore> Chores { get; set; }
        public ICollection<Grocery> Groceries { get; set; }
        public ICollection<Rule> Rules { get; set; }
        public Building AssignedBuilding { get; set; } // Cross-Reference
        #endregion

        #region Constructors
        public Flat(HousingManager housingManager, Building assignedBuilding)
        {
            FlatId = housingManager.GetNextFlatId();
            Students = [];
            Complaints = [];
            Agreements = [];
            Announcements = [];
            Chores = [];
            Groceries = [];
            Rules = [];
            AssignedBuilding = assignedBuilding;
        }

        public Flat(int flatNumber, HousingManager housingManager, Building assignedBuilding)
        {
            FlatId = housingManager.GetNextFlatId();
            FlatNumber = flatNumber;
            Students = [];
            Complaints = [];
            Agreements = [];
            Announcements = [];
            Chores = [];
            Groceries = [];
            Rules = [];
            AssignedBuilding = assignedBuilding;
        }

        public Flat(int flatNumber, List<Student> students, HousingManager housingManager, Building assignedBuilding)
        {
            FlatId = housingManager.GetNextFlatId();
            FlatNumber = flatNumber;
            Students = students;
            Complaints = [];
            Agreements = [];
            Announcements = [];
            Chores = [];
            Groceries = [];
            Rules = [];
            AssignedBuilding = assignedBuilding;
        }
        #endregion
    }
}
