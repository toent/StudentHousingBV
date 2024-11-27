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


        //-------------------------------------------------------------------------------------METHODS FOR GETTING IDs-------------------------------------------------------------------------------------


        /// <summary>
        /// Get the current highest ID assigned to a building
        /// </summary>
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


        /// <summary>
        /// Get the current highest ID assigned to a flat
        /// </summary>
        public int GetIdFromClass(Flat flat, int buildingId)
        {
            int resultId = -1;

            LoadFromStorage();

            if (this.buildings[buildingId].Flats.Count > 0)
            {
                foreach (Flat f in this.GetFlats(buildingId))
                {
                    if (f.Id > resultId)
                    {
                        resultId = f.Id;
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

        //get all students in a flat
        public List<Student> GetStudents(int buildingId, int flatId) 
        { return this.GetFlats(buildingId).FirstOrDefault(flat => flat.Id == flatId).Students; }


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
                        this.buildings = deserializedJson;
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
            string jsonBuilding = JsonSerializer.Serialize(this.buildings);

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
