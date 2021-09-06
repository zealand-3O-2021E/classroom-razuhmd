using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string _name;
        private int _birthMonth;
        private int _birthDay;

        public Student(string name, int birthMonth, int birthDay)
        {
            _name = name;
            _birthMonth = birthMonth;
            _birthDay = birthDay;
        }

        public string Name
        {
            get { return _name; }
        }
        public int BirthMonth
        {
            get { return _birthMonth; }
        }
        public int BirthDay
        {
            get { return _birthDay; }
        }

        public string Season()
        {
            if (BirthMonth == 12 || BirthMonth == 1 || BirthMonth == 2)
            { return "Winter"; }
            else
            if (BirthMonth == 3 || BirthMonth == 4 || BirthMonth == 5)
            { return "Spring"; }
            else
            if (BirthMonth == 6 || BirthMonth == 7 || BirthMonth == 8)
            { return "Summer"; }
            else
            if (BirthMonth == 9 || BirthMonth == 10 || BirthMonth == 11)
            { return "Autumn"; }
            else
                return "Month Entered is not correct";
        }

        public override string ToString()
        {
            return $"\n\t\t\t\tStudent's Name: {Name} \n\t\t\t\tBirth Month: {BirthMonth} \n\t\t\t\tBirth Day: {BirthDay}";
        }

    }
}
