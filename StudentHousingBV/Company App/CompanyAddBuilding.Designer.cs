﻿namespace StudentHousingBV.Company_App
{
    partial class CompanyAddBuilding
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
            tbAddress = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(23, 52);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(363, 31);
            tbAddress.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 24);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(165, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(221, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(23, 144);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CompanyAddBuilding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 191);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(tbAddress);
            Controls.Add(label3);
            Name = "CompanyAddBuilding";
            Text = "CompanyAddBuilding";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAddress;
        private Label label3;
        private Button btnAdd;
        private Button btnCancel;
    }
}