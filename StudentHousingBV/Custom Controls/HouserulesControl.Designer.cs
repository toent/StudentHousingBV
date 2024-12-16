namespace StudentHousingBV.Custom_Controls
{
    partial class HouserulesControl
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
            lblDescription = new Label();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(27, 36);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1441, 52);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "[Description]";
            // 
            // HouserulesControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblDescription);
            Name = "HouserulesControl";
            Size = new Size(1499, 120);
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescription;
    }
}
