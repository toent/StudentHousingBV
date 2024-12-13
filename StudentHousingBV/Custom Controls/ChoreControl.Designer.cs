namespace StudentHousingBV.Custom_Controls
{
    partial class ChoreControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblAssignee = new Label();
            label5 = new Label();
            lblDueDate = new Label();
            label2 = new Label();
            lblChoreName = new Label();
            lblDescription = new Label();
            btnStatusChange = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblAssignee);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblDueDate);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1493, 59);
            panel1.TabIndex = 0;
            // 
            // lblAssignee
            // 
            lblAssignee.AutoSize = true;
            lblAssignee.Location = new Point(1272, 17);
            lblAssignee.Name = "lblAssignee";
            lblAssignee.Size = new Size(135, 25);
            lblAssignee.TabIndex = 5;
            lblAssignee.Text = "[Student Name]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1183, 17);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 4;
            label5.Text = "Assignee";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(112, 17);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(89, 25);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "[EndDate]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 17);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Due date";
            // 
            // lblChoreName
            // 
            lblChoreName.AutoSize = true;
            lblChoreName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChoreName.Location = new Point(22, 81);
            lblChoreName.Name = "lblChoreName";
            lblChoreName.Size = new Size(167, 32);
            lblChoreName.TabIndex = 1;
            lblChoreName.Text = "[Chore Name]";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(284, 88);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(162, 25);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "[Chore description]";
            // 
            // btnStatusChange
            // 
            btnStatusChange.BackColor = Color.FromArgb(214, 223, 255);
            btnStatusChange.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnStatusChange.ForeColor = Color.FromArgb(26, 37, 47);
            btnStatusChange.Location = new Point(1184, 67);
            btnStatusChange.Margin = new Padding(8);
            btnStatusChange.Name = "btnStatusChange";
            btnStatusChange.Size = new Size(309, 58);
            btnStatusChange.TabIndex = 3;
            btnStatusChange.Text = "[Status]";
            btnStatusChange.UseVisualStyleBackColor = false;
            btnStatusChange.Click += btnStatusChange_Click;
            // 
            // ChoreControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnStatusChange);
            Controls.Add(lblDescription);
            Controls.Add(lblChoreName);
            Controls.Add(panel1);
            Name = "ChoreControl";
            Size = new Size(1499, 133);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label lblDueDate;
        private Label label5;
        private Label lblAssignee;
        private Label lblChoreName;
        private Label lblDescription;
        private Button btnStatusChange;
    }
}
