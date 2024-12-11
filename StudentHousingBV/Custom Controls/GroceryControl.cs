using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using StudentHousingBV.Classes;

namespace StudentHousingBV.Custom_Controls
{
    public partial class GroceryControl : UserControl
    {
        private Grocery grocery;
        public GroceryControl()
        {
            InitializeComponent();
        }

        public void SetGrocery(Grocery grocery)
        {
            this.grocery = grocery;

            lblName.Text = grocery.GroceryId.ToString();
            lblDate.Text = grocery.Date.ToShortDateString();
            pictureBoxGrocery.Image = Image.FromFile(grocery.ImagePath);
            
        }
    }
}
