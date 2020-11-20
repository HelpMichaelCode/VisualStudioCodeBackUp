using System;
namespace Lab7CollectionsAndGenerics
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Student()
        {
        }
        public Student(string studentID, string studentName, string studentGender)
        {
            ID = studentID;
            Name = studentName;
            Gender = studentGender;
        }

        public override string ToString()
        {
            return $"Student ID: {ID}\n" +
                   $"Student Name: {Name}\n" +
                   $"Student Gender: {Gender}";
        }
    }
}
