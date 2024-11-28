using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Student
    {
        public string ContractId { get; set; }
        public string Name { get; set; }

        //Empty constructor for deserialization
        public Student() { }

        //Constructor for normal usage
        public Student(string contractId, string name)
        {
            this.ContractId = contractId;
            this.Name = name;
        }
    }
}
