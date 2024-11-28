namespace StudentHousingBV.Classes
{
    public class Chore
    {
        #region Properties
        public int ChoreId { get; set; } // Primary Key
        public string Description { get; set; }
        public int StudentId { get; set; } // Foreign Key 

        // Navigation property
        public Student Student { get; set; }
        #endregion

        #region Constructors
        public Chore()
        {
            StudentId = 0;
            Student = new Student();
            Description = "";
        }
        #endregion
    }
}
