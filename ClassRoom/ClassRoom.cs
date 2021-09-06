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

        public ClassRoom()
        {
        }

        public string ClassName
        {
            get { return _className; }
        }
        public List<Student> StudentList
        {
            get { return _studentList; }
        }
        public DateTime SemesterStart
        {
            get { return _semesterStart; }
        }
    }
}
