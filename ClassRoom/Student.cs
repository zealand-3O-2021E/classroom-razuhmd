﻿using System;
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
    }
}
