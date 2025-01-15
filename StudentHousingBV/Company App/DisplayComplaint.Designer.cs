namespace StudentHousingBV.Company_App
{
    partial class DisplayComplaint
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
            pComplaints = new FlowLayoutPanel();
            cbFlat = new ComboBox();
            cbBuilding = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            checkBoxViewAll = new CheckBox();
            SuspendLayout();
            // 
            // pComplaints
            // 
            pComplaints.AutoScroll = true;
            pComplaints.Location = new Point(8, 40);
            pComplaints.Margin = new Padding(2);
            pComplaints.Name = "pComplaints";
            pComplaints.Size = new Size(1086, 443);
            pComplaints.TabIndex = 13;
            // 
            // cbFlat
            // 
            cbFlat.FormattingEnabled = true;
            cbFlat.Location = new Point(307, 11);
            cbFlat.Margin = new Padding(2);
            cbFlat.Name = "cbFlat";
            cbFlat.Size = new Size(189, 23);
            cbFlat.TabIndex = 12;
            cbFlat.SelectedIndexChanged += cbFlat_SelectedIndexChanged;
            // 
            // cbBuilding
            // 
            cbBuilding.FormattingEnabled = true;
            cbBuilding.Location = new Point(66, 11);
            cbBuilding.Margin = new Padding(2);
            cbBuilding.Name = "cbBuilding";
            cbBuilding.Size = new Size(189, 23);
            cbBuilding.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 10;
            label2.Text = "Flat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Building";
            // 
            // checkBoxViewAll
            // 
            checkBoxViewAll.AutoSize = true;
            checkBoxViewAll.Location = new Point(540, 12);
            checkBoxViewAll.Name = "checkBoxViewAll";
            checkBoxViewAll.Size = new Size(128, 19);
            checkBoxViewAll.TabIndex = 14;
            checkBoxViewAll.Text = "View all complaints";
            checkBoxViewAll.UseVisualStyleBackColor = true;
            checkBoxViewAll.CheckedChanged += checkBoxViewAll_CheckedChanged;
            // 
            // DisplayComplaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 593);
            Controls.Add(checkBoxViewAll);
            Controls.Add(pComplaints);
            Controls.Add(cbFlat);
            Controls.Add(cbBuilding);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DisplayComplaint";
            Text = "DisplayComplaint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel pComplaints;
        private ComboBox cbFlat;
        private ComboBox cbBuilding;
        private Label label2;
        private Label label1;
        private CheckBox checkBoxViewAll;
    }
}