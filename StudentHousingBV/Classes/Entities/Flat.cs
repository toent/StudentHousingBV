using System.Text.Json.Serialization;

namespace StudentHousingBV.Classes.Entities
{
    public class Flat
    {
        #region Properties
        internal int FlatId { get; set; } // Primary Key
        public int FlatNumber { get; set; }
        public List<Student> Students { get; set; }
        public List<Complaint> Complaints { get; set; }
        public List<Agreement> Agreements { get; set; }
        public List<Announcement> Announcements { get; set; }
        public List<Chore> Chores { get; set; }
        public List<Grocery> Groceries { get; set; }
        public List<Rule> Rules { get; set; }
        public int ExternalId { get => FlatId; }
        [JsonIgnore]
        public Building AssignedBuilding { get; set; } // Cross-Reference
        #endregion

        #region Constructors
        public Flat()
        {
            Students = [];
            Complaints = [];
            Agreements = [];
            Announcements = [];
            Chores = [];
            Groceries = [];
            Rules = [];
            AssignedBuilding = new();
        }

        public Flat(int id, Building assignedBuilding)
        {
            FlatId = id;
            Students = [];
            Complaints = [];
            Agreements = [];
            Announcements = [];
            Chores = [];
            Groceries = [];
            Rules = [];
            AssignedBuilding = assignedBuilding;
        }

        public Flat(int id, int flatNumber, Building assignedBuilding)
        {
            FlatId = id;
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

        public Flat(int id, int flatNumber, Building assignedBuilding, List<Student> students)
        {
            FlatId = id;
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

        #region Methods
        public override string ToString()
        {
            return $"Flat {FlatNumber} - Students: {Students.Count}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Flat flat && FlatId == flat.FlatId;
        }

        #endregion
    }
}
