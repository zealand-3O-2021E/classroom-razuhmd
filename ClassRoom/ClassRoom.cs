using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        private string _className;
        private List<Student> _studentList;
        private DateTime _semesterStart;

        public ClassRoom(string className, List<Student> studentList, DateTime semesterStart)
        {
            _className = className;
            _studentList = studentList;
            _semesterStart = semesterStart;
        }

        public ClassRoom()
        {
        }

        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }
        public List<Student> StudentList
        {
            get { return _studentList; }
            set { _studentList = value; }
        }
        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }

        public void CountBirthPerSeason()
        {
            int winterCount = 0;
            int springCount = 0;
            int summerCount = 0;
            int autumnCount = 0;

            foreach(Student student in StudentList)
            {
                if (student.BirthMonth == 12 || student.BirthMonth == 1 || student.BirthMonth == 2)
                { winterCount++; }
                else
                if (student.BirthMonth == 3 || student.BirthMonth == 4 || student.BirthMonth == 5)
                { springCount++; }
                else
                if (student.BirthMonth == 6 || student.BirthMonth == 7 || student.BirthMonth == 8)
                { summerCount++; }
                else
                if (student.BirthMonth == 9 || student.BirthMonth == 10 || student.BirthMonth == 11)
                { autumnCount++; }               
            }

            Console.WriteLine($"Number of students born in Winter: {winterCount}");
            Console.WriteLine($"Number of students born in Spring: {springCount}");
            Console.WriteLine($"Number of students born in Summer: {summerCount}");
            Console.WriteLine($"Number of students born in Autumn: {autumnCount}");

        }

        public override string ToString()
        {
            return $"\n\t\t\tClass Name: {ClassName}, \n\t\t\t::::::Student List::::: {StudentList}, \n\t\t\tSemester Start: {SemesterStart}";
        }

    }
}
