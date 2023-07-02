namespace StudentManagementSystem
{
    partial class Settings
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
            dstxt = new TextBox();
            dbtxt = new TextBox();
            label2 = new Label();
            usernametxt = new TextBox();
            label3 = new Label();
            passwordtxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            DatasourceTxt = new TextBox();
            label6 = new Label();
            isCB = new CheckBox();
            savebtn = new Button();
            dserrorlabel = new Label();
            dberrorlabel = new Label();
            usernameerrorlabel = new Label();
            passworderrorlabel = new Label();
            LeftPanel.SuspendLayout();
            panel6.SuspendLayout();
            RightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Size = new Size(201, 450);
            // 
            // panel6
            // 
            panel6.Controls.Add(savebtn);
            panel6.Controls.Add(isCB);
            panel6.Controls.Add(passwordtxt);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(usernametxt);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(dbtxt);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(DatasourceTxt);
            panel6.Controls.Add(dstxt);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(dserrorlabel);
            panel6.Controls.Add(passworderrorlabel);
            panel6.Controls.Add(usernameerrorlabel);
            panel6.Controls.Add(dberrorlabel);
            panel6.Size = new Size(201, 413);
            // 
            // RightPanel
            // 
            RightPanel.Size = new Size(599, 450);
            // 
            // panel5
            // 
            panel5.Size = new Size(599, 413);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 145);
            label1.Name = "label1";
            label1.Size = new Size(78, 14);
            label1.TabIndex = 0;
            label1.Text = "DataSource";
            label1.Click += label1_Click;
            // 
            // dstxt
            // 
            dstxt.Location = new Point(12, 162);
            dstxt.Name = "dstxt";
            dstxt.Size = new Size(168, 22);
            dstxt.TabIndex = 1;
            // 
            // dbtxt
            // 
            dbtxt.Location = new Point(12, 162);
            dbtxt.Name = "dbtxt";
            dbtxt.Size = new Size(168, 22);
            dbtxt.TabIndex = 3;
            dbtxt.TextChanged += dbtxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 187);
            label2.Name = "label2";
            label2.Size = new Size(64, 14);
            label2.TabIndex = 2;
            label2.Text = "Database";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(12, 204);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(168, 22);
            usernametxt.TabIndex = 5;
            usernametxt.TextChanged += usernametxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 187);
            label3.Name = "label3";
            label3.Size = new Size(66, 14);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(12, 246);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(168, 22);
            passwordtxt.TabIndex = 7;
            passwordtxt.UseSystemPasswordChar = true;
            passwordtxt.TextChanged += passwordtxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 229);
            label4.Name = "label4";
            label4.Size = new Size(66, 14);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 103);
            label5.Name = "label5";
            label5.Size = new Size(78, 14);
            label5.TabIndex = 0;
            label5.Text = "DataSource";
            label5.Click += label5_Click;
            // 
            // DatasourceTxt
            // 
            DatasourceTxt.Location = new Point(12, 120);
            DatasourceTxt.Name = "DatasourceTxt";
            DatasourceTxt.Size = new Size(168, 22);
            DatasourceTxt.TabIndex = 1;
            DatasourceTxt.TextChanged += DatasourceTxt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 145);
            label6.Name = "label6";
            label6.Size = new Size(64, 14);
            label6.TabIndex = 2;
            label6.Text = "Database";
            // 
            // isCB
            // 
            isCB.AutoSize = true;
            isCB.Location = new Point(12, 283);
            isCB.Name = "isCB";
            isCB.Size = new Size(133, 18);
            isCB.TabIndex = 8;
            isCB.Text = "Integrated Security";
            isCB.UseVisualStyleBackColor = true;
            isCB.CheckedChanged += isCB_CheckedChanged;
            // 
            // savebtn
            // 
            savebtn.FlatStyle = FlatStyle.Flat;
            savebtn.Location = new Point(22, 307);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(142, 23);
            savebtn.TabIndex = 9;
            savebtn.Text = "&Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // dserrorlabel
            // 
            dserrorlabel.AutoSize = true;
            dserrorlabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dserrorlabel.ForeColor = Color.Red;
            dserrorlabel.Location = new Point(161, 98);
            dserrorlabel.Name = "dserrorlabel";
            dserrorlabel.Size = new Size(19, 19);
            dserrorlabel.TabIndex = 10;
            dserrorlabel.Text = "*";
            dserrorlabel.Visible = false;
            // 
            // dberrorlabel
            // 
            dberrorlabel.AutoSize = true;
            dberrorlabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dberrorlabel.ForeColor = Color.Red;
            dberrorlabel.Location = new Point(161, 145);
            dberrorlabel.Name = "dberrorlabel";
            dberrorlabel.Size = new Size(19, 19);
            dberrorlabel.TabIndex = 11;
            dberrorlabel.Text = "*";
            dberrorlabel.Visible = false;
            // 
            // usernameerrorlabel
            // 
            usernameerrorlabel.AutoSize = true;
            usernameerrorlabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameerrorlabel.ForeColor = Color.Red;
            usernameerrorlabel.Location = new Point(161, 187);
            usernameerrorlabel.Name = "usernameerrorlabel";
            usernameerrorlabel.Size = new Size(19, 19);
            usernameerrorlabel.TabIndex = 12;
            usernameerrorlabel.Text = "*";
            usernameerrorlabel.Visible = false;
            // 
            // passworderrorlabel
            // 
            passworderrorlabel.AutoSize = true;
            passworderrorlabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passworderrorlabel.ForeColor = Color.Red;
            passworderrorlabel.Location = new Point(161, 229);
            passworderrorlabel.Name = "passworderrorlabel";
            passworderrorlabel.Size = new Size(19, 19);
            passworderrorlabel.TabIndex = 13;
            passworderrorlabel.Text = "*";
            passworderrorlabel.Visible = false;
            // 
            // Settings
            // 
            AcceptButton = savebtn;
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Name = "Settings";
            Text = "Settings";
            LeftPanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            RightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox dstxt;
        private Label label1;
        private TextBox usernametxt;
        private Label label3;
        private TextBox dbtxt;
        private Label label2;
        private TextBox passwordtxt;
        private Label label4;
        private Label label6;
        private TextBox DatasourceTxt;
        private Label label5;
        private CheckBox isCB;
        private Button savebtn;
        private Label dberrorlabel;
        private Label dserrorlabel;
        private Label passworderrorlabel;
        private Label usernameerrorlabel;
    }
}