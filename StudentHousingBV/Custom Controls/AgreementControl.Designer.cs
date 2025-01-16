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
            lblAgreementTitle = new Label();
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
            lblAgreementCreator.Font = new Font("Segoe UI", 10F);
            lblAgreementCreator.Location = new Point(6, 319);
            lblAgreementCreator.Name = "lblAgreementCreator";
            lblAgreementCreator.Size = new Size(174, 28);
            lblAgreementCreator.TabIndex = 0;
            lblAgreementCreator.Text = "By: [StudentName]";
            // 
            // gbAgreementProperties
            // 
            gbAgreementProperties.Controls.Add(lblAgreementTitle);
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
            // lblAgreementTitle
            // 
            lblAgreementTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblAgreementTitle.Location = new Point(6, 30);
            lblAgreementTitle.Name = "lblAgreementTitle";
            lblAgreementTitle.Size = new Size(402, 217);
            lblAgreementTitle.TabIndex = 5;
            lblAgreementTitle.Text = "[Title]";
            // 
            // btnDeleteAgreement
            // 
            btnDeleteAgreement.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDeleteAgreement.Location = new Point(6, 387);
            btnDeleteAgreement.Name = "btnDeleteAgreement";
            btnDeleteAgreement.Size = new Size(402, 43);
            btnDeleteAgreement.TabIndex = 4;
            btnDeleteAgreement.Text = "Delete";
            btnDeleteAgreement.UseVisualStyleBackColor = true;
            btnDeleteAgreement.Click += btnDeleteAgreement_Click;
            // 
            // lblCreationDateTime
            // 
            lblCreationDateTime.AutoSize = true;
            lblCreationDateTime.Font = new Font("Segoe UI", 10F);
            lblCreationDateTime.Location = new Point(6, 347);
            lblCreationDateTime.Name = "lblCreationDateTime";
            lblCreationDateTime.Size = new Size(107, 28);
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
            gbAgreementContent.Size = new Size(1119, 436);
            gbAgreementContent.TabIndex = 3;
            gbAgreementContent.TabStop = false;
            gbAgreementContent.Text = "Content";
            // 
            // btnAgreeTo
            // 
            btnAgreeTo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAgreeTo.Location = new Point(885, 387);
            btnAgreeTo.Name = "btnAgreeTo";
            btnAgreeTo.Size = new Size(228, 43);
            btnAgreeTo.TabIndex = 6;
            btnAgreeTo.Text = "(Un)Agree";
            btnAgreeTo.UseVisualStyleBackColor = true;
            btnAgreeTo.Click += btnAgreeTo_Click;
            // 
            // lblAgreedBy
            // 
            lblAgreedBy.Font = new Font("Segoe UI", 10F);
            lblAgreedBy.Location = new Point(6, 319);
            lblAgreedBy.Name = "lblAgreedBy";
            lblAgreedBy.Size = new Size(873, 111);
            lblAgreedBy.TabIndex = 5;
            lblAgreedBy.Text = "Agreed by: [StudentNameList]";
            // 
            // lblAgreementContent
            // 
            lblAgreementContent.Font = new Font("Segoe UI", 10F);
            lblAgreementContent.Location = new Point(6, 30);
            lblAgreementContent.Name = "lblAgreementContent";
            lblAgreementContent.Size = new Size(1107, 245);
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
            Size = new Size(1545, 442);
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
        private Label lblAgreementTitle;
    }
}
