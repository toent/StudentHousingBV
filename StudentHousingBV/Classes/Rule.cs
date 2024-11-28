using System;
using System.Xml;

namespace StudentHousingBV.Classes
{
    public class Rule
    {
        //removed idCounter
        public int Id { get; set; }                                 //made id a property
        public string Description { get; set; }                     //made description a property
        public DateTime CreateTime { get; set; }                    //made createTime a property

        // Empty constructor for deserialization
        public Rule() { }

        // Constructor  
        public Rule(string description, DataManager dataManager, int buildingId)
        {
            Description = description;
            CreateTime = DateTime.Now;
            Id = dataManager.GetIdFromClass(this, buildingId);
            dataManager.GetBuildings()[buildingId].BuildingRules.Add(this);
        }

        public Rule(string description, DataManager dataManager, int buildingId, int flatId)
        {
            Description = description;
            CreateTime = DateTime.Now;
            Id = dataManager.GetIdFromClass(this, buildingId);
            dataManager.GetFlats(buildingId)[flatId].FlatRules.Add(this);
        }

    }
}
