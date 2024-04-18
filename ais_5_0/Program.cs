using Model;
using Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewWinForm;

namespace ais_5_0
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StudentLogic studentLogic = new StudentLogic();
            IAdd viewAdd = new AddForm();
            IMain viewMain = new MainForm((AddForm)viewAdd);
            PresenterMain presenterMain = new PresenterMain(studentLogic, viewMain);
            PresenterAdd presenterAdd = new PresenterAdd(studentLogic, viewAdd);
            Application.Run((Form)viewMain);
        }
    }
}
