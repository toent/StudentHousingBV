using System.Text.Json;
using StudentHousingBV.Classes;

namespace StudentHousingBV.Classes
{
    public class DataManager
    {
        private List<Building> buildings;

        public DataManager()
        {
            buildings = new List<Building>();
            LoadFromStorage();
        }


        //-------------------------------------------------------------------------------------METHODS FOR GETTING IDs-------------------------------------------------------------------------------------


        /// <summary>
        /// Get the current highest ID assigned to a building
        /// </summary>
        public int GetIdFromClass(Building building)
        {
            int resultId = -1;

            LoadFromStorage();

            if (buildings.Count > 0)
            {

                resultId = buildings.Max(building => building.Id);
            }

            return resultId;
        }


        /// <summary>
        /// Get the current highest ID assigned to a flat
        /// </summary>
        public int GetIdFromClass(Flat flat, int buildingId)
        {
            int resultId = -1;

            LoadFromStorage();

            if (GetFlats(buildingId).Count > 0)
            {
                resultId = GetFlats(buildingId).Max(flat => flat.Id);
            }

            return resultId;
        }


        /// <summary>
        /// Get the current highest ID assigned to a complaint
        /// </summary>
        public int GetIdFromClass(Complaint complaint, int buildingId, int flatId)
        {
            int resultId = -1;

            LoadFromStorage();

            if (buildings[buildingId].Flats.Count > 0)
            {

                resultId = GetComplaints(buildingId, flatId).Max(complaint => complaint.Id);
            }

            return resultId;
        }

        /// <summary>
        /// Get the current highest ID assigned to a rule
        /// </summary>
        public int GetIdFromClass(Rule rule, int buildingId)
        {
            int resultId = -1;

            LoadFromStorage();

            if (buildings[buildingId].Flats.Count > 0)
            {
                resultId = buildings[buildingId].BuildingRules.Max(rule => rule.Id);

                foreach (Flat f in GetFlats(buildingId))
                {
                    if (f.FlatRules.Max(rule => rule.Id) > resultId)
                    {
                        resultId = f.FlatRules.Max(rule => rule.Id);
                    }
                }
            }

            return resultId;
        }


        //----------------------------------------------------------------------------------------ALL OTHER METHODS----------------------------------------------------------------------------------------


        //get all buildings
        public List<Building> GetBuildings()
        { return this.buildings; }

        //get all flats in a building
        public List<Flat> GetFlats(int buildingId)
        { return this.buildings.FirstOrDefault(building => building.Id == buildingId).Flats; }

        //get all students
        public List<Student> GetStudents()
        {
            List<Student> allStudents = new List<Student>();

            foreach (Building building in this.buildings)
            {
                foreach (Flat flat in building.Flats)
                {
                    allStudents.AddRange(flat.Students);
                }
            }

            return allStudents;
        }

        //get all students in a building
        public List<Student> GetStudents(int buildingId) 
        {
            List<Student> buildingStudents = new List<Student>();

            foreach (Flat flat in this.GetFlats(buildingId))
            {
                buildingStudents.AddRange(flat.Students);
            }

            return buildingStudents;
        }

        //get all students in a flat
        public List<Student> GetStudents(int buildingId, int flatId)
        { return this.GetFlats(buildingId).FirstOrDefault(flat => flat.Id == flatId).Students; }

        //get all complaints of a flat
        public List<Complaint> GetComplaints(int buildingId, int flatId)
        { return this.GetFlats(buildingId).FirstOrDefault(flat => flat.Id == flatId).Complaints; }

        //get all rules
        public List<Rule> GetAllRules(int buildingId, int flatId)
        {
            List<Rule> totalRules = new List<Rule>();
            totalRules.AddRange(GetBuildings()[buildingId].BuildingRules);
            totalRules.AddRange(GetFlats(buildingId)[flatId].FlatRules);
            return totalRules;
        }


        /// <summary>
        /// Load the data that is currently in /Storage/data.json
        /// </summary>
        public void LoadFromStorage()
        {
            //get the storage path
            string storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage");

            if (Directory.Exists(storagePath))
            {
                //save json as string
                string savedJsonText = File.ReadAllText(Path.Combine(storagePath, "data.json"));

                try
                {
                    //deserialize json and make it nullable
                    List<Building>? deserializedJson = JsonSerializer.Deserialize<List<Building>>(savedJsonText);
                    if (deserializedJson != null)
                    {
                        //if not null add to buildings
                        buildings = deserializedJson;
                    }
                }
                catch (Exception ex)
                {
                    //catch exception
                }
            }
        }


        /// <summary>
        /// Save the current data in /Storage/data.json
        /// </summary>
        public void SaveToStorage()
        {
            //set storage file path 
            string storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage");

            //create storage file path if it doesnt exist yet
            Directory.CreateDirectory(storagePath);

            //convert Buildings to json
            string jsonBuilding = JsonSerializer.Serialize(buildings);

            //write or create json file
            File.WriteAllText(Path.Combine(storagePath, "data.json"), jsonBuilding);
        }


        /// <summary>
        /// Debug string that just get the entire text that is currently in the json file
        /// </summary>
        public string GetJsonBuilding()
        {
            LoadFromStorage();
            string savedJsonText = string.Empty;
            string storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage");
            //save json as string
            if (Directory.Exists(storagePath))
            {
                savedJsonText = File.ReadAllText(Path.Combine(storagePath, "data.json"));
            }
            return savedJsonText;
        }
    }
}
