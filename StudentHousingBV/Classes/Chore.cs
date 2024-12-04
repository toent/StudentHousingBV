namespace StudentHousingBV.Classes
{
    public class Chore(DataManager dataManager)
    {
        #region Properties
        public int ChoreId { get; set; } = dataManager.GetMaxIdChores() + 1;
        public string Description { get; set; } = "";
        public int StudentId { get; set; } = 0;

        // Navigation property
        public Student? Student { get; set; }

        #endregion
        #region Constructors
        #endregion
    }
}
