using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeviationManager.Model;
using DeviationManager.Entity;
using DeviationManager.GUI;
using System.Windows.Forms;

namespace DeviationManager
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrincipalWin());
         
        }
    }
}
