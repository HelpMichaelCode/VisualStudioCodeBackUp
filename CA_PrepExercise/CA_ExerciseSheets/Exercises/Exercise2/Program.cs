using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoNote myNote1 = new ToDoNote("I Don't know anymore", DateTime.Now.Date, "High");
            ToDoNote myNote2 = new ToDoNote("I really don't know anymore", DateTime.Now.Date, "Low");


            ToDoList myToDoList = new ToDoList("Susan");
            myToDoList.Add(myNote1);
            myToDoList.Add(myNote2);

            myToDoList[1].FileInputName("todo.xml");
            myToDoList[0].FileInputName("todo.xml");
        }
    }
}
