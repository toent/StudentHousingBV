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
            flowLayoutPanelGrocery.Location = new Point(15, 64);
            flowLayoutPanelGrocery.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanelGrocery.Name = "flowLayoutPanelGrocery";
            flowLayoutPanelGrocery.Size = new Size(1548, 739);
            flowLayoutPanelGrocery.TabIndex = 0;
            // 
            // btnAddChore
            // 
            btnAddChore.BackColor = Color.FromArgb(240, 243, 255);
            btnAddChore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddChore.Location = new Point(1390, 14);
            btnAddChore.Margin = new Padding(2);
            btnAddChore.Name = "btnAddChore";
            btnAddChore.Size = new Size(172, 42);
            btnAddChore.TabIndex = 1;
            btnAddChore.Text = "Add Grocery";
            btnAddChore.UseVisualStyleBackColor = false;
            btnAddChore.Click += btnAddGrocery_Click;
            // 
            // StudentGroceries
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1576, 818);
            Controls.Add(btnAddChore);
            Controls.Add(flowLayoutPanelGrocery);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
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