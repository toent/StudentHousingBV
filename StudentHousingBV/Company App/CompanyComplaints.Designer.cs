namespace StudentHousingBV.Company_App
{
    partial class CompanyComplaints
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
            label3 = new Label();
            cbSelectedBuilding = new ComboBox();
            label1 = new Label();
            cbSelectedFlat = new ComboBox();
            pComplaints = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 15);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 38;
            label3.Text = "Building:";
            // 
            // cbSelectedBuilding
            // 
            cbSelectedBuilding.Font = new Font("Segoe UI", 10F);
            cbSelectedBuilding.FormattingEnabled = true;
            cbSelectedBuilding.Location = new Point(106, 14);
            cbSelectedBuilding.Name = "cbSelectedBuilding";
            cbSelectedBuilding.Size = new Size(255, 36);
            cbSelectedBuilding.TabIndex = 37;
            cbSelectedBuilding.SelectedIndexChanged += cbSelectedBuilding_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(375, 14);
            label1.Name = "label1";
            label1.Size = new Size(48, 28);
            label1.TabIndex = 36;
            label1.Text = "Flat:";
            // 
            // cbSelectedFlat
            // 
            cbSelectedFlat.Font = new Font("Segoe UI", 10F);
            cbSelectedFlat.FormattingEnabled = true;
            cbSelectedFlat.Location = new Point(429, 14);
            cbSelectedFlat.Name = "cbSelectedFlat";
            cbSelectedFlat.Size = new Size(255, 36);
            cbSelectedFlat.TabIndex = 35;
            cbSelectedFlat.SelectedIndexChanged += cbSelectedFlat_SelectedIndexChanged;
            // 
            // pComplaints
            // 
            pComplaints.AutoScroll = true;
            pComplaints.Location = new Point(12, 59);
            pComplaints.Name = "pComplaints";
            pComplaints.Size = new Size(1551, 745);
            pComplaints.TabIndex = 31;
            // 
            // CompanyComplaints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(label3);
            Controls.Add(cbSelectedBuilding);
            Controls.Add(label1);
            Controls.Add(cbSelectedFlat);
            Controls.Add(pComplaints);
            Name = "CompanyComplaints";
            Text = "CompanyComplaints";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cbSelectedBuilding;
        private Label label1;
        private ComboBox cbSelectedFlat;
        private FlowLayoutPanel pComplaints;
    }
}