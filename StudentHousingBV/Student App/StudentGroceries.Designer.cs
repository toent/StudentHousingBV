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
            flowLayoutPanelGrocery = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            richTextBoxGroceryItems = new RichTextBox();
            label2 = new Label();
            tBoxImgPath = new TextBox();
            label1 = new Label();
            tBoxPaymentURL = new TextBox();
            btnAddGrocery = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanelGrocery);
            groupBox1.Location = new Point(437, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 592);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grocery list";
            // 
            // flowLayoutPanelGrocery
            // 
            flowLayoutPanelGrocery.AutoScroll = true;
            flowLayoutPanelGrocery.Location = new Point(50, 47);
            flowLayoutPanelGrocery.Name = "flowLayoutPanelGrocery";
            flowLayoutPanelGrocery.Size = new Size(686, 502);
            flowLayoutPanelGrocery.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(richTextBoxGroceryItems);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tBoxImgPath);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tBoxPaymentURL);
            groupBox2.Controls.Add(btnAddGrocery);
            groupBox2.Location = new Point(55, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 592);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add groceries";
            // 
            // richTextBoxGroceryItems
            // 
            richTextBoxGroceryItems.Location = new Point(44, 275);
            richTextBoxGroceryItems.Name = "richTextBoxGroceryItems";
            richTextBoxGroceryItems.Size = new Size(236, 195);
            richTextBoxGroceryItems.TabIndex = 5;
            richTextBoxGroceryItems.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 130);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 4;
            label2.Text = "Image path:";
            // 
            // tBoxImgPath
            // 
            tBoxImgPath.Location = new Point(44, 161);
            tBoxImgPath.Name = "tBoxImgPath";
            tBoxImgPath.Size = new Size(236, 27);
            tBoxImgPath.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 47);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 2;
            label1.Text = "Payment URL:";
            // 
            // tBoxPaymentURL
            // 
            tBoxPaymentURL.Location = new Point(44, 78);
            tBoxPaymentURL.Name = "tBoxPaymentURL";
            tBoxPaymentURL.Size = new Size(236, 27);
            tBoxPaymentURL.TabIndex = 1;
            // 
            // btnAddGrocery
            // 
            btnAddGrocery.Location = new Point(44, 520);
            btnAddGrocery.Name = "btnAddGrocery";
            btnAddGrocery.Size = new Size(236, 29);
            btnAddGrocery.TabIndex = 0;
            btnAddGrocery.Text = "Add grocery";
            btnAddGrocery.UseVisualStyleBackColor = true;
            btnAddGrocery.Click += btnAddGrocery_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 191);
            label3.Name = "label3";
            label3.Size = new Size(232, 17);
            label3.TabIndex = 6;
            label3.Text = "Leave blank for auto-generated image";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 244);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 7;
            label4.Text = "Grocery list:";
            // 
            // StudentGroceries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 699);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "StudentGroceries";
            Text = "StudentGroceries";
            groupBox1.ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanelGrocery;
        private Label label3;
        private Label label4;
    }
}