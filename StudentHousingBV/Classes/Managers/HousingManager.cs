using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Classes.Managers
{
    public class HousingManager
    {
        #region Fields
        private readonly List<Building> buildings;
        private readonly DataManager dataManager;
        #endregion

        #region Properties
        public List<Building> Buildings { get => buildings; }
        #endregion

        #region Constructors
        public HousingManager()
        {
            dataManager = new();
            buildings = dataManager.GetAllBuildings();
        }
        #endregion

        #region Methods
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

            if (dataManager.AddBuilding(building))
            {
                buildings.Add(building);
                result = true;
            }

            return result;
        }

        public bool DeleteBuilding(Building building)
        {
            bool result = false;
            if (!buildings.Contains(building))
            {
                throw new Exception("Building does not exist.");
            }
            else if (building.Flats.Count > 0)
            {
                throw new Exception("Building has flats assigned to it. Cannot remove.");
            }

            if (dataManager.DeleteBuilding(building.BuildingId))
            {
                buildings.Remove(building);
                result = true;
            }

            return result;
        }

        public bool UpdateBuilding(Building building)
        {
            bool result = false;
            if (!buildings.Contains(building))
            {
                throw new Exception("Building does not exist.");
            }

            if (dataManager.UpdateBuilding(building))
            {
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
            bool result = false;
            if (GetFlats().Contains(flat))
            {
                throw new Exception("Flat already exists.");
            }

            if (dataManager.AddFlat(flat))
            {
                flat.AssignedBuilding.Flats.Add(flat);
                result = true;
            }

            return result;
        }

        public bool UpdateFlat(Flat flat)
        {
            if (!GetFlats().Contains(flat))
            {
                throw new Exception("Flat does not exist.");
            }

            return dataManager.UpdateFlat(flat);
        }

        public bool DeleteFlat(Flat flat)
        {
            bool result = false;
            if (flat.Students.Count > 0)
            {
                throw new Exception("Flat has students assigned to it. Cannot remove.");
            }

            if (dataManager.DeleteFlat(flat.FlatId))
            {
                flat.AssignedBuilding.Flats.Remove(flat);
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
            if (dataManager.AddStudent(student))
            {
                student.AssignedFlat.Students.Add(student);
                result = true;
            }
            return result;
        }

        public bool UpdateStudent(Student student)
        {
            return dataManager.UpdateStudent(student);
        }

        // Remove student from flat and all related data
        public bool DeleteStudent(Student student)
        {
            bool result = false;

            if (dataManager.DeleteStudent(student))
            {
                foreach (Chore chore in student.AssignedFlat.Chores.FindAll(chore => chore.Assignee == student))
                {
                    if (dataManager.DeleteChore(chore.ChoreId))
                    {
                        student.AssignedFlat.Chores.Remove(chore);
                    }
                }
                foreach (Agreement agreement in student.AssignedFlat.Agreements.FindAll(agreement => agreement.Student == student))
                {
                    if (dataManager.DeleteAgreement(agreement.AgreementId))
                    {
                        student.AssignedFlat.Agreements.Remove(agreement);
                    }
                }
                foreach (Grocery grocery in student.AssignedFlat.Groceries.FindAll(grocery => grocery.Creator == student))
                {
                    if (dataManager.DeleteGrocery(grocery.GroceryId))
                    {
                        student.AssignedFlat.Groceries.Remove(grocery);
                    }
                }
                student.AssignedFlat.Students.Remove(student);
                result = true;
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

        public bool SubmitComplaint(Complaint complaint)
        {
            bool result = false;
            complaint.AssignedFlat.Complaints.Add(complaint);
            if (dataManager.AddComplaint(complaint))
            {
                result = true;
                MessageBox.Show("Saved");
            }
            return result;
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

        public List<Complaint> GetAllComplaintsDB()
        {
            return dataManager.GetAllComplaints();
        }

        public List<Complaint> GetComplaintsByFlatDB(int flatId)
        {
            return dataManager.GetComplaintByFlat(flatId);
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

        public bool UpdateRule(Rule rule)
        {
            return dataManager.UpdateRule(rule);
        }

        public bool AddRule(Rule rule)
        {
            rule.AssignedFlat?.Rules.Add(rule);
            return dataManager.AddRule(rule);
        }

        public bool RemoveRule(Rule rule)
        {
            rule.AssignedFlat?.Rules.Remove(rule);
            return dataManager.DeleteRule(rule.RuleId);
        }
        #endregion

        #region Announcement

        public List<Announcement> GetAnnouncementsByFlat(int flatId)
        {
            return dataManager.GetAnnouncementByFlat(flatId);
        }

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
                dataManager.DeleteAnnouncement(announcement.AnnouncementId);
                result = true;
            }
            return result;
        }

        public bool AddAnnouncement(Announcement announcement)
        {
            //announcement.AssignedFlat?.Announcements.Add(announcement);
            return dataManager.AddAnnouncement(announcement);
        }

        public bool UpdateAnnouncement(Announcement announcement)
        {
            return dataManager.UpdateAnnouncement(announcement);
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
                dataManager.DeleteAgreement(agreement.AgreementId);
                result = true;
            }
            return result;
        }

        public bool UpdateAgreement(Agreement agreement)
        {
            return dataManager.UpdateAgreement(agreement);
        }

        public bool AddAgreement(Agreement agreement)
        {
            agreement.AssignedFlat?.Agreements.Add(agreement);
            return dataManager.AddAgreement(agreement);
        }
        #endregion

        #region Chore
        /// <summary>
        /// Get the next available ID for a chore
        /// </summary>
        /// <returns> The next available ID for a chore </returns>
        /// 

        public List<Chore> GetChoresByFlatId(int flatId)
        {
            return dataManager.GetChoreByFlat(flatId);
        }

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

        public bool UpdateChore(Chore chore)
        {
            return dataManager.UpdateChore(chore);
        }

        public bool AddChore(Chore chore)
        {
            chore.AssignedFlat?.Chores.Add(chore);
            return dataManager.AddChore(chore);
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
                if (dataManager.AddGrocery(grocery))
                {
                    result = true;
                    MessageBox.Show("Saved");
                }
            }
            return result;
        }

        public List<Grocery> GetGroceryByFlat(int flatId)
        {
            return dataManager.GetGroceryByFlat(flatId);
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

