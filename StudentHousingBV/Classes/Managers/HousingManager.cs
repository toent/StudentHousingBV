using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Classes.Managers
{
    public class HousingManager
    {
        #region Fields
        private List<Building> buildings;
        private readonly DataManager dataManager;
        #endregion

        #region Properties
        public List<Building> Buildings { get => buildings; }
        #endregion

        #region Constructors
        public HousingManager()
        {
            dataManager = new();
            buildings = dataManager.GetAllData() ?? []; //Flagged as modify
        }
        #endregion

        #region Methods
        #region Serialization
        public void SaveAllData()
        {
            dataManager.SaveAllData(buildings);
        }

        public void LoadAllData()
        {
            buildings = dataManager.GetAllData() ?? [];
        }
        #endregion

        #region Building
        /// <summary>
        /// Get the next available ID for a building
        /// </summary>
        /// <returns> The next available ID for a building </returns>
        public int GetNextBuildingId()
        {
            return buildings.Count > 0 ? buildings.Max(building => building.BuildingId) + 1 : 1;
        }

        /// <summary>
        /// Get all buildings
        /// </summary>
        /// <returns> A list of all buildings if they exist, otherwise null </returns>
        public List<Building> GetBuildings()
        {
            return buildings;
        }

        public List<Building> GetBuildings(string filter)
        {
            return buildings.Where(building => building.Address.Contains(filter, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        public Building? GetBuilding(int buildingId) => buildings.FirstOrDefault(building => building.BuildingId == buildingId);

        public bool AddBuilding(Building building)
        {
            bool result = false;
            try
            {
                if (GetBuilding(building.BuildingId) is null)
                {
                    buildings.Add(building);
                    dataManager.SaveAllData(buildings);
                    result = true;
                }
            }
            catch
            {
                MessageBox.Show("There was an error adding the building.");
            }

            return result;
        }

        public bool DeleteBuilding(Building building)
        {
            bool result;
            if (!buildings.Contains(building))
            {
                throw new Exception("Building does not exist.");
            }
            else if (building.Flats.Count > 0)
            {
                throw new Exception("Building has flats assigned to it. Cannot remove.");
            }
            else
            {
                buildings.Remove(building);
                dataManager.SaveAllData(buildings);
                result = true;
            }

            return result;
        }

        public bool UpdateBuilding(Building building)
        {
            bool result;
            if (!buildings.Contains(building))
            {
                throw new Exception("Building does not exist.");
            }
            else
            {
                dataManager.SaveAllData(buildings);
                result = true;
            }
            return result;
        }

        #endregion

        #region Flat
        /// <summary>
        /// Get the next available ID for a flat
        /// </summary>
        /// <returns> The next available ID for a flat </returns>
        public int GetNextFlatId()
        {
            return GetFlats().Count > 0 ? GetFlats().Max(flat => flat.FlatId) + 1 : 1;
        }

        /// <summary>
        /// Get all flats
        /// </summary>
        /// <returns> A list of all flats if they exist, otherwise null </returns>
        public ICollection<Flat> GetFlats()
        {
            return buildings.SelectMany(building => building.Flats).ToList();
        }

        public static ICollection<Flat> GetFlats(Building building, string filter)
        {
            return building.Flats.Where(flat => flat.FlatNumber.ToString().Contains(filter, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        public bool AddFlat(Flat flat)
        {
            bool result;
            if (GetFlats().Contains(flat))
            {
                throw new Exception("Flat already exists.");
            }
            else
            {
                flat.AssignedBuilding.Flats.Add(flat);
                dataManager.SaveAllData(buildings);
                result = true;
            }
            return result;
        }

        public bool UpdateFlat(Flat flat)
        {
            bool result;
            if (!GetFlats().Contains(flat))
            {
                throw new Exception("Flat does not exist.");
            }
            else
            {
                dataManager.SaveAllData(buildings);
                result = true;
            }
            return result;
        }

        public bool DeleteFlat(Flat flat)
        {
            bool result;
            if (flat.Students.Count > 0)
            {
                throw new Exception("Flat has students assigned to it. Cannot remove.");
            }
            else
            {
                flat.AssignedBuilding.Flats.Remove(flat);
                dataManager.SaveAllData(buildings);
                result = true;
            }
            return result;
        }
        #endregion

        #region Student

        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns> A list of all students if they exist, otherwise null </returns>
        public ICollection<Student> GetAllStudents()
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

        public ICollection<Student> GetStudents(string filter)
        {
            return buildings.SelectMany(building => building.Flats)
                            .SelectMany(flat => flat.Students)
                            .Where(student => student.Name.Contains(filter, StringComparison.CurrentCultureIgnoreCase))
                            .ToList();
        }

        public bool AddStudent(Student student)
        {
            bool result = false;
            if (GetStudent(student.StudentId) is null)
            {
                student.AssignedFlat.Students.Add(student);
                dataManager.SaveAllData(buildings);
                result = true;
            }
            return result;
        }

        public bool UpdateStudent(Student student)
        {
            bool result = false;
            if (GetStudent(student.StudentId) is not null)
            {
                dataManager.SaveAllData(buildings);
                result = true;
            }
            return result;
        }

        // Remove student from flat and all related data
        public bool DeleteStudent(Student student)
        {
            bool result = false;

            try
            {
                if (GetStudent(student.StudentId) is not null)
                {
                    // Remove all related data from agreements, chores and groceries.
                    student.AssignedFlat.Agreements.RemoveAll(agreement => agreement.Student == student);
                    student.AssignedFlat.Chores.RemoveAll(chore => chore.Assignee == student);
                    student.AssignedFlat.Groceries.RemoveAll(grocery => grocery.Creator == student);

                    // Remove student from flat
                    student.AssignedFlat.Students.Remove(student);

                    // Save data
                    dataManager.SaveAllData(buildings);
                    result = true;
                }
            }
            catch
            {
                MessageBox.Show("There was an error deleting the student.");
            }

            return result;
        }
        #endregion

        #region Complaint
        /// <summary>
        /// Get the next available ID for complaints
        /// </summary>
        /// <returns> The highest ID assigned to a complaint </returns>
        public int GetNextComplaintId()
        {
            return GetAllComplaints().Count > 0 ? GetAllComplaints().Max(complaint => complaint.ComplaintId) + 1 : 1;
        }

        public void SubmitComplaint(Complaint complaint)
        {
            complaint.AssignedFlat.Complaints.Add(complaint);
        }

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

        #region Rule
        /// <summary>
        /// Get the next available ID for a rule
        /// </summary>
        /// <returns> The next available ID for a rule </returns>
        public int GetNextRuleId()
        {
            return GetAllRules().Count > 0 ? GetAllRules().Max(rule => rule.RuleId) + 1 : 1;
        }

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

        #region Announcement
        /// <summary>
        ///  Get the next available ID for an announcement
        /// </summary>
        /// <returns> The next available ID for a announcement </returns>
        public int GetNextAnnouncementId()
        {
            return GetAllAnnouncements().Count > 0 ? GetAllAnnouncements().Max(announcement => announcement.AnnouncementId) + 1 : 1;
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

        public bool DeleteAnnouncement(Announcement announcement)
        {
            bool result = false;
            if (announcement.AssignedFlat is not null)
            {
                announcement.AssignedFlat.Announcements.Remove(announcement);
                SaveAllData();
                result = true;
            }
            return result;
        }

        public bool AddAnnouncement(Announcement announcement)
        {
            bool result = false;
            if (GetAllAnnouncements().FirstOrDefault(a => a.AnnouncementId == announcement.AnnouncementId) is null)
            {
                announcement.AssignedFlat.Announcements.Add(announcement);
                result = true;
                if (dataManager.AddAnnouncement(announcement))
                {
                    MessageBox.Show("Saved");
                }
            }
            return result;
        }
        #endregion

        #region Agreement
        /// <summary>
        /// Get the next available ID for an agreement
        /// </summary>
        /// <returns> The next available ID for an agreement </returns>
        public int GetNextAgreementId()
        {
            return GetAllAgreements().Count > 0 ? GetAllAgreements().Max(agreement => agreement.AgreementId) + 1 : 1;
        }

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

        public bool DeleteAgreement(Agreement agreement)
        {
            bool result = false;
            if (agreement.AssignedFlat is not null)
            {
                agreement.AssignedFlat.Agreements.Remove(agreement);
                SaveAllData();
                result = true;
            }
            return result;
        }
        #endregion

        #region Chore
        /// <summary>
        /// Get the next available ID for a chore
        /// </summary>
        /// <returns> The next available ID for a chore </returns>
        public int GetNextChoreId()
        {
            return GetAllChores().Count > 0 ? GetAllChores().Max(chore => chore.ChoreId) + 1 : 1;
        }

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

        #region Grocery
        /// <summary>
        /// Get the next available ID for a grocery
        /// </summary>
        /// <returns> The next available ID for a grocery </returns>
        public int GetNextGroceryId()
        {
            return GetAllGroceries().Count > 0 ? GetAllGroceries().Max(grocery => grocery.GroceryId) + 1 : 1;
        }

        /// <summary>
        /// Add a grocery to the list of groceries
        /// </summary>
        /// <param name="grocery"></param>
        /// <returns></returns>
        public bool AddGrocery(Grocery grocery)
        {
            bool result = false;
            if (GetAllGroceries().FirstOrDefault(g => g.GroceryId == grocery.GroceryId) is null)
            {
                grocery.AssignedFlat.Groceries.Add(grocery);
                result = true;
                dataManager.SaveAllData(buildings);
            }
            return result;
        }

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

