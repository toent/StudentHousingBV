using System.Security.Policy;

namespace StudentHousingBV.Classes
{
    public class Chore
    {
        #region Properties
        public int ChoreId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsFinished { get; set; }
        public Student? Assignee { get; set; }
        public DateTime Deadline { get; set; }
        public string StudentId { get; set; } // Foreign Key
        public int FlatId { get; set; } // Foreign Key
        public int BuildingId { get; set; } // Foreign Key

        // Navigation property
        public Student? Student { get; set; }
        public Flat? Flat { get; set; }
        public Building? Building { get; set; }

        #endregion

        #region Constructors
        public Chore() { }

        public Chore(string choreTitle, string choreDescription, DateTime choreDeadline, string studentId, int flatId, int buildingId, DataManager dataManager)
        {
            ChoreId = dataManager.GetNextChoreId();
            Title = choreTitle;
            Description = choreDescription;
            IsFinished = false;
            Deadline = choreDeadline;
            StudentId = studentId;
            FlatId = flatId;
            BuildingId = buildingId;
        }

        public Chore(string choreTitle, string choreDescription, Student choreAssignee, DateTime choreDeadline, 
                        string studentId, int flatId, int buildingId, DataManager dataManager)
        {
            ChoreId = dataManager.GetNextChoreId();
            Title = choreTitle;
            Description = choreDescription;
            IsFinished = false;
            Assignee = choreAssignee;
            Deadline = choreDeadline;
            StudentId = studentId;
            FlatId = flatId;
            BuildingId = buildingId;
        }
        #endregion

        #region Methods
        #endregion
    }
}
