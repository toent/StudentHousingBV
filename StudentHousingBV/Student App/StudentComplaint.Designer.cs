namespace StudentHousingBV.Student_App
{
    partial class StudentComplaint
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
            btnSubmitComplaint = new Button();
            richTBoxComplaint = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSubmitComplaint
            // 
            btnSubmitComplaint.Location = new Point(39, 370);
            btnSubmitComplaint.Name = "btnSubmitComplaint";
            btnSubmitComplaint.Size = new Size(723, 29);
            btnSubmitComplaint.TabIndex = 5;
            btnSubmitComplaint.Text = "Submit";
            btnSubmitComplaint.UseVisualStyleBackColor = true;
            btnSubmitComplaint.UseWaitCursor = true;
            // 
            // richTBoxComplaint
            // 
            richTBoxComplaint.Location = new Point(39, 93);
            richTBoxComplaint.Name = "richTBoxComplaint";
            richTBoxComplaint.Size = new Size(723, 262);
            richTBoxComplaint.TabIndex = 4;
            richTBoxComplaint.Text = "";
            richTBoxComplaint.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 52);
            label1.Name = "label1";
            label1.Size = new Size(256, 20);
            label1.TabIndex = 3;
            label1.Text = "Please describe what's bothering you:";
            label1.UseWaitCursor = true;
            // 
            // StudentComplaint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmitComplaint);
            Controls.Add(richTBoxComplaint);
            Controls.Add(label1);
            Name = "StudentComplaint";
            Text = "StudentComplaint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmitComplaint;
        private RichTextBox richTBoxComplaint;
        private Label label1;
    }
}