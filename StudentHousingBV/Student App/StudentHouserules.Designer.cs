﻿namespace StudentHousingBV.Student_App
{
    partial class StudentHouserules
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
            pHouserules = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // pHouserules
            // 
            pHouserules.AutoScroll = true;
            pHouserules.Location = new Point(12, 12);
            pHouserules.Name = "pHouserules";
            pHouserules.Size = new Size(1552, 794);
            pHouserules.TabIndex = 2;
            // 
            // StudentHouserules
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(pHouserules);
            Name = "StudentHouserules";
            Text = "StudentHouserules";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pHouserules;
    }
}