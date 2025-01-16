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
            pComplaints.Location = new Point(11, 67);
            pComplaints.Name = "pComplaints";
            pComplaints.Size = new Size(1551, 738);
            pComplaints.TabIndex = 13;
            // 
            // cbFlat
            // 
            cbFlat.FormattingEnabled = true;
            cbFlat.Location = new Point(439, 18);
            cbFlat.Name = "cbFlat";
            cbFlat.Size = new Size(268, 33);
            cbFlat.TabIndex = 12;
            cbFlat.SelectedIndexChanged += cbFlat_SelectedIndexChanged;
            // 
            // cbBuilding
            // 
            cbBuilding.FormattingEnabled = true;
            cbBuilding.Location = new Point(94, 18);
            cbBuilding.Name = "cbBuilding";
            cbBuilding.Size = new Size(268, 33);
            cbBuilding.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(389, 18);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 10;
            label2.Text = "Flat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 9;
            label1.Text = "Building";
            // 
            // checkBoxViewAll
            // 
            checkBoxViewAll.AutoSize = true;
            checkBoxViewAll.Location = new Point(742, 20);
            checkBoxViewAll.Margin = new Padding(4, 5, 4, 5);
            checkBoxViewAll.Name = "checkBoxViewAll";
            checkBoxViewAll.Size = new Size(189, 29);
            checkBoxViewAll.TabIndex = 14;
            checkBoxViewAll.Text = "View all complaints";
            checkBoxViewAll.UseVisualStyleBackColor = true;
            checkBoxViewAll.CheckedChanged += checkBoxViewAll_CheckedChanged;
            // 
            // DisplayComplaint
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1911, 988);
            Controls.Add(checkBoxViewAll);
            Controls.Add(pComplaints);
            Controls.Add(cbFlat);
            Controls.Add(cbBuilding);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
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