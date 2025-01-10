namespace StudentHousingBV.Custom_Controls
{
    partial class CompanyAnnouncementControl
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
            tbTitle = new TextBox();
            lblPublishedDate = new Label();
            label5 = new Label();
            rtbContent = new RichTextBox();
            btnApplyChanges = new Button();
            btnDelete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(tbTitle);
            panel1.Controls.Add(lblPublishedDate);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1499, 86);
            panel1.TabIndex = 2;
            // 
            // tbTitle
            // 
            tbTitle.BackColor = Color.WhiteSmoke;
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbTitle.Location = new Point(20, 17);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(1216, 48);
            tbTitle.TabIndex = 6;
            tbTitle.Text = "[Title]";
            tbTitle.TextChanged += tbTitle_TextChanged;
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
            // rtbContent
            // 
            rtbContent.BorderStyle = BorderStyle.None;
            rtbContent.Location = new Point(20, 100);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(1216, 182);
            rtbContent.TabIndex = 3;
            rtbContent.Text = "[Content]";
            rtbContent.TextChanged += rtbContent_TextChanged;
            // 
            // btnApplyChanges
            // 
            btnApplyChanges.Enabled = false;
            btnApplyChanges.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyChanges.Location = new Point(1242, 100);
            btnApplyChanges.Name = "btnApplyChanges";
            btnApplyChanges.Size = new Size(254, 34);
            btnApplyChanges.TabIndex = 4;
            btnApplyChanges.Text = "Apply Changes";
            btnApplyChanges.UseVisualStyleBackColor = true;
            btnApplyChanges.Click += btnApplyChanges_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1242, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(254, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CompanyAnnouncementControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnDelete);
            Controls.Add(btnApplyChanges);
            Controls.Add(rtbContent);
            Controls.Add(panel1);
            Name = "CompanyAnnouncementControl";
            Size = new Size(1499, 300);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbTitle;
        private Label lblPublishedDate;
        private Label label5;
        private RichTextBox rtbContent;
        private Button btnApplyChanges;
        private Button btnDelete;
    }
}
