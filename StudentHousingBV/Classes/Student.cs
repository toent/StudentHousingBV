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
        public Flat Flat { get; set; }
        public Building Building { get; set; }
        #endregion

        #region Constructors
        public Student()
        {
            Name = "";
            Flat = new Flat();
            Building = new Building();
            StudentId = "";
        }

        public Student(string studentId, string name)
        {
            StudentId = studentId;
            Name = name;
            Flat = new Flat();
            Building = new Building();
        }
        #endregion
    }
}
