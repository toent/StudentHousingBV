using System.Runtime.InteropServices;
using System.Text.Json;
using System.Reflection;
using StudentHousingBV.Classes;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace StudentHousingBV.Classes
{
    public class DataManager
    {
        private List<Building> buildings = new List<Building>();
        private List<Flat> flats = new List<Flat>();
        private List<Announcement> announcements = new List<Announcement>();
        private List<Agreement> agreements = new List<Agreement>();
        private List<Chore> chores = new List<Chore>();
        private List<Complaint> complaints = new List<Complaint>();
        private List<Student> students = new List<Student>();
        private List<Rule> rules = new List<Rule>();
        private List<Grocery> groceries = new List<Grocery>();


        private string storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage");
        private bool directoryExists = false;

        public DataManager()
        {
            Directory.CreateDirectory(storagePath);
            if (Directory.Exists(storagePath))
            {
                directoryExists = true;
            }
            else
            {
                directoryExists = false;
            }
            SaveAllData();
            LoadAllData();
        }


        //-------------------------------------------------------------------------------------METHODS FOR GETTING IDs-------------------------------------------------------------------------------------


        /// <summary>
        /// Get the current highest ID assigned to a building
        /// </summary>
        public int GetIdFromClass(Building building)
        {
            int resultId = 0;

            LoadAttribute(() => buildings);

            if (buildings.Count > 0)
            {

                resultId = buildings.Max(building => building.BuildingId);
            }

            return resultId;
        }


        /// <summary>
        /// Get the current highest ID assigned to a flat
        /// </summary>
        public int GetIdFromClass(Flat flat, int buildingId)
        {
            int resultId = 0;

            LoadAttribute(() => flats);

            if (GetFlats(buildingId).Count > 0)
            {
                resultId = GetFlats(buildingId).Max(flat => flat.FlatId);
            }

            return resultId;
        }


        /// <summary>
        /// Get the current highest ID assigned to a complaint
        /// </summary>
        public int GetIdFromClass(Complaint complaint, int buildingId, int flatId)
        {
            int resultId = 0;

            LoadAttribute(() => complaints);

            if (buildings.FirstOrDefault(building => building.BuildingId == buildingId)?.Flats.Count > 0)
            {

                resultId = GetComplaints(buildingId, flatId).Max(complaint => complaint.ComplaintId);
            }

            return resultId;
        }

        /// <summary>
        /// Get the current highest ID assigned to a rule
        /// </summary>
        public int GetIdFromClass(Rule rule, int buildingId)
        {
            int resultId = 0;

            LoadAttribute(() => rules);

            if (GetFlats(buildingId).Count > 0)
            {
                resultId = GetRules(buildingId).Max(rule => rule.RuleId);

                foreach (Flat f in GetFlats(buildingId))
                {
                    if (GetRules(buildingId, f.FlatId).Max(rule => rule.RuleId) > resultId)
                    {
                        resultId = GetRules(buildingId, f.FlatId).Max(rule => rule.RuleId);
                    }
                }
            }

            return resultId;
        }


        //----------------------------------------------------------------------------------------ALL OTHER METHODS----------------------------------------------------------------------------------------

        //get one building
        public Building? GetBuilding(int buildingId)
        { return this.buildings.FirstOrDefault(building => building.BuildingId == buildingId); }

        //get all buildings
        public List<Building>? GetBuildings()
        { return this.buildings; }

        //get one flat
        public Flat? GetFlat(int buildingId, int flatId)
        { return flats.FirstOrDefault(flat => flat.BuildingId == buildingId && flat.FlatId == flatId); }

        //get all flats in a building
        public ICollection<Flat> GetFlats(int buildingId)
        { return flats.FindAll(flat => flat.BuildingId == buildingId); }

        public ICollection<Flat> GetFlats() { return flats; }

        //get all students
        public ICollection<Student> GetStudents()
        { return students; }

        //get all students in a building
        public ICollection<Student> GetStudents(int buildingId)
        { return students.FindAll(student => student.BuildingId == buildingId); }

        //get all students in a flat
        public ICollection<Student>? GetStudents(int buildingId, int flatId)
        { return students.FindAll(student => student.BuildingId == buildingId && student.FlatId == flatId); }

        //get all complaints of a flat
        public ICollection<Complaint>? GetComplaints(int buildingId, int flatId)
        { return this.GetFlat(buildingId, flatId)?.Complaints; }

        //get rules of a building
        public ICollection<Rule> GetRules(int buildingId)
        { return rules.FindAll(rule => rule.BuildingId == buildingId); }

        //get rules of a flat
        public ICollection<Rule> GetRules(int buildingId, int flatId)
        { return rules.FindAll(rule => rule.BuildingId == buildingId && rule.FlatId == flatId); }

        //get all rules of flat and building
        public ICollection<Rule> GetAllRules(int buildingId, int flatId)
        { return rules.FindAll(rule => rule.BuildingId == buildingId || (rule.BuildingId == buildingId && rule.FlatId == flatId)); }

        public void LoadAllData()
        {
            LoadAttribute(() => buildings);
            LoadAttribute(() => flats);
            LoadAttribute(() => groceries);
            LoadAttribute(() => rules);
            LoadAttribute(() => students);
            LoadAttribute(() => complaints);
            LoadAttribute(() => agreements);
            LoadAttribute(() => announcements);
            LoadAttribute(() => chores);
        }

        public void SaveAllData()
        {
            SaveAttribute(() => buildings);
            SaveAttribute(() => flats);
            SaveAttribute(() => groceries);
            SaveAttribute(() => rules);
            SaveAttribute(() => students);
            SaveAttribute(() => complaints);
            SaveAttribute(() => agreements);
            SaveAttribute(() => announcements);
            SaveAttribute(() => chores);
        }


        public List<T>? LoadAttribute<T>(Expression<Func<List<T>>> listExpression)
        {
            string jsonName = GetListName(listExpression);

            if (directoryExists)
            {
                string filePath = Path.Combine(storagePath, $"{jsonName}.json");

                if (File.Exists(filePath))
                {
                    try
                    {
                        string extractedJson = File.ReadAllText(filePath);

                        List<T>? deserializedJson = JsonSerializer.Deserialize<List<T>>(extractedJson);
                        return deserializedJson;
                    }
                    catch (Exception ex)
                    {
                        // Log the error or handle it as needed (e.g., deserialization issues)
                        Console.WriteLine($"Error deserializing {jsonName}.json: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"File {jsonName}.json not found.");
                }
            }

            // Return null if loading fails or the file doesn't exist
            return null;
        }

        public void SaveAttribute<T>(Expression<Func<List<T>>> listExpression)
        {
            string jsonName = GetListName(listExpression);

            string jsonData = JsonSerializer.Serialize(listExpression.Compile().Invoke());

            if (directoryExists)
            {
                string filePath = Path.Combine(storagePath, $"{jsonName}.json");

                File.WriteAllText(filePath, jsonData);
            }
        }

        public static string GetListName<T>(Expression<Func<List<T>>> expression)
        {
            if (expression.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member.Name;
            }
            throw new ArgumentException("");
        }

        public string GetFilePath() { return storagePath; }
    }
            

}
