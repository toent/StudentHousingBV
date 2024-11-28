using System;
using System.Xml;

namespace StudentHousingBV
{
    public class Rule
    {
        private static int idCounter = 1; //each rule gets a unique ID
        private int id;
        private string description;
        private DateTime createTime;

        // Constructor  
        public Rule(string description)
        {
            this.id = idCounter++;
            this.description = description;
            this.createTime = DateTime.Now;
        }

        //property for accessing and modifying the description
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //property for retrieving the unique ID
        public int Id
        {
            get { return id; }
        }
        //property to create time
        public DateTime CreateTime
        {
            get { return createTime; }
        }
    }
}
