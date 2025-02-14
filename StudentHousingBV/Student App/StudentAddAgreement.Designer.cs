﻿namespace StudentHousingBV.Student_App
{
    partial class StudentAddAgreement
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
            btnCreateAgreement = new Button();
            label1 = new Label();
            tbxAgreementContent = new TextBox();
            label2 = new Label();
            tbxAgreementTitle = new TextBox();
            SuspendLayout();
            // 
            // btnCreateAgreement
            // 
            btnCreateAgreement.BackColor = Color.FromArgb(240, 243, 255);
            btnCreateAgreement.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAgreement.Location = new Point(30, 553);
            btnCreateAgreement.Name = "btnCreateAgreement";
            btnCreateAgreement.Size = new Size(792, 44);
            btnCreateAgreement.TabIndex = 1;
            btnCreateAgreement.Text = "Create Agreement";
            btnCreateAgreement.UseVisualStyleBackColor = false;
            btnCreateAgreement.Click += btnCreateAgreement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(30, 124);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 2;
            label1.Text = "Agreement Content:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxAgreementContent
            // 
            tbxAgreementContent.Location = new Point(30, 152);
            tbxAgreementContent.Multiline = true;
            tbxAgreementContent.Name = "tbxAgreementContent";
            tbxAgreementContent.ScrollBars = ScrollBars.Vertical;
            tbxAgreementContent.Size = new Size(792, 356);
            tbxAgreementContent.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(30, 30);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 4;
            label2.Text = "Agreement Title:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbxAgreementTitle
            // 
            tbxAgreementTitle.Location = new Point(30, 58);
            tbxAgreementTitle.Name = "tbxAgreementTitle";
            tbxAgreementTitle.Size = new Size(792, 31);
            tbxAgreementTitle.TabIndex = 3;
            // 
            // StudentAddAgreement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(856, 621);
            Controls.Add(label2);
            Controls.Add(tbxAgreementTitle);
            Controls.Add(label1);
            Controls.Add(btnCreateAgreement);
            Controls.Add(tbxAgreementContent);
            Name = "StudentAddAgreement";
            Text = "Create An Agreement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreateAgreement;
        private Label label1;
        private TextBox tbxAgreementContent;
        private Label label2;
        private TextBox tbxAgreementTitle;
    }
}