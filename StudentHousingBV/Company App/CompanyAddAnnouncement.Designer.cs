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
            label2 = new Label();
            cbBuilding = new ComboBox();
            cbFlat = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(147, 444);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(241, 444);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 27);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(11, 218);
            rtbMessage.Margin = new Padding(2);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(391, 222);
            rtbMessage.TabIndex = 13;
            rtbMessage.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 196);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 12;
            label4.Text = "Message";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(10, 33);
            tbTitle.Margin = new Padding(2);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(179, 27);
            tbTitle.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 10;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 98);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 17;
            label2.Text = "Building";
            // 
            // cbBuilding
            // 
            cbBuilding.FormattingEnabled = true;
            cbBuilding.Location = new Point(10, 121);
            cbBuilding.Name = "cbBuilding";
            cbBuilding.Size = new Size(179, 28);
            cbBuilding.TabIndex = 18;
            cbBuilding.SelectedIndexChanged += cbBuilding_SelectedIndexChanged;
            // 
            // cbFlat
            // 
            cbFlat.FormattingEnabled = true;
            cbFlat.Location = new Point(223, 121);
            cbFlat.Name = "cbFlat";
            cbFlat.Size = new Size(179, 28);
            cbFlat.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 99);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 20;
            label3.Text = "Flat";
            // 
            // CompanyAddAnnouncement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 480);
            Controls.Add(label3);
            Controls.Add(cbFlat);
            Controls.Add(cbBuilding);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(rtbMessage);
            Controls.Add(label4);
            Controls.Add(tbTitle);
            Controls.Add(label1);
            Margin = new Padding(2);
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
        private Label label2;
        private ComboBox cbBuilding;
        private ComboBox cbFlat;
        private Label label3;
    }
}