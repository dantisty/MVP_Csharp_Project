using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ais_5_0
{
    public interface IMain
    {
        event EventHandler<EventArgs> showAddForm;
        event EventHandler<int> deleteStudentEvent;
        void loadStudents(List<string> students);
        void Show();
    }
}
