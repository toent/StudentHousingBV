namespace StudentHousingBV.Classes
{
    public class Rule
    {
        #region Properties
        public int RuleId { get; set; } // Primary Key
        public string Description { get; set; }
        public int BuildingId { get; set; } // Foreign Key 
        public int FlatId { get; set; } // Foreign Key

        // Navigation property
        public Building Building { get; set; }
        public Flat Flat {  get; set; }
        #endregion

        #region Constructors  
        public Rule()
        {
            Description = "";
            Building = new Building();
            Flat = new Flat();
        }

        public Rule(string description, DataManager dataManager, int buildingId)
        {
            Description = description;
            RuleId = dataManager.GetIdFromClass(this, buildingId) + 1;
            Building = dataManager.GetBuilding(buildingId);
            BuildingId = buildingId;
        }

        public Rule(string description, DataManager dataManager, int buildingId, int flatId)
        {
            Description = description;
            RuleId = dataManager.GetIdFromClass(this, buildingId) + 1;
            Building = dataManager.GetBuilding(buildingId);
            BuildingId = buildingId;
            Flat = dataManager.GetFlat(buildingId, flatId);
            FlatId = flatId;
        }
        #endregion

    }
}
