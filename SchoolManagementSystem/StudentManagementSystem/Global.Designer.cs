namespace StudentManagementSystem
{
    partial class Global
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LeftPanel = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            RightPanel = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            LeftPanel.SuspendLayout();
            panel4.SuspendLayout();
            RightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.FromArgb(0, 192, 192);
            LeftPanel.Controls.Add(panel6);
            LeftPanel.Controls.Add(panel4);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.ForeColor = Color.White;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Margin = new Padding(2, 3, 2, 3);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(201, 420);
            LeftPanel.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 37);
            panel6.Margin = new Padding(2, 3, 2, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(201, 383);
            panel6.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(201, 37);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Right;
            label5.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 37);
            label5.TabIndex = 1;
            label5.Text = "Welcome,";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RightPanel
            // 
            RightPanel.Controls.Add(panel5);
            RightPanel.Controls.Add(panel3);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(201, 0);
            RightPanel.Margin = new Padding(2, 3, 2, 3);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(599, 420);
            RightPanel.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 37);
            panel5.Margin = new Padding(2, 3, 2, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(599, 383);
            panel5.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(599, 37);
            panel3.TabIndex = 0;
            // 
            // Global
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 420);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Global";
            LeftPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel LeftPanel;
        public Panel panel6;
        public Panel panel4;
        public Panel RightPanel;
        public Panel panel5;
        public Panel panel3;
        private Label label5;
    }
}