using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.Classes
{
    public class Building
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Flat> Flats { get; set; }
        public List<Rule> BuildingRules { get; set; }

        //Empty constructor for deserialization
        public Building() { }

        //constructors for regular usage
        public Building(string inputAddress, DataManager dataManager)
        {
            Address = inputAddress;
            Flats = new List<Flat>();
            BuildingRules = new List<Rule>();
            Id = dataManager.GetIdFromClass(this) + 1;
        }

        public Building(string inputAddress, List<Flat> inputFlats, DataManager dataManager)
        {
            Address = inputAddress;
            Flats = inputFlats;
            BuildingRules = new List<Rule>();
            Id = dataManager.GetIdFromClass(this) + 1;
        }

        public Building(string inputAddress, List<Flat> inputFlats, List<Rule> rules, DataManager dataManager)
        {
            Address = inputAddress;
            Flats = inputFlats;
            BuildingRules = rules;
            Id = dataManager.GetIdFromClass(this) + 1;
        }

        public void AddBuildingRule(Rule buildingRule)
        {
            BuildingRules.Add(buildingRule);
        }
    }
}
