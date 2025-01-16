namespace StudentHousingBV
{
    partial class HouseRulesCompany
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
            label2 = new Label();
            btnCreate = new Button();
            cbxFlat = new ComboBox();
            cbxBuilding = new ComboBox();
            label1 = new Label();
            flpRules = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(336, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 1;
            label2.Text = "Flat";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(240, 243, 255);
            btnCreate.FlatStyle = FlatStyle.System;
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCreate.Location = new Point(1347, 13);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(211, 48);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // cbxFlat
            // 
            cbxFlat.FormattingEnabled = true;
            cbxFlat.Location = new Point(388, 20);
            cbxFlat.Margin = new Padding(4, 3, 4, 3);
            cbxFlat.Name = "cbxFlat";
            cbxFlat.Size = new Size(188, 33);
            cbxFlat.TabIndex = 5;
            cbxFlat.SelectedIndexChanged += cbxFlat_SelectedIndexChanged;
            // 
            // cbxBuilding
            // 
            cbxBuilding.FormattingEnabled = true;
            cbxBuilding.Location = new Point(109, 20);
            cbxBuilding.Margin = new Padding(4, 3, 4, 3);
            cbxBuilding.Name = "cbxBuilding";
            cbxBuilding.Size = new Size(188, 33);
            cbxBuilding.TabIndex = 7;
            cbxBuilding.SelectedIndexChanged += cbxBuilding_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(17, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 6;
            label1.Text = "Building";
            // 
            // flpRules
            // 
            flpRules.AutoScroll = true;
            flpRules.Location = new Point(17, 67);
            flpRules.Margin = new Padding(4, 5, 4, 5);
            flpRules.Name = "flpRules";
            flpRules.Size = new Size(1541, 732);
            flpRules.TabIndex = 8;
            // 
            // HouseRulesCompany
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(flpRules);
            Controls.Add(cbxBuilding);
            Controls.Add(label1);
            Controls.Add(cbxFlat);
            Controls.Add(btnCreate);
            Controls.Add(label2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HouseRulesCompany";
            Text = "HouseRulesCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnCreate;
        private ComboBox cbxFlat;
        private ComboBox cbxBuilding;
        private Label label1;
        private FlowLayoutPanel flpRules;
    }
}