namespace StudentHousingBV.Student_App
{
    partial class StudentAgreements
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
            btnAddAgreement = new Button();
            pAgreements = new FlowLayoutPanel();
            cbxSelectAgreementCreator = new ComboBox();
            cbUnagreedOnly = new CheckBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblCreatorFilter = new Label();
            label2 = new Label();
            btnShowMine = new Button();
            SuspendLayout();
            // 
            // btnAddAgreement
            // 
            btnAddAgreement.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAgreement.Location = new Point(1338, 12);
            btnAddAgreement.Name = "btnAddAgreement";
            btnAddAgreement.Size = new Size(226, 37);
            btnAddAgreement.TabIndex = 3;
            btnAddAgreement.Text = "Add Agreement";
            btnAddAgreement.UseVisualStyleBackColor = true;
            btnAddAgreement.Click += btnAddAgreement_Click;
            // 
            // pAgreements
            // 
            pAgreements.AutoScroll = true;
            pAgreements.Location = new Point(12, 61);
            pAgreements.Name = "pAgreements";
            pAgreements.Size = new Size(1552, 745);
            pAgreements.TabIndex = 4;
            // 
            // cbxSelectAgreementCreator
            // 
            cbxSelectAgreementCreator.Font = new Font("Segoe UI", 10F);
            cbxSelectAgreementCreator.FormattingEnabled = true;
            cbxSelectAgreementCreator.Location = new Point(99, 15);
            cbxSelectAgreementCreator.Name = "cbxSelectAgreementCreator";
            cbxSelectAgreementCreator.Size = new Size(255, 36);
            cbxSelectAgreementCreator.TabIndex = 5;
            cbxSelectAgreementCreator.SelectedIndexChanged += cbxSelectAgreementCreator_SelectedIndexChanged;
            // 
            // cbUnagreedOnly
            // 
            cbUnagreedOnly.AutoSize = true;
            cbUnagreedOnly.Font = new Font("Segoe UI", 10F);
            cbUnagreedOnly.Location = new Point(696, 15);
            cbUnagreedOnly.Name = "cbUnagreedOnly";
            cbUnagreedOnly.Size = new Size(223, 32);
            cbUnagreedOnly.TabIndex = 6;
            cbUnagreedOnly.Text = "Show Unagreed Only";
            cbUnagreedOnly.UseVisualStyleBackColor = true;
            cbUnagreedOnly.CheckedChanged += cbUnagreedOnly_CheckedChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarFont = new Font("Segoe UI", 9F);
            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(939, 13);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(159, 34);
            dtpStartDate.TabIndex = 7;
            dtpStartDate.Value = new DateTime(2025, 1, 10, 0, 0, 0, 0);
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarFont = new Font("Segoe UI", 9F);
            dtpEndDate.Font = new Font("Segoe UI", 10F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(1141, 13);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(161, 34);
            dtpEndDate.TabIndex = 8;
            dtpEndDate.Value = new DateTime(2025, 1, 10, 0, 0, 0, 0);
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // lblCreatorFilter
            // 
            lblCreatorFilter.AutoSize = true;
            lblCreatorFilter.Font = new Font("Segoe UI", 10F);
            lblCreatorFilter.Location = new Point(12, 18);
            lblCreatorFilter.Name = "lblCreatorFilter";
            lblCreatorFilter.Size = new Size(81, 28);
            lblCreatorFilter.TabIndex = 9;
            lblCreatorFilter.Text = "Creator:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(1104, 16);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 11;
            label2.Text = "to";
            // 
            // btnShowMine
            // 
            btnShowMine.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowMine.Location = new Point(360, 14);
            btnShowMine.Name = "btnShowMine";
            btnShowMine.Size = new Size(258, 37);
            btnShowMine.TabIndex = 12;
            btnShowMine.Text = "Show My Agreements";
            btnShowMine.UseVisualStyleBackColor = true;
            btnShowMine.Click += btnShowMine_Click;
            // 
            // StudentAgreements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(btnShowMine);
            Controls.Add(label2);
            Controls.Add(lblCreatorFilter);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cbUnagreedOnly);
            Controls.Add(cbxSelectAgreementCreator);
            Controls.Add(pAgreements);
            Controls.Add(btnAddAgreement);
            Name = "StudentAgreements";
            Text = "StudentAgreements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddAgreement;
        private FlowLayoutPanel pAgreements;
        private ComboBox cbxSelectAgreementCreator;
        private CheckBox cbUnagreedOnly;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label lblCreatorFilter;
        private Label label2;
        private Button btnShowMine;
    }
}