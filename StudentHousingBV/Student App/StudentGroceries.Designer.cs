namespace StudentHousingBV.Student_App
{
    partial class StudentGroceries
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnAddGrocery = new Button();
            tBoxPaymentURL = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tBoxImgPath = new TextBox();
            richTextBoxGroceryItems = new RichTextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(332, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grocery list";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBoxGroceryItems);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tBoxImgPath);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tBoxPaymentURL);
            groupBox2.Controls.Add(btnAddGrocery);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add groceries";
            // 
            // btnAddGrocery
            // 
            btnAddGrocery.Location = new Point(16, 380);
            btnAddGrocery.Name = "btnAddGrocery";
            btnAddGrocery.Size = new Size(269, 29);
            btnAddGrocery.TabIndex = 0;
            btnAddGrocery.Text = "Add grocery";
            btnAddGrocery.UseVisualStyleBackColor = true;
            btnAddGrocery.Click += btnAddGrocery_Click;
            // 
            // tBoxPaymentURL
            // 
            tBoxPaymentURL.Location = new Point(16, 63);
            tBoxPaymentURL.Name = "tBoxPaymentURL";
            tBoxPaymentURL.Size = new Size(269, 27);
            tBoxPaymentURL.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 2;
            label1.Text = "Payment URL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 104);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 4;
            label2.Text = "Image path:";
            // 
            // tBoxImgPath
            // 
            tBoxImgPath.Location = new Point(16, 135);
            tBoxImgPath.Name = "tBoxImgPath";
            tBoxImgPath.Size = new Size(269, 27);
            tBoxImgPath.TabIndex = 3;
            // 
            // richTextBoxGroceryItems
            // 
            richTextBoxGroceryItems.Location = new Point(16, 180);
            richTextBoxGroceryItems.Name = "richTextBoxGroceryItems";
            richTextBoxGroceryItems.Size = new Size(269, 185);
            richTextBoxGroceryItems.TabIndex = 5;
            richTextBoxGroceryItems.Text = "";
            // 
            // StudentGroceries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "StudentGroceries";
            Text = "StudentGroceries";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAddGrocery;
        private Label label1;
        private TextBox tBoxPaymentURL;
        private Label label2;
        private TextBox tBoxImgPath;
        private RichTextBox richTextBoxGroceryItems;
    }
}