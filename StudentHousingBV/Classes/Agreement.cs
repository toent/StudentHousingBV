namespace StudentHousingBV.Classes
{
    public class Agreement
    {
        #region Properties
        public int AgreementId { get; set; } // Primary Key
        public string Details { get; set; } 
        public int StudentId { get; set; } // Foreign Key
        public int BuildingId { get; set; } // Foreign Key 
        
        // Navigation properties
        public Student Student { get; set; } 
        public Building Building { get; set; }
        #endregion

        #region Constructors
        public Agreement()
        {
            Student = new Student();
            Building = new Building();
            Details = "";
        }
        #endregion
    }
}
