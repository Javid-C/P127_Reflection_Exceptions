using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Reflection_Exceptions
{
    class Teacher
    {
        public string TeacherFullname;
        public int Age { get; set; }

        private string Academy = "Code Academy";

        public List<Student> Students;

        public Teacher()
        {
            //Students = new List<Student>();
        }
    }
}
