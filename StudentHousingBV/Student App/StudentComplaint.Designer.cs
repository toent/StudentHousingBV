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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentComplaint));
            btnSubmitComplaint = new Button();
            rtbComplaint = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSubmitComplaint
            // 
            btnSubmitComplaint.BackColor = Color.FromArgb(240, 243, 255);
            resources.ApplyResources(btnSubmitComplaint, "btnSubmitComplaint");
            btnSubmitComplaint.Name = "btnSubmitComplaint";
            btnSubmitComplaint.UseVisualStyleBackColor = false;
            btnSubmitComplaint.Click += btnSubmitComplaint_Click;
            // 
            // rtbComplaint
            // 
            rtbComplaint.BackColor = Color.White;
            resources.ApplyResources(rtbComplaint, "rtbComplaint");
            rtbComplaint.Name = "rtbComplaint";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.UseWaitCursor = true;
            // 
            // StudentComplaint
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnSubmitComplaint);
            Controls.Add(rtbComplaint);
            Controls.Add(label1);
            Name = "StudentComplaint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmitComplaint;
        private RichTextBox rtbComplaint;
        private Label label1;
    }
}