namespace StudentHousingBV.Custom_Controls
{
    partial class ComplaintControl
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
            lblIssue = new Label();
            panel1 = new Panel();
            lblId = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblIssue
            // 
            lblIssue.Font = new Font("Segoe UI", 10F);
            lblIssue.Location = new Point(21, 107);
            lblIssue.Name = "lblIssue";
            lblIssue.Size = new Size(1456, 173);
            lblIssue.TabIndex = 5;
            lblIssue.Text = "[Issue]";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblId);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1499, 87);
            panel1.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(21, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(77, 48);
            lblId.TabIndex = 1;
            lblId.Text = "[Id]";
            // 
            // ComplaintControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblIssue);
            Controls.Add(panel1);
            Name = "ComplaintControl";
            Size = new Size(1499, 302);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblIssue;
        private Panel panel1;
        private Label lblId;
    }
}
