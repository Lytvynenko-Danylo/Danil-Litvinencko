using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginPlayer lp = new LoginPlayer();
            Application.Run(new FormEntry(lp));
            if (lp.ResEntry)
                Application.Run(new Game(lp));
        }
    }
}
