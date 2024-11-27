using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Building
    {
        private DataManager dataManager;
        private int id;
        private string address;
        //private List<Flat> flats;
        //private List<Rule> buildingRules;

        public Building(string inputAddress)
        {
            this.address = inputAddress;
            //this.flats = new List<Flat>();
            //this.buildingRules = new List<Rule>();
            this.id = dataManager.GetIdFromClass(this) + 1;
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

        public int GetId()
        { return id; }
    }
}
