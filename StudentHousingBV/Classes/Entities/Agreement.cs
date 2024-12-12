using System.Text.Json.Serialization;

namespace StudentHousingBV.Classes.Entities
{
    public class Agreement
    {
        #region Properties
        public int AgreementId { get; set; } // Primary key
        public string Title { get; set; }
        public string Details { get; set; }
        public List<Student> AgreedBy { get; set; }
        public Student? Student { get; set; }
        public DateTime DateCreated { get; set; }
        [JsonIgnore]
        public Flat AssignedFlat { get; set; } // Cross-reference
        #endregion

        #region Constructor
        public Agreement() 
        {
            Title = "Agreement";
            Details = "Details";
            AgreedBy = [];
            AssignedFlat = new();
        }

        public Agreement(int id, string agreementTitle, string agreementDetails, List<Student> studentsInAgreement, Student student, Flat assignedFlat)
        {
            AgreementId = id;
            Title = agreementTitle;
            Details = agreementDetails;
            Student = student;
            AssignedFlat = assignedFlat;
            DateCreated = DateTime.Now;
            AgreedBy = studentsInAgreement;
        }

        #endregion

        #region Methods
        public void AddStudentAgreed(Student student)
        {
            AgreedBy.Add(student);
        }

        public void RemoveStudentAgreed(Student student)
        {
            AgreedBy.Remove(student);
        }
        #endregion
    }
}
