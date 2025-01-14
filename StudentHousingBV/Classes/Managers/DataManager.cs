using Microsoft.Data.SqlClient;
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
        private readonly string CONNECTION_STRING = "Server=tcp:s1aurbano.database.windows.net,1433;Initial Catalog=StudentHousing;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=Active Directory Interactive;";
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
                MessageBox.Show($"Error loading buildings: {ex.Message}");
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
                        foreach (Classes.Entities.Rule rule in flat.Rules)
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

        #region Database
        // CRUD for Building
        public bool AddBuilding(Building building)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "INSERT INTO Building (Address) VALUES (@Address)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Address", building.Address);
                command.ExecuteNonQuery();
                foreach (Flat flat in building.Flats)
                {
                    if (GetFlat(flat.FlatId) == null)
                    {
                        AddFlat(flat);
                    }
                    else
                    {
                        UpdateFlat(flat);
                    }
                }
                foreach (Flat flat in building.Flats)
                {
                    if (flat.AssignedBuilding.BuildingId == building.BuildingId && !building.Flats.Contains(flat))
                    {
                        DeleteFlat(flat.FlatId);
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding building: {ex.Message}");
            }
            return result;
        }
        public bool UpdateBuilding(Building building)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "UPDATE Building SET Address = @Address WHERE BuildingId = @BuildingId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Address", building.Address);
                command.Parameters.AddWithValue("@BuildingId", building.BuildingId);
                command.ExecuteNonQuery();
                foreach (Flat flat in building.Flats)
                {
                    if (GetFlat(flat.FlatId) == null)
                    {
                        AddFlat(flat);
                    }
                    else
                    {
                        UpdateFlat(flat);
                    }
                }
                foreach (Flat flat in GetFlatByBuilding(building.BuildingId))
                {
                    if (flat.AssignedBuilding.BuildingId == building.BuildingId && !building.Flats.Contains(flat))
                    {
                        DeleteFlat(flat.FlatId);
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating building: {ex.Message}");
            }
            return result;
        }
        public bool DeleteBuilding(int buildingId)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Building WHERE BuildingId = @BuildingId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@BuildingId", buildingId);
                command.ExecuteNonQuery();

                foreach (Flat flat in GetAllFlats())
                {
                    if (flat.AssignedBuilding.BuildingId == buildingId)
                    {
                        DeleteFlat(flat.FlatId);
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting building: {ex.Message}");
            }
            return result;
        }
        public Building? GetBuilding(int buildingId)
        {
            Building? result = null;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Building WHERE BuildingId = @BuildingId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@BuildingId", buildingId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = new Building(reader.GetInt32(0), reader.GetString(1));
                    result.Flats = GetFlatByBuilding(result.BuildingId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting building: {ex.Message}");
            }
            return result;
        }
        public List<Building> GetAllBuildings()
        {
            List<Building> buildings = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Building";
                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Building building = new(reader.GetInt32(0), reader.GetString(1));
                    building.Flats = GetFlatByBuilding(building.BuildingId);
                    buildings.Add(building);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting buildings: {ex.Message}");
            }
            return buildings;
        }

        // CRUD for Flat
        public bool AddFlat(Flat flat)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "INSERT INTO Flat (FlatNumber, AssignedBuildingId) VALUES (@FlatNumber, @BuildingId)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatNumber", flat.FlatNumber);
                command.Parameters.AddWithValue("@BuildingId", flat.AssignedBuilding.BuildingId);
                command.ExecuteNonQuery();
                foreach (Student student in flat.Students)
                {
                    if (GetStudent(student.StudentId) == null)
                    {
                        AddStudent(student);
                    }
                    else
                    {
                        UpdateStudent(student);
                    }
                }
                foreach (Complaint complaint in flat.Complaints)
                {
                    if (GetComplaint(complaint.ComplaintId) == null)
                    {
                        AddComplaint(complaint);
                    }
                    else
                    {
                        UpdateComplaint(complaint);
                    }
                }
                foreach (Agreement agreement in flat.Agreements)
                {
                    if (GetAgreement(agreement.AgreementId) == null)
                    {
                        AddAgreement(agreement);
                    }
                    else
                    {
                        UpdateAgreement(agreement);
                    }
                }
                foreach (Announcement announcement in flat.Announcements)
                {
                    if (GetAnnouncement(announcement.AnnouncementId) == null)
                    {
                        AddAnnouncement(announcement);
                    }
                    else
                    {
                        UpdateAnnouncement(announcement);
                    }
                }
                foreach (Chore chore in flat.Chores)
                {
                    if (GetChore(chore.ChoreId) == null)
                    {
                        AddChore(chore);
                    }
                    else
                    {
                        UpdateChore(chore);
                    }
                }
                foreach (Grocery grocery in flat.Groceries)
                {
                    if (GetGrocery(grocery.GroceryId) == null)
                    {
                        AddGrocery(grocery);
                    }
                    else
                    {
                        UpdateGrocery(grocery);
                    }
                }
                foreach (Rule rule in flat.Rules)
                {
                    if (GetRule(rule.RuleId) == null)
                    {
                        AddRule(rule);
                    }
                    else
                    {
                        UpdateRule(rule);
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding flat: {ex.Message}");
            }
            return result;
        }
        public bool UpdateFlat(Flat flat)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "UPDATE Flat SET FlatNumber = @FlatNumber, AssignedBuildingId = @BuildingId WHERE FlatId = @FlatId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatNumber", flat.FlatNumber);
                command.Parameters.AddWithValue("@BuildingId", flat.AssignedBuilding.BuildingId);
                command.Parameters.AddWithValue("@FlatId", flat.FlatId);
                command.ExecuteNonQuery();
                foreach (Student student in flat.Students)
                {
                    if (GetStudent(student.StudentId) == null)
                    {
                        AddStudent(student);
                    }
                    else
                    {
                        UpdateStudent(student);
                    }
                }
                foreach (Complaint complaint in flat.Complaints)
                {
                    if (GetComplaint(complaint.ComplaintId) == null)
                    {
                        AddComplaint(complaint);
                    }
                    else
                    {
                        UpdateComplaint(complaint);
                    }
                }
                foreach (Agreement agreement in flat.Agreements)
                {
                    if (GetAgreement(agreement.AgreementId) == null)
                    {
                        AddAgreement(agreement);
                    }
                    else
                    {
                        UpdateAgreement(agreement);
                    }
                }
                foreach (Announcement announcement in flat.Announcements)
                {
                    if (GetAnnouncement(announcement.AnnouncementId) == null)
                    {
                        AddAnnouncement(announcement);
                    }
                    else
                    {
                        UpdateAnnouncement(announcement);
                    }
                }
                foreach (Chore chore in flat.Chores)
                {
                    if (GetChore(chore.ChoreId) == null)
                    {
                        AddChore(chore);
                    }
                    else
                    {
                        UpdateChore(chore);
                    }
                }
                foreach (Grocery grocery in flat.Groceries)
                {
                    if (GetGrocery(grocery.GroceryId) == null)
                    {
                        AddGrocery(grocery);
                    }
                    else
                    {
                        UpdateGrocery(grocery);
                    }
                }
                foreach (Rule rule in flat.Rules)
                {
                    if (GetRule(rule.RuleId) == null)
                    {
                        AddRule(rule);
                    }
                    else
                    {
                        UpdateRule(rule);
                    }
                }
                result = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating flat: {ex.Message}");
            }
            return result;
        }
        public bool DeleteFlat(int flatId)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Flat WHERE FlatId = @FlatId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatId", flatId);
                command.ExecuteNonQuery();
                foreach (Complaint complaint in GetComplaintByFlat(flatId))
                {
                    DeleteComplaint(complaint.ComplaintId);
                }
                foreach (Agreement agreement in GetAgreementByFlat(flatId))
                {
                    DeleteAgreement(agreement.AgreementId);
                }
                foreach (Announcement announcement in GetAnnouncementByFlat(flatId))
                {
                    DeleteAnnouncement(announcement.AnnouncementId);
                }
                foreach (Chore chore in GetChoreByFlat(flatId))
                {
                    DeleteChore(chore.ChoreId);
                }
                foreach (Grocery grocery in GetGroceryByFlat(flatId))
                {
                    DeleteGrocery(grocery.GroceryId);
                }
                foreach (Rule rule in GetRuleByFlat(flatId))
                {
                    DeleteRule(rule.RuleId);
                }
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting flat: {ex.Message}");
            }
            return result;
        }
        public Flat? GetFlat(int flatId)
        {
            Flat? result = null;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Flat WHERE FlatId = @FlatId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatId", flatId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = new Flat(reader.GetInt32(0), reader.GetInt32(1), GetBuilding(reader.GetInt32(2)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting flat: {ex.Message}");
            }
            return result;
        }
        public List<Flat> GetAllFlats()
        {
            List<Flat> flats = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Flat";
                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    flats.Add(new Flat(reader.GetInt32(0), reader.GetInt32(1), GetBuilding(reader.GetInt32(2))));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting flats: {ex.Message}");
            }
            return flats;
        }
        public List<Flat> GetFlatByBuilding(int buildingId)
        {
            List<Flat> flats = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Flat WHERE AssignedBuildingId = @BuildingId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@BuildingId", buildingId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    flats.Add(new Flat(reader.GetInt32(0), reader.GetInt32(1), GetBuilding(reader.GetInt32(2))));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting flats by building: {ex.Message}");
            }
            return flats;
        }

        // CRUD for Chore
        public bool AddChore(Chore chore)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "INSERT INTO Chore (Title, Description, IsFinished, AssigneeId, Deadline, AssignedFlatId) VALUES (@Title, @Description, @IsFinished, @AssigneeId, @Deadline, @FlatId)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Title", chore.Title);
                command.Parameters.AddWithValue("@Description", chore.Description);
                command.Parameters.AddWithValue("@IsFinished", chore.IsFinished);
                command.Parameters.AddWithValue("@AssigneeId", chore.Assignee?.StudentId);
                command.Parameters.AddWithValue("@Deadline", chore.Deadline);
                command.Parameters.AddWithValue("@FlatId", chore.AssignedFlat.FlatId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding chore: {ex.Message}");
            }
            return result;
        }
        public bool UpdateChore(Chore chore)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "UPDATE Chore SET Title = @Title, Description = @Description, IsFinished = @IsFinished, AssigneeId = @AssigneeId, Deadline = @Deadline, AssignedFlatId = @FlatId WHERE ChoreId = @ChoreId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Title", chore.Title);
                command.Parameters.AddWithValue("@Description", chore.Description);
                command.Parameters.AddWithValue("@IsFinished", chore.IsFinished);
                command.Parameters.AddWithValue("@AssigneeId", chore.Assignee?.StudentId);
                command.Parameters.AddWithValue("@Deadline", chore.Deadline);
                command.Parameters.AddWithValue("@FlatId", chore.AssignedFlat.FlatId);
                command.Parameters.AddWithValue("@ChoreId", chore.ChoreId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating chore: {ex.Message}");
            }
            return result;
        }
        public bool DeleteChore(int choreId)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Chore WHERE ChoreId = @ChoreId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@ChoreId", choreId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting chore: {ex.Message}");
            }
            return result;
        }
        public Chore? GetChore(int choreId)
        {
            Chore? chore = null;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Chore WHERE ChoreId = @ChoreId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@ChoreId", choreId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    chore = new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), reader.GetDateTime(5), GetFlat(reader.GetInt32(6)), GetStudent(reader.GetString(4)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting chore: {ex.Message}");
            }
            return chore;
        }
        public List<Chore> GetChoreByFlat(int flatId)
        {
            List<Chore> chores = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Chore WHERE AssignedFlatId = @FlatId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatId", flatId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    chores.Add(new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), reader.GetDateTime(5), GetFlat(reader.GetInt32(6)), GetStudent(reader.GetString(4))));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting chores by flat: {ex.Message}");
            }
            return chores;
        }

        // CRUD for Student
        public bool AddStudent(Student student)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "INSERT INTO Student (StudentId, Name, AssignedFlatId) VALUES (@StudentId, @Name, @FlatId)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@FlatId", student.AssignedFlat.FlatId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}");
            }
            return result;
        }
        public bool UpdateStudent(Student student)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "UPDATE Student SET Name = @Name, AssignedFlatId = @FlatId WHERE StudentId = @StudentId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@FlatId", student.AssignedFlat.FlatId);
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}");
            }
            return result;
        }
        public bool DeleteStudent(Student student)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Student WHERE StudentId = @StudentId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}");
            }
            return result;
        }
        public bool DeleteStudent(int studentId)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Student WHERE StudentId = @StudentId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}");
            }
            return result;
        }
        public Student? GetStudent(string studentId)
        {
            Student? student = null;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Student WHERE StudentId = @StudentId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@StudentId", studentId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    student = new Student(reader.GetString(0), reader.GetString(1), GetFlat(reader.GetInt32(2)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting student: {ex.Message}");
            }
            return student;
        }

        // CRUD for Agreement
        public bool AddAgreement(Agreement agreement)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "INSERT INTO Agreement (Title, Details, StudentId, DateCreated, AssignedFlatId) VALUES (@Title, @Details, @StudentId, @DateCreated, @FlatId)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Title", agreement.Title);
                command.Parameters.AddWithValue("@Details", agreement.Details);
                command.Parameters.AddWithValue("@StudentId", agreement.Student.StudentId);
                command.Parameters.AddWithValue("@DateCreated", agreement.DateCreated);
                command.Parameters.AddWithValue("@FlatId", agreement.AssignedFlat.FlatId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding agreement: {ex.Message}");
            }
            return result;
        }
        public bool UpdateAgreement(Agreement agreement)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "UPDATE Agreement SET Title = @Title, Details = @Details, StudentId = @StudentId, DateCreated = @DateCreated, AssignedFlatId = @FlatId WHERE AgreementId = @AgreementId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Title", agreement.Title);
                command.Parameters.AddWithValue("@Details", agreement.Details);
                command.Parameters.AddWithValue("@StudentId", agreement.Student.StudentId);
                command.Parameters.AddWithValue("@DateCreated", agreement.DateCreated);
                command.Parameters.AddWithValue("@FlatId", agreement.AssignedFlat.FlatId);
                command.Parameters.AddWithValue("@AgreementId", agreement.AgreementId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating agreement: {ex.Message}");
            }
            return result;
        }
        public bool DeleteAgreement(int agreementId)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Agreement WHERE AgreementId = @AgreementId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@AgreementId", agreementId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting agreement: {ex.Message}");
            }
            return result;
        }
        public Agreement? GetAgreement(int agreementId)
        {
            Agreement? agreement = null;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Agreement WHERE AgreementId = @AgreementId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@AgreementId", agreementId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    agreement = new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), GetAgreeingStudents(reader.GetInt32(0)), GetStudent(reader.GetString(3)), reader.GetDateTime(4), GetFlat(reader.GetInt32(5)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting agreement: {ex.Message}");
            }
            return agreement;
        }
        private List<Student> GetAgreeingStudents(int agreementId)
        {
            List<Student> result = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT Student.StudentId, Student.Name, Student.AssignedFlatId FROM Agreement_Student " +
                                "INNER JOIN Student ON Student.StudentId = Agreement_Student.StudentId WHERE AgreementId = @AgreementId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@AgreementId", agreementId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new(reader.GetString(0), reader.GetString(1), GetFlat(reader.GetInt32(2))));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting agreeing students: {ex.Message}");
            }

            return result;
        }
        private List<Agreement> GetAgreementByFlat(int flatId)
        {
            List<Agreement> result = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Agreement WHERE AssignedFlatId = @FlatId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatId", flatId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), GetAgreeingStudents(reader.GetInt32(0)), GetStudent(reader.GetString(3)), reader.GetDateTime(4), GetFlat(reader.GetInt32(5))));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting agreements by flat: {ex.Message}");
            }
            return result;
        }

        // CRUD for Grocery
        public bool AddGrocery(Grocery grocery)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "INSERT INTO Grocery (Date, CreatorId, ImagePath, PaymentUrl, GroceryItems, AssignedFlatId) VALUES (@Date, @CreatorId, @ImagePath, @PaymentUrl, @GroceryItems, @FlatId)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Date", grocery.Date);
                command.Parameters.AddWithValue("@CreatorId", grocery.Creator.StudentId);
                command.Parameters.AddWithValue("@ImagePath", grocery.ImagePath);
                command.Parameters.AddWithValue("@PaymentUrl", grocery.PaymentUrl);
                command.Parameters.AddWithValue("@GroceryItems", grocery.GroceryItems);
                command.Parameters.AddWithValue("@FlatId", grocery.AssignedFlat.FlatId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding grocery: {ex.Message}");
            }
            return result;
        }
        public bool UpdateGrocery(Grocery grocery)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "UPDATE Grocery SET Date = @Date, CreatorId = @CreatorId, ImagePath = @ImagePath, PaymentUrl = @PaymentUrl, GroceryItems = @GroceryItems, AssignedFlatId = @FlatId WHERE GroceryId = @GroceryId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Date", grocery.Date);
                command.Parameters.AddWithValue("@CreatorId", grocery.Creator.StudentId);
                command.Parameters.AddWithValue("@ImagePath", grocery.ImagePath);
                command.Parameters.AddWithValue("@PaymentUrl", grocery.PaymentUrl);
                command.Parameters.AddWithValue("@GroceryItems", grocery.GroceryItems);
                command.Parameters.AddWithValue("@FlatId", grocery.AssignedFlat.FlatId);
                command.Parameters.AddWithValue("@GroceryId", grocery.GroceryId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating grocery: {ex.Message}");
            }
            return result;
        }
        public bool DeleteGrocery(int groceryId)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Grocery WHERE GroceryId = @GroceryId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@GroceryId", groceryId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting grocery: {ex.Message}");
            }
            return result;
        }
        public Grocery? GetGrocery(int groceryId)
        {
            Grocery? grocery = null;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Grocery WHERE GroceryId = @GroceryId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@GroceryId", groceryId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    grocery = new(reader.GetInt32(0), reader.GetDateTime(1), GetStudent(reader.GetString(2)), reader.GetString(3), reader.GetString(4), GetFlat(reader.GetInt32(6)), reader.GetString(5));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting grocery: {ex.Message}");
            }
            return grocery;
        }
        public List<Grocery> GetGroceryByFlat(int flatId)
        {
            List<Grocery> groceries = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Grocery WHERE AssignedFlatId = @FlatId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatId", flatId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    groceries.Add(new(reader.GetInt32(0), reader.GetDateTime(1), GetStudent(reader.GetString(2)), reader.GetString(3), reader.GetString(4), GetFlat(reader.GetInt32(6)), reader.GetString(5)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting groceries by flat: {ex.Message}");
            }
            return groceries;
        }

        // CRUD for Announcement
        public bool AddAnnouncement(Announcement announcement)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "INSERT INTO Announcement (Title, Message, Date, AssignedFlatId) VALUES (@Title, @Message, @Date, @FlatId)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Title", announcement.Title);
                command.Parameters.AddWithValue("@Message", announcement.Message);
                command.Parameters.AddWithValue("@Date", announcement.Date);
                command.Parameters.AddWithValue("@FlatId", announcement.AssignedFlat.FlatId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding announcement: {ex.Message}");
            }
            return result;
        }
        public bool UpdateAnnouncement(Announcement announcement)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "UPDATE Announcement SET Title = @Title, Message = @Message, Date = @Date, AssignedFlatId = @FlatId WHERE AnnouncementId = @AnnouncementId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Title", announcement.Title);
                command.Parameters.AddWithValue("@Message", announcement.Message);
                command.Parameters.AddWithValue("@Date", announcement.Date);
                command.Parameters.AddWithValue("@FlatId", announcement.AssignedFlat.FlatId);
                command.Parameters.AddWithValue("@AnnouncementId", announcement.AnnouncementId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating announcement: {ex.Message}");
            }
            return result;
        }
        public bool DeleteAnnouncement(int announcementId)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Announcement WHERE AnnouncementId = @AnnouncementId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@AnnouncementId", announcementId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting announcement: {ex.Message}");
            }
            return result;
        }
        public Announcement? GetAnnouncement(int announcementId)
        {
            Announcement? announcement = null;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Announcement WHERE AnnouncementId = @AnnouncementId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@AnnouncementId", announcementId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    announcement = new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), GetFlat(reader.GetInt32(4)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting announcement: {ex.Message}");
            }
            return announcement;
        }
        public List<Announcement> GetAnnouncementByFlat(int flatId)
        {
            List<Announcement> announcements = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Announcement WHERE AssignedFlatId = @FlatId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatId", flatId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    announcements.Add(new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), GetFlat(reader.GetInt32(4))));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting announcements by flat: {ex.Message}");
            }
            return announcements;
        }

        // CRUD for Rule
        public bool AddRule(Rule rule)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "INSERT INTO Rule (Description, AssignedFlatId, AssignedBuildingId) VALUES (@Description, @FlatId, @BuildingId)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Description", rule.Description);
                command.Parameters.AddWithValue("@FlatId", rule.AssignedFlat.FlatId);
                command.Parameters.AddWithValue("@BuildingId", rule.AssignedFlat.AssignedBuilding.BuildingId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding rule: {ex.Message}");
            }
            return result;
        }
        public bool UpdateRule(Rule rule)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "UPDATE Rule SET Description = @Description, AssignedFlatId = @FlatId, AssignedBuildingId = @BuildingId WHERE RuleId = @RuleId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Description", rule.Description);
                command.Parameters.AddWithValue("@FlatId", rule.AssignedFlat.FlatId);
                command.Parameters.AddWithValue("@BuildingId", rule.AssignedFlat.AssignedBuilding.BuildingId);
                command.Parameters.AddWithValue("@RuleId", rule.RuleId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating rule: {ex.Message}");
            }
            return result;
        }
        public bool DeleteRule(int ruleId)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Rule WHERE RuleId = @RuleId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@RuleId", ruleId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting rule: {ex.Message}");
            }
            return result;
        }
        public Rule? GetRule(int ruleId)
        {
            Classes.Entities.Rule? rule = null;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Rule WHERE RuleId = @RuleId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@RuleId", ruleId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    rule = new(reader.GetInt32(0), GetFlat(reader.GetInt32(2)), reader.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting rule: {ex.Message}");
            }
            return rule;
        }
        public List<Rule> GetRuleByFlat(int flatId)
        {
            List<Rule> rules = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Rule WHERE AssignedFlatId = @FlatId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatId", flatId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //rules.Add(new(reader.GetInt32(0), reader.GetString(1), GetFlat(reader.GetInt32(2)), GetBuilding(reader.GetInt32(3)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting rules by flat: {ex.Message}");
            }
            return rules;
        }

        // CRUD for Complaint
        public bool AddComplaint(Complaint complaint)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "INSERT INTO Complaint (Issue, AssignedFlatId) VALUES (@Issue, @FlatId)";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Issue", complaint.Issue);
                command.Parameters.AddWithValue("@FlatId", complaint.AssignedFlat.FlatId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding complaint: {ex.Message}");
            }
            return result;
        }
        public bool UpdateComplaint(Complaint complaint)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "UPDATE Complaint SET Issue = @Issue, AssignedFlatId = @FlatId WHERE ComplaintId = @ComplaintId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@Issue", complaint.Issue);
                command.Parameters.AddWithValue("@FlatId", complaint.AssignedFlat.FlatId);
                command.Parameters.AddWithValue("@ComplaintId", complaint.ComplaintId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating complaint: {ex.Message}");
            }
            return result;
        }
        public bool DeleteComplaint(int complaintId)
        {
            bool result = false;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "DELETE FROM Complaint WHERE ComplaintId = @ComplaintId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@ComplaintId", complaintId);
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting complaint: {ex.Message}");
            }
            return result;
        }
        public Complaint? GetComplaint(int complaintId)
        {
            Complaint? complaint = null;
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Complaint WHERE ComplaintId = @ComplaintId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@ComplaintId", complaintId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    complaint = new(reader.GetInt32(0), GetFlat(reader.GetInt32(2)), reader.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting complaint: {ex.Message}");
            }
            return complaint;
        }
        public List<Complaint> GetComplaintByFlat(int flatId)
        {
            List<Complaint> complaints = [];
            try
            {
                using SqlConnection connection = new(CONNECTION_STRING);
                connection.Open();
                string query = "SELECT * FROM Complaint WHERE AssignedFlatId = @FlatId";
                SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@FlatId", flatId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    complaints.Add(new Complaint(reader.GetInt32(0), GetFlat(reader.GetInt32(2)), reader.GetString(1)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting complaints by flat: {ex.Message}");
            }
            return complaints;
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
