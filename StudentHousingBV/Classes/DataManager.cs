using System.Linq.Expressions;
using System.Text.Json;

namespace StudentHousingBV.Classes
{
    public class DataManager
    {
        #region Fields
        private readonly string storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Storage");
        private readonly bool directoryExists = false;
        private List<Building> buildings = [];
        private List<Flat> flats = [];
        private List<Announcement> announcements = [];
        private List<Agreement> agreements = [];
        private List<Chore> chores = [];
        private List<Complaint> complaints = [];
        private List<Student> students = [];
        private List<Rule> rules = [];
        private List<Grocery> groceries = [];
        #endregion

        #region TestingProperties [TO DELETE] (Create accessor methods)
        public List<Building> Buildings { get => buildings; set => buildings = value; }
        public List<Flat> Flats { get => flats; set => flats = value; }
        public List<Announcement> Announcements { get => announcements; set => announcements = value; }
        public List<Agreement> Agreements { get => agreements; set => agreements = value; }
        public List<Chore> Chores { get => chores; set => chores = value; }
        public List<Complaint> Complaints { get => complaints; set => complaints = value; }
        public List<Student> Students { get => students; set => students = value; }
        public List<Rule> Rules { get => rules; set => rules = value; }
        public List<Grocery> Groceries { get => groceries; set => groceries = value; }
        #endregion

        #region Constructors
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
            LoadAllData();
            SaveAllData();
        }
        #endregion

        #region ID Getters
        /// <summary>
        /// Get the next available ID for a building
        /// </summary>
        /// <returns> The next available ID for a building </returns>
        public int GetNextBuildingId()
        {
            int resultId;
            LoadAttribute(() => buildings);
            if(buildings.Count > 0)
            {
                resultId = buildings.Max(building => building.BuildingId) + 1;
            }else if (buildings.Count == 0)
            {
                resultId = 1;
            }
            else
            {
                resultId = 0;
            }
            return resultId;
        }

        /// <summary>
        /// Get the next available ID for a flat
        /// </summary>
        /// <returns> The next available ID for a flat </returns>
        public int GetNextFlatId()
        {
            int resultId;
            LoadAttribute(() => flats);
            if (flats.Count > 0)
            {
                resultId = flats.Max(flat => flat.FlatId) + 1;
            }
            else if (flats.Count == 0)
            {
                resultId = 1;
            }
            else
            {
                resultId = 0;
            }
            return resultId;
        }

        /// <summary>
        /// Get the next available ID for complaints
        /// </summary>
        /// <returns> The highest ID assigned to a complaint </returns>
        public int GetNextComplaintId()
        {
            int resultId;
            LoadAttribute(() => complaints);
            if (complaints.Count > 0)
            {
                resultId = complaints.Max(complaint => complaint.ComplaintId) + 1;
            }
            else if (complaints.Count == 0)
            {
                resultId = 1;
            }
            else
            {
                resultId = 0;
            }
            return resultId;
        }

        /// <summary>
        /// Get the next available ID for a rule
        /// </summary>
        /// <returns> The next available ID for a rule </returns>
        public int GetNextRuleId()
        {
            int resultId;
            LoadAttribute(() => rules);
            if (rules.Count > 0)
            {
                resultId = rules.Max(rule => rule.RuleId) + 1;
            }
            else if (rules.Count == 0)
            {
                resultId = 1;
            }
            else
            {
                resultId = 0;
            }
            return resultId;
        }

        /// <summary>
        ///  Get the next available ID for an announcement
        /// </summary>
        /// <returns> The next available ID for a announcement </returns>
        public int GetNextAnnouncementId()
        {
            int resultId;
            LoadAttribute(() => announcements);
            if (announcements.Count > 0)
            {
                resultId = announcements.Max(announcement => announcement.AnnouncementId) + 1;
            }
            else if (announcements.Count == 0)
            {
                resultId = 1;
            }
            else
            {
                resultId = 0;
            }
            return resultId;
        }

        /// <summary>
        /// Get the next available ID for an agreement
        /// </summary>
        /// <returns> The next available ID for an agreement </returns>
        public int GetNextAgreementId()
        {
            int resultId;
            LoadAttribute(() => agreements);
            if (agreements.Count > 0)
            {
                resultId = agreements.Max(agreement => agreement.AgreementId) + 1;
            }
            else if (agreements.Count == 0)
            {
                resultId = 1;
            }
            else
            {
                resultId = 0;
            }
            return resultId;
        }

        /// <summary>
        /// Get the next available ID for a chore
        /// </summary>
        /// <returns> The next available ID for a chore </returns>
        public int GetNextChoreId()
        {
            int resultId;
            LoadAttribute(() => chores);
            if (chores.Count > 0)
            {
                resultId = chores.Max(chore => chore.ChoreId) + 1;
            }
            else if (chores.Count == 0)
            {
                resultId = 1;
            }
            else
            {
                resultId = 0;
            }
            return resultId;
        }

        /// <summary>
        /// Get the next available ID for a grocery
        /// </summary>
        /// <returns> The next available ID for a grocery </returns>
        public int GetNextGroceryId()
        {
            int resultId;
            LoadAttribute(() => groceries);
            if (groceries.Count > 0)
            {
                resultId = groceries.Max(grocery => grocery.GroceryId) + 1;
            }
            else if (groceries.Count == 0)
            {
                resultId = 1;
            }
            else
            {
                resultId = 0;
            }
            return resultId;
        }
        #endregion

        #region Class Getters

        #region Getting Buildings

        /// <summary>
        /// Get a building by its ID
        /// </summary>
        /// <param name="buildingId"> The ID of the building to get </param>
        /// <returns> The building with the specified ID if it exists, otherwise null </returns>
        public Building? GetBuilding(int buildingId)
        {
            return buildings.FirstOrDefault(building => building.BuildingId == buildingId);
        }

        /// <summary>
        /// Get all buildings
        /// </summary>
        /// <returns> A list of all buildings if they exist, otherwise null </returns>
        public List<Building>? GetBuildings()
        {
            return buildings;
        }
        #endregion

        #region Getting Flats
        /// <summary>
        /// Get a flat by its ID
        /// </summary>
        /// <param name="flatId"> The ID of the flat to get </param>
        /// <returns> The flat with the specified ID if it exists, otherwise null </returns>
        public Flat? GetFlat(int flatId)
        {
            return flats.FirstOrDefault(flat => flat.FlatId == flatId);
        }

        /// <summary>
        /// Get all flats
        /// </summary>
        /// <returns> A list of all flats if they exist, otherwise null </returns>
        public ICollection<Flat> GetFlats()
        {
            return flats;
        }

        /// <summary>
        /// Get all flats in a building
        /// </summary>
        /// <param name="buildingId"> The ID of the building to get the flats from </param>
        /// <returns> A list of all flats in the building if they exist, otherwise null </returns>
        public ICollection<Flat> GetFlatsFromBuilding(int buildingId)
        {
            return flats.FindAll(flat => flat.BuildingId == buildingId);
        }
        #endregion

        #region Getting Students
        /// <summary>
        /// Get a student by their ID
        /// </summary>
        /// <param name="studentId"> The ID of the student to get </param>
        /// <returns> The student with the specified ID if they exist, otherwise null </returns>
        public Student? GetStudent(string studentId)
        {
            return students.FirstOrDefault(student => student.StudentId == studentId);
        }

        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns> A list of all students if they exist, otherwise null </returns>
        public ICollection<Student> GetStudents()
        {
            return students;
        }

        /// <summary>
        /// Get all students in a building
        /// </summary>
        /// <param name="buildingId"> The ID of the building to get the students from </param>
        /// <returns> A list of all students in the building if they exist, otherwise null </returns>
        public ICollection<Student> GetStudentsInBuilding(int buildingId)
        {
            return students.FindAll(student => student.BuildingId == buildingId);
        }

        public ICollection<Student> GetStudentsInFlat(int flatId)
        {
            return students.FindAll(student => student.FlatId == flatId);
        }

        /// <summary>
        /// Get all students in a flat
        /// </summary>
        /// <param name="buildingId"> The ID of the building the flat is in </param>
        /// <param name="flatId"> The ID of the flat to get the students from </param>
        /// <returns> A list of all students in the flat if they exist, otherwise null </returns>
        public ICollection<Student>? GetStudents(int buildingId, int flatId)
        {
            return students.FindAll(student => student.BuildingId == buildingId && student.FlatId == flatId);
        }
        #endregion

        #region Getting Complaint by flatId

        /// <summary>
        /// Get a complaint by its ID
        /// </summary>
        /// <param name="flatId"> The ID of the flat the complaint is in </param>
        /// <returns> The complaint with the specified ID if it exists, otherwise null </returns>
        public ICollection<Complaint>? GetComplaints(int flatId)
        {
            return GetFlat(flatId)?.Complaints;
        }
        #endregion

        #region Get all Complaints
        
        public List<Complaint> GetAllComplaints()
        {
            return complaints;
        }
        #endregion

        #region Getting Rules
        /// <summary>
        /// Get all rules
        /// </summary>
        /// <returns> A list of all rules if they exist, otherwise null </returns>
        public ICollection<Rule> GetAllRules()
        {
            return rules;
        }

        /// <summary>
        /// Get all rules of a building
        /// </summary>
        /// <param name="buildingId"> The ID of the building to get the rules from </param>
        /// <returns> A list of all rules in the building if they exist, otherwise null </returns>
        public ICollection<Rule> GetRulesBuilding(int buildingId)
        {
            return rules.FindAll(rule => rule.BuildingId == buildingId);
        }

        /// <summary>
        /// Get all rules of a flat and building
        /// </summary>
        /// <param name="buildingId"> The ID of the building to get the rules from </param>
        /// <param name="flatId"> The ID of the flat to get the rules from </param>
        /// <returns> A list of all rules in the flat and building if they exist, otherwise null </returns>
        public ICollection<Rule> GetRulesFlat(int flatId)
        {
            return rules.FindAll(rule => rule.FlatId == flatId);
        }

        /// <summary>
        /// Get all rules
        /// </summary>
        /// <param name="buildingId"> The ID of the building to get the rules from </param>
        /// <param name="flatId"> The ID of the flat to get the rules from </param>
        /// <returns> A list of all rules if they exist, otherwise null </returns>
        public ICollection<Rule> GetRulesFlatBuilding(int buildingId, int flatId)
        {
            return rules.FindAll(rule => rule.BuildingId == buildingId && (rule.FlatId <= 0 || rule.FlatId == flatId));
        }


        #endregion

        #region Getting Announcements
        /// <summary>
        /// Get all announcements of a building
        /// </summary>
        /// <param name="buildingId"> The ID of the building to get the announcements from </param>
        /// <returns> A list of all announcements in the building if they exist, otherwise null </returns>
        public ICollection<Announcement> GetAnnouncementsFromBuilding(int buildingId)
        {
            return announcements.FindAll(announcement => announcement.BuildingId == buildingId);
        }

        /// <summary>
        /// Get all announcements of a flat and building
        /// </summary>
        /// <param name="buildingId"> The ID of the building to get the announcements from </param>
        /// <param name="flatId"> The ID of the flat to get the announcements from </param>
        /// <returns> A list of all announcements in the flat and building if they exist, otherwise null </returns>
        public ICollection<Announcement> GetAnnouncementsFromFlat(int flatId)
        {
            return announcements.FindAll(announcement => announcement.FlatId == flatId);
        }

        /// <summary>
        /// Get all global announcements
        /// </summary>
        /// <returns> A list of all global announcements if they exist, otherwise null </returns>
        public ICollection<Announcement> GetGlobalAnnouncements()
        {
            return announcements.FindAll(announcement => announcement.IsGlobal);
        }

        /// <summary>
        /// Get all announcements
        /// </summary>
        /// <returns> A list of all announcements if they exist, otherwise null </returns>
        public ICollection<Announcement> GetAllAnnouncements()
        {
            return announcements;
        }

        /// <summary>
        /// Get all announcements of a building and flat
        /// </summary>
        /// <param name="buildingId"> The ID of the building to get the announcements from </param>
        /// <param name="flatId"> The ID of the flat to get the announcements from </param>
        /// <returns> A list of all announcements in the building and flat if they exist, otherwise null </returns>
        public ICollection<Announcement> GetAllAnnouncementsBuildingFlat(int buildingId, int flatId)
        {
            return announcements.FindAll(announcement =>
                announcement.IsGlobal ||
                (announcement.BuildingId == buildingId && (announcement.FlatId <= 0 || announcement.FlatId == flatId))
            );
        }
        #endregion

        #region Getting Agreements
        public ICollection<Agreement> GetAgreements() 
        { 
            return agreements; 
        }

        public ICollection<Agreement> GetFlatAgreements(int flatId)
        {
            return agreements.FindAll(agreement => agreement.FlatId == flatId);
        }
        #endregion

        #region Getting Chores
        public ICollection<Chore> GetChores()
        {
            return chores;
        }

        public ICollection<Chore> GetFlatChores(int flatId)
        {
            return chores.FindAll(chores => chores.FlatId == flatId);
        }

        public ICollection<Chore> GetStudentChores(string assigneeId)
        {
            return chores.FindAll(chores=> chores.Assignee?.StudentId == assigneeId);
        }
        #endregion

        #region Getting Groceries

        public ICollection<Grocery> GetGroceries()
        {
            return groceries;
        }

        public ICollection<Grocery> GetFlatGroceries(int flatId)
        {
            return groceries.FindAll(grocery =>  grocery.FlatId == flatId);
        }

        #endregion

        #endregion

        #region Serialization

        /// <summary>
        /// Load all data from the storage directory
        /// </summary>
        public void LoadAllData()
        {
            buildings = LoadAttribute(() => buildings) ?? [];
            flats = LoadAttribute(() => flats) ?? [];
            groceries = LoadAttribute(() => groceries) ?? [];
            rules = LoadAttribute(() => rules) ?? [];
            students = LoadAttribute(() => students) ?? [];
            complaints = LoadAttribute(() => complaints) ?? [];
            agreements = LoadAttribute(() => agreements) ?? [];
            announcements = LoadAttribute(() => announcements) ?? [];
            chores = LoadAttribute(() => chores) ?? [];
        }

        /// <summary>
        /// Save all data to the storage directory
        /// </summary>
        public void SaveAllData()
        {
            // Deleting any possibly invalid announcements
            announcements = announcements.Where(announcement => announcement.AnnouncementId >= 0).ToList();
            SaveAttributes();
        }

        /// <summary>
        /// Save all attributes
        /// </summary>
        public void SaveAttributes()
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



        /// <summary>
        /// Load a list from the storage directory
        /// </summary>
        /// <typeparam name="T"> The type of the list </typeparam>
        /// <param name="listExpression"> The list to load </param>
        /// <returns> The list if it exists, otherwise null </returns>
        public List<T>? LoadAttribute<T>(Expression<Func<List<T>>> listExpression)
        {
            string jsonName = GetListName(listExpression);
            string filePath = Path.Combine(storagePath, $"{jsonName}.json");

            if (!directoryExists || !File.Exists(filePath))
            {
                return null;
            }

            try
            {
                string extractedJson = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(extractedJson);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error loading {jsonName}: {ex.Message}");
            }

            return null;
        }


        /// <summary>
        /// Save a list to the storage directory
        /// </summary>
        /// <typeparam name="T"> The type of the list </typeparam>
        /// <param name="listExpression"> The list to save </param>
        public void SaveAttribute<T>(Expression<Func<List<T>>> listExpression)
        {
            string jsonName = GetListName(listExpression);
            string jsonData = JsonSerializer.Serialize(listExpression.Compile().Invoke());

            if (!directoryExists) return;

            string filePath = Path.Combine(storagePath, $"{jsonName}.json");

            File.WriteAllText(filePath, jsonData);
        }


        /// <summary>
        /// Get the name of a list
        /// </summary>
        /// <typeparam name="T"> The type of the list </typeparam>
        /// <param name="expression"> The list to get the name from </param>
        /// <returns> The name of the list </returns>
        /// <exception cref="ArgumentException"> Thrown when the expression is not a member expression </exception>
        public static string GetListName<T>(Expression<Func<List<T>>> expression)
        {
            if (expression.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member.Name;
            }
            throw new ArgumentException("The expression does not specify a valid member.");
        }


        /// <summary>
        /// Get the path of the storage directory
        /// </summary>
        /// <returns> The path of the storage directory </returns>
        public string GetFilePath()
        {
            return storagePath;
        }
    }
    #endregion

}
