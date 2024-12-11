using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Classes.Entities
{
    public class Agreement(string agreementTitle, string agreementDetails, List<Student> studentsInAgreement, Student student, HousingManager housingManager, Flat assignedFlat)
    {
        #region Properties
        public int AgreementId { get; set; } = housingManager.GetNextAgreementId(); // Primary key
        public string Title { get; set; } = agreementTitle;
        public string Details { get; set; } = agreementDetails;
        public List<Student> AgreedBy { get; set; } = studentsInAgreement;
        public Student? Student { get; set; } = student;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public Flat AssignedFlat { get; set; } = assignedFlat; // Cross-reference

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
