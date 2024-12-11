using System.Xml.Linq;

namespace StudentHousingBV.Classes
{
    public class Grocery
    {
        private readonly int groceryId;
        private readonly DateTime date;
        private readonly Student? creator;
        private string imagePath;
        private string paymentUrl;

        public int GroceryId { get => groceryId; }
        public DateTime Date { get => date; }
        public Student? Creator { get => creator; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string PaymentUrl { get => paymentUrl; set => paymentUrl = value; }

        public int FlatId { get; set; } // Foreign Key

        //Navigation Properties
        public Flat Flat { get; set; }

        public Grocery() { }

        public Grocery(string creatorId, string imagePath, string paymentUrl, int flatId, DataManager dataManager)
        {
            groceryId = dataManager.GetNextGroceryId();
            date = DateTime.Now;
            creator = dataManager.GetStudent(creatorId);
            FlatId = flatId;
            this.imagePath = imagePath;
            this.paymentUrl = paymentUrl;
        }


        // temporary constructor that doesnt take the datamanager
        Student studentExample = new Student("F93756", "Jane Doe");
        public Grocery(string creatorId, string imagePath, string paymentUrl, int flatId)
        {
            groceryId = 1;
            date = DateTime.Now;
            creator = studentExample;
            FlatId = flatId;
            this.imagePath = imagePath;
            this.paymentUrl = paymentUrl;
        }
    }
}
