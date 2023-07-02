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
    public partial class HomeScreen : Global
    {
        public HomeScreen()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();
        private void StaffBtn_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            main.showWindow(st, this, MDI.ActiveForm);
        }

        private void RolesBtn_Click(object sender, EventArgs e)
        {
            Roles st = new Roles();
            main.showWindow(st, this, MDI.ActiveForm);
        }
    }
}
