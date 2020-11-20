using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class ToDoList
    {
        private string _owner; // Owner of to do list
        public string Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }
        List<ToDoNote> list;

        public ToDoList(string nameOfOwner)
        {
            this._owner = nameOfOwner;
            list = new List<ToDoNote>();
        }

        public ToDoNote this[int index]
        {
            get
            {
                return list[index];
            }
        }

        public void Add(ToDoNote addNote)
        {
            list.Add(addNote);
        }
    }
}
