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
            flowLayoutPanelGrocery = new FlowLayoutPanel();
            btnAddChore = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelGrocery
            // 
            flowLayoutPanelGrocery.AutoScroll = true;
            flowLayoutPanelGrocery.Location = new Point(12, 51);
            flowLayoutPanelGrocery.Name = "flowLayoutPanelGrocery";
            flowLayoutPanelGrocery.Size = new Size(1238, 591);
            flowLayoutPanelGrocery.TabIndex = 0;
            // 
            // btnAddChore
            // 
            btnAddChore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddChore.Location = new Point(1112, 11);
            btnAddChore.Margin = new Padding(2);
            btnAddChore.Name = "btnAddChore";
            btnAddChore.Size = new Size(138, 34);
            btnAddChore.TabIndex = 1;
            btnAddChore.Text = "Add Grocery";
            btnAddChore.UseVisualStyleBackColor = true;
            btnAddChore.Click += btnAddGrocery_Click;
            // 
            // StudentGroceries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1261, 654);
            Controls.Add(btnAddChore);
            Controls.Add(flowLayoutPanelGrocery);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StudentGroceries";
            Text = "StudentGroceries";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddGrocery;
        private FlowLayoutPanel flowLayoutPanelGrocery;
        private Button btnAddChore;
    }
}