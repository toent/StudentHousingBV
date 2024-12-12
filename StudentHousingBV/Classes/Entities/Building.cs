using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Classes.Entities
{
    public class Building
    {
        #region Properties
        public int BuildingId { get; set; } // Primary key
        public string Address { get; set; }
        public List<Rule> Rules { get; set; }
        public List<Flat> Flats { get; set; }
        #endregion

        #region Constructors
        public Building() { }

        public Building(int id)
        {
            BuildingId = id;
            Address = "";
            Rules = [];
            Flats = [];
        }

        public Building(int id, string inputAddress)
        {
            BuildingId = id;
            Address = inputAddress;
            Rules = [];
            Flats = [];
        }

        public Building(int id, string inputAddress, List<Rule> rules, List<Flat> flats)
        {
            BuildingId = id;
            Address = inputAddress;
            Rules = rules;
            Flats = flats;
        }
        #endregion
    }
}
