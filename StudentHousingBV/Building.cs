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
        //private List<Flat> flats;
        //private List<Rule> buildingRules;

        //parameterless constructor used for deserialization
        public Building() { }

        //constructor for regular usage
        public Building(string inputAddress, DataManager dataManager)
        {
            this.Address = inputAddress;
            //this.flats = new List<Flat>();
            //this.buildingRules = new List<Rule>();
            this.Id = dataManager.GetIdFromClass(this) + 1;
        }

        /*public Building(string inputAddress, List<Flat> inputFlats)
        {
            this.address = inputAddress;
            this.flats = inputFlats;
            this.buildingRules = new List<Rule>();
            this.id = dataManager.GetIdFromClass(this) + 1;
        }*/

        /*public Building(string inputAddress, List<Flat> inputFlats, List<Rule> inputBuildingRules)
        {
            this.address = inputAddress;
            this.flats = inputFlats;
            this.buildingRules = inputBuildingRules;
            this.id = dataManager.GetIdFromClass(this) + 1;
        }*/
    }
}
