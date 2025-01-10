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
            tbAddress = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(22, 141);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(164, 141);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(221, 34);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(22, 49);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(363, 31);
            tbAddress.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 21);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 10;
            label3.Text = "Address";
            // 
            // CompanyAddFlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(407, 196);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(tbAddress);
            Controls.Add(label3);
            Name = "CompanyAddFlat";
            Text = "CompanyAddFlat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private TextBox tbAddress;
        private Label label3;
    }
}