namespace StudentManagementSystem
{
    partial class Staff
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
            panel2 = new Panel();
            LeftPanel.SuspendLayout();
            panel6.SuspendLayout();
            RightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Size = new Size(201, 498);
            // 
            // panel6
            // 
            panel6.Controls.Add(panel2);
            panel6.Location = new Point(0, 33);
            panel6.Size = new Size(201, 465);
            // 
            // panel4
            // 
            panel4.Size = new Size(201, 33);
            // 
            // RightPanel
            // 
            RightPanel.Size = new Size(747, 498);
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 33);
            panel5.Size = new Size(747, 465);
            panel5.Paint += panel5_Paint;
            // 
            // panel3
            // 
            panel3.Size = new Size(747, 33);
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 37);
            panel2.TabIndex = 1;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 498);
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
            LeftPanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
    }
}