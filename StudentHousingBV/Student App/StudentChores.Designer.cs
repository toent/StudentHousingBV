namespace StudentHousingBV.Student_App
{
    partial class StudentChores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddChore = new Button();
            pChores = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbAssignee = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnFilter = new Button();
            btnClearFilter = new Button();
            SuspendLayout();
            // 
            // btnAddChore
            // 
            btnAddChore.BackColor = Color.FromArgb(240, 243, 255);
            btnAddChore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddChore.Location = new Point(1391, 12);
            btnAddChore.Name = "btnAddChore";
            btnAddChore.Size = new Size(173, 43);
            btnAddChore.TabIndex = 0;
            btnAddChore.Text = "Add Chore";
            btnAddChore.UseVisualStyleBackColor = false;
            btnAddChore.Click += btnAddChore_Click;
            // 
            // pChores
            // 
            pChores.AutoScroll = true;
            pChores.Location = new Point(12, 67);
            pChores.Name = "pChores";
            pChores.Size = new Size(1552, 739);
            pChores.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 22);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 2;
            label2.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 22);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 3;
            label3.Text = "Assignee";
            // 
            // cbAssignee
            // 
            cbAssignee.FormattingEnabled = true;
            cbAssignee.Location = new Point(636, 19);
            cbAssignee.Name = "cbAssignee";
            cbAssignee.Size = new Size(182, 33);
            cbAssignee.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(108, 19);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 31);
            dtpStartDate.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(368, 19);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 31);
            dtpEndDate.TabIndex = 6;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(240, 243, 255);
            btnFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnFilter.Location = new Point(849, 14);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 43);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(240, 243, 255);
            btnClearFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnClearFilter.Location = new Point(967, 14);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(137, 43);
            btnClearFilter.TabIndex = 8;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // StudentChores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(btnClearFilter);
            Controls.Add(btnFilter);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cbAssignee);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pChores);
            Controls.Add(btnAddChore);
            Name = "StudentChores";
            Text = "StudentChores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddChore;
        private FlowLayoutPanel pChores;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbAssignee;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnFilter;
        private Button btnClearFilter;
    }
}