using StudentHousingBV.Classes.Entities;
using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Custom_Controls;

namespace StudentHousingBV.Student_App
{
    public partial class StudentChores : Form
    {
        private readonly HousingManager housingManager;
        private readonly Student student;
        private readonly Flat flat;

        private bool isFiltered;

        public StudentChores(HousingManager housingManager, Student student)
        {
            InitializeComponent();
            this.housingManager = housingManager;
            this.student = student;
            isFiltered = false;
            flat = student.AssignedFlat;
            cbAssignee.DataSource = flat.Students;
            LoadChores();
        }

        private void ChoreControl_StatusChanged(object sender, EventArgs e)
        {
            if (sender is ChoreControl choreControl)
            {
                if (housingManager.UpdateChore(choreControl.Chore))
                {
                    MessageBox.Show("Chore status updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChores();
                }
                else
                {
                    MessageBox.Show("Failed to update chore status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            isFiltered = true;
            LoadChores();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbAssignee.SelectedItem = null;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            isFiltered = false;
            LoadChores();
        }

        private bool ValidateInput()
        {
            bool result = true;
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start date cannot be greater than end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            if (cbAssignee.SelectedItem == null)
            {
                MessageBox.Show("Please select an assignee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        private void LoadChores()
        {
            List<Chore> chores = isFiltered && ValidateInput() ?
                                 student.AssignedFlat!.Chores.Where(c => c.Deadline >= dtpStartDate.Value &&
                                                                    c.Deadline <= dtpEndDate.Value &&
                                                                    c.Assignee == (Student)cbAssignee.SelectedItem!).ToList() :
                                                                    [.. flat.Chores];

            pChores.Controls.Clear();

            foreach (Chore chore in chores)
            {
                ChoreControl choreControl = new(chore);
                choreControl.StatusChanged += ChoreControl_StatusChanged!;
                choreControl.Margin = new Padding(0, 10, 0, 10);

                pChores.Controls.Add(choreControl);
            }
        }

        private void btnAddChore_Click(object sender, EventArgs e)
        {
            StudentAddChore studentAddChore = new([.. student.AssignedFlat.Students], housingManager, student);
            studentAddChore.ShowDialog();

            if (studentAddChore.DialogResult == DialogResult.OK && studentAddChore.chore is Chore chore)
            {
                if (housingManager.AddChore(chore))
                {
                    MessageBox.Show("Chore added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChores();
                }
            }
        }
    }
}
