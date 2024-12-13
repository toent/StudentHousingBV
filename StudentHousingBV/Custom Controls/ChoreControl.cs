using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Custom_Controls
{
    public partial class ChoreControl : UserControl
    {
        private readonly Chore chore;
        public event EventHandler StatusChanged;

        public ChoreControl(Chore chore)
        {
            InitializeComponent();
            this.chore = chore;
            LoadChoreControl();
        }

        private void btnStatusChange_Click(object sender, EventArgs e)
        {
            if (chore.IsFinished)
            {
                chore.AssignedFlat.Chores.Remove(chore);
            }
            else
            {
                chore.IsFinished = true;
                btnStatusChange.Text = "Delete";
            }

            StatusChanged?.Invoke(this, EventArgs.Empty);
        }

        private void LoadChoreControl()
        {
            lblChoreName.Text = chore.Title;
            lblDescription.Text = chore.Description;
            lblDueDate.Text = chore.Deadline.ToString("dd/MM/yyyy");
            lblAssignee.Text = chore.Assignee?.Name;
            btnStatusChange.Text = chore.IsFinished ? "Delete" : "Mark as finished";
        }
    }
}
