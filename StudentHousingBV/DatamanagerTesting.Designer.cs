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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            lbCurrentBuildings.Size = new Size(443, 179);
            lbCurrentBuildings.TabIndex = 3;
            // 
            // lblJsonDebug
            // 
            lblJsonDebug.Location = new Point(13, 244);
            lblJsonDebug.Name = "lblJsonDebug";
            lblJsonDebug.Size = new Size(776, 218);
            lblJsonDebug.TabIndex = 4;
            lblJsonDebug.Text = "Json Debug";
            lblJsonDebug.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLoadJson
            // 
            btnLoadJson.Location = new Point(11, 156);
            btnLoadJson.Name = "btnLoadJson";
            btnLoadJson.Size = new Size(303, 33);
            btnLoadJson.TabIndex = 5;
            btnLoadJson.Text = "Load Json";
            btnLoadJson.UseVisualStyleBackColor = true;
            btnLoadJson.Click += btnLoadJson_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLoadJson);
            groupBox1.Controls.Add(btnCreateBuilding);
            groupBox1.Controls.Add(lblJsonDebug);
            groupBox1.Controls.Add(tbBuildingAddress);
            groupBox1.Controls.Add(lbCurrentBuildings);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 478);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Buildings";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(857, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(795, 478);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create Flats";
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
            // button1
            // 
            button1.Location = new Point(13, 193);
            button1.Name = "button1";
            button1.Size = new Size(303, 33);
            button1.TabIndex = 5;
            button1.Text = "Load Json";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(13, 154);
            button2.Name = "button2";
            button2.Size = new Size(303, 33);
            button2.TabIndex = 0;
            button2.Text = "Create Building";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(13, 244);
            label3.Name = "label3";
            label3.Size = new Size(776, 218);
            label3.TabIndex = 4;
            label3.Text = "Json Debug";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 31);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(346, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(443, 179);
            listBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
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
            // DatamanagerTesting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1848, 815);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DatamanagerTesting";
            Text = "DatamanagerTesting";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private ComboBox comboBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
        private ListBox listBox1;
    }
}