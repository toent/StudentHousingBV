namespace StudentHousingBV.Student_App
{
    partial class StudentAddChore
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
            label1 = new Label();
            tbTitle = new TextBox();
            label2 = new Label();
            dtpDeadline = new DateTimePicker();
            cbAssignee = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            rtbDescription = new RichTextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(24, 50);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(296, 31);
            tbTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 99);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 2;
            label2.Text = "Assignee";
            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(24, 210);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(300, 31);
            dtpDeadline.TabIndex = 3;
            // 
            // cbAssignee
            // 
            cbAssignee.FormattingEnabled = true;
            cbAssignee.Location = new Point(24, 127);
            cbAssignee.Name = "cbAssignee";
            cbAssignee.Size = new Size(296, 33);
            cbAssignee.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 182);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 5;
            label3.Text = "Deadline";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 262);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(24, 290);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(300, 144);
            rtbDescription.TabIndex = 7;
            rtbDescription.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(143, 450);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(25, 450);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // StudentAddChore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 496);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(rtbDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbAssignee);
            Controls.Add(dtpDeadline);
            Controls.Add(label2);
            Controls.Add(tbTitle);
            Controls.Add(label1);
            Name = "StudentAddChore";
            Text = "Add Chore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbTitle;
        private Label label2;
        private DateTimePicker dtpDeadline;
        private ComboBox cbAssignee;
        private Label label3;
        private Label label4;
        private RichTextBox rtbDescription;
        private Button btnAdd;
        private Button btnCancel;
    }
}