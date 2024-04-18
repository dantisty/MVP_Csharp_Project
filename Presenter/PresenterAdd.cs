using ais_5_0;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewWinForm;

namespace Presenter
{
    public class PresenterAdd
    {
        private IStudentLogic StudentLogic = null;
        private IAdd AddForm = null;
        private IMain ViewMain = null;

        public PresenterAdd(StudentLogic studentLogic, IAdd addForm)
        {
            StudentLogic = studentLogic;
            AddForm = addForm;

            AddForm.AddStudentEvent += ViewAddStudent; 
        }

        private void ViewAddStudent(object sender, List<string> e)
        {
            StudentLogic.AddStudent(e);
        }
        public void SetMainView(IMain mainView)
        {
            this.ViewMain = mainView;
        }
    }
}
