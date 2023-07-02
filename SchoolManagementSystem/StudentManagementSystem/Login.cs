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
    public partial class Login : Global
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        MainClass main = new MainClass();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            main.showWindow(hs,this,MDI.ActiveForm);
        }
    }
}
