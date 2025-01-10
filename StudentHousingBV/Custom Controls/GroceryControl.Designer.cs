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
            pictureBoxGrocery = new PictureBox();
            panel1 = new Panel();
            lblDate = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrocery).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(698, 169);
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
            btnPaymentLink.Location = new Point(197, 169);
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
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(173, 41);
            label1.TabIndex = 2;
            label1.Text = "Grocery list";
            // 
            // pictureBoxGrocery
            // 
            pictureBoxGrocery.Location = new Point(17, 87);
            pictureBoxGrocery.Name = "pictureBoxGrocery";
            pictureBoxGrocery.Size = new Size(138, 111);
            pictureBoxGrocery.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGrocery.TabIndex = 5;
            pictureBoxGrocery.TabStop = false;
            pictureBoxGrocery.Click += pictureBoxGrocery_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 69);
            panel1.TabIndex = 6;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(1058, 34);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(119, 20);
            lblDate.TabIndex = 7;
            lblDate.Text = "[Published Date]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1058, 14);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 6;
            label5.Text = "Published";
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
            Size = new Size(1199, 215);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrocery).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDetails;
        private Button btnPaymentLink;
        private Label label1;
        private PictureBox pictureBoxGrocery;
        private Panel panel1;
        private Label lblDate;
        private Label label5;
    }


}
