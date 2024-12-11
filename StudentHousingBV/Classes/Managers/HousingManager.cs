using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Classes.Managers
{
    public class HousingManager
    {
        #region Fields
        private List<Building> buildings;
        private readonly DataManager dataManager;
        private Student? loggedStudent;
        #endregion

        #region Properties
        public List<Building> Buildings { get => buildings; }
        public Student? LoggedStudent { get => loggedStudent; set => loggedStudent = value; }
        #endregion

        #region Constructors
        public HousingManager()
        {
            dataManager = new();
            buildings = dataManager.GetAllData();
        }
        #endregion

        #region Methods
        public void SaveAllData()
        {
            dataManager.SaveAllData(buildings);
        }

        public void LoadAllData()
        {
            buildings = dataManager.GetAllData();
        }
        #endregion

        #region ID Getters
        /// <summary>
        /// Get the next available ID for a building
        /// </summary>
        /// <returns> The next available ID for a building </returns>
        public int GetNextBuildingId()
        {
            LoadAllData();
            return buildings.Count > 0 ? buildings.Max(building => building.BuildingId) + 1 : 1;
        }

        /// <summary>
        /// Get the next available ID for a flat
        /// </summary>
        /// <returns> The next available ID for a flat </returns>
        public int GetNextFlatId()
        {
            LoadAllData();
            return GetAllFlats().Count > 0 ? GetAllFlats().Max(flat => flat.FlatId) + 1 : 1;
        }

        /// <summary>
        /// Get the next available ID for complaints
        /// </summary>
        /// <returns> The highest ID assigned to a complaint </returns>
        public int GetNextComplaintId()
        {
            LoadAllData();
            return GetAllComplaints().Count > 0 ? GetAllComplaints().Max(complaint => complaint.ComplaintId) + 1 : 1;
        }

        /// <summary>
        /// Get the next available ID for a rule
        /// </summary>
        /// <returns> The next available ID for a rule </returns>
        public int GetNextRuleId()
        {
            LoadAllData();
            return GetAllRules().Count > 0 ? GetAllRules().Max(rule => rule.RuleId) + 1 : 1;
        }

        /// <summary>
        ///  Get the next available ID for an announcement
        /// </summary>
        /// <returns> The next available ID for a announcement </returns>
        public int GetNextAnnouncementId()
        {
            LoadAllData();
            return GetAllAnnouncements().Count > 0 ? GetAllAnnouncements().Max(announcement => announcement.AnnouncementId) + 1 : 1;
        }

        /// <summary>
        /// Get the next available ID for an agreement
        /// </summary>
        /// <returns> The next available ID for an agreement </returns>
        public int GetNextAgreementId()
        {
            LoadAllData();
            return GetAllAgreements().Count > 0 ? GetAllAgreements().Max(agreement => agreement.AgreementId) + 1 : 1;
        }

        /// <summary>
        /// Get the next available ID for a chore
        /// </summary>
        /// <returns> The next available ID for a chore </returns>
        public int GetNextChoreId()
        {
            LoadAllData();
            return GetAllChores().Count > 0 ? GetAllChores().Max(chore => chore.ChoreId) + 1 : 1;
        }

        /// <summary>
        /// Get the next available ID for a grocery
        /// </summary>
        /// <returns> The next available ID for a grocery </returns>
        public int GetNextGroceryId()
        {
            LoadAllData();
            return GetAllGroceries().Count > 0 ? GetAllGroceries().Max(grocery => grocery.GroceryId) + 1 : 1;
        }
        #endregion

        #region Class Getters

        #region Getting Buildings
        /// <summary>
        /// Get all buildings
        /// </summary>
        /// <returns> A list of all buildings if they exist, otherwise null </returns>
        public List<Building> GetBuildings()
        {
            return buildings;
        }
        #endregion

        #region Getting Flats
        /// <summary>
        /// Get all flats
        /// </summary>
        /// <returns> A list of all flats if they exist, otherwise null </returns>
        public ICollection<Flat> GetAllFlats()
        {
            return buildings.SelectMany(building => building.Flats).ToList();
        }
        #endregion

        #region Getting Students
        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns> A list of all students if they exist, otherwise null </returns>
        public ICollection<Student> GetStudents()
        {
            return buildings.SelectMany(building => building.Flats)
                            .SelectMany(flat => flat.Students)
                            .ToList();
        }

        public Student? GetStudent(string studentId)
        {
            return buildings.SelectMany(building => building.Flats)
                            .SelectMany(flat => flat.Students)
                            .FirstOrDefault(student => student.StudentId == studentId);
        }
        #endregion

        #region Get all Complaints

        /// <summary>
        /// Get all complaints
        /// </summary>
        /// <returns> A list of all complaints</returns>
        public List<Complaint> GetAllComplaints()
        {
            return buildings.SelectMany(building => building.Flats)
                            .SelectMany(flat => flat.Complaints)
                            .ToList();
        }
        #endregion

        #region Getting Rules
        /// <summary>
        /// Get all rules
        /// </summary>
        /// <returns> A list of all rules if they exist, otherwise null </returns>
        public ICollection<Rule> GetAllRules()
        {
            return buildings.SelectMany(buildings => buildings.Flats)
                            .SelectMany(flat => flat.Rules)
                            .Concat(buildings.SelectMany(building => building.Rules))
                            .ToList();
        }
        #endregion

        #region Getting Announcements

        /// <summary>
        /// Get all global announcements
        /// </summary>
        /// <returns> A list of all global announcements if they exist, otherwise null </returns>
        public ICollection<Announcement> GetGlobalAnnouncements()
        {
            return buildings.SelectMany(building => building.Flats)
                            .SelectMany(flat => flat.Announcements)
                            .Where(announcement => announcement.IsGlobal)
                            .ToList();
        }

        /// <summary>
        /// Get all announcements
        /// </summary>
        /// <returns> A list of all announcements if they exist, otherwise null </returns>
        public ICollection<Announcement> GetAllAnnouncements()
        {
            return buildings.SelectMany(building => building.Flats)
                            .SelectMany(flat => flat.Announcements)
                            .ToList();
        }
        #endregion

        #region Getting Agreements
        /// <summary>
        /// Get all agreements
        /// </summary>
        /// <returns> A list of all agreements </returns>
        public ICollection<Agreement> GetAllAgreements()
        {
            return buildings.SelectMany(building => building.Flats)
                            .SelectMany(flat => flat.Agreements)
                            .ToList();
        }
        #endregion

        #region Getting Chores
        /// <summary>
        /// Get all chores
        /// </summary>
        /// <returns> A list of all chores </returns>
        public ICollection<Chore> GetAllChores()
        {
            return buildings.SelectMany(building => building.Flats)
                            .SelectMany(flat => flat.Chores)
                            .ToList();
        }
        #endregion

        #region Getting Groceries
        /// <summary>
        /// Get all groceries
        /// </summary>
        /// <returns> A list of all groceries </returns>
        public ICollection<Grocery> GetAllGroceries()
        {
            return buildings.SelectMany(building => building.Flats)
                            .SelectMany(flat => flat.Groceries)
                            .ToList();
        }
        #endregion

        #endregion
    }
}

