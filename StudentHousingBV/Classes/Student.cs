namespace StudentHousingBV.Classes
{
    public class Student
    {
        #region Properties
        public string StudentId { get; set; } // Primary Key
        public string Name { get; set; } 
        public int FlatId { get; set; } // Foreign Key 
        public int BuildingId { get; set; } // Foreign Key
        
        // Navigation property
        public Flat? Flat { get; set; }
        public Building? Building { get; set; }
        #endregion

        public Student() { }
        
        public Student(string studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }

        #region Constructors
        public Student(string studentId, string name, int buildingId, int flatId)
        {
            StudentId = studentId;
            Name = name;
            FlatId = flatId;
            BuildingId = buildingId;
        }
        #endregion
    }
}
