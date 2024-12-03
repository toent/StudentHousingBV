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
        public Building? Building { get; set; }
        public Flat? Flat {  get; set; }
        #endregion

        #region Constructors  
        public Rule(DataManager dataManager)
        {
            RuleId = dataManager.GetMaxIdRules() + 1;
            Description = "";
        }

        public Rule(string description, DataManager dataManager, int buildingId)
        {
            RuleId = dataManager.GetMaxIdRules() + 1;
            BuildingId = buildingId;
            Description = description;
            Building = dataManager.GetBuilding(buildingId);
        }

        public Rule(string description, DataManager dataManager, int buildingId, int flatId)
        {
            RuleId = dataManager.GetMaxIdRules() + 1;
            BuildingId = buildingId;
            FlatId = flatId;
            Description = description;
            Building = dataManager.GetBuilding(buildingId);
            Flat = dataManager.GetFlat(flatId);
        }
        #endregion

    }
}
