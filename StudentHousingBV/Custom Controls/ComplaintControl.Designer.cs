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
            lblDescription = new Label();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(10, 10);
            lblDescription.Margin = new Padding(10);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1479, 207);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "[Description]";
            // 
            // ComplaintControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblDescription);
            Name = "ComplaintControl";
            Size = new Size(1499, 227);
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescription;
    }
}
