namespace StudentHousingBV.Classes
{
    public class Flat
    {
        #region Properties
        public int FlatId { get; set; } // Primary Key
        public int BuildingId { get; set; } // Foreign Key
        public int FlatNumber { get; set; }

        // Navigation properties
        public Building Building { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Complaint> Complaints { get; set; }
        #endregion

        #region Constructors
        public Flat()
        {
            FlatId = -1;
            Building = new Building();
            Students = new List<Student>();
        }

        public Flat(int buildingId, int flatNumber, DataManager dataManager)
        {
            BuildingId = buildingId;
            FlatNumber = flatNumber;
            FlatId = dataManager.GetIdFromClass(this, buildingId) + 1;
            Building = dataManager.GetBuilding(buildingId);
            Students = new List<Student>();
        }

        public Flat(int buildingId, int flatNumber, DataManager dataManger, List<Student> students)
        {
            BuildingId = buildingId;
            FlatNumber = flatNumber;
            FlatId = dataManger.GetIdFromClass(this, buildingId) + 1;
            Building = dataManger.GetBuilding(buildingId);
            Students = students;
        }
        #endregion
    }
}
