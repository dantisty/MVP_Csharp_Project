using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ais_5_0;
using Model;

namespace Presenter
{
    public class PresenterMain
    {
        private IStudentLogic StudentLogic = null;
        private IMain MainForm = null;

        public PresenterMain(StudentLogic studentLogic, IMain mainForm)
        {
            StudentLogic = studentLogic;
            MainForm = mainForm;

            StudentLogic.EventStudentsGet += OnEventStudentsGet;
            MainForm.deleteStudentEvent += OnDeleteStudent;

            StudentLogic.GetAllStudents();

            MainForm.Show();
        }

        private void OnDeleteStudent(object sender, int e)
        {
            StudentLogic.DeleteStudent(e);
        }

        private void OnEventStudentsGet(object sender, GetStudentArgs e)
        {
            MainForm.loadStudents(e.Students);
        }
    }
}
