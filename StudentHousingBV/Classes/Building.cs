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
        public Building(DataManager dataManager)
        {
            BuildingId = dataManager.GetMaxIdBuildings() + 1;
            Flats = [];
            Address = "";
        }

        //constructors for regular usage
        public Building(string inputAddress, DataManager dataManager)
        {
            BuildingId = dataManager.GetMaxIdBuildings() + 1;
            Address = inputAddress;
            Flats = [];
        }

        public Building(string inputAddress, List<Flat> inputFlats, DataManager dataManager)
        {
            BuildingId = dataManager.GetMaxIdBuildings() + 1;
            Address = inputAddress;
            Flats = inputFlats;
        }
        #endregion
    }
}
