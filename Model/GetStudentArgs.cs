using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GetStudentArgs
    {
        public List<string> Students { get; set; }
        public GetStudentArgs(List<string> students)
        {
            Students = students;
        }
    }
}
