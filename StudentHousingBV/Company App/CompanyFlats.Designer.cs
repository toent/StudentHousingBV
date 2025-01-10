namespace StudentHousingBV.Company_App
{
    partial class CompanyFlats
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
            gbFlatInfo = new GroupBox();
            lbFlatOverview = new ListBox();
            label4 = new Label();
            tbFlatNum = new TextBox();
            label3 = new Label();
            tbFlatId = new TextBox();
            label2 = new Label();
            btnDeleteFlat = new Button();
            btnModifyFlat = new Button();
            btnAddFlat = new Button();
            label1 = new Label();
            lbFlats = new ListBox();
            tbBuildingFilter = new TextBox();
            lbBuildingFilter = new ListBox();
            label5 = new Label();
            gbFlatInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gbFlatInfo
            // 
            gbFlatInfo.Controls.Add(lbFlatOverview);
            gbFlatInfo.Controls.Add(label4);
            gbFlatInfo.Controls.Add(tbFlatNum);
            gbFlatInfo.Controls.Add(label3);
            gbFlatInfo.Controls.Add(tbFlatId);
            gbFlatInfo.Controls.Add(label2);
            gbFlatInfo.Location = new Point(1096, 56);
            gbFlatInfo.Name = "gbFlatInfo";
            gbFlatInfo.Size = new Size(468, 695);
            gbFlatInfo.TabIndex = 11;
            gbFlatInfo.TabStop = false;
            gbFlatInfo.Text = "Building information";
            // 
            // lbFlatOverview
            // 
            lbFlatOverview.FormattingEnabled = true;
            lbFlatOverview.ItemHeight = 25;
            lbFlatOverview.Location = new Point(19, 245);
            lbFlatOverview.Name = "lbFlatOverview";
            lbFlatOverview.Size = new Size(428, 429);
            lbFlatOverview.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 217);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 4;
            label4.Text = "Student overview";
            // 
            // tbFlatNum
            // 
            tbFlatNum.Location = new Point(19, 154);
            tbFlatNum.Name = "tbFlatNum";
            tbFlatNum.Size = new Size(428, 31);
            tbFlatNum.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 126);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 2;
            label3.Text = "Flat Number";
            // 
            // tbFlatId
            // 
            tbFlatId.Enabled = false;
            tbFlatId.Location = new Point(19, 77);
            tbFlatId.Name = "tbFlatId";
            tbFlatId.Size = new Size(428, 31);
            tbFlatId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 49);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 0;
            label2.Text = "Id";
            // 
            // btnDeleteFlat
            // 
            btnDeleteFlat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteFlat.Location = new Point(766, 105);
            btnDeleteFlat.Name = "btnDeleteFlat";
            btnDeleteFlat.Size = new Size(228, 43);
            btnDeleteFlat.TabIndex = 10;
            btnDeleteFlat.Text = "Delete flat";
            btnDeleteFlat.UseVisualStyleBackColor = true;
            // 
            // btnModifyFlat
            // 
            btnModifyFlat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifyFlat.Location = new Point(1096, 757);
            btnModifyFlat.Name = "btnModifyFlat";
            btnModifyFlat.Size = new Size(468, 43);
            btnModifyFlat.TabIndex = 9;
            btnModifyFlat.Text = "Modify flat";
            btnModifyFlat.UseVisualStyleBackColor = true;
            // 
            // btnAddFlat
            // 
            btnAddFlat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFlat.Location = new Point(766, 56);
            btnAddFlat.Name = "btnAddFlat";
            btnAddFlat.Size = new Size(228, 43);
            btnAddFlat.TabIndex = 8;
            btnAddFlat.Text = "Add flat";
            btnAddFlat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 7;
            label1.Text = "Flats";
            // 
            // lbFlats
            // 
            lbFlats.FormattingEnabled = true;
            lbFlats.ItemHeight = 25;
            lbFlats.Location = new Point(12, 56);
            lbFlats.Name = "lbFlats";
            lbFlats.Size = new Size(736, 729);
            lbFlats.TabIndex = 6;
            // 
            // tbBuildingFilter
            // 
            tbBuildingFilter.Location = new Point(766, 244);
            tbBuildingFilter.Name = "tbBuildingFilter";
            tbBuildingFilter.Size = new Size(228, 31);
            tbBuildingFilter.TabIndex = 13;
            // 
            // lbBuildingFilter
            // 
            lbBuildingFilter.FormattingEnabled = true;
            lbBuildingFilter.ItemHeight = 25;
            lbBuildingFilter.Location = new Point(766, 281);
            lbBuildingFilter.Name = "lbBuildingFilter";
            lbBuildingFilter.Size = new Size(228, 504);
            lbBuildingFilter.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(766, 216);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 15;
            label5.Text = "Select a building";
            // 
            // CompanyFlats
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(label5);
            Controls.Add(lbBuildingFilter);
            Controls.Add(tbBuildingFilter);
            Controls.Add(gbFlatInfo);
            Controls.Add(btnDeleteFlat);
            Controls.Add(btnModifyFlat);
            Controls.Add(btnAddFlat);
            Controls.Add(label1);
            Controls.Add(lbFlats);
            Name = "CompanyFlats";
            Text = "CompanyFlats";
            gbFlatInfo.ResumeLayout(false);
            gbFlatInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbFlatInfo;
        private ListBox lbFlatOverview;
        private Label label4;
        private TextBox tbFlatNum;
        private Label label3;
        private TextBox tbFlatId;
        private Label label2;
        private Button btnDeleteFlat;
        private Button btnModifyFlat;
        private Button btnAddFlat;
        private Label label1;
        private ListBox lbFlats;
        private TextBox tbBuildingFilter;
        private ListBox lbBuildingFilter;
        private Label label5;
    }
}