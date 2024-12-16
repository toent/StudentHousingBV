namespace StudentHousingBV.Student_App
{
    partial class StudentAnnouncements
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
            pAnnouncements = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // pAnnouncements
            // 
            pAnnouncements.AutoScroll = true;
            pAnnouncements.Location = new Point(12, 12);
            pAnnouncements.Name = "pAnnouncements";
            pAnnouncements.Size = new Size(1552, 794);
            pAnnouncements.TabIndex = 1;
            // 
            // StudentAnnouncements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(pAnnouncements);
            Name = "StudentAnnouncements";
            Text = "StudentAnnouncements";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pAnnouncements;
    }
}