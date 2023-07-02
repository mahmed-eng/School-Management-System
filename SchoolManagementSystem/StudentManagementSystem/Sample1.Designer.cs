namespace StudentManagementSystem
{
    partial class Sample1
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ViewBtn = new Button();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            BackBtn = new Button();
            LeftPanel.SuspendLayout();
            panel4.SuspendLayout();
            RightPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Size = new Size(201, 525);
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 35);
            panel6.Size = new Size(201, 490);
            // 
            // panel4
            // 
            panel4.Controls.Add(BackBtn);
            panel4.Size = new Size(201, 35);
            panel4.Controls.SetChildIndex(BackBtn, 0);
            // 
            // RightPanel
            // 
            RightPanel.Size = new Size(748, 525);
            // 
            // panel5
            // 
            panel5.Controls.Add(panel1);
            panel5.Location = new Point(0, 35);
            panel5.Size = new Size(748, 490);
            // 
            // panel3
            // 
            panel3.Size = new Size(748, 35);
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 43);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.02671F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.0283813F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(ViewBtn, 4, 0);
            tableLayoutPanel1.Controls.Add(DeleteBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(SaveBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(EditBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(AddBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(748, 43);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ViewBtn
            // 
            ViewBtn.Dock = DockStyle.Fill;
            ViewBtn.FlatAppearance.BorderSize = 2;
            ViewBtn.FlatStyle = FlatStyle.Flat;
            ViewBtn.Location = new Point(500, 3);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(119, 37);
            ViewBtn.TabIndex = 4;
            ViewBtn.Text = "VIEW";
            ViewBtn.UseVisualStyleBackColor = true;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Dock = DockStyle.Fill;
            DeleteBtn.FlatAppearance.BorderSize = 2;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Location = new Point(373, 3);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(121, 37);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Dock = DockStyle.Fill;
            SaveBtn.FlatAppearance.BorderSize = 2;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Location = new Point(253, 3);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(114, 37);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Dock = DockStyle.Fill;
            EditBtn.FlatAppearance.BorderSize = 2;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Location = new Point(128, 3);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(119, 37);
            EditBtn.TabIndex = 1;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Dock = DockStyle.Fill;
            AddBtn.FlatAppearance.BorderSize = 2;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Location = new Point(3, 3);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(119, 37);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(625, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(120, 37);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 22);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BackBtn
            // 
            BackBtn.Dock = DockStyle.Left;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Image = Properties.Resources.prev1;
            BackBtn.Location = new Point(0, 0);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 35);
            BackBtn.TabIndex = 1;
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // Sample1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 525);
            ControlBox = false;
            Name = "Sample1";
            Load += Sample_Load;
            LeftPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddBtn;
        private Button ViewBtn;
        private Button DeleteBtn;
        private Button SaveBtn;
        private Button EditBtn;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button BackBtn;
    }
}