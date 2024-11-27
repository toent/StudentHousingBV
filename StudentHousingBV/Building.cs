using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Building
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Flat> Flats { get; set; }
        //public List<Rule> BuildingRules { get; set; }

        //Empty constructor for deserialization
        public Building() { }

        //constructors for regular usage
        public Building(string inputAddress, DataManager dataManager)
        {
            this.Address = inputAddress;
            this.Flats = new List<Flat>();
            //this.BuildingRules = new List<Rule>();
            this.Id = dataManager.GetIdFromClass(this) + 1;
        }

        public Building(string inputAddress, List<Flat> inputFlats, DataManager dataManager)
        {
            this.Address = inputAddress;
            this.Flats = inputFlats;
            //this.BuildingRules = new List<Rule>();
            this.Id = dataManager.GetIdFromClass(this) + 1;
        }

        /*public Building(string inputAddress, List<Flat> inputFlats, List<Rule> rules,DataManager dataManager)
        {
            this.Address = inputAddress;
            this.Flats = inputFlats;
            this.BuildingRules = rules;
            this.Id = dataManager.GetIdFromClass(this) + 1;
        }*/
    }
}
