using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School2
{
    class Program
    {
        static void Main(string[] args)
        {
            //sukurti nauja mokykla
            var school = new School();
            //sukurti naujus mokytojus ir mokiniusir juso prideti i sarasus

            var teacher = new Teacher("Math");
            teacher.FullName = "Aldona Mickeviciene";
            teacher.Age = 40;
            var teacher2 = new Teacher("Geagraphy");
            teacher2.FullName = "Karolis Kolkunas";
            teacher2.Age = 45;
            var teacher3 = new Teacher("Chemistry");
            teacher3.FullName = "Karolina Linkyte";
            teacher3.Age = 28;


            //school.PutTeacherToList()


            school.PutTeacherToList(teacher);
            school.PutTeacherToList(teacher2);
            school.PutTeacherToList(teacher3);

            var student = new Student();
            student.FullName = "Justas Zaksauskas";
            student.Age = 26;
            student.Avarage = (decimal) 8.7;
            var student2 = new Student();
            student2.FullName = "Andrius Astramskas";
            student2.Avarage = (decimal) 6.9;
            student2.Age = 13;
            var student3 = new Student();
            student3.FullName = "Simona Sanulaityte";
            student3.Avarage = (decimal) 9.2;
            student3.Age = 14;
            var student4 = new Student();
            student4.FullName = "Paulius Kristaponis";
            student4.Avarage = (decimal) 7.4;
            student4.Age = 21;
            school.PutStudentToList(student);
            school.PutStudentToList(student2);
            school.PutStudentToList(student3);
            school.PutStudentToList(student4);

            // Išspausdinti visų mokinių ir mokytojų vardus didžiosiomis raidėmis.
            school.PrintTeachersList();
            Console.WriteLine();
            school.PrintStundentsList();
            Console.WriteLine();

            //Išspausdinti mokytojus, kurių amžius daugiau už 30.
            school.GetListOfTeachersOver30Years();
            Console.WriteLine();


            //Išspausdinti mokinius, kurie yra jaunesni nei 15 ir pažymių vidurkis mažiau už 7.5 
            //(Ciklo arba Where metodo su predikatu pagalba).
            school.GetListofStudentsLess15YearsAnd75Average();
            Console.ReadLine();




        }
    }
}
