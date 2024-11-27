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
            btnCreateBuilding.Location = new Point(8, 57);
            btnCreateBuilding.Margin = new Padding(2);
            btnCreateBuilding.Name = "btnCreateBuilding";
            btnCreateBuilding.Size = new Size(212, 20);
            btnCreateBuilding.TabIndex = 0;
            btnCreateBuilding.Text = "Create Building";
            btnCreateBuilding.UseVisualStyleBackColor = true;
            btnCreateBuilding.Click += btnCreateBuilding_Click;
            // 
            // tbBuildingAddress
            // 
            tbBuildingAddress.Location = new Point(8, 28);
            tbBuildingAddress.Margin = new Padding(2);
            tbBuildingAddress.Name = "tbBuildingAddress";
            tbBuildingAddress.Size = new Size(213, 23);
            tbBuildingAddress.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "Building Address:";
            // 
            // lbCurrentBuildings
            // 
            lbCurrentBuildings.FormattingEnabled = true;
            lbCurrentBuildings.ItemHeight = 15;
            lbCurrentBuildings.Location = new Point(242, 7);
            lbCurrentBuildings.Margin = new Padding(2);
            lbCurrentBuildings.Name = "lbCurrentBuildings";
            lbCurrentBuildings.Size = new Size(311, 109);
            lbCurrentBuildings.TabIndex = 3;
            // 
            // lblJsonDebug
            // 
            lblJsonDebug.Location = new Point(8, 134);
            lblJsonDebug.Margin = new Padding(2, 0, 2, 0);
            lblJsonDebug.Name = "lblJsonDebug";
            lblJsonDebug.Size = new Size(543, 131);
            lblJsonDebug.TabIndex = 4;
            lblJsonDebug.Text = "Json Debug";
            lblJsonDebug.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLoadJson
            // 
            btnLoadJson.Location = new Point(8, 83);
            btnLoadJson.Margin = new Padding(2);
            btnLoadJson.Name = "btnLoadJson";
            btnLoadJson.Size = new Size(212, 20);
            btnLoadJson.TabIndex = 5;
            btnLoadJson.Text = "Load Json";
            btnLoadJson.UseVisualStyleBackColor = true;
            btnLoadJson.Click += btnLoadJson_Click;
            // 
            // DatamanagerTesting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnLoadJson);
            Controls.Add(lblJsonDebug);
            Controls.Add(lbCurrentBuildings);
            Controls.Add(label1);
            Controls.Add(tbBuildingAddress);
            Controls.Add(btnCreateBuilding);
            Margin = new Padding(2);
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