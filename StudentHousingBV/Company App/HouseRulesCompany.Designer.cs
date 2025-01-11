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
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 12);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 1;
            label2.Text = "Flat";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.WhiteSmoke;
            btnCreate.FlatStyle = FlatStyle.System;
            btnCreate.Font = new Font("Segoe UI", 12F);
            btnCreate.Location = new Point(943, 8);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(148, 29);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // cbxFlat
            // 
            cbxFlat.FormattingEnabled = true;
            cbxFlat.Location = new Point(276, 11);
            cbxFlat.Margin = new Padding(3, 2, 3, 2);
            cbxFlat.Name = "cbxFlat";
            cbxFlat.Size = new Size(133, 23);
            cbxFlat.TabIndex = 5;
            cbxFlat.SelectedIndexChanged += cbxFlat_SelectedIndexChanged;
            // 
            // cbxBuilding
            // 
            cbxBuilding.FormattingEnabled = true;
            cbxBuilding.Location = new Point(85, 12);
            cbxBuilding.Margin = new Padding(3, 2, 3, 2);
            cbxBuilding.Name = "cbxBuilding";
            cbxBuilding.Size = new Size(133, 23);
            cbxBuilding.TabIndex = 7;
            cbxBuilding.SelectedIndexChanged += cbxBuilding_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 6;
            label1.Text = "Building";
            // 
            // flpRules
            // 
            flpRules.AutoScroll = true;
            flpRules.Location = new Point(12, 40);
            flpRules.Name = "flpRules";
            flpRules.Size = new Size(1079, 439);
            flpRules.TabIndex = 8;
            // 
            // HouseRulesCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1103, 491);
            Controls.Add(flpRules);
            Controls.Add(cbxBuilding);
            Controls.Add(label1);
            Controls.Add(cbxFlat);
            Controls.Add(btnCreate);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
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