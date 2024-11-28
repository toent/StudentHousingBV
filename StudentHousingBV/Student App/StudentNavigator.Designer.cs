namespace StudentHousingBV
{
    partial class StudentNavigator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pSideMenu = new Panel();
            btnFileComplaint = new Button();
            btnGroceries = new Button();
            btnChores = new Button();
            btnAgreements = new Button();
            btnHouseRules = new Button();
            btnAnnouncements = new Button();
            pFormTitle = new Panel();
            lblContractId = new Label();
            lblUserName = new Label();
            btnLogout = new Button();
            pShowForm = new Panel();
            label1 = new Label();
            lblTitle = new Label();
            pSideMenu.SuspendLayout();
            pFormTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pSideMenu
            // 
            pSideMenu.Controls.Add(btnFileComplaint);
            pSideMenu.Controls.Add(btnGroceries);
            pSideMenu.Controls.Add(btnChores);
            pSideMenu.Controls.Add(btnAgreements);
            pSideMenu.Controls.Add(btnHouseRules);
            pSideMenu.Controls.Add(btnAnnouncements);
            pSideMenu.Dock = DockStyle.Left;
            pSideMenu.Location = new Point(0, 0);
            pSideMenu.Name = "pSideMenu";
            pSideMenu.Size = new Size(300, 1024);
            pSideMenu.TabIndex = 0;
            // 
            // btnFileComplaint
            // 
            btnFileComplaint.BackColor = Color.FromArgb(214, 223, 255);
            btnFileComplaint.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFileComplaint.ForeColor = Color.FromArgb(26, 37, 47);
            btnFileComplaint.Location = new Point(3, 818);
            btnFileComplaint.Margin = new Padding(3, 20, 3, 20);
            btnFileComplaint.Name = "btnFileComplaint";
            btnFileComplaint.Size = new Size(294, 69);
            btnFileComplaint.TabIndex = 5;
            btnFileComplaint.Text = "File complaint";
            btnFileComplaint.UseVisualStyleBackColor = false;
            // 
            // btnGroceries
            // 
            btnGroceries.BackColor = Color.FromArgb(214, 223, 255);
            btnGroceries.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGroceries.ForeColor = Color.FromArgb(26, 37, 47);
            btnGroceries.Location = new Point(3, 709);
            btnGroceries.Margin = new Padding(3, 20, 3, 20);
            btnGroceries.Name = "btnGroceries";
            btnGroceries.Size = new Size(294, 69);
            btnGroceries.TabIndex = 4;
            btnGroceries.Text = "Groceries";
            btnGroceries.UseVisualStyleBackColor = false;
            // 
            // btnChores
            // 
            btnChores.BackColor = Color.FromArgb(214, 223, 255);
            btnChores.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChores.ForeColor = Color.FromArgb(26, 37, 47);
            btnChores.Location = new Point(3, 600);
            btnChores.Margin = new Padding(3, 20, 3, 20);
            btnChores.Name = "btnChores";
            btnChores.Size = new Size(294, 69);
            btnChores.TabIndex = 3;
            btnChores.Text = "Chores";
            btnChores.UseVisualStyleBackColor = false;
            // 
            // btnAgreements
            // 
            btnAgreements.BackColor = Color.FromArgb(214, 223, 255);
            btnAgreements.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgreements.ForeColor = Color.FromArgb(26, 37, 47);
            btnAgreements.Location = new Point(3, 491);
            btnAgreements.Margin = new Padding(3, 20, 3, 20);
            btnAgreements.Name = "btnAgreements";
            btnAgreements.Size = new Size(294, 69);
            btnAgreements.TabIndex = 2;
            btnAgreements.Text = "Agreements";
            btnAgreements.UseVisualStyleBackColor = false;
            // 
            // btnHouseRules
            // 
            btnHouseRules.BackColor = Color.FromArgb(214, 223, 255);
            btnHouseRules.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHouseRules.ForeColor = Color.FromArgb(26, 37, 47);
            btnHouseRules.Location = new Point(3, 382);
            btnHouseRules.Margin = new Padding(3, 20, 3, 20);
            btnHouseRules.Name = "btnHouseRules";
            btnHouseRules.Size = new Size(294, 69);
            btnHouseRules.TabIndex = 1;
            btnHouseRules.Text = "House rules";
            btnHouseRules.UseVisualStyleBackColor = false;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.BackColor = Color.FromArgb(214, 223, 255);
            btnAnnouncements.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnouncements.ForeColor = Color.FromArgb(26, 37, 47);
            btnAnnouncements.Location = new Point(3, 273);
            btnAnnouncements.Margin = new Padding(3, 20, 3, 20);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(294, 69);
            btnAnnouncements.TabIndex = 0;
            btnAnnouncements.Text = "Announcements";
            btnAnnouncements.UseVisualStyleBackColor = false;
            // 
            // pFormTitle
            // 
            pFormTitle.Controls.Add(lblTitle);
            pFormTitle.Controls.Add(label1);
            pFormTitle.Controls.Add(lblContractId);
            pFormTitle.Controls.Add(lblUserName);
            pFormTitle.Controls.Add(btnLogout);
            pFormTitle.Dock = DockStyle.Top;
            pFormTitle.Location = new Point(300, 0);
            pFormTitle.Name = "pFormTitle";
            pFormTitle.Size = new Size(1598, 150);
            pFormTitle.TabIndex = 1;
            // 
            // lblContractId
            // 
            lblContractId.AutoSize = true;
            lblContractId.Location = new Point(6, 37);
            lblContractId.Name = "lblContractId";
            lblContractId.Size = new Size(152, 25);
            lblContractId.TabIndex = 2;
            lblContractId.Text = "F8364BFJ-235432";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(6, 12);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(113, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Aleix Urbano";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLogout.Location = new Point(1418, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(168, 43);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // pShowForm
            // 
            pShowForm.Dock = DockStyle.Fill;
            pShowForm.Location = new Point(300, 150);
            pShowForm.Name = "pShowForm";
            pShowForm.Size = new Size(1598, 874);
            pShowForm.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 62);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 3;
            label1.Text = "Lombokpad 1 - Flat 2";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(607, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(385, 65);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Announcements";
            // 
            // StudentNavigator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1898, 1024);
            Controls.Add(pShowForm);
            Controls.Add(pFormTitle);
            Controls.Add(pSideMenu);
            Name = "StudentNavigator";
            Text = "Form1";
            pSideMenu.ResumeLayout(false);
            pFormTitle.ResumeLayout(false);
            pFormTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSideMenu;
        private Panel pFormTitle;
        private Panel pShowForm;
        private Button btnAnnouncements;
        private Button btnFileComplaint;
        private Button btnGroceries;
        private Button btnChores;
        private Button btnAgreements;
        private Button btnHouseRules;
        private Label lblContractId;
        private Label lblUserName;
        private Button btnLogout;
        private Label label1;
        private Label lblTitle;
    }
}
