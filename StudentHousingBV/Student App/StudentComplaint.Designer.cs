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
            tabControlComplaint = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnSubmitComplaint = new Button();
            richTBoxComplaint = new RichTextBox();
            label1 = new Label();
            tabControlComplaint.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlComplaint
            // 
            tabControlComplaint.Controls.Add(tabPage1);
            tabControlComplaint.Controls.Add(tabPage2);
            tabControlComplaint.Location = new Point(12, 12);
            tabControlComplaint.Name = "tabControlComplaint";
            tabControlComplaint.SelectedIndex = 0;
            tabControlComplaint.Size = new Size(776, 426);
            tabControlComplaint.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "View complaints";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSubmitComplaint);
            tabPage2.Controls.Add(richTBoxComplaint);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add complaints";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.UseWaitCursor = true;
            // 
            // btnSubmitComplaint
            // 
            btnSubmitComplaint.Location = new Point(23, 347);
            btnSubmitComplaint.Name = "btnSubmitComplaint";
            btnSubmitComplaint.Size = new Size(723, 29);
            btnSubmitComplaint.TabIndex = 2;
            btnSubmitComplaint.Text = "Submit";
            btnSubmitComplaint.UseVisualStyleBackColor = true;
            btnSubmitComplaint.UseWaitCursor = true;
            btnSubmitComplaint.Click += btnSubmitComplaint_Click;
            // 
            // richTBoxComplaint
            // 
            richTBoxComplaint.Location = new Point(23, 70);
            richTBoxComplaint.Name = "richTBoxComplaint";
            richTBoxComplaint.Size = new Size(723, 262);
            richTBoxComplaint.TabIndex = 1;
            richTBoxComplaint.Text = "";
            richTBoxComplaint.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(256, 20);
            label1.TabIndex = 0;
            label1.Text = "Please describe what's bothering you:";
            label1.UseWaitCursor = true;
            // 
            // StudentComplaint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlComplaint);
            Name = "StudentComplaint";
            Text = "StudentComplaint";
            tabControlComplaint.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlComplaint;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSubmitComplaint;
        private RichTextBox richTBoxComplaint;
        private Label label1;
    }
}