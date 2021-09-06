using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Razu", 09, 10);
            Student s2 = new Student("Vladimir", 01, 11);
            Student s3 = new Student("Nat", 07, 14);
            Student s4 = new Student("Artus", 11, 12);
            Student s5 = new Student("Zdenek", 09, 19);

            List<Student> studentList = new List<Student>();
            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
            studentList.Add(s4);
            studentList.Add(s5);

            ClassRoom cr = new ClassRoom();
            cr.ClassName = "3Q";
            cr.StudentList = studentList;
            cr.SemesterStart = new DateTime(2019, 8, 26);

        }
    }
}
