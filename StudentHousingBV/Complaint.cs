using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Complaint
    {
        private int id;
        private string description;
        private bool read;

        public int ID { get; }
        public string Description { get; }
        public bool Read { get; set; }

        public Complaint(string description)
        {
            this.description = description;
            this.read = false;
            this.id = generateId();
        }

        static int generateId()
        {
            int id = 0;
            id++;
            return id;
        }
    }
}
