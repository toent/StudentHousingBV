using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.CompilerServices;

namespace StudentHousingBV
{
    public class DataManager
    {
        private List<Building> buildings;

        public DataManager() 
        {
            this.buildings = new List<Building>();
            LoadFromStorage();
        }

        //Class to get the latests id of a class from the storage
        public int GetIdFromClass(Building building)
        {
            int resultId = -1;

            LoadFromStorage();

            if (this.buildings.Count > 0)
            {
                foreach (Building b in this.buildings)
                {
                    if (b.Id > resultId)
                    {
                        resultId = b.Id;
                    }
                }
            }

            return resultId;
        }

        //get all buildings aka all the available data
        public List<Building> GetBuildings() 
        { return this.buildings; }

        //set the buildings in the datamanager
        public void SetBuildings(List<Building> newBuildings)
        { this.buildings = newBuildings; }


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
                    if(deserializedJson != null)
                    {
                        //if not null add to buildings
                        this.buildings = deserializedJson;
                    } 
                }
                catch (Exception ex)
                {
                    //catch exception
                }
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
