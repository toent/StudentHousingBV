using StudentHousingBV.Classes.Managers;
using System.Text.Json.Serialization;

namespace StudentHousingBV.Classes.Entities
{
    public class Rule
    {
        #region Properties
        public int RuleId { get; set; } // Primary Key
        public string Description { get; set; }
        [JsonIgnore]
        public Flat? AssignedFlat { get; set; } // Cross-Reference
        [JsonIgnore]
        public Building? AssignedBuilding { get; set; } // Cross-Reference
        #endregion

        #region Constructors

        public Rule()
        {
            Description = "";
        }

        public Rule(int id, Flat assignedFlat, string description)
        {
            RuleId = id;
            Description = description;
            AssignedFlat = assignedFlat;
        }

        public Rule(int id, Building assignedBuilding, string description)
        {
            RuleId = id;
            Description = description;
            AssignedBuilding = assignedBuilding;
        }
        #endregion

    }
}
