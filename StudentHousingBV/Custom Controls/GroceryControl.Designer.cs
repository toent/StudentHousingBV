namespace StudentHousingBV.Custom_Controls
{
    public partial class GroceryControl
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
            btnDetails = new Button();
            btnPaymentLink = new Button();
            label1 = new Label();
            lblDate = new Label();
            lblName = new Label();
            pictureBoxGrocery = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrocery).BeginInit();
            SuspendLayout();
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(383, 105);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(212, 29);
            btnDetails.TabIndex = 0;
            btnDetails.Text = "View details";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnPaymentLink
            // 
            btnPaymentLink.BackColor = Color.Transparent;
            btnPaymentLink.Location = new Point(165, 105);
            btnPaymentLink.Name = "btnPaymentLink";
            btnPaymentLink.Size = new Size(212, 29);
            btnPaymentLink.TabIndex = 1;
            btnPaymentLink.Text = "Payment link";
            btnPaymentLink.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 18);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 2;
            label1.Text = "Grocery list";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F);
            lblDate.Location = new Point(530, 18);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(65, 28);
            lblDate.TabIndex = 3;
            lblDate.Text = "label2";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(165, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 4;
            lblName.Text = "label2";
            // 
            // pictureBoxGrocery
            // 
            pictureBoxGrocery.Location = new Point(19, 18);
            pictureBoxGrocery.Name = "pictureBoxGrocery";
            pictureBoxGrocery.Size = new Size(125, 116);
            pictureBoxGrocery.TabIndex = 5;
            pictureBoxGrocery.TabStop = false;
            // 
            // Grocery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBoxGrocery);
            Controls.Add(lblName);
            Controls.Add(lblDate);
            Controls.Add(label1);
            Controls.Add(btnPaymentLink);
            Controls.Add(btnDetails);
            Name = "Grocery";
            Size = new Size(618, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrocery).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDetails;
        private Button btnPaymentLink;
        private Label label1;
        private Label lblDate;
        private Label lblName;
        private PictureBox pictureBoxGrocery;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color borderColor = Color.RebeccaPurple;
            int borderWidth = 2;
            Rectangle borderRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, borderRectangle);
            }
        }
    }


}
