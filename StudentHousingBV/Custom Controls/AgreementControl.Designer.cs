namespace StudentHousingBV.Custom_Controls
{
    partial class AgreementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAgreementCreator = new Label();
            gbAgreementProperties = new GroupBox();
            btnDeleteAgreement = new Button();
            lblCreationDateTime = new Label();
            gbAgreementContent = new GroupBox();
            btnAgreeTo = new Button();
            lblAgreedBy = new Label();
            lblAgreementContent = new Label();
            gbAgreementProperties.SuspendLayout();
            gbAgreementContent.SuspendLayout();
            SuspendLayout();
            // 
            // lblAgreementCreator
            // 
            lblAgreementCreator.AutoSize = true;
            lblAgreementCreator.Font = new Font("Segoe UI", 15F);
            lblAgreementCreator.Location = new Point(6, 27);
            lblAgreementCreator.Name = "lblAgreementCreator";
            lblAgreementCreator.Size = new Size(265, 41);
            lblAgreementCreator.TabIndex = 0;
            lblAgreementCreator.Text = "By: [StudentName]";
            // 
            // gbAgreementProperties
            // 
            gbAgreementProperties.Controls.Add(btnDeleteAgreement);
            gbAgreementProperties.Controls.Add(lblCreationDateTime);
            gbAgreementProperties.Controls.Add(lblAgreementCreator);
            gbAgreementProperties.Location = new Point(3, 3);
            gbAgreementProperties.Name = "gbAgreementProperties";
            gbAgreementProperties.Size = new Size(414, 436);
            gbAgreementProperties.TabIndex = 1;
            gbAgreementProperties.TabStop = false;
            gbAgreementProperties.Text = "About";
            // 
            // btnDeleteAgreement
            // 
            btnDeleteAgreement.Font = new Font("Segoe UI", 15F);
            btnDeleteAgreement.Location = new Point(6, 364);
            btnDeleteAgreement.Name = "btnDeleteAgreement";
            btnDeleteAgreement.Size = new Size(402, 66);
            btnDeleteAgreement.TabIndex = 4;
            btnDeleteAgreement.Text = "Delete";
            btnDeleteAgreement.UseVisualStyleBackColor = true;
            btnDeleteAgreement.Click += btnDeleteAgreement_Click;
            // 
            // lblCreationDateTime
            // 
            lblCreationDateTime.AutoSize = true;
            lblCreationDateTime.Font = new Font("Segoe UI", 15F);
            lblCreationDateTime.Location = new Point(6, 82);
            lblCreationDateTime.Name = "lblCreationDateTime";
            lblCreationDateTime.Size = new Size(163, 41);
            lblCreationDateTime.TabIndex = 1;
            lblCreationDateTime.Text = "[DateTime]";
            // 
            // gbAgreementContent
            // 
            gbAgreementContent.Controls.Add(btnAgreeTo);
            gbAgreementContent.Controls.Add(lblAgreedBy);
            gbAgreementContent.Controls.Add(lblAgreementContent);
            gbAgreementContent.Location = new Point(423, 3);
            gbAgreementContent.Name = "gbAgreementContent";
            gbAgreementContent.Size = new Size(1074, 436);
            gbAgreementContent.TabIndex = 3;
            gbAgreementContent.TabStop = false;
            gbAgreementContent.Text = "Content";
            // 
            // btnAgreeTo
            // 
            btnAgreeTo.Font = new Font("Segoe UI", 15F);
            btnAgreeTo.Location = new Point(800, 364);
            btnAgreeTo.Name = "btnAgreeTo";
            btnAgreeTo.Size = new Size(268, 66);
            btnAgreeTo.TabIndex = 6;
            btnAgreeTo.Text = "(Un)Agree";
            btnAgreeTo.UseVisualStyleBackColor = true;
            btnAgreeTo.Click += btnAgreeTo_Click;
            // 
            // lblAgreedBy
            // 
            lblAgreedBy.Location = new Point(6, 364);
            lblAgreedBy.Name = "lblAgreedBy";
            lblAgreedBy.Size = new Size(788, 66);
            lblAgreedBy.TabIndex = 5;
            lblAgreedBy.Text = "Agreed by: [StudentNameList]";
            // 
            // lblAgreementContent
            // 
            lblAgreementContent.Font = new Font("Segoe UI", 15F);
            lblAgreementContent.Location = new Point(6, 30);
            lblAgreementContent.Name = "lblAgreementContent";
            lblAgreementContent.Size = new Size(1062, 334);
            lblAgreementContent.TabIndex = 4;
            lblAgreementContent.Text = "[Content]";
            // 
            // AgreementControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbAgreementContent);
            Controls.Add(gbAgreementProperties);
            Name = "AgreementControl";
            Size = new Size(1500, 442);
            gbAgreementProperties.ResumeLayout(false);
            gbAgreementProperties.PerformLayout();
            gbAgreementContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblAgreementCreator;
        private GroupBox gbAgreementProperties;
        private Label lblCreationDateTime;
        private GroupBox gbAgreementContent;
        private Button btnAgreeTo;
        private Label lblAgreedBy;
        private Label lblAgreementContent;
        private Button btnDeleteAgreement;
    }
}
