﻿namespace StudentHousingBV.Company_App
{
    partial class CompanyAgreements
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
            lblCreatorFilter = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            cbxSelectedCreator = new ComboBox();
            pAgreements = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            cbxSelectedFlat = new ComboBox();
            label3 = new Label();
            cbxSelectedBuilding = new ComboBox();
            SuspendLayout();
            // 
            // lblCreatorFilter
            // 
            lblCreatorFilter.AutoSize = true;
            lblCreatorFilter.Font = new Font("Segoe UI", 10F);
            lblCreatorFilter.Location = new Point(488, 10);
            lblCreatorFilter.Margin = new Padding(2, 0, 2, 0);
            lblCreatorFilter.Name = "lblCreatorFilter";
            lblCreatorFilter.Size = new Size(58, 19);
            lblCreatorFilter.TabIndex = 17;
            lblCreatorFilter.Text = "Creator:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarFont = new Font("Segoe UI", 9F);
            dtpEndDate.Font = new Font("Segoe UI", 10F);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(982, 8);
            dtpEndDate.Margin = new Padding(2, 2, 2, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(114, 25);
            dtpEndDate.TabIndex = 16;
            dtpEndDate.Value = new DateTime(2025, 1, 10, 0, 0, 0, 0);
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarFont = new Font("Segoe UI", 9F);
            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(841, 8);
            dtpStartDate.Margin = new Padding(2, 2, 2, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(112, 25);
            dtpStartDate.TabIndex = 15;
            dtpStartDate.Value = new DateTime(2025, 1, 10, 0, 0, 0, 0);
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // cbxSelectedCreator
            // 
            cbxSelectedCreator.Font = new Font("Segoe UI", 10F);
            cbxSelectedCreator.FormattingEnabled = true;
            cbxSelectedCreator.Location = new Point(549, 8);
            cbxSelectedCreator.Margin = new Padding(2, 2, 2, 2);
            cbxSelectedCreator.Name = "cbxSelectedCreator";
            cbxSelectedCreator.Size = new Size(180, 25);
            cbxSelectedCreator.TabIndex = 13;
            cbxSelectedCreator.SelectedIndexChanged += cbxSelectedCreator_SelectedIndexChanged;
            // 
            // pAgreements
            // 
            pAgreements.AutoScroll = true;
            pAgreements.Location = new Point(8, 37);
            pAgreements.Margin = new Padding(2, 2, 2, 2);
            pAgreements.Name = "pAgreements";
            pAgreements.Size = new Size(1086, 447);
            pAgreements.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(956, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(22, 19);
            label2.TabIndex = 18;
            label2.Text = "to";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(262, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 19);
            label1.TabIndex = 20;
            label1.Text = "Flat:";
            // 
            // cbxSelectedFlat
            // 
            cbxSelectedFlat.Font = new Font("Segoe UI", 10F);
            cbxSelectedFlat.FormattingEnabled = true;
            cbxSelectedFlat.Location = new Point(300, 8);
            cbxSelectedFlat.Margin = new Padding(2, 2, 2, 2);
            cbxSelectedFlat.Name = "cbxSelectedFlat";
            cbxSelectedFlat.Size = new Size(180, 25);
            cbxSelectedFlat.TabIndex = 19;
            cbxSelectedFlat.SelectedIndexChanged += cbxSelectedFlat_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(8, 11);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 22;
            label3.Text = "Building:";
            // 
            // cbxSelectedBuilding
            // 
            cbxSelectedBuilding.Font = new Font("Segoe UI", 10F);
            cbxSelectedBuilding.FormattingEnabled = true;
            cbxSelectedBuilding.Location = new Point(74, 8);
            cbxSelectedBuilding.Margin = new Padding(2, 2, 2, 2);
            cbxSelectedBuilding.Name = "cbxSelectedBuilding";
            cbxSelectedBuilding.Size = new Size(180, 25);
            cbxSelectedBuilding.TabIndex = 21;
            cbxSelectedBuilding.SelectedIndexChanged += cbxSelectedBuilding_SelectedIndexChanged;
            // 
            // CompanyAgreements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1103, 491);
            Controls.Add(label3);
            Controls.Add(cbxSelectedBuilding);
            Controls.Add(label1);
            Controls.Add(cbxSelectedFlat);
            Controls.Add(label2);
            Controls.Add(lblCreatorFilter);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cbxSelectedCreator);
            Controls.Add(pAgreements);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CompanyAgreements";
            Text = "CompanyAgreements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreatorFilter;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private ComboBox cbxSelectedCreator;
        private FlowLayoutPanel pAgreements;
        private Label label2;
        private Label label1;
        private ComboBox cbxSelectedFlat;
        private Label label3;
        private ComboBox cbxSelectedBuilding;
    }
}