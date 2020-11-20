using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7CollectionsAndGenerics
{
    public class StudentClass
    {
        public string CRN { get; set; }
        public string LectureName { get; set; }
        List<Student> students;

        public StudentClass(string setCRN, string setLectureName)
        {
            CRN = setCRN;
            LectureName = setLectureName;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            var duplicateID = from studentList in students group studentList by studentList.ID into g where g.Count() > 1 select g.Key;
            if (duplicateID.Contains(student.ID))
            {
                throw new ArgumentException("Duplicate IDs found!");
            }
        }

        public Student this[int index]
        {
            get
            {
                if(index < 0 || index > students.Count)
                {
                    throw new ArgumentException("Index is out of bound!");
                }
                else
                {
                    return students[index];
                }
            }
        }

        public Student checkStudentIDAndReturnStudent(string ID)
        {
            var result = new Student();
            try
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].ID == ID)
                    {
                        result = students[i];
                    }
                    else
                    {
                        //throw new ArgumentException("No student found!");
                        Console.WriteLine("No student found!");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public Student this[string studentID]
        {
            get
            {
                return checkStudentIDAndReturnStudent(studentID);
            }
        }

        public override string ToString()
        {
            return $"Class Reference Number: {CRN}\n" +
                   $"Lecture Name: {LectureName}\n";
        }
    }
}
