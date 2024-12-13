namespace StudentHousingBV.Custom_Controls
{
    partial class AnnoucmentsControl
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
            lblContent = new Label();
            lblAnnouncment = new Label();
            panel1 = new Panel();
            btnStatusChange = new Button();
            lblTimeUploaded = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Location = new Point(491, 89);
            lblContent.Margin = new Padding(2, 0, 2, 0);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(165, 20);
            lblContent.TabIndex = 6;
            lblContent.Text = "[Announcment content]";
            // 
            // lblAnnouncment
            // 
            lblAnnouncment.AutoSize = true;
            lblAnnouncment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnnouncment.Location = new Point(500, 47);
            lblAnnouncment.Margin = new Padding(2, 0, 2, 0);
            lblAnnouncment.Name = "lblAnnouncment";
            lblAnnouncment.Size = new Size(156, 28);
            lblAnnouncment.TabIndex = 5;
            lblAnnouncment.Text = "[Announcment]";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnStatusChange);
            panel1.Controls.Add(lblTimeUploaded);
            panel1.Controls.Add(lblAnnouncment);
            panel1.Controls.Add(lblContent);
            panel1.Location = new Point(99, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 320);
            panel1.TabIndex = 8;
            // 
            // btnStatusChange
            // 
            btnStatusChange.Location = new Point(480, 136);
            btnStatusChange.Name = "btnStatusChange";
            btnStatusChange.Size = new Size(190, 29);
            btnStatusChange.TabIndex = 7;
            btnStatusChange.Text = "Mark as Read";
            btnStatusChange.UseVisualStyleBackColor = true;
            btnStatusChange.Click += btnStatusChange_Click;
            // 
            // lblTimeUploaded
            // 
            lblTimeUploaded.AutoSize = true;
            lblTimeUploaded.Location = new Point(516, 17);
            lblTimeUploaded.Margin = new Padding(2, 0, 2, 0);
            lblTimeUploaded.Name = "lblTimeUploaded";
            lblTimeUploaded.Size = new Size(120, 20);
            lblTimeUploaded.TabIndex = 3;
            lblTimeUploaded.Text = "[Time uploaded]";
            // 
            // AnnoucmentsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AnnoucmentsControl";
            Size = new Size(1393, 403);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblContent;
        private Label lblAnnouncment;
        private Panel panel1;
        private Label lblTimeUploaded;
        private Button btnStatusChange;
    }
}
