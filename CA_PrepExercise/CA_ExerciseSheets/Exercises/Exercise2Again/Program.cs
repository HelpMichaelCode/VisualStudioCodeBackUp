using System;

namespace Exercise2Again
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoNote note1 = new ToDoNote("Susan is here", DateTime.Now, Priority.high);
            ToDoNote note2 = new ToDoNote("Nitesh is here", DateTime.Now, Priority.high);
            
            ToDoList list = new ToDoList("Nitesh Cock");
            list.AddNotes(note1);
            list.AddNotes(note2);
            for (int i = 0; i < list.Length; i++)
            {
                list[i].TakeInputFileName($"Test{i}.xml");
            }
        }
    }
}
