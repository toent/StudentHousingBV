namespace StudentHousingBV.Company_App
{
    partial class CompanyNavigator
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
            pShowForm = new Panel();
            pFormTitle = new Panel();
            lblTitle = new Label();
            pSideMenu = new Panel();
            btnFlats = new Button();
            btnBuildings = new Button();
            btnFiledComplaint = new Button();
            btnStudents = new Button();
            btnAgreements = new Button();
            btnHouseRules = new Button();
            btnAnnouncements = new Button();
            pFormTitle.SuspendLayout();
            pSideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pShowForm
            // 
            pShowForm.Dock = DockStyle.Fill;
            pShowForm.Location = new Point(300, 150);
            pShowForm.Name = "pShowForm";
            pShowForm.Size = new Size(1598, 874);
            pShowForm.TabIndex = 5;
            // 
            // pFormTitle
            // 
            pFormTitle.BackColor = Color.White;
            pFormTitle.Controls.Add(lblTitle);
            pFormTitle.Dock = DockStyle.Top;
            pFormTitle.Location = new Point(300, 0);
            pFormTitle.Name = "pFormTitle";
            pFormTitle.Size = new Size(1598, 150);
            pFormTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(607, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(231, 65);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Buildings";
            // 
            // pSideMenu
            // 
            pSideMenu.BackColor = Color.WhiteSmoke;
            pSideMenu.Controls.Add(btnFlats);
            pSideMenu.Controls.Add(btnBuildings);
            pSideMenu.Controls.Add(btnFiledComplaint);
            pSideMenu.Controls.Add(btnStudents);
            pSideMenu.Controls.Add(btnAgreements);
            pSideMenu.Controls.Add(btnHouseRules);
            pSideMenu.Controls.Add(btnAnnouncements);
            pSideMenu.Dock = DockStyle.Left;
            pSideMenu.Location = new Point(0, 0);
            pSideMenu.Name = "pSideMenu";
            pSideMenu.Size = new Size(300, 1024);
            pSideMenu.TabIndex = 3;
            // 
            // btnFlats
            // 
            btnFlats.BackColor = Color.White;
            btnFlats.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFlats.ForeColor = Color.FromArgb(26, 37, 47);
            btnFlats.Location = new Point(3, 279);
            btnFlats.Margin = new Padding(3, 20, 3, 20);
            btnFlats.Name = "btnFlats";
            btnFlats.Size = new Size(294, 69);
            btnFlats.TabIndex = 7;
            btnFlats.Text = "Flats";
            btnFlats.UseVisualStyleBackColor = false;
            btnFlats.Click += Navigation_Click;
            // 
            // btnBuildings
            // 
            btnBuildings.BackColor = Color.White;
            btnBuildings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuildings.ForeColor = Color.FromArgb(26, 37, 47);
            btnBuildings.Location = new Point(3, 170);
            btnBuildings.Margin = new Padding(3, 20, 3, 20);
            btnBuildings.Name = "btnBuildings";
            btnBuildings.Size = new Size(294, 69);
            btnBuildings.TabIndex = 6;
            btnBuildings.Text = "Buildings";
            btnBuildings.UseVisualStyleBackColor = false;
            btnBuildings.Click += Navigation_Click;
            // 
            // btnFiledComplaint
            // 
            btnFiledComplaint.BackColor = Color.White;
            btnFiledComplaint.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiledComplaint.ForeColor = Color.FromArgb(26, 37, 47);
            btnFiledComplaint.Location = new Point(3, 824);
            btnFiledComplaint.Margin = new Padding(3, 20, 3, 20);
            btnFiledComplaint.Name = "btnFiledComplaint";
            btnFiledComplaint.Size = new Size(294, 69);
            btnFiledComplaint.TabIndex = 5;
            btnFiledComplaint.Text = "Complaints";
            btnFiledComplaint.UseVisualStyleBackColor = false;
            btnFiledComplaint.Click += Navigation_Click;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.White;
            btnStudents.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.ForeColor = Color.FromArgb(26, 37, 47);
            btnStudents.Location = new Point(3, 388);
            btnStudents.Margin = new Padding(3, 20, 3, 20);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(294, 69);
            btnStudents.TabIndex = 4;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += Navigation_Click;
            // 
            // btnAgreements
            // 
            btnAgreements.BackColor = Color.White;
            btnAgreements.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgreements.ForeColor = Color.FromArgb(26, 37, 47);
            btnAgreements.Location = new Point(3, 715);
            btnAgreements.Margin = new Padding(3, 20, 3, 20);
            btnAgreements.Name = "btnAgreements";
            btnAgreements.Size = new Size(294, 69);
            btnAgreements.TabIndex = 2;
            btnAgreements.Text = "Agreements";
            btnAgreements.UseVisualStyleBackColor = false;
            btnAgreements.Click += Navigation_Click;
            // 
            // btnHouseRules
            // 
            btnHouseRules.BackColor = Color.White;
            btnHouseRules.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHouseRules.ForeColor = Color.FromArgb(26, 37, 47);
            btnHouseRules.Location = new Point(3, 606);
            btnHouseRules.Margin = new Padding(3, 20, 3, 20);
            btnHouseRules.Name = "btnHouseRules";
            btnHouseRules.Size = new Size(294, 69);
            btnHouseRules.TabIndex = 1;
            btnHouseRules.Text = "House rules";
            btnHouseRules.UseVisualStyleBackColor = false;
            btnHouseRules.Click += Navigation_Click;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.BackColor = Color.White;
            btnAnnouncements.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnouncements.ForeColor = Color.FromArgb(26, 37, 47);
            btnAnnouncements.Location = new Point(3, 497);
            btnAnnouncements.Margin = new Padding(3, 20, 3, 20);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(294, 69);
            btnAnnouncements.TabIndex = 0;
            btnAnnouncements.Text = "Announcements";
            btnAnnouncements.UseVisualStyleBackColor = false;
            btnAnnouncements.Click += Navigation_Click;
            // 
            // CompanyNavigator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(pShowForm);
            Controls.Add(pFormTitle);
            Controls.Add(pSideMenu);
            Name = "CompanyNavigator";
            Text = "Company - Student Housing B.V.";
            pFormTitle.ResumeLayout(false);
            pFormTitle.PerformLayout();
            pSideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pShowForm;
        private Panel pFormTitle;
        private Label lblTitle;
        private Panel pSideMenu;
        private Button btnFiledComplaint;
        private Button btnStudents;
        private Button btnAgreements;
        private Button btnHouseRules;
        private Button btnAnnouncements;
        private Button btnFlats;
        private Button btnBuildings;
    }
}