namespace StudentHousingBV.Classes
{
    public class Complaint
    {
        #region Properties
        public int ComplaintId { get; set; } // Primary Key
        public string Issue { get; set; }
        public int StudentId { get; set; } // Foreign Key
        public int BuildingId { get; set; } // Foreign Key 

        // Navigation properties
        public Student Student { get; set; }
        public Building Building { get; set}
        #endregion

        #region Constructors
        public Complaint()
        {
            ComplaintId = -1;
            Issue = "";
            Student = new Student();
            Building = new Building();
        }

        public Complaint(string description, int buildingId, int flatId, DataManager dataManager)
        {
            ComplaintId = -1;
            Issue = description;
            BuildingId = buildingId;
            StudentId = flatId;
            Building = dataManager.GetBuildings()[buildingId];
            Student = dataManager.GetStudents()[flatId];
        }
        #endregion
    }
}
