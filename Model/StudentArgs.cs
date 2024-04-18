using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentArgs: EventArgs
    {
        public Student Student { get; set; }
        public StudentArgs(Student student)
        {
            Student = student;
        }
    }
}
