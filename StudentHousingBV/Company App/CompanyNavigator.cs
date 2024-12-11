using StudentHousingBV.Classes;
using StudentHousingBV.Student_App;

namespace StudentHousingBV
{
    public partial class CompanyNavigator : Form
    {
        private readonly DataManager dataManager;
        private readonly Student student;

        public CompanyNavigator(DataManager dataManager, Student student)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.dataManager = dataManager;
        }

        private void Navigation_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "btnGroceries":
                        MessageBox.Show("This feature is not implemented yet.");
                        lblTitle.Text = "Groceries";
                        pShowForm.Controls.Clear();
                        break;
                    case "btnFileComplaint":
                        LoadFormIntoPanel(new StudentComplaint(dataManager));
                        lblTitle.Text = "File Complaint";
                        break;
                    default:
                        MessageBox.Show("This feature is not implemented yet.");
                        lblTitle.Text = "Home";
                        pShowForm.Controls.Clear();
                        break;
                }
            }
        }

        public void LoadFormIntoPanel(Form form)
        {
            pShowForm.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pShowForm.Controls.Add(form);
            form.Show();
        }

    }
}
