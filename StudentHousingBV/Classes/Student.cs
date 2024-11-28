namespace StudentHousingBV.Classes
{
    public class Student
    {
        private string contractId;
        private string name;
        private int fkFlatId;

        public string ContractId { get { return contractId; } set { contractId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int FkFlatId { get { return fkFlatId; } set { fkFlatId = value; } }

        //Empty constructor for deserialization
        public Student() { }

        //Constructor for normal usage
        public Student(string contractId, string name)
        {
            ContractId = contractId;
            Name = name;
        }
    }
}
