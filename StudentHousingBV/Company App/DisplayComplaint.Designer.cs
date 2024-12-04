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
            rTBoxComplaintDescription = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 3;
            label1.Text = "Flat:";
            // 
            // cBoxFlat
            // 
            cBoxFlat.FormattingEnabled = true;
            cBoxFlat.Location = new Point(72, 54);
            cBoxFlat.Name = "cBoxFlat";
            cBoxFlat.Size = new Size(160, 28);
            cBoxFlat.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 4;
            label2.Text = "Date:";
            // 
            // tBoxDate
            // 
            tBoxDate.Location = new Point(72, 119);
            tBoxDate.Name = "tBoxDate";
            tBoxDate.Size = new Size(160, 27);
            tBoxDate.TabIndex = 5;
            // 
            // tBoxTime
            // 
            tBoxTime.Location = new Point(72, 185);
            tBoxTime.Name = "tBoxTime";
            tBoxTime.Size = new Size(160, 27);
            tBoxTime.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 188);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 7;
            label3.Text = "Time:";
            // 
            // lBoxComplaint
            // 
            lBoxComplaint.FormattingEnabled = true;
            lBoxComplaint.Location = new Point(314, 54);
            lBoxComplaint.Name = "lBoxComplaint";
            lBoxComplaint.Size = new Size(457, 164);
            lBoxComplaint.TabIndex = 8;
            // 
            // rTBoxComplaintDescription
            // 
            rTBoxComplaintDescription.Location = new Point(314, 259);
            rTBoxComplaintDescription.Name = "rTBoxComplaintDescription";
            rTBoxComplaintDescription.Size = new Size(457, 179);
            rTBoxComplaintDescription.TabIndex = 9;
            rTBoxComplaintDescription.Text = "";
            // 
            // DisplayComplaint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rTBoxComplaintDescription);
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
        private RichTextBox rTBoxComplaintDescription;
    }
}