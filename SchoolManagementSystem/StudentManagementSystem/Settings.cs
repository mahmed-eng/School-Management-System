using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class Settings : Global
    {
        public Settings()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DatasourceTxt_TextChanged(object sender, EventArgs e)
        {
            if (DatasourceTxt.Text == "")
            {
                dserrorlabel.Visible = true;
            }
            else
            {
                dserrorlabel.Visible = false;

            }
        }

        private void dbtxt_TextChanged(object sender, EventArgs e)
        {
            if (dbtxt.Text == "")
            {
                dberrorlabel.Visible = true;
            }
            else
            {
                dberrorlabel.Visible = false;

            }
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            if (usernametxt.Text == "")
            {
                usernameerrorlabel.Visible = true;
            }
            else
            {
                usernameerrorlabel.Visible = false;

            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordtxt.Text == "")
            {
                passworderrorlabel.Visible = true;
            }
            else
            {
                passworderrorlabel.Visible = false;

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (isCB.Checked)
            {
                if (DatasourceTxt.Text == "") { dserrorlabel.Visible = true; } else { dserrorlabel.Visible = false; }
                if (dbtxt.Text == "") { dberrorlabel.Visible = true; } else { dberrorlabel.Visible = false; }
                if (dberrorlabel.Visible || dserrorlabel.Visible)
                {
                    MessageBox.Show("* is Mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + DatasourceTxt.Text + ";Initial Catalog=" + dbtxt.Text + ";Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(main.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        main.showWindow(log, this, MDI.ActiveForm);
                    }
                }

            }
            else
            {
                if (DatasourceTxt.Text == "") { dserrorlabel.Visible = true; } else { dserrorlabel.Visible = false; }
                if (dbtxt.Text == "") { dberrorlabel.Visible = true; } else { dberrorlabel.Visible = false; }
                if (usernametxt.Text == "") { usernameerrorlabel.Visible = true; } else { usernameerrorlabel.Visible = false; }
                if (passwordtxt.Text == "") { passworderrorlabel.Visible = true; } else { passworderrorlabel.Visible = false; }
                if (dberrorlabel.Visible || dserrorlabel.Visible || usernameerrorlabel.Visible || passworderrorlabel.Visible)
                {
                    MessageBox.Show("* is Mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + DatasourceTxt.Text + ";Initial Catalog=" + dbtxt.Text + ";User ID=" + usernametxt.Text + ";Password=" + passwordtxt.Text + ";MultipleActiveResultSets=true");
                    File.WriteAllText(main.path + "\\connect", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        main.showWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                usernametxt.Text = "";
                usernametxt.Enabled = false;
                passwordtxt.Text = "";
                passwordtxt.Enabled = false;
                usernameerrorlabel.Visible = false;
                passworderrorlabel.Visible = false;

            }
            else
            {
               // usernametxt.Text = "";
                usernametxt.Enabled = true;
             //   passwordtxt.Text = "";
                passwordtxt.Enabled = true;

            }
        }
    }
}

