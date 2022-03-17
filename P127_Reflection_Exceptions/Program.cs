using P127_Reflection_Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P127_Reflection_Exceptions
{
    class Program
    {
        public int MyProperty { get; set; }
        static void Main(string[] args)
        {
            #region Reflection

            //Assembly assembly = Assembly.GetExecutingAssembly();

            //var classes = assembly.GetTypes();

            //foreach (var clas in classes)
            //{
            //    Console.WriteLine($"{clas.Name} class:");

            //    //Fields
            //foreach (var item in clas.GetFields())
            //    {
            //        Console.WriteLine(item);
            //    }


            //    //Properties
            //foreach (var item in clas.GetProperties())
            //    {
            //        Console.WriteLine(item + "\n");
            //    }

            //    //Methods

            //foreach (var method in clas.GetMethods())
            //    {
            //        Console.WriteLine(method + "\n");
            //    }
            //}

            //var type = assembly.GetType("P127_Reflection_Exceptions.Teacher");

            //var field = type.GetField("TeacherFullname");

            //Console.WriteLine(field);

            //foreach (var item in type.GetFields())
            //{
            //    Console.WriteLine(item);
            //}

            //var field = type.GetField("Academy",BindingFlags.NonPublic | BindingFlags.Instance);


            //Teacher teacher = new Teacher();


            //Console.WriteLine(field.GetValue(teacher));

            //Console.WriteLine("After set");

            //field.SetValue(teacher,"Private deyeri deyishdirmek olur, agilli ol");


            //Console.WriteLine(field.GetValue(teacher));

            #endregion


            #region Exception

            //Student student = new Student();
            //Student student1 = new Student();
            //Student student2 = new Student();

            //Teacher teacher = new Teacher();


            //try
            //{

            //    //Format exceptions
            //    //int number = int.Parse("5a");
            //    //Console.WriteLine(number);

            //    //Divide by zero

            //    //int five = 5;
            //    //int zero = 0;
            //    //int number = five / zero;


            //    //Index out of range exceptions
            //    //int[] numbers = new int[5];
            //    //numbers[5] = 15;

            //    //Null Reference Exception
            //    //teacher.Students.Add(student);
            //    //teacher.Students.Add(student1);
            //    //teacher.Students.Add(student2);

            //    //Argument Null Exception
            //    //teacher.Students.First(x => x.StudentAge == 220);


            //    Student student3 = new Student();
            //    student3.StudentAge = 17;

            //    Console.WriteLine(student3.checkAge());

            //}
            ////catch (ArgumentNullException e)
            ////{
            ////    Console.WriteLine(e.Message);
            ////}
            //catch(NullReferenceException e)
            //{
            //    Console.WriteLine(e.Message);

            //    Console.WriteLine("Handle of null reference");
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (DivideByZeroException e)
            //{
            //    throw new DivideByZeroException("Zero");

            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (CheckStudentAgeException e)
            //{
            //    throw new CheckStudentAgeException();

            //}
            ////catch (Exception e)
            ////{
            ////    Console.WriteLine(e.Message);

            ////    Console.WriteLine("Common exc");
            ////}
            //finally
            //{
            //    Console.WriteLine("After catch");
            //}

            //Console.WriteLine("After finally");
            #endregion

            List<string> list = new List<string>();

            list.Add("Okay");
            Console.WriteLine(list[0]);

            Student student = new Student();



        //try
        //{
        //    student[0] = "Avaz";
        //    Console.WriteLine(student[10]);
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);

        //}

        

        }
    }
}
