namespace StudentHousingBV.Company_App
{
    partial class CompanyAddHouseRule
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
            tbxDescription = new TextBox();
            lblRuleAddPageTitle = new Label();
            btnAddUpdate = new Button();
            SuspendLayout();
            // 
            // tbxDescription
            // 
            tbxDescription.Font = new Font("Segoe UI", 10F);
            tbxDescription.Location = new Point(12, 28);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(398, 77);
            tbxDescription.TabIndex = 0;
            // 
            // lblRuleAddPageTitle
            // 
            lblRuleAddPageTitle.AutoSize = true;
            lblRuleAddPageTitle.Font = new Font("Segoe UI", 12F);
            lblRuleAddPageTitle.Location = new Point(12, 4);
            lblRuleAddPageTitle.Name = "lblRuleAddPageTitle";
            lblRuleAddPageTitle.Size = new Size(90, 21);
            lblRuleAddPageTitle.TabIndex = 1;
            lblRuleAddPageTitle.Text = "Add A Rule:";
            // 
            // btnAddUpdate
            // 
            btnAddUpdate.Font = new Font("Segoe UI", 12F);
            btnAddUpdate.Location = new Point(130, 111);
            btnAddUpdate.Name = "btnAddUpdate";
            btnAddUpdate.Size = new Size(154, 36);
            btnAddUpdate.TabIndex = 2;
            btnAddUpdate.Text = "Add Rule";
            btnAddUpdate.UseVisualStyleBackColor = true;
            btnAddUpdate.Click += btnAddUpdate_Click;
            // 
            // CompanyAddHouseRule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 154);
            Controls.Add(btnAddUpdate);
            Controls.Add(lblRuleAddPageTitle);
            Controls.Add(tbxDescription);
            Name = "CompanyAddHouseRule";
            Text = "CompanyAddHouseRule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxDescription;
        private Label lblRuleAddPageTitle;
        private Button btnAddUpdate;
    }
}