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
            pictureBoxGrocery = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrocery).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(698, 105);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(453, 29);
            btnDetails.TabIndex = 0;
            btnDetails.Text = "View details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnPaymentLink
            // 
            btnPaymentLink.BackColor = Color.Transparent;
            btnPaymentLink.Location = new Point(197, 105);
            btnPaymentLink.Name = "btnPaymentLink";
            btnPaymentLink.Size = new Size(453, 29);
            btnPaymentLink.TabIndex = 1;
            btnPaymentLink.Text = "Payment link";
            btnPaymentLink.UseVisualStyleBackColor = false;
            btnPaymentLink.Click += btnPaymentLink_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 7);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 2;
            label1.Text = "Grocery list";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F);
            lblDate.Location = new Point(14, 7);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(65, 28);
            lblDate.TabIndex = 3;
            lblDate.Text = "label2";
            // 
            // pictureBoxGrocery
            // 
            pictureBoxGrocery.Location = new Point(19, 50);
            pictureBoxGrocery.Name = "pictureBoxGrocery";
            pictureBoxGrocery.Size = new Size(100, 84);
            pictureBoxGrocery.TabIndex = 5;
            pictureBoxGrocery.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 47);
            panel1.TabIndex = 6;
            // 
            // GroceryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBoxGrocery);
            Controls.Add(btnPaymentLink);
            Controls.Add(btnDetails);
            Name = "GroceryControl";
            Size = new Size(1199, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrocery).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDetails;
        private Button btnPaymentLink;
        private Label label1;
        private Label lblDate;
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

        private Panel panel1;
    }


}
