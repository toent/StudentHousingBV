namespace StudentHousingBV.Company_App
{
    partial class CompanyAddStudent
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
            tbId = new TextBox();
            tbFlatFilter = new TextBox();
            lbStudentFlat = new ListBox();
            label5 = new Label();
            tbBuildingFilter = new TextBox();
            lbStudentBuilding = new ListBox();
            label4 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            tbName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Contract Id";
            // 
            // tbId
            // 
            tbId.Location = new Point(31, 51);
            tbId.Name = "tbId";
            tbId.Size = new Size(402, 31);
            tbId.TabIndex = 1;
            // 
            // tbFlatFilter
            // 
            tbFlatFilter.Location = new Point(31, 427);
            tbFlatFilter.Name = "tbFlatFilter";
            tbFlatFilter.Size = new Size(402, 31);
            tbFlatFilter.TabIndex = 16;
            tbFlatFilter.TextChanged += tbFlatFilter_TextChanged;
            // 
            // lbStudentFlat
            // 
            lbStudentFlat.FormattingEnabled = true;
            lbStudentFlat.ItemHeight = 25;
            lbStudentFlat.Location = new Point(31, 464);
            lbStudentFlat.Name = "lbStudentFlat";
            lbStudentFlat.Size = new Size(402, 129);
            lbStudentFlat.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 399);
            label5.Name = "label5";
            label5.Size = new Size(118, 25);
            label5.TabIndex = 14;
            label5.Text = "Assigned Flat";
            // 
            // tbBuildingFilter
            // 
            tbBuildingFilter.Location = new Point(31, 210);
            tbBuildingFilter.Name = "tbBuildingFilter";
            tbBuildingFilter.Size = new Size(402, 31);
            tbBuildingFilter.TabIndex = 13;
            tbBuildingFilter.TextChanged += tbBuildingFilter_TextChanged;
            // 
            // lbStudentBuilding
            // 
            lbStudentBuilding.FormattingEnabled = true;
            lbStudentBuilding.ItemHeight = 25;
            lbStudentBuilding.Location = new Point(31, 247);
            lbStudentBuilding.Name = "lbStudentBuilding";
            lbStudentBuilding.Size = new Size(402, 129);
            lbStudentBuilding.TabIndex = 12;
            lbStudentBuilding.SelectedIndexChanged += lbStudentBuilding_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 182);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 11;
            label4.Text = "Assigned Building";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(31, 639);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(154, 42);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(240, 243, 255);
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(191, 639);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(242, 42);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(31, 123);
            tbName.Name = "tbName";
            tbName.Size = new Size(402, 31);
            tbName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 95);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // CompanyAddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(468, 693);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(tbFlatFilter);
            Controls.Add(lbStudentFlat);
            Controls.Add(label5);
            Controls.Add(tbBuildingFilter);
            Controls.Add(lbStudentBuilding);
            Controls.Add(label4);
            Controls.Add(tbId);
            Controls.Add(label1);
            Name = "CompanyAddStudent";
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbId;
        private TextBox tbFlatFilter;
        private ListBox lbStudentFlat;
        private Label label5;
        private TextBox tbBuildingFilter;
        private ListBox lbStudentBuilding;
        private Label label4;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox tbName;
        private Label label2;
    }
}