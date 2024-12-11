using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Classes.Entities
{
    public class Rule
    {
        #region Properties
        public int RuleId { get; set; } // Primary Key
        public string Description { get; set; }
        public Flat AssignedFlat { get; set; } // Cross-Reference
        #endregion

        #region Constructors  
        public Rule(HousingManager housingManager, Flat assignedFlat)
        {
            RuleId = housingManager.GetNextRuleId();
            Description = "";
            AssignedFlat = assignedFlat;
        }

        public Rule(string description, HousingManager housingManager, Flat assignedFlat)
        {
            RuleId = housingManager.GetNextRuleId();
            Description = description;
            AssignedFlat = assignedFlat;
        }
        #endregion

    }
}
