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
            SuspendLayout();
            // 
            // btnCreateBuilding
            // 
            btnCreateBuilding.Location = new Point(12, 78);
            btnCreateBuilding.Name = "btnCreateBuilding";
            btnCreateBuilding.Size = new Size(303, 34);
            btnCreateBuilding.TabIndex = 0;
            btnCreateBuilding.Text = "Create Building";
            btnCreateBuilding.UseVisualStyleBackColor = true;
            btnCreateBuilding.Click += btnCreateBuilding_Click;
            // 
            // tbBuildingAddress
            // 
            tbBuildingAddress.Location = new Point(12, 41);
            tbBuildingAddress.Name = "tbBuildingAddress";
            tbBuildingAddress.Size = new Size(303, 31);
            tbBuildingAddress.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 2;
            label1.Text = "Building Address:";
            // 
            // lbCurrentBuildings
            // 
            lbCurrentBuildings.FormattingEnabled = true;
            lbCurrentBuildings.ItemHeight = 25;
            lbCurrentBuildings.Location = new Point(345, 12);
            lbCurrentBuildings.Name = "lbCurrentBuildings";
            lbCurrentBuildings.Size = new Size(443, 179);
            lbCurrentBuildings.TabIndex = 3;
            // 
            // lblJsonDebug
            // 
            lblJsonDebug.Location = new Point(12, 223);
            lblJsonDebug.Name = "lblJsonDebug";
            lblJsonDebug.Size = new Size(776, 218);
            lblJsonDebug.TabIndex = 4;
            lblJsonDebug.Text = "Json Debug";
            lblJsonDebug.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLoadJson
            // 
            btnLoadJson.Location = new Point(12, 118);
            btnLoadJson.Name = "btnLoadJson";
            btnLoadJson.Size = new Size(303, 34);
            btnLoadJson.TabIndex = 5;
            btnLoadJson.Text = "Load Json";
            btnLoadJson.UseVisualStyleBackColor = true;
            btnLoadJson.Click += btnLoadJson_Click;
            // 
            // DatamanagerTesting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadJson);
            Controls.Add(lblJsonDebug);
            Controls.Add(lbCurrentBuildings);
            Controls.Add(label1);
            Controls.Add(tbBuildingAddress);
            Controls.Add(btnCreateBuilding);
            Name = "DatamanagerTesting";
            Text = "DatamanagerTesting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateBuilding;
        private TextBox tbBuildingAddress;
        private Label label1;
        private ListBox lbCurrentBuildings;
        private Label lblJsonDebug;
        private Button btnLoadJson;
    }
}