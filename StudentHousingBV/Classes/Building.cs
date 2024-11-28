namespace StudentHousingBV.Classes
{
    public class Building
    {
        #region Properties
        public int BuildingId { get; set; } // Primary Key
        public string Address { get; set; } 
        
        // Navigation property
        public ICollection<Flat> Flats { get; set; }
        #endregion

        #region Constructors
        public Building()
        {
            Flats = new List<Flat>();
            Address = "";
        }

        //constructors for regular usage
        public Building(string inputAddress, DataManager dataManager)
        {
            Address = inputAddress;
            Flats = new List<Flat>();
            BuildingId = dataManager.GetIdFromClass(this) + 1;
        }

        public Building(string inputAddress, List<Flat> inputFlats, DataManager dataManager)
        {
            Address = inputAddress;
            Flats = inputFlats;
            BuildingId = dataManager.GetIdFromClass(this) + 1;
        }

        public Building(string inputAddress, List<Flat> inputFlats, List<Rule> rules, DataManager dataManager)
        {
            Address = inputAddress;
            Flats = inputFlats;
            BuildingId = dataManager.GetIdFromClass(this) + 1;
        }
        #endregion
    }
}
