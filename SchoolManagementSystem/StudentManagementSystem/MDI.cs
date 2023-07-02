using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StudentManagementSystem
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        MainClass main = new MainClass();
        private void MDI_Load(object sender, EventArgs e)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (File.Exists(main.path+ "\\connect"))
            {
                Login obj = new Login();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();

            }
                else
            {
                Settings obj = new Settings();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();

            }


        }
    }
}
