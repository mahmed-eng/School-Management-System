using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class MainClass
    {
       public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public void showWindow(Form openWin,Form closeWin,Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
    }
}
