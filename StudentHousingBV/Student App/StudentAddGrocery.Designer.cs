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
            btnCancel.Location = new Point(20, 430);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 27);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(145, 430);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 27);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 224);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 16;
            label4.Text = "Items:";
            // 
            // tBoxPaymentURL
            // 
            tBoxPaymentURL.Location = new Point(20, 30);
            tBoxPaymentURL.Margin = new Padding(2);
            tBoxPaymentURL.Name = "tBoxPaymentURL";
            tBoxPaymentURL.Size = new Size(238, 27);
            tBoxPaymentURL.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 10;
            label1.Text = "Payment URL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 89);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 23;
            label2.Text = "Receipt:";
            // 
            // btnAddReceipt
            // 
            btnAddReceipt.Location = new Point(21, 112);
            btnAddReceipt.Name = "btnAddReceipt";
            btnAddReceipt.Size = new Size(106, 29);
            btnAddReceipt.TabIndex = 24;
            btnAddReceipt.Text = "Add";
            btnAddReceipt.UseVisualStyleBackColor = true;
            btnAddReceipt.Click += btnAddReceipt_Click;
            // 
            // pictureBoxReceipt
            // 
            pictureBoxReceipt.Location = new Point(144, 112);
            pictureBoxReceipt.Name = "pictureBoxReceipt";
            pictureBoxReceipt.Size = new Size(114, 114);
            pictureBoxReceipt.TabIndex = 25;
            pictureBoxReceipt.TabStop = false;
            // 
            // btnRemoveRecepit
            // 
            btnRemoveRecepit.Location = new Point(23, 147);
            btnRemoveRecepit.Name = "btnRemoveRecepit";
            btnRemoveRecepit.Size = new Size(104, 29);
            btnRemoveRecepit.TabIndex = 26;
            btnRemoveRecepit.Text = "Remove";
            btnRemoveRecepit.UseVisualStyleBackColor = true;
            btnRemoveRecepit.Click += btnRemoveRecepit_Click;
            // 
            // richTextBoxGroceryItems
            // 
            richTextBoxGroceryItems.Location = new Point(22, 247);
            richTextBoxGroceryItems.Name = "richTextBoxGroceryItems";
            richTextBoxGroceryItems.Size = new Size(236, 167);
            richTextBoxGroceryItems.TabIndex = 22;
            richTextBoxGroceryItems.Text = "";
            // 
            // StudentAddGrocery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 470);
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