namespace StudentHousingBV
{
    partial class DatamanagerTesting
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
            btnCreateBuilding = new Button();
            tbBuildingAddress = new TextBox();
            label1 = new Label();
            lbCurrentBuildings = new ListBox();
            lblJsonDebug = new Label();
            btnLoadJson = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            cbBuildingIdFlat = new ComboBox();
            label2 = new Label();
            btnCreateFlat = new Button();
            tbFlatNumber = new TextBox();
            lbCurrentFlats = new ListBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            tbContractId = new TextBox();
            cbFlatIdStudent = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            cbBuildingIdStudent = new ComboBox();
            label5 = new Label();
            btnCreateStudent = new Button();
            tbStudentName = new TextBox();
            lbCurrentStudent = new ListBox();
            groupBox4 = new GroupBox();
            cbRuleIsForBuilding = new CheckBox();
            label8 = new Label();
            cbFlatIdRule = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            cbBuildingIdRule = new ComboBox();
            btnCreateRule = new Button();
            tbRuleContent = new TextBox();
            lbCurrentRules = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateBuilding
            // 
            btnCreateBuilding.Location = new Point(11, 113);
            btnCreateBuilding.Name = "btnCreateBuilding";
            btnCreateBuilding.Size = new Size(303, 33);
            btnCreateBuilding.TabIndex = 0;
            btnCreateBuilding.Text = "Create Building";
            btnCreateBuilding.UseVisualStyleBackColor = true;
            btnCreateBuilding.Click += btnCreateBuilding_Click;
            // 
            // tbBuildingAddress
            // 
            tbBuildingAddress.Location = new Point(11, 65);
            tbBuildingAddress.Name = "tbBuildingAddress";
            tbBuildingAddress.Size = new Size(303, 31);
            tbBuildingAddress.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 2;
            label1.Text = "Building Address:";
            // 
            // lbCurrentBuildings
            // 
            lbCurrentBuildings.FormattingEnabled = true;
            lbCurrentBuildings.ItemHeight = 25;
            lbCurrentBuildings.Location = new Point(346, 30);
            lbCurrentBuildings.Name = "lbCurrentBuildings";
            lbCurrentBuildings.Size = new Size(443, 154);
            lbCurrentBuildings.TabIndex = 3;
            // 
            // lblJsonDebug
            // 
            lblJsonDebug.Location = new Point(23, 632);
            lblJsonDebug.Name = "lblJsonDebug";
            lblJsonDebug.Size = new Size(1614, 231);
            lblJsonDebug.TabIndex = 4;
            lblJsonDebug.Text = "Json Debug";
            lblJsonDebug.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLoadJson
            // 
            btnLoadJson.Location = new Point(12, 548);
            btnLoadJson.Name = "btnLoadJson";
            btnLoadJson.Size = new Size(795, 65);
            btnLoadJson.TabIndex = 5;
            btnLoadJson.Text = "Load Json";
            btnLoadJson.UseVisualStyleBackColor = true;
            btnLoadJson.Click += btnLoadJson_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCreateBuilding);
            groupBox1.Controls.Add(tbBuildingAddress);
            groupBox1.Controls.Add(lbCurrentBuildings);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 211);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Buildings";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbBuildingIdFlat);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnCreateFlat);
            groupBox2.Controls.Add(tbFlatNumber);
            groupBox2.Controls.Add(lbCurrentFlats);
            groupBox2.Location = new Point(842, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(795, 246);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create Flats";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 38);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 7;
            label4.Text = "Building ID:";
            // 
            // cbBuildingIdFlat
            // 
            cbBuildingIdFlat.FormattingEnabled = true;
            cbBuildingIdFlat.Location = new Point(129, 35);
            cbBuildingIdFlat.Name = "cbBuildingIdFlat";
            cbBuildingIdFlat.Size = new Size(182, 33);
            cbBuildingIdFlat.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 76);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 2;
            label2.Text = "Flat Number:";
            // 
            // btnCreateFlat
            // 
            btnCreateFlat.Location = new Point(13, 154);
            btnCreateFlat.Name = "btnCreateFlat";
            btnCreateFlat.Size = new Size(303, 33);
            btnCreateFlat.TabIndex = 0;
            btnCreateFlat.Text = "Create Flat";
            btnCreateFlat.UseVisualStyleBackColor = true;
            btnCreateFlat.Click += btnCreateFlat_Click;
            // 
            // tbFlatNumber
            // 
            tbFlatNumber.Location = new Point(13, 111);
            tbFlatNumber.Name = "tbFlatNumber";
            tbFlatNumber.Size = new Size(303, 31);
            tbFlatNumber.TabIndex = 1;
            // 
            // lbCurrentFlats
            // 
            lbCurrentFlats.FormattingEnabled = true;
            lbCurrentFlats.ItemHeight = 25;
            lbCurrentFlats.Location = new Point(346, 30);
            lbCurrentFlats.Name = "lbCurrentFlats";
            lbCurrentFlats.Size = new Size(443, 204);
            lbCurrentFlats.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(tbContractId);
            groupBox3.Controls.Add(cbFlatIdStudent);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cbBuildingIdStudent);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnCreateStudent);
            groupBox3.Controls.Add(tbStudentName);
            groupBox3.Controls.Add(lbCurrentStudent);
            groupBox3.Location = new Point(12, 229);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(795, 313);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Create Students";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 186);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 11;
            label7.Text = "ContractID:";
            // 
            // tbContractId
            // 
            tbContractId.Location = new Point(13, 220);
            tbContractId.Name = "tbContractId";
            tbContractId.Size = new Size(303, 31);
            tbContractId.TabIndex = 10;
            // 
            // cbFlatIdStudent
            // 
            cbFlatIdStudent.FormattingEnabled = true;
            cbFlatIdStudent.Location = new Point(129, 76);
            cbFlatIdStudent.Name = "cbFlatIdStudent";
            cbFlatIdStudent.Size = new Size(182, 33);
            cbFlatIdStudent.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 79);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 8;
            label6.Text = "Flat ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 38);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 7;
            label3.Text = "Building ID:";
            // 
            // cbBuildingIdStudent
            // 
            cbBuildingIdStudent.FormattingEnabled = true;
            cbBuildingIdStudent.Location = new Point(129, 35);
            cbBuildingIdStudent.Name = "cbBuildingIdStudent";
            cbBuildingIdStudent.Size = new Size(182, 33);
            cbBuildingIdStudent.TabIndex = 6;
            cbBuildingIdStudent.SelectedIndexChanged += cbBuildingIdStudent_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 118);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 2;
            label5.Text = "Student Name:";
            // 
            // btnCreateStudent
            // 
            btnCreateStudent.Location = new Point(13, 260);
            btnCreateStudent.Name = "btnCreateStudent";
            btnCreateStudent.Size = new Size(303, 33);
            btnCreateStudent.TabIndex = 0;
            btnCreateStudent.Text = "Create Student";
            btnCreateStudent.UseVisualStyleBackColor = true;
            btnCreateStudent.Click += btnCreateStudent_Click;
            // 
            // tbStudentName
            // 
            tbStudentName.Location = new Point(13, 152);
            tbStudentName.Name = "tbStudentName";
            tbStudentName.Size = new Size(303, 31);
            tbStudentName.TabIndex = 1;
            // 
            // lbCurrentStudent
            // 
            lbCurrentStudent.FormattingEnabled = true;
            lbCurrentStudent.ItemHeight = 25;
            lbCurrentStudent.Location = new Point(346, 30);
            lbCurrentStudent.Name = "lbCurrentStudent";
            lbCurrentStudent.Size = new Size(443, 254);
            lbCurrentStudent.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbRuleIsForBuilding);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(cbFlatIdRule);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(cbBuildingIdRule);
            groupBox4.Controls.Add(btnCreateRule);
            groupBox4.Controls.Add(tbRuleContent);
            groupBox4.Controls.Add(lbCurrentRules);
            groupBox4.Location = new Point(842, 264);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(795, 349);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Create Rule";
            // 
            // cbRuleIsForBuilding
            // 
            cbRuleIsForBuilding.AutoSize = true;
            cbRuleIsForBuilding.Location = new Point(13, 118);
            cbRuleIsForBuilding.Name = "cbRuleIsForBuilding";
            cbRuleIsForBuilding.Size = new Size(187, 29);
            cbRuleIsForBuilding.TabIndex = 6;
            cbRuleIsForBuilding.Text = "Rule is for building";
            cbRuleIsForBuilding.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 155);
            label8.Name = "label8";
            label8.Size = new Size(118, 25);
            label8.TabIndex = 11;
            label8.Text = "Rule Content:";
            // 
            // cbFlatIdRule
            // 
            cbFlatIdRule.FormattingEnabled = true;
            cbFlatIdRule.Location = new Point(129, 76);
            cbFlatIdRule.Name = "cbFlatIdRule";
            cbFlatIdRule.Size = new Size(182, 33);
            cbFlatIdRule.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 79);
            label9.Name = "label9";
            label9.Size = new Size(67, 25);
            label9.TabIndex = 8;
            label9.Text = "Flat ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 43);
            label10.Name = "label10";
            label10.Size = new Size(103, 25);
            label10.TabIndex = 7;
            label10.Text = "Building ID:";
            // 
            // cbBuildingIdRule
            // 
            cbBuildingIdRule.FormattingEnabled = true;
            cbBuildingIdRule.Location = new Point(129, 35);
            cbBuildingIdRule.Name = "cbBuildingIdRule";
            cbBuildingIdRule.Size = new Size(182, 33);
            cbBuildingIdRule.TabIndex = 6;
            // 
            // btnCreateRule
            // 
            btnCreateRule.Location = new Point(13, 299);
            btnCreateRule.Name = "btnCreateRule";
            btnCreateRule.Size = new Size(303, 33);
            btnCreateRule.TabIndex = 0;
            btnCreateRule.Text = "Create Rule";
            btnCreateRule.UseVisualStyleBackColor = true;
            // 
            // tbRuleContent
            // 
            tbRuleContent.Location = new Point(13, 189);
            tbRuleContent.Multiline = true;
            tbRuleContent.Name = "tbRuleContent";
            tbRuleContent.ScrollBars = ScrollBars.Vertical;
            tbRuleContent.Size = new Size(303, 95);
            tbRuleContent.TabIndex = 1;
            // 
            // lbCurrentRules
            // 
            lbCurrentRules.FormattingEnabled = true;
            lbCurrentRules.ItemHeight = 25;
            lbCurrentRules.Location = new Point(346, 30);
            lbCurrentRules.Name = "lbCurrentRules";
            lbCurrentRules.Size = new Size(443, 304);
            lbCurrentRules.TabIndex = 3;
            // 
            // DatamanagerTesting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1648, 872);
            Controls.Add(groupBox4);
            Controls.Add(btnLoadJson);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblJsonDebug);
            Name = "DatamanagerTesting";
            Text = "DatamanagerTesting";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateBuilding;
        private TextBox tbBuildingAddress;
        private Label label1;
        private ListBox lbCurrentBuildings;
        private Label lblJsonDebug;
        private Button btnLoadJson;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox cbBuildingIdFlat;
        private Label label2;
        private Button btnCreateFlat;
        private TextBox tbFlatNumber;
        private ListBox lbCurrentFlats;
        private GroupBox groupBox3;
        private Label label3;
        private ComboBox cbBuildingIdStudent;
        private Label label5;
        private Button btnCreateStudent;
        private TextBox tbStudentName;
        private ListBox lbCurrentStudent;
        private ComboBox cbFlatIdStudent;
        private Label label6;
        private Label label7;
        private TextBox tbContractId;
        private GroupBox groupBox4;
        private Label label8;
        private ComboBox cbFlatIdRule;
        private Label label9;
        private Label label10;
        private ComboBox cbBuildingIdRule;
        private Button btnCreateRule;
        private TextBox tbRuleContent;
        private ListBox lbCurrentRules;
        private CheckBox cbRuleIsForBuilding;
    }
}