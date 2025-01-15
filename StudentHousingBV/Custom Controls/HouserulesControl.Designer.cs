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
            lblDescription.Location = new Point(27, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1071, 120);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "[Description]";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnModify.Location = new Point(1252, 14);
            btnModify.Margin = new Padding(4, 5, 4, 5);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(234, 44);
            btnModify.TabIndex = 1;
            btnModify.Text = "Edit";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(1252, 61);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(234, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // HouserulesControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(lblDescription);
            Name = "HouserulesControl";
            Size = new Size(1499, 120);
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescription;
        private Button btnModify;
        private Button btnDelete;
    }
}
