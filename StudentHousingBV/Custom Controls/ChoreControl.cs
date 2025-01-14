using StudentHousingBV.Classes.Entities;

namespace StudentHousingBV.Custom_Controls
{
    public partial class ChoreControl : UserControl
    {
        public readonly Chore Chore;
        public event EventHandler? StatusChanged;

        public ChoreControl(Chore chore)
        {
            InitializeComponent();
            this.Chore = chore;
            LoadChoreControl();
        }

        private void btnStatusChange_Click(object sender, EventArgs e)
        {
            if (Chore.IsFinished)
            {
                Chore.AssignedFlat.Chores.Remove(Chore);
            }
            else
            {
                Chore.IsFinished = true;
                btnStatusChange.Text = "Delete";
            }

            StatusChanged?.Invoke(this, EventArgs.Empty);
        }

        private void LoadChoreControl()
        {
            lblChoreName.Text = Chore.Title;
            lblDescription.Text = Chore.Description;
            lblDueDate.Text = Chore.Deadline.ToString("dd/MM/yyyy");
            lblAssignee.Text = Chore.Assignee?.Name;
            btnStatusChange.Text = Chore.IsFinished ? "Delete" : "Mark as finished";
        }
    }
}
