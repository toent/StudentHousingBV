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
            btnModify = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(19, 0);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(750, 72);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "[Description]";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("Segoe UI", 16F);
            btnModify.Location = new Point(774, 13);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(129, 47);
            btnModify.TabIndex = 1;
            btnModify.Text = "Edit";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 16F);
            btnDelete.Location = new Point(909, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 47);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // HouserulesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(lblDescription);
            Margin = new Padding(2);
            Name = "HouserulesControl";
            Size = new Size(1049, 72);
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescription;
        private Button btnModify;
        private Button btnDelete;
    }
}
