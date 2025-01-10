using StudentHousingBV.Classes.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StudentHousingBV.Classes.Managers
{
    public class DataManager
    {
        #region Fields
        private readonly string storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage");
        private readonly bool directoryExists = false;
        private const string JSON_NAME = "Data";
        private readonly JsonSerializerOptions jsonOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true
        };
        #endregion

        #region Constructors
        public DataManager()
        {
            Directory.CreateDirectory(storagePath);
            directoryExists = Directory.Exists(storagePath);
        }
        #endregion

        #region Serialization

        /// <summary>
        /// Load all data from the storage directory
        /// </summary>
        public List<Building>? GetAllData()
        {
            string filePath = Path.Combine(storagePath, "Data.json");
            if (!directoryExists || !File.Exists(filePath))
            {
                return null;
            }
            try
            {
                string extractedJson = File.ReadAllText(filePath);
                var buildings = JsonSerializer.Deserialize<List<Building>>(extractedJson, jsonOptions);
                ReLinkAllData(buildings);
                return buildings;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading buildings: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Re-link all data after deserialization
        /// </summary>
        /// <param name="buildings"> The list of buildings to re-link </param>
        private static void ReLinkAllData(List<Building>? buildings)
        {
            if (buildings != null)
            {
                foreach (Building building in buildings)
                {
                    foreach (Flat flat in building.Flats)
                    {
                        flat.AssignedBuilding = building;
                        foreach (Chore chore in flat.Chores)
                        {
                            chore.AssignedFlat = flat;
                        }
                        foreach (Student student in flat.Students)
                        {
                            student.AssignedFlat = flat;
                        }
                        foreach (Agreement agreement in flat.Agreements)
                        {
                            agreement.AssignedFlat = flat;
                        }
                        foreach (Grocery grocery in flat.Groceries)
                        {
                            grocery.AssignedFlat = flat;
                        }
                        foreach (Announcement announcement in flat.Announcements)
                        {
                            announcement.AssignedFlat = flat;
                        }
                        foreach (Rule rule in flat.Rules)
                        {
                            rule.AssignedFlat = flat;
                        }
                        foreach (Complaint complaint in flat.Complaints)
                        {
                            complaint.AssignedFlat = flat;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Save all data to the storage directory
        /// </summary>
        public void SaveAllData(List<Building> buildings)
        {
            if (directoryExists)
            {
                string jsonData = JsonSerializer.Serialize(buildings, jsonOptions);
                string filePath = Path.Combine(storagePath, $"{JSON_NAME}.json");
                File.WriteAllText(filePath, jsonData);
            }
        }

        /// <summary>
        /// Get the path of the storage directory
        /// </summary>
        /// <returns> The path of the storage directory </returns>
        public string GetFilePath()
        {
            return storagePath;
        }
        #endregion

        #region Methods

        public static bool CheckIfDataExists()
        {
            string filePath = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage"), "Data.json");
            return File.Exists(filePath);
        }

        #endregion
    }
}
