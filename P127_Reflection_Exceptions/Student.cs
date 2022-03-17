using P127_Reflection_Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Reflection_Exceptions
{
    class Student
    {
        public string StudentFullname;

        public int StudentAge { get; set; }



        //public string checkAge()
        //{
        //    if (StudentAge < 18)
        //    {
        //        //throw new IndexOutOfRangeException("Due to Age");

        //        throw new CheckStudentAgeException("Uygun deyil");
        //    }
        //    return "Its okay to join university";
        //}


        public string[] students = new string[10];
        public string this[int index]
        {
            get
            {
                return students[index];
            }
            set
            {
                if(index<0 || index >= students.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                students[index] = value;
            }
        }
    }
}
