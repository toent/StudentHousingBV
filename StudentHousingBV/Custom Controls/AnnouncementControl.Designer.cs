namespace StudentHousingBV.Custom_Controls
{
    partial class AnnouncementControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblPublishedDate = new Label();
            label5 = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblPublishedDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1499, 86);
            panel1.TabIndex = 1;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.Location = new Point(1323, 42);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(141, 25);
            lblPublishedDate.TabIndex = 5;
            lblPublishedDate.Text = "[Published Date]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1323, 17);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 4;
            label5.Text = "Published";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(21, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(114, 48);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "[Title]";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(21, 109);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1456, 173);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "[Description]";
            // 
            // AnnouncementControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDescription);
            Controls.Add(panel1);
            Name = "AnnouncementControl";
            Size = new Size(1499, 300);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPublishedDate;
        private Label label5;
        private Label lblDueDate;
        private Label lblTitle;
        private Label lblDescription;
    }
}
