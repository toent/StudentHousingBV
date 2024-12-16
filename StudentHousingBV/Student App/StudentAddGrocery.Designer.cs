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
            label2 = new Label();
            tBoxPaymentURL = new TextBox();
            label1 = new Label();
            tBoxImgPath = new TextBox();
            label3 = new Label();
            richTextBoxGroceryItems = new RichTextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(21, 350);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(115, 350);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 27);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 155);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 16;
            label4.Text = "Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 12;
            label2.Text = "Image Path";
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
            label1.Size = new Size(95, 20);
            label1.TabIndex = 10;
            label1.Text = "Payment URL";
            // 
            // tBoxImgPath
            // 
            tBoxImgPath.Location = new Point(22, 92);
            tBoxImgPath.Name = "tBoxImgPath";
            tBoxImgPath.Size = new Size(236, 27);
            tBoxImgPath.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 122);
            label3.Name = "label3";
            label3.Size = new Size(232, 17);
            label3.TabIndex = 21;
            label3.Text = "Leave blank for auto-generated image";
            // 
            // richTextBoxGroceryItems
            // 
            richTextBoxGroceryItems.Location = new Point(22, 178);
            richTextBoxGroceryItems.Name = "richTextBoxGroceryItems";
            richTextBoxGroceryItems.Size = new Size(236, 167);
            richTextBoxGroceryItems.TabIndex = 22;
            richTextBoxGroceryItems.Text = "";
            // 
            // StudentAddGrocery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 397);
            Controls.Add(richTextBoxGroceryItems);
            Controls.Add(label3);
            Controls.Add(tBoxImgPath);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(tBoxPaymentURL);
            Controls.Add(label1);
            Name = "StudentAddGrocery";
            Text = "StudentAddGrocery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private Label label4;
        private Label label2;
        private TextBox tBoxPaymentURL;
        private Label label1;
        private TextBox tBoxImgPath;
        private Label label3;
        private RichTextBox richTextBoxGroceryItems;
    }
}