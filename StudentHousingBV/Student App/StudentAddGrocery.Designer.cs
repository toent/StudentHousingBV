namespace StudentHousingBV.Student_App
{
    partial class StudentAddGrocery
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
            label4 = new Label();
            tBoxPaymentURL = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddReceipt = new Button();
            pictureBoxReceipt = new PictureBox();
            btnRemoveRecepit = new Button();
            richTextBoxGroceryItems = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxReceipt).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(25, 534);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 44);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(240, 243, 255);
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(163, 534);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 44);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 280);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 16;
            label4.Text = "Items:";
            // 
            // tBoxPaymentURL
            // 
            tBoxPaymentURL.Location = new Point(25, 38);
            tBoxPaymentURL.Margin = new Padding(2);
            tBoxPaymentURL.Name = "tBoxPaymentURL";
            tBoxPaymentURL.Size = new Size(338, 31);
            tBoxPaymentURL.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 10;
            label1.Text = "Payment URL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 111);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 23;
            label2.Text = "Receipt:";
            // 
            // btnAddReceipt
            // 
            btnAddReceipt.BackColor = Color.FromArgb(240, 243, 255);
            btnAddReceipt.Location = new Point(26, 140);
            btnAddReceipt.Margin = new Padding(4, 4, 4, 4);
            btnAddReceipt.Name = "btnAddReceipt";
            btnAddReceipt.Size = new Size(132, 36);
            btnAddReceipt.TabIndex = 24;
            btnAddReceipt.Text = "Add";
            btnAddReceipt.UseVisualStyleBackColor = false;
            btnAddReceipt.Click += btnAddReceipt_Click;
            // 
            // pictureBoxReceipt
            // 
            pictureBoxReceipt.Location = new Point(221, 140);
            pictureBoxReceipt.Margin = new Padding(4, 4, 4, 4);
            pictureBoxReceipt.Name = "pictureBoxReceipt";
            pictureBoxReceipt.Size = new Size(142, 142);
            pictureBoxReceipt.TabIndex = 25;
            pictureBoxReceipt.TabStop = false;
            // 
            // btnRemoveRecepit
            // 
            btnRemoveRecepit.Location = new Point(25, 184);
            btnRemoveRecepit.Margin = new Padding(4, 4, 4, 4);
            btnRemoveRecepit.Name = "btnRemoveRecepit";
            btnRemoveRecepit.Size = new Size(133, 36);
            btnRemoveRecepit.TabIndex = 26;
            btnRemoveRecepit.Text = "Remove";
            btnRemoveRecepit.UseVisualStyleBackColor = true;
            btnRemoveRecepit.Click += btnRemoveRecepit_Click;
            // 
            // richTextBoxGroceryItems
            // 
            richTextBoxGroceryItems.Location = new Point(28, 309);
            richTextBoxGroceryItems.Margin = new Padding(4, 4, 4, 4);
            richTextBoxGroceryItems.Name = "richTextBoxGroceryItems";
            richTextBoxGroceryItems.Size = new Size(335, 208);
            richTextBoxGroceryItems.TabIndex = 22;
            richTextBoxGroceryItems.Text = "";
            // 
            // StudentAddGrocery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(392, 588);
            Controls.Add(btnRemoveRecepit);
            Controls.Add(pictureBoxReceipt);
            Controls.Add(btnAddReceipt);
            Controls.Add(label2);
            Controls.Add(richTextBoxGroceryItems);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(tBoxPaymentURL);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StudentAddGrocery";
            Text = "StudentAddGrocery";
            ((System.ComponentModel.ISupportInitialize)pictureBoxReceipt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private Label label4;
        private TextBox tBoxPaymentURL;
        private Label label1;
        private Label label2;
        private Button btnAddReceipt;
        private PictureBox pictureBoxReceipt;
        private Button btnRemoveRecepit;
        private RichTextBox richTextBoxGroceryItems;
    }
}