using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentLogic : IStudentLogic
    {
        private int lastUsedId { get; set; }

        public List<Student> Students = new List<Student>();

        public event EventHandler<GetStudentArgs> EventStudentsGet;

        public StudentLogic()
        {
            Student student1 = new Student();
            student1.Id = 1;
            student1.Name = "das";
            student1.Speciality = "dsa";
            student1.Group = "dsa";
            Students.Add(student1);

            if (Students.Count > 0)
                lastUsedId = Students.Max(s => s.Id);
            else
                lastUsedId = 0;
        }

        public void AddStudent(List<string> newStudentParams)
        {
            Student newStudent = new Student();
            newStudent.Id = lastUsedId + 1;
            newStudent.Name = newStudentParams[0];
            newStudent.Speciality = newStudentParams[1];
            newStudent.Group = newStudentParams[2];
            Students.Add(newStudent);
            GetAllStudents();
        }

        public void DeleteStudent(int id)
        {
            Student studentToDelete = Students.FirstOrDefault(s => s.Id == id);
            Students.Remove(studentToDelete);
            GetAllStudents();
        }

        public void GetAllStudents()
        {
            List<string> studentList = new List<string>();
            foreach (var student in Students)
            {
                studentList.Add(student.Id.ToString());
                studentList.Add(student.Name);
                studentList.Add(student.Speciality);
                studentList.Add(student.Group);
            }

            EventStudentsGet(this, new GetStudentArgs(studentList));
        }
    }
}
