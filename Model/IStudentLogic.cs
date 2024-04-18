using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IStudentLogic
    {
        void AddStudent(List<string> newStudentParams);
        void DeleteStudent(int id);
        void GetAllStudents();

       // event EventHandler<StudentArgs> EventStudentAdd;
       // event EventHandler<StudentArgs> EventStudentRemove;
        event EventHandler<GetStudentArgs> EventStudentsGet;
    }
}
