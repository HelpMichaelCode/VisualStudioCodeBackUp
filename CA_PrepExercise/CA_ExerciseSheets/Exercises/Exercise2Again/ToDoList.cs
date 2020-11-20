using System;
using System.Collections.Generic;

namespace Exercise2Again
{
    public class ToDoList
    {
        private string owner;
        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        List<ToDoNote> notes;
        public int Length
        {
            get
            {
                return notes.Count;
            }
        }
        public ToDoList(string owner)
        {
            Owner = owner;
            notes = new List<ToDoNote>();
        }

        public ToDoNote this[int index]
        {
            get
            {
                return notes[index];
            }
        }

        public void AddNotes(ToDoNote note)
        {
            notes.Add(note);
        }
    }
}
