namespace StudentHousingBV.Company_App
{
    partial class CompanyAddFlat
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
            btnCancel = new Button();
            btnAdd = new Button();
            label3 = new Label();
            nudFlatNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudFlatNumber).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(12, 131);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 44);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(240, 243, 255);
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(164, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(227, 44);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 21);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 10;
            label3.Text = "Flat number";
            // 
            // nudFlatNumber
            // 
            nudFlatNumber.Location = new Point(22, 49);
            nudFlatNumber.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudFlatNumber.Name = "nudFlatNumber";
            nudFlatNumber.Size = new Size(258, 31);
            nudFlatNumber.TabIndex = 14;
            // 
            // CompanyAddFlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 184);
            Controls.Add(nudFlatNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Name = "CompanyAddFlat";
            Text = "CompanyAddFlat";
            ((System.ComponentModel.ISupportInitialize)nudFlatNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private Label label3;
        private NumericUpDown nudFlatNumber;
    }
}