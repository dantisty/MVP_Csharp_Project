using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Shared
{
    public interface IView
    {
        void AddStudent(Student student);
        void DeleteStudent (string student);
        void LoadStudents (IList<Student> students);
    }
}
