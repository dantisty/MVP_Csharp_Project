using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewWinForm
{
    public interface IAdd
    {
        event EventHandler<List<string>> AddStudentEvent;
        void Show();
    }
}
