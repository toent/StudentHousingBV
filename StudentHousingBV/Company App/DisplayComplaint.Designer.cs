namespace StudentHousingBV.Company_App
{
    partial class DisplayComplaint
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
            label1 = new Label();
            cBoxFlat = new ComboBox();
            label2 = new Label();
            tBoxDate = new TextBox();
            tBoxTime = new TextBox();
            label3 = new Label();
            lBoxComplaint = new ListBox();
            richTextBoxComplaint = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 3;
            label1.Text = "Flat:";
            // 
            // cBoxFlat
            // 
            cBoxFlat.FormattingEnabled = true;
            cBoxFlat.Location = new Point(72, 22);
            cBoxFlat.Name = "cBoxFlat";
            cBoxFlat.Size = new Size(160, 28);
            cBoxFlat.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 4;
            label2.Text = "Date:";
            // 
            // tBoxDate
            // 
            tBoxDate.Location = new Point(72, 87);
            tBoxDate.Name = "tBoxDate";
            tBoxDate.Size = new Size(160, 27);
            tBoxDate.TabIndex = 5;
            // 
            // tBoxTime
            // 
            tBoxTime.Location = new Point(72, 153);
            tBoxTime.Name = "tBoxTime";
            tBoxTime.Size = new Size(160, 27);
            tBoxTime.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 7;
            label3.Text = "Time:";
            // 
            // lBoxComplaint
            // 
            lBoxComplaint.FormattingEnabled = true;
            lBoxComplaint.Location = new Point(314, 22);
            lBoxComplaint.Name = "lBoxComplaint";
            lBoxComplaint.Size = new Size(538, 164);
            lBoxComplaint.TabIndex = 8;
            lBoxComplaint.SelectedIndexChanged += lBoxComplaint_SelectedIndexChanged;
            // 
            // richTextBoxComplaint
            // 
            richTextBoxComplaint.Location = new Point(314, 221);
            richTextBoxComplaint.Name = "richTextBoxComplaint";
            richTextBoxComplaint.ReadOnly = true;
            richTextBoxComplaint.Size = new Size(538, 289);
            richTextBoxComplaint.TabIndex = 9;
            richTextBoxComplaint.Text = "";
            // 
            // DisplayComplaint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 522);
            Controls.Add(richTextBoxComplaint);
            Controls.Add(lBoxComplaint);
            Controls.Add(label3);
            Controls.Add(tBoxTime);
            Controls.Add(tBoxDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cBoxFlat);
            Name = "DisplayComplaint";
            Text = "DisplayComplaint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cBoxFlat;
        private Label label2;
        private TextBox tBoxDate;
        private TextBox tBoxTime;
        private Label label3;
        private ListBox lBoxComplaint;
        private RichTextBox richTextBoxComplaint;
    }
}