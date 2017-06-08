using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School2
{

    public class School
    {
        private List<Teacher> TeachersList;
        private List<Student> StudentsList;

        public School() {
            TeachersList = new List<Teacher>();
            StudentsList = new List<Student>();
        }


        public void PutTeacherToList(Teacher teacher)
        {
            TeachersList.Add(teacher);
        }

        public void PutStudentToList(Student student) {
            StudentsList.Add(student);
        }

        public void PrintTeachersList() {
            foreach (var teacher in TeachersList)
                Console.WriteLine(teacher.FullName.ToUpper());
            
        }

        public void PrintStundentsList() {
            foreach (var student in StudentsList)
                Console.WriteLine(student.FullName.ToUpper());
           
        }


        public void GetListOfTeachersOver30Years() {
            var teacherOver30 = TeachersList.Where(teacher => teacher.Age > 30);
            foreach (var teacher in teacherOver30)
            {
                Console.WriteLine(teacher.FullName);
            }
        }



        public void GetListofStudentsLess15YearsAnd75Average()
        {
            var studentover15andaverage75 = StudentsList.Where(student => student.Age < 15 && student.Avarage > 7.5M);
            foreach (var student in studentover15andaverage75)
            {
                Console.WriteLine(student.FullName);
            }
        }



    }
}
