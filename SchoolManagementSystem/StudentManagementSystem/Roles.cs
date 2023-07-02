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
    public partial class Roles : Sample1
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
        {

        }

        private void Roletxt_TextChanged(object sender, EventArgs e)
        {
            if (Roletxt.Text == "")
            {
                roleerrorlabel.Visible = true;
                roleerrorlabel.Enabled = true;
            }


            else
            {
                roleerrorlabel.Visible = false;
                roleerrorlabel.Enabled = false;
            }
        }

        private void Statuscmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.Enabled = false;
            if (Statuscmbx.SelectedIndex == -1)
            {
                statuserrorlabel.Visible = true;
                statuserrorlabel.Enabled = true;
            }
            else
            {
                statuserrorlabel.Visible = false;
                statuserrorlabel.Enabled = false;
            }
        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {
            Roletxt.Enabled = true;
            Statuscmbx.Enabled = true;
        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {

        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {

        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
