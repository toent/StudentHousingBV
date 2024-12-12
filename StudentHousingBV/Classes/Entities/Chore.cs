using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Classes.Entities
{
    public class Chore
    {
        #region Properties
        public int ChoreId { get; set; } // Primary key
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsFinished { get; set; }
        public Student? Assignee { get; set; }
        public DateTime Deadline { get; set; }
        public Student? Student { get; set; }
        public Flat AssignedFlat { get; set; } // Cross-reference
        #endregion

        #region Constructors
        public Chore() 
        {
            Title = "New chore";
            Description = "New chore description";
            AssignedFlat = new();
        }

        public Chore(int id, string choreTitle, string choreDescription, DateTime choreDeadline, Flat assignedFlat)
        {
            ChoreId = id;
            Title = choreTitle;
            Description = choreDescription;
            IsFinished = false;
            Deadline = choreDeadline;
            AssignedFlat = assignedFlat;
        }

        public Chore(int id, string choreTitle, string choreDescription, DateTime choreDeadline, Flat assignedFlat, Student choreAssignee)
        {
            ChoreId = id;
            Title = choreTitle;
            Description = choreDescription;
            IsFinished = false;
            Assignee = choreAssignee;
            Deadline = choreDeadline;
            AssignedFlat = assignedFlat;
        }
        #endregion
    }
}
