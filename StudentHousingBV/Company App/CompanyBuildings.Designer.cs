namespace StudentHousingBV.Company_App
{
    partial class CompanyBuildings
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
            lbBuildings = new ListBox();
            label1 = new Label();
            btnAddBuilding = new Button();
            btnModifyBuilding = new Button();
            btnDeleteBuilding = new Button();
            groupBox1 = new GroupBox();
            lbFlatOverview = new ListBox();
            label4 = new Label();
            tbAddressId = new TextBox();
            label3 = new Label();
            tbFlatId = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbBuildings
            // 
            lbBuildings.FormattingEnabled = true;
            lbBuildings.ItemHeight = 25;
            lbBuildings.Location = new Point(12, 62);
            lbBuildings.Name = "lbBuildings";
            lbBuildings.Size = new Size(736, 729);
            lbBuildings.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "Buildings";
            // 
            // btnAddBuilding
            // 
            btnAddBuilding.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBuilding.Location = new Point(766, 62);
            btnAddBuilding.Name = "btnAddBuilding";
            btnAddBuilding.Size = new Size(228, 43);
            btnAddBuilding.TabIndex = 2;
            btnAddBuilding.Text = "Add building";
            btnAddBuilding.UseVisualStyleBackColor = true;
            btnAddBuilding.Click += btnAddBuilding_Click;
            // 
            // btnModifyBuilding
            // 
            btnModifyBuilding.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifyBuilding.Location = new Point(1096, 763);
            btnModifyBuilding.Name = "btnModifyBuilding";
            btnModifyBuilding.Size = new Size(468, 43);
            btnModifyBuilding.TabIndex = 3;
            btnModifyBuilding.Text = "Modify building";
            btnModifyBuilding.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBuilding
            // 
            btnDeleteBuilding.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteBuilding.Location = new Point(766, 111);
            btnDeleteBuilding.Name = "btnDeleteBuilding";
            btnDeleteBuilding.Size = new Size(228, 43);
            btnDeleteBuilding.TabIndex = 4;
            btnDeleteBuilding.Text = "Delete building";
            btnDeleteBuilding.UseVisualStyleBackColor = true;
            btnDeleteBuilding.Click += btnDeleteBuilding_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbFlatOverview);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbAddressId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbFlatId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1096, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 695);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Building information";
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
            label4.Size = new Size(115, 25);
            label4.TabIndex = 4;
            label4.Text = "Flat overview";
            // 
            // tbAddressId
            // 
            tbAddressId.Location = new Point(19, 154);
            tbAddressId.Name = "tbAddressId";
            tbAddressId.Size = new Size(428, 31);
            tbAddressId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 126);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Address";
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
            // CompanyBuildings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(groupBox1);
            Controls.Add(btnDeleteBuilding);
            Controls.Add(btnModifyBuilding);
            Controls.Add(btnAddBuilding);
            Controls.Add(label1);
            Controls.Add(lbBuildings);
            Name = "CompanyBuildings";
            Text = "CompanyBuildings";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbBuildings;
        private Label label1;
        private Button btnAddBuilding;
        private Button btnModifyBuilding;
        private Button btnDeleteBuilding;
        private GroupBox groupBox1;
        private TextBox tbFlatId;
        private Label label2;
        private TextBox tbAddressId;
        private Label label3;
        private Label label4;
        private ListBox lbFlatOverview;
    }
}