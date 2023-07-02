namespace StudentManagementSystem
{
    partial class Roles
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            Roletxt = new TextBox();
            label2 = new Label();
            Statuscmbx = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            snoGV = new DataGridViewTextBoxColumn();
            rolesIDGV = new DataGridViewTextBoxColumn();
            RoleGV = new DataGridViewTextBoxColumn();
            StatusGV = new DataGridViewTextBoxColumn();
            roleerrorlabel = new Label();
            statuserrorlabel = new Label();
            LeftPanel.SuspendLayout();
            panel6.SuspendLayout();
            RightPanel.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.Size = new Size(201, 420);
            // 
            // panel6
            // 
            panel6.Controls.Add(statuserrorlabel);
            panel6.Controls.Add(Statuscmbx);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(Roletxt);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(roleerrorlabel);
            panel6.Location = new Point(0, 33);
            panel6.Size = new Size(201, 387);
            // 
            // panel4
            // 
            panel4.Size = new Size(201, 33);
            // 
            // RightPanel
            // 
            RightPanel.Size = new Size(599, 420);
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox2);
            panel5.Location = new Point(0, 33);
            panel5.Size = new Size(599, 387);
            panel5.Controls.SetChildIndex(groupBox2, 0);
            // 
            // panel3
            // 
            panel3.Size = new Size(599, 33);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 51);
            label1.Name = "label1";
            label1.Size = new Size(34, 14);
            label1.TabIndex = 1;
            label1.Text = "Role";
            // 
            // Roletxt
            // 
            Roletxt.Enabled = false;
            Roletxt.Location = new Point(28, 68);
            Roletxt.Name = "Roletxt";
            Roletxt.Size = new Size(154, 22);
            Roletxt.TabIndex = 1;
            Roletxt.TextChanged += Roletxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 106);
            label2.Name = "label2";
            label2.Size = new Size(48, 14);
            label2.TabIndex = 3;
            label2.Text = "Status";
            // 
            // Statuscmbx
            // 
            Statuscmbx.DropDownStyle = ComboBoxStyle.DropDownList;
            Statuscmbx.Enabled = false;
            Statuscmbx.FormattingEnabled = true;
            Statuscmbx.Items.AddRange(new object[] { "Active", "In-Active" });
            Statuscmbx.Location = new Point(31, 124);
            Statuscmbx.Name = "Statuscmbx";
            Statuscmbx.Size = new Size(151, 22);
            Statuscmbx.TabIndex = 4;
            Statuscmbx.SelectedIndexChanged += Statuscmbx_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(599, 344);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Details";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { snoGV, rolesIDGV, RoleGV, StatusGV });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(593, 323);
            dataGridView1.TabIndex = 0;
            // 
            // snoGV
            // 
            snoGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            snoGV.HeaderText = "SNO";
            snoGV.Name = "snoGV";
            snoGV.ReadOnly = true;
            snoGV.Width = 56;
            // 
            // rolesIDGV
            // 
            rolesIDGV.HeaderText = "Role ID";
            rolesIDGV.Name = "rolesIDGV";
            rolesIDGV.ReadOnly = true;
            rolesIDGV.Visible = false;
            // 
            // RoleGV
            // 
            RoleGV.HeaderText = "Role";
            RoleGV.Name = "RoleGV";
            RoleGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            StatusGV.HeaderText = "Status";
            StatusGV.Name = "StatusGV";
            StatusGV.ReadOnly = true;
            // 
            // roleerrorlabel
            // 
            roleerrorlabel.AutoSize = true;
            roleerrorlabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            roleerrorlabel.Location = new Point(161, 46);
            roleerrorlabel.Name = "roleerrorlabel";
            roleerrorlabel.Size = new Size(17, 17);
            roleerrorlabel.TabIndex = 5;
            roleerrorlabel.Text = "*";
            roleerrorlabel.Visible = false;
            // 
            // statuserrorlabel
            // 
            statuserrorlabel.AutoSize = true;
            statuserrorlabel.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            statuserrorlabel.Location = new Point(161, 103);
            statuserrorlabel.Name = "statuserrorlabel";
            statuserrorlabel.Size = new Size(17, 17);
            statuserrorlabel.TabIndex = 6;
            statuserrorlabel.Text = "*";
            statuserrorlabel.Visible = false;
            // 
            // Roles
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Name = "Roles";
            Text = "Roles";
            Load += Roles_Load;
            LeftPanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            RightPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox Roletxt;
        private Label label2;
        private ComboBox Statuscmbx;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn snoGV;
        private DataGridViewTextBoxColumn rolesIDGV;
        private DataGridViewTextBoxColumn RoleGV;
        private DataGridViewTextBoxColumn StatusGV;
        private Label roleerrorlabel;
        private Label statuserrorlabel;
    }
}