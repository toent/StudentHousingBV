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
            label1 = new Label();
            label2 = new Label();
            cbFlat = new ComboBox();
            panelRules = new Panel();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(485, 9);
            label1.Name = "label1";
            label1.Size = new Size(379, 81);
            label1.TabIndex = 0;
            label1.Text = "House Rules";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 146);
            label2.Name = "label2";
            label2.Size = new Size(44, 27);
            label2.TabIndex = 1;
            label2.Text = "Flat";
            // 
            // cbFlat
            // 
            cbFlat.FormattingEnabled = true;
            cbFlat.Location = new Point(422, 149);
            cbFlat.Name = "cbFlat";
            cbFlat.Size = new Size(151, 28);
            cbFlat.TabIndex = 2;
            // 
            // panelRules
            // 
            panelRules.Location = new Point(372, 227);
            panelRules.Name = "panelRules";
            panelRules.Size = new Size(863, 157);
            panelRules.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.ActiveCaption;
            btnCreate.Location = new Point(794, 149);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(170, 29);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // HouseRulesCompany
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnCreate);
            Controls.Add(panelRules);
            Controls.Add(cbFlat);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HouseRulesCompany";
            Text = "HouseRulesCompany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbFlat;
        private Panel panelRules;
        private Button btnCreate;
    }
}