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
            tbxDescription.Location = new Point(17, 57);
            tbxDescription.Margin = new Padding(4, 5, 4, 5);
            tbxDescription.Multiline = true;
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(567, 126);
            tbxDescription.TabIndex = 0;
            // 
            // lblRuleAddPageTitle
            // 
            lblRuleAddPageTitle.AutoSize = true;
            lblRuleAddPageTitle.Font = new Font("Segoe UI", 12F);
            lblRuleAddPageTitle.Location = new Point(17, 17);
            lblRuleAddPageTitle.Margin = new Padding(4, 0, 4, 0);
            lblRuleAddPageTitle.Name = "lblRuleAddPageTitle";
            lblRuleAddPageTitle.Size = new Size(116, 32);
            lblRuleAddPageTitle.TabIndex = 1;
            lblRuleAddPageTitle.Text = "Add Rule:";
            // 
            // btnAddUpdate
            // 
            btnAddUpdate.BackColor = Color.FromArgb(240, 243, 255);
            btnAddUpdate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddUpdate.Location = new Point(17, 199);
            btnAddUpdate.Margin = new Padding(4, 5, 4, 5);
            btnAddUpdate.Name = "btnAddUpdate";
            btnAddUpdate.Size = new Size(567, 44);
            btnAddUpdate.TabIndex = 2;
            btnAddUpdate.Text = "Add Rule";
            btnAddUpdate.UseVisualStyleBackColor = false;
            btnAddUpdate.Click += btnAddUpdate_Click;
            // 
            // CompanyAddHouseRule
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(603, 257);
            Controls.Add(btnAddUpdate);
            Controls.Add(lblRuleAddPageTitle);
            Controls.Add(tbxDescription);
            Margin = new Padding(4, 5, 4, 5);
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