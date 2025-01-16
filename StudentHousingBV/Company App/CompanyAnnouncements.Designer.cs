namespace StudentHousingBV.Company_App
{
    partial class CompanyAnnouncements
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
            btnAddAnnouncement = new Button();
            label1 = new Label();
            label2 = new Label();
            cbBuilding = new ComboBox();
            cbFlat = new ComboBox();
            pAnnouncements = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnAddAnnouncement
            // 
            btnAddAnnouncement.BackColor = Color.FromArgb(240, 243, 255);
            btnAddAnnouncement.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAddAnnouncement.Location = new Point(1314, 12);
            btnAddAnnouncement.Name = "btnAddAnnouncement";
            btnAddAnnouncement.Size = new Size(250, 43);
            btnAddAnnouncement.TabIndex = 1;
            btnAddAnnouncement.Text = "Add Announcement";
            btnAddAnnouncement.UseVisualStyleBackColor = false;
            btnAddAnnouncement.Click += btnAddAnnouncement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 3;
            label1.Text = "Building";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(388, 19);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 4;
            label2.Text = "Flat";
            // 
            // cbBuilding
            // 
            cbBuilding.FormattingEnabled = true;
            cbBuilding.Location = new Point(94, 19);
            cbBuilding.Name = "cbBuilding";
            cbBuilding.Size = new Size(268, 33);
            cbBuilding.TabIndex = 5;
            cbBuilding.SelectedIndexChanged += cbBuilding_SelectedIndexChanged;
            // 
            // cbFlat
            // 
            cbFlat.FormattingEnabled = true;
            cbFlat.Location = new Point(438, 19);
            cbFlat.Name = "cbFlat";
            cbFlat.Size = new Size(268, 33);
            cbFlat.TabIndex = 6;
            cbFlat.SelectedIndexChanged += cbFlat_SelectedIndexChanged;
            // 
            // pAnnouncements
            // 
            pAnnouncements.AutoScroll = true;
            pAnnouncements.Location = new Point(12, 67);
            pAnnouncements.Name = "pAnnouncements";
            pAnnouncements.Size = new Size(1552, 739);
            pAnnouncements.TabIndex = 7;
            // 
            // CompanyAnnouncements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(pAnnouncements);
            Controls.Add(cbFlat);
            Controls.Add(cbBuilding);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddAnnouncement);
            Name = "CompanyAnnouncements";
            Text = "CompanyAnnouncements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddAnnouncement;
        private Label label1;
        private Label label2;
        private ComboBox cbBuilding;
        private ComboBox cbFlat;
        private FlowLayoutPanel pAnnouncements;
    }
}