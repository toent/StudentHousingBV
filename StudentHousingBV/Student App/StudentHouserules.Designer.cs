namespace StudentHousingBV
{
    partial class StudentHouserules
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
            panelRules = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 39);
            label1.Name = "label1";
            label1.Size = new Size(423, 89);
            label1.TabIndex = 0;
            label1.Text = "House Rules";
            // 
            // panelRules
            // 
            panelRules.Location = new Point(65, 141);
            panelRules.Name = "panelRules";
            panelRules.Size = new Size(712, 564);
            panelRules.TabIndex = 1;
            // 
            // StudentHouserules
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelRules);
            Controls.Add(label1);
            Name = "StudentHouserules";
            Text = "h";
            Load += StudentHouserules_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panelRules;
    }
}