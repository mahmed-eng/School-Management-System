namespace StudentManagementSystem
{
    partial class Login
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            LoginBtn = new Button();
            LeftPanel.SuspendLayout();
            panel6.SuspendLayout();
            RightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Size = new Size(234, 420);
            // 
            // panel6
            // 
            panel6.Controls.Add(LoginBtn);
            panel6.Controls.Add(textBox2);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(0, 35);
            panel6.Size = new Size(234, 385);
            // 
            // panel4
            // 
            panel4.Size = new Size(234, 35);
            // 
            // RightPanel
            // 
            RightPanel.Location = new Point(234, 0);
            RightPanel.Size = new Size(699, 420);
            // 
            // panel5
            // 
            panel5.Cursor = Cursors.Hand;
            panel5.Size = new Size(699, 383);
            // 
            // panel3
            // 
            panel3.Size = new Size(699, 37);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 139);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 14);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 156);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 22);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 204);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 22);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 189);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 14);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.FlatAppearance.BorderColor = Color.White;
            LoginBtn.FlatAppearance.BorderSize = 2;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.Location = new Point(63, 246);
            LoginBtn.Margin = new Padding(4, 3, 4, 3);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(88, 25);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Login
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 420);
            ControlBox = false;
            Name = "Login";
            Text = "Login";
            LeftPanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            RightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button LoginBtn;
    }
}