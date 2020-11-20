using System;
using System.Collections.Generic;

namespace Lab7CollectionsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClass sc = new StudentClass("MA_1234", "Mr.Poppins");

            List<Student> list = new List<Student>()
            {
                new Student("X00IP", "Michael", "Male"),
                new Student("X00QW", "Conor", "Male"),
                new Student("X00MS", "Heath", "Male"),
                new Student("X00RT", "Jasmine", "Female")
            };

            foreach (var item in list)
            {
                sc.AddStudent(item);
            }

            //Console.WriteLine($"{sc} {sc["LL999"]}");
            Console.WriteLine($"{sc}{sc[3]}");

        }
    }
}
