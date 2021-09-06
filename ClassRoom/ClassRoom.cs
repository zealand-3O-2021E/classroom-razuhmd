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
    }
}
