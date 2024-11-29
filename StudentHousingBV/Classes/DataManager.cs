using System.Runtime.InteropServices;
using System.Text.Json;
using System.Reflection;
using StudentHousingBV.Classes;
using System.Linq.Expressions;

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
        private List<Classes.Rule> rules = new List<Classes.Rule>();
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

            LoadAllData();
            SaveAllData();
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
        public int GetIdFromClass(Classes.Rule rule, int buildingId)
        {
            int resultId = 0;

            LoadAttribute(() => rules);

            if (GetFlats(buildingId).Count > 0)
            {
                if(GetRules(buildingId).Count > 0)
                {
                    resultId = GetRules(buildingId).Max(rule => rule.RuleId);
                }
                
                foreach (Flat f in GetFlats(buildingId))
                {

                    if (GetRules(buildingId,f.FlatId).Count > 0 && GetRules(buildingId, f.FlatId).Max(rule => rule.RuleId) > resultId)
                    {
                        resultId = GetRules(buildingId, f.FlatId).Max(rule => rule.RuleId);
                    }
                }
            }

            return resultId;
        }


        /// <summary>
        /// Get the current highest ID assigned to an announcement
        /// </summary>
        public int GetIdFromClass(Announcement announcement, int buildingId)
        {
            int resultId = 0;

            LoadAttribute(() => announcements);

            if (GetFlats(buildingId).Count > 0)
            {
                if (GetGlobalAnnouncements().Count > 0)
                {
                    resultId = GetGlobalAnnouncements().Max(announcement => announcement.AnnouncementId);
                }

                foreach (Flat f in GetFlats(buildingId))
                {
                    if (GetAllAnnouncements(buildingId, f.FlatId).Count > 0 && GetAllAnnouncements(buildingId, f.FlatId).Max(announcement => announcement.AnnouncementId) > resultId)
                    {
                        resultId = GetAllAnnouncements(buildingId, f.FlatId).Max(announcement => announcement.AnnouncementId);
                    }
                }
            }

            return resultId;
        }

        /// <summary>
        /// Get the current highest ID assigned to an announcement, when the announcement is global
        /// </summary>
        public int GetIdFromClass(Announcement announcement)
        {
            int resultId = 0;

            LoadAttribute(() => announcements);

            foreach(Building b in buildings)
            {
                if (GetFlats(b.BuildingId).Count > 0)
                {
                    if (GetGlobalAnnouncements().Count > 0)
                    {
                        resultId = GetGlobalAnnouncements().Max(announcement => announcement.AnnouncementId);
                    }

                    foreach (Flat f in GetFlats(b.BuildingId))
                    {
                        if (GetAllAnnouncements(b.BuildingId, f.FlatId).Count > 0 && GetAllAnnouncements(b.BuildingId, f.FlatId).Max(announcement => announcement.AnnouncementId) > resultId)
                        {
                            resultId = GetAllAnnouncements(b.BuildingId, f.FlatId).Max(announcement => announcement.AnnouncementId);
                        }
                    }
                }
            }

            return resultId;
        }

        //----------------------------------------------------------------------------------------METHODS FOR RETRIEVING DATA----------------------------------------------------------------------------------------

        #region Getting Buildings
        //get one building
        public Building? GetBuilding(int buildingId)
        { return this.buildings.FirstOrDefault(building => building.BuildingId == buildingId); }

        //get all buildings
        public List<Building>? GetBuildings()
        { return this.buildings; }
        #endregion

        #region Getting Flats
        //get one flat
        public Flat? GetFlat(int buildingId, int flatId)
        { return flats.FirstOrDefault(flat => flat.BuildingId == buildingId && flat.FlatId == flatId); }

        //get all flats in a building
        public ICollection<Flat> GetFlats(int buildingId)
        { return flats.FindAll(flat => flat.BuildingId == buildingId); }

        public ICollection<Flat> GetFlats() { return flats; }
        #endregion

        #region Getting Students
        //get all students
        public ICollection<Student> GetStudents()
        { return students; }

        //get all students in a building
        public ICollection<Student> GetStudents(int buildingId)
        { return students.FindAll(student => student.BuildingId == buildingId); }

        //get all students in a flat
        public ICollection<Student>? GetStudents(int buildingId, int flatId)
        { return students.FindAll(student => student.BuildingId == buildingId && student.FlatId == flatId); }
        #endregion

        #region Getting Complaints
        //get all complaints of a flat
        public ICollection<Complaint>? GetComplaints(int buildingId, int flatId)
        { return this.GetFlat(buildingId, flatId)?.Complaints; }
        #endregion

        #region Getting Rules
        //get rules of a building
        public ICollection<Classes.Rule> GetRules(int buildingId)
        { return rules.FindAll(rule => rule.BuildingId == buildingId); }

        //get rules of a flat
        public ICollection<Classes.Rule> GetRules(int buildingId, int flatId)
        { return rules.FindAll(rule => rule.BuildingId == buildingId && rule.FlatId == flatId); }

        //get all rules of a flat and building
        public ICollection<Classes.Rule> GetAllRules(int buildingId, int flatId)
        { return rules.FindAll(rule => (rule.BuildingId == buildingId && rule.FlatId <= 0) || (rule.BuildingId == buildingId && rule.FlatId == flatId)); }

        //get all rules
        public ICollection<Classes.Rule> GetAllRules()
        { return rules; }
        #endregion

        #region Getting Announcements
        //get all announcements of a building
        public ICollection<Announcement> GetAnnouncements(int buildingId)
        { return announcements.FindAll(announcement => announcement.BuildingId == buildingId && announcement.AnnouncementId >= 0); }

        //get all announcements of a flat 
        public ICollection<Announcement> GetAnnouncements(int buildingId, int flatId)
        { return announcements.FindAll(announcement => announcement.BuildingId == buildingId && announcement.FlatId == flatId && announcement.AnnouncementId >= 0); }

        //get all global announcements
        public ICollection<Announcement> GetGlobalAnnouncements() 
        { return announcements.FindAll(announcement => announcement.IsGlobal == true && announcement.AnnouncementId >= 0); }

        //get all announcements
        public ICollection<Announcement> GetAllAnnouncements() 
        { return announcements; }

        //get building flat and global announcements
        public ICollection<Announcement> GetAllAnnouncements(int buildingId, int flatId)
        {
            return announcements.FindAll(announcement => (announcement.IsGlobal == true ||
            (announcement.BuildingId == buildingId && announcement.FlatId <= 0) ||
            (announcement.BuildingId == buildingId && announcement.FlatId == flatId)) && 
            announcement.AnnouncementId >= 0);
        }
        #endregion


        //----------------------------------------------------------------------------------------METHODS FOR SAVING & LOADING----------------------------------------------------------------------------------------

        public void LoadAllData()
        {
            buildings = LoadAttribute(() => buildings);
            flats = LoadAttribute(() => flats);
            groceries = LoadAttribute(() => groceries);
            rules = LoadAttribute(() => rules);
            students = LoadAttribute(() => students);
            complaints = LoadAttribute(() => complaints);
            agreements = LoadAttribute(() => agreements);
            announcements = LoadAttribute(() => announcements);
            chores = LoadAttribute(() => chores);
        }

        public void SaveAllData()
        {
            //Deleting any possibly invalid announcements
            if(announcements.Count > 0)
            {
                foreach (Announcement announcement in announcements)
                {
                    //Invalid announcements have an Id of -1
                    if (announcement.AnnouncementId < 0)
                    {
                        announcements.RemoveAt(announcements.IndexOf(announcement));
                    }
                }
            }

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
                    catch (Exception ex){}
                }

            }

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
