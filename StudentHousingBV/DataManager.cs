using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace StudentHousingBV
{
    public class DataManager
    {
        private List<Building> buildings;

        public DataManager() 
        {
            this.buildings = new List<Building>();
        }

        public int GetIdFromClass(Building building)
        {
            int resultId = -1;

            if (buildings.Count > 0)
            {
                foreach (Building b in buildings)
                {
                    if (b.GetId() > resultId)
                    {
                        resultId = b.GetId();
                    }
                }
            }

            return resultId;
        }

        public List<Building> GetBuildings() 
        { return buildings; }

        public void SetBuildings(List<Building> newBuildings)
        { buildings = newBuildings; }


        public void LoadFromStorage()
        {
            //save json as string
            string savedJsonText = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage", "data.json"));

            try
            {
                //deserialize json to Building list
                buildings = JsonSerializer.Deserialize<List<Building>>(savedJsonText);
            }
            catch (Exception ex)
            {
                //catch exception
            }

        }

        public void SaveToStorage()
        {    
            //set storage file path 
            string storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage");

            //create storage file path if it doesnt exist yet
            Directory.CreateDirectory(storagePath);

            //convert Buildings to json
            string jsonBuilding = JsonSerializer.Serialize(this.buildings);

            //write or create json file
            File.WriteAllText(Path.Combine(storagePath, "data.json"), jsonBuilding);
        }
    }
}
