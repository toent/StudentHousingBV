namespace StudentHousingBV.Classes
{
    public class Flat
    {
        #region Properties
        public int FlatId { get; set; } // Primary Key
        public int BuildingId { get; set; } // Foreign Key
        public int FlatNumber { get; set; }

        // Navigation properties
        public Building? Building { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Complaint> Complaints { get; set; }
        #endregion

        #region Constructors
        public Flat(DataManager dataManager)
        {
            FlatId = dataManager.GetNextFlatId();
            Students = [];
            Complaints = [];
        }

        public Flat(int buildingId, int flatNumber, DataManager dataManager)
        {
            FlatId = dataManager.GetNextFlatId();
            BuildingId = buildingId;
            FlatNumber = flatNumber;
            Building = dataManager.GetBuilding(buildingId);
            Students = [];
            Complaints = [];
        }

        public Flat(int buildingId, int flatNumber, DataManager dataManger, List<Student> students)
        {
            FlatId = dataManger.GetNextFlatId();
            BuildingId = buildingId;
            FlatNumber = flatNumber;
            Building = dataManger.GetBuilding(buildingId);
            Students = students;
            Complaints = [];
        }
        #endregion
    }
}
