using System.Text.Json.Serialization;

namespace StudentHousingBV.Classes.Entities
{
    public class Student
    {
        #region Properties
        public string StudentId { get; set; } // Primary Key
        public string Name { get; set; }
        [JsonIgnore]
        public Flat? AssignedFlat { get; set; } // Cross-reference
        #endregion

        #region Constructors
        public Student ()
        {
            StudentId = "";
            Name = "";
        }

        public Student(string studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }

        public Student(string studentId, string name, Flat assignedFlat)
        {
            StudentId = studentId;
            Name = name;
            AssignedFlat = assignedFlat;
        }
        #endregion
    }
}
