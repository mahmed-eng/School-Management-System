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
    public partial class Sample1 : Global
    {
        public Sample1()
        {
            InitializeComponent();
        }

        public void Sample_Load(object sender, EventArgs e)
        {

        }

        public virtual void AddBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void EditBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void ViewBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        MainClass main = new MainClass();
        private void BackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            main.showWindow(hs, this, MDI.ActiveForm);
        }
    }
}
