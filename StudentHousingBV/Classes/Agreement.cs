namespace StudentHousingBV.Classes
{
    public class Agreement(DataManager dataManager)
    {
        #region Properties
        public int AgreementId { get; set; } = dataManager.GetNextAgreementId();
        public string Details { get; set; } = "";
        public int StudentId { get; set; } // Foreign Key
        public int BuildingId { get; set; } // Foreign Key 

        // Navigation properties
        public Student? Student { get; set; }
        public Building? Building { get; set; }

        #endregion
    }
}
