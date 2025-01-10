namespace StudentHousingBV.Company_App
{
    partial class CompanyAddAnnouncement
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
            btnCancel = new Button();
            btnAdd = new Button();
            rtbMessage = new RichTextBox();
            label4 = new Label();
            tbTitle = new TextBox();
            label1 = new Label();
            cbGlobal = new CheckBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(357, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(475, 386);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(201, 34);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(12, 103);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(664, 277);
            rtbMessage.TabIndex = 13;
            rtbMessage.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 75);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 12;
            label4.Text = "Message";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(12, 41);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(296, 31);
            tbTitle.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 10;
            label1.Text = "Title";
            // 
            // cbGlobal
            // 
            cbGlobal.AutoSize = true;
            cbGlobal.Location = new Point(461, 41);
            cbGlobal.Name = "cbGlobal";
            cbGlobal.Size = new Size(215, 29);
            cbGlobal.TabIndex = 16;
            cbGlobal.Text = "Global Announcement";
            cbGlobal.UseVisualStyleBackColor = true;
            // 
            // CompanyAddAnnouncement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 432);
            Controls.Add(cbGlobal);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(rtbMessage);
            Controls.Add(label4);
            Controls.Add(tbTitle);
            Controls.Add(label1);
            Name = "CompanyAddAnnouncement";
            Text = "Add announcement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private RichTextBox rtbMessage;
        private Label label4;
        private TextBox tbTitle;
        private Label label1;
        private CheckBox cbGlobal;
    }
}