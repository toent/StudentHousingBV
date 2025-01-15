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
            label3.Location = new Point(8, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 38;
            label3.Text = "Building:";
            // 
            // cbBuilding
            // 
            cbBuilding.Font = new Font("Segoe UI", 10F);
            cbBuilding.FormattingEnabled = true;
            cbBuilding.Location = new Point(74, 8);
            cbBuilding.Margin = new Padding(2);
            cbBuilding.Name = "cbBuilding";
            cbBuilding.Size = new Size(180, 25);
            cbBuilding.TabIndex = 37;
            cbBuilding.SelectedIndexChanged += cbBuilding_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(262, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 19);
            label1.TabIndex = 36;
            label1.Text = "Flat:";
            // 
            // cbFlat
            // 
            cbFlat.Font = new Font("Segoe UI", 10F);
            cbFlat.FormattingEnabled = true;
            cbFlat.Location = new Point(300, 8);
            cbFlat.Margin = new Padding(2);
            cbFlat.Name = "cbFlat";
            cbFlat.Size = new Size(180, 25);
            cbFlat.TabIndex = 35;
            cbFlat.SelectedIndexChanged += cbFlat_SelectedIndexChanged;
            // 
            // pComplaints
            // 
            pComplaints.AutoScroll = true;
            pComplaints.Location = new Point(8, 35);
            pComplaints.Margin = new Padding(2);
            pComplaints.Name = "pComplaints";
            pComplaints.Size = new Size(1086, 447);
            pComplaints.TabIndex = 31;
            // 
            // checkBoxViewAll
            // 
            checkBoxViewAll.AutoSize = true;
            checkBoxViewAll.Checked = true;
            checkBoxViewAll.CheckState = CheckState.Checked;
            checkBoxViewAll.Location = new Point(509, 10);
            checkBoxViewAll.Name = "checkBoxViewAll";
            checkBoxViewAll.Size = new Size(128, 19);
            checkBoxViewAll.TabIndex = 39;
            checkBoxViewAll.Text = "View all complaints";
            checkBoxViewAll.UseVisualStyleBackColor = true;
            checkBoxViewAll.CheckedChanged += checkBoxViewAll_CheckedChanged;
            // 
            // CompanyComplaints
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1103, 491);
            Controls.Add(checkBoxViewAll);
            Controls.Add(label3);
            Controls.Add(cbBuilding);
            Controls.Add(label1);
            Controls.Add(cbFlat);
            Controls.Add(pComplaints);
            Margin = new Padding(2);
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