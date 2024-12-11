namespace StudentHousingBV.Student_App
{
    partial class StudentAgreements
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
            button1 = new Button();
            panelAgreementControls = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(1376, 12);
            button1.Name = "button1";
            button1.Size = new Size(210, 80);
            button1.TabIndex = 1;
            button1.Text = "Add Agreement";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelAgreementControls
            // 
            panelAgreementControls.AutoScroll = true;
            panelAgreementControls.Location = new Point(12, 98);
            panelAgreementControls.Name = "panelAgreementControls";
            panelAgreementControls.Size = new Size(1574, 764);
            panelAgreementControls.TabIndex = 2;
            // 
            // StudentAgreements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 874);
            Controls.Add(panelAgreementControls);
            Controls.Add(button1);
            Name = "StudentAgreements";
            Text = "StudentAgreements";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panelAgreementControls;
    }
}