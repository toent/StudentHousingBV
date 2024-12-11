namespace StudentHousingBV.Student_App
{
    partial class StudentChores
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
            btnAddChore = new Button();
            SuspendLayout();
            // 
            // btnAddChore
            // 
            btnAddChore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddChore.Location = new Point(1391, 12);
            btnAddChore.Name = "btnAddChore";
            btnAddChore.Size = new Size(173, 43);
            btnAddChore.TabIndex = 0;
            btnAddChore.Text = "Add Chore";
            btnAddChore.UseVisualStyleBackColor = true;
            // 
            // StudentChores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(btnAddChore);
            Name = "StudentChores";
            Text = "StudentChores";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddChore;
    }
}