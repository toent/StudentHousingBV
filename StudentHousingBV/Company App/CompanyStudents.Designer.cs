namespace StudentHousingBV.Company_App
{
    partial class CompanyStudents
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
            gbStudentInfo = new GroupBox();
            tbFlatFilter = new TextBox();
            lbStudentFlat = new ListBox();
            label5 = new Label();
            tbBuildingFilter = new TextBox();
            tbStudentName = new TextBox();
            lbStudentBuilding = new ListBox();
            label4 = new Label();
            label3 = new Label();
            tbStudentId = new TextBox();
            label2 = new Label();
            btnRemoveStudent = new Button();
            btnModifyStudent = new Button();
            btnAddStudent = new Button();
            label1 = new Label();
            lbStudents = new ListBox();
            tbFilterStudent = new TextBox();
            gbStudentInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gbStudentInfo
            // 
            gbStudentInfo.Controls.Add(tbFlatFilter);
            gbStudentInfo.Controls.Add(lbStudentFlat);
            gbStudentInfo.Controls.Add(label5);
            gbStudentInfo.Controls.Add(tbBuildingFilter);
            gbStudentInfo.Controls.Add(tbStudentName);
            gbStudentInfo.Controls.Add(lbStudentBuilding);
            gbStudentInfo.Controls.Add(label4);
            gbStudentInfo.Controls.Add(label3);
            gbStudentInfo.Controls.Add(tbStudentId);
            gbStudentInfo.Controls.Add(label2);
            gbStudentInfo.Location = new Point(1059, 56);
            gbStudentInfo.Name = "gbStudentInfo";
            gbStudentInfo.Size = new Size(468, 695);
            gbStudentInfo.TabIndex = 21;
            gbStudentInfo.TabStop = false;
            gbStudentInfo.Text = "Student information";
            // 
            // tbFlatFilter
            // 
            tbFlatFilter.Location = new Point(19, 466);
            tbFlatFilter.Name = "tbFlatFilter";
            tbFlatFilter.Size = new Size(428, 31);
            tbFlatFilter.TabIndex = 10;
            tbFlatFilter.TextChanged += tbFlatFilter_TextChanged;
            // 
            // lbStudentFlat
            // 
            lbStudentFlat.FormattingEnabled = true;
            lbStudentFlat.ItemHeight = 25;
            lbStudentFlat.Location = new Point(19, 503);
            lbStudentFlat.Name = "lbStudentFlat";
            lbStudentFlat.Size = new Size(428, 154);
            lbStudentFlat.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 438);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 8;
            label5.Text = "Assigned Flat";
            // 
            // tbBuildingFilter
            // 
            tbBuildingFilter.Location = new Point(19, 233);
            tbBuildingFilter.Name = "tbBuildingFilter";
            tbBuildingFilter.Size = new Size(428, 31);
            tbBuildingFilter.TabIndex = 7;
            tbBuildingFilter.TextChanged += tbBuildingFilter_TextChanged;
            // 
            // tbStudentName
            // 
            tbStudentName.Location = new Point(19, 137);
            tbStudentName.Name = "tbStudentName";
            tbStudentName.Size = new Size(428, 31);
            tbStudentName.TabIndex = 6;
            // 
            // lbStudentBuilding
            // 
            lbStudentBuilding.FormattingEnabled = true;
            lbStudentBuilding.ItemHeight = 25;
            lbStudentBuilding.Location = new Point(19, 270);
            lbStudentBuilding.Name = "lbStudentBuilding";
            lbStudentBuilding.Size = new Size(428, 154);
            lbStudentBuilding.TabIndex = 5;
            lbStudentBuilding.SelectedIndexChanged += lbStudentBuilding_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 205);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 4;
            label4.Text = "Assigned Building";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 109);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // tbStudentId
            // 
            tbStudentId.Enabled = false;
            tbStudentId.Location = new Point(19, 65);
            tbStudentId.Name = "tbStudentId";
            tbStudentId.Size = new Size(428, 31);
            tbStudentId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 37);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "Contract Id";
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.BackColor = Color.FromArgb(240, 243, 255);
            btnRemoveStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveStudent.Location = new Point(765, 113);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(228, 43);
            btnRemoveStudent.TabIndex = 20;
            btnRemoveStudent.Text = "Remove Student";
            btnRemoveStudent.UseVisualStyleBackColor = false;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // btnModifyStudent
            // 
            btnModifyStudent.BackColor = Color.FromArgb(240, 243, 255);
            btnModifyStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifyStudent.Location = new Point(1059, 757);
            btnModifyStudent.Name = "btnModifyStudent";
            btnModifyStudent.Size = new Size(468, 43);
            btnModifyStudent.TabIndex = 19;
            btnModifyStudent.Text = "Modify student";
            btnModifyStudent.UseVisualStyleBackColor = false;
            btnModifyStudent.Click += btnModifyStudent_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(240, 243, 255);
            btnAddStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(765, 64);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(228, 43);
            btnAddStudent.TabIndex = 18;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 17;
            label1.Text = "Students";
            // 
            // lbStudents
            // 
            lbStudents.FormattingEnabled = true;
            lbStudents.ItemHeight = 25;
            lbStudents.Location = new Point(12, 106);
            lbStudents.Name = "lbStudents";
            lbStudents.Size = new Size(736, 679);
            lbStudents.TabIndex = 16;
            lbStudents.SelectedIndexChanged += lbStudents_SelectedIndexChanged;
            // 
            // tbFilterStudent
            // 
            tbFilterStudent.Location = new Point(12, 64);
            tbFilterStudent.Name = "tbFilterStudent";
            tbFilterStudent.Size = new Size(736, 31);
            tbFilterStudent.TabIndex = 22;
            tbFilterStudent.TextChanged += tbFilterStudent_TextChanged;
            // 
            // CompanyStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(tbFilterStudent);
            Controls.Add(gbStudentInfo);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnModifyStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(label1);
            Controls.Add(lbStudents);
            Name = "CompanyStudents";
            Text = "CompanyStudents";
            gbStudentInfo.ResumeLayout(false);
            gbStudentInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbStudentInfo;
        private ListBox lbStudentBuilding;
        private Label label4;
        private Label label3;
        private TextBox tbStudentId;
        private Label label2;
        private Button btnRemoveStudent;
        private Button btnModifyStudent;
        private Button btnAddStudent;
        private Label label1;
        private ListBox lbStudents;
        private TextBox tbFilterStudent;
        private TextBox tbStudentName;
        private TextBox tbFlatFilter;
        private ListBox lbStudentFlat;
        private Label label5;
        private TextBox tbBuildingFilter;
    }
}