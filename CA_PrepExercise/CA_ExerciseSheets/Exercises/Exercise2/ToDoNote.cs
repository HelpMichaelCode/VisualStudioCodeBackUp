using System;
using System.Xml;

namespace Exercise2
{
    public class ToDoNote
    {
        private string _subjectMatter;
        public string SubjectMatter
        {
            get
            {
                return _subjectMatter;
            }
            set
            {
                _subjectMatter = value;
            }
        }
        private DateTime _dueDate;
        public DateTime DueDate
        {
            get
            {
                return _dueDate;
            }
            set
            {
                _dueDate = value;
            }
        }
        private string _priority;
        public string Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
            }
        }

    
        public ToDoNote(string subjectMatter, DateTime dueDate, string priority)
        {
            this._subjectMatter = subjectMatter;
            this._dueDate = dueDate;
            this._priority = priority;
        }

        public override string ToString()
        {
            return $"Subject of matter: {SubjectMatter}\n" +
                   $"Due date: {DueDate}\n" +
                   $"Priority: {Priority}";
        }

        public void FileInputName(string fileName)
        {
            using (XmlWriter writer = XmlWriter.Create(fileName))
            {
                writer.WriteStartElement("To-Do-Note");
                writer.WriteElementString("SubjectMatter", SubjectMatter);
                writer.WriteElementString("Due-date", DueDate.ToString());
                writer.WriteElementString("Priority", Priority);
                writer.WriteEndElement();
                writer.Flush();
            }
        }


    }
}