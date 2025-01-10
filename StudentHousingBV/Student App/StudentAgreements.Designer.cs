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
            btnAddAgreement = new Button();
            pAgreements = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnAddAgreement
            // 
            btnAddAgreement.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAgreement.Location = new Point(1391, 12);
            btnAddAgreement.Name = "btnAddAgreement";
            btnAddAgreement.Size = new Size(173, 43);
            btnAddAgreement.TabIndex = 3;
            btnAddAgreement.Text = "Add Agreement";
            btnAddAgreement.UseVisualStyleBackColor = true;
            btnAddAgreement.Click += btnAddAgreement_Click;
            // 
            // pAgreements
            // 
            pAgreements.AutoScroll = true;
            pAgreements.Location = new Point(12, 61);
            pAgreements.Name = "pAgreements";
            pAgreements.Size = new Size(1552, 745);
            pAgreements.TabIndex = 4;
            // 
            // StudentAgreements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(pAgreements);
            Controls.Add(btnAddAgreement);
            Name = "StudentAgreements";
            Text = "StudentAgreements";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddAgreement;
        private FlowLayoutPanel pAgreements;
    }
}