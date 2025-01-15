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
            cbBuilding = new ComboBox();
            label1 = new Label();
            cbFlat = new ComboBox();
            pComplaints = new FlowLayoutPanel();
            checkBoxViewAll = new CheckBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(11, 14);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 38;
            label3.Text = "Building";
            // 
            // cbBuilding
            // 
            cbBuilding.Font = new Font("Segoe UI", 10F);
            cbBuilding.FormattingEnabled = true;
            cbBuilding.Location = new Point(106, 13);
            cbBuilding.Name = "cbBuilding";
            cbBuilding.Size = new Size(255, 36);
            cbBuilding.TabIndex = 37;
            cbBuilding.SelectedIndexChanged += cbBuilding_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(374, 14);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 36;
            label1.Text = "Flat";
            // 
            // cbFlat
            // 
            cbFlat.Font = new Font("Segoe UI", 10F);
            cbFlat.FormattingEnabled = true;
            cbFlat.Location = new Point(429, 13);
            cbFlat.Name = "cbFlat";
            cbFlat.Size = new Size(255, 36);
            cbFlat.TabIndex = 35;
            cbFlat.SelectedIndexChanged += cbFlat_SelectedIndexChanged;
            // 
            // pComplaints
            // 
            pComplaints.AutoScroll = true;
            pComplaints.Location = new Point(11, 58);
            pComplaints.Name = "pComplaints";
            pComplaints.Size = new Size(1551, 745);
            pComplaints.TabIndex = 31;
            // 
            // checkBoxViewAll
            // 
            checkBoxViewAll.AutoSize = true;
            checkBoxViewAll.Checked = true;
            checkBoxViewAll.CheckState = CheckState.Checked;
            checkBoxViewAll.Location = new Point(727, 17);
            checkBoxViewAll.Margin = new Padding(4, 5, 4, 5);
            checkBoxViewAll.Name = "checkBoxViewAll";
            checkBoxViewAll.Size = new Size(189, 29);
            checkBoxViewAll.TabIndex = 39;
            checkBoxViewAll.Text = "View all complaints";
            checkBoxViewAll.UseVisualStyleBackColor = true;
            checkBoxViewAll.CheckedChanged += checkBoxViewAll_CheckedChanged;
            // 
            // CompanyComplaints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(checkBoxViewAll);
            Controls.Add(label3);
            Controls.Add(cbBuilding);
            Controls.Add(label1);
            Controls.Add(cbFlat);
            Controls.Add(pComplaints);
            Name = "CompanyComplaints";
            Text = "CompanyComplaints";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cbBuilding;
        private Label label1;
        private ComboBox cbFlat;
        private FlowLayoutPanel pComplaints;
        private CheckBox checkBoxViewAll;
    }
}