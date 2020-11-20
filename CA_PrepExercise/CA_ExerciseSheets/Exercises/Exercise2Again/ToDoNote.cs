using System;
using System.Xml;

namespace Exercise2Again
{
    public enum Priority { high, normal, low}
    public class ToDoNote : SerialisedXML
    {
        private string subjectMatter;
        public string SubjectMatter
        {
            get
            {
                return subjectMatter;
            }
            set
            {
                subjectMatter = value;
            }
        }
        private DateTime dateTime;
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
            set
            {
                dateTime = value;
            }
        }
        private Priority priority;
        public Priority MyPriority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }


        public ToDoNote(string subjectMatter, DateTime dateTime, Priority priority)
        {
            SubjectMatter = subjectMatter;
            DateTime = dateTime;
            MyPriority = priority;
        }

        public override string ToString()
        {
            return $"Subject Matter: {SubjectMatter}\n" +
                   $"Datetime: {DateTime}\n" +
                   $"Priority: {MyPriority}";
        }
        
        public void TakeInputFileName(string fileName)
        {
            using (XmlWriter writer = XmlWriter.Create(fileName))
            {
                writer.WriteStartElement("To-Do-Note");
                writer.WriteElementString("SubjectMatter", SubjectMatter);
                writer.WriteElementString("Due-date", DateTime.ToString());
                writer.WriteElementString("Priority", MyPriority.ToString("d"));
                writer.WriteEndElement();
                writer.Flush();
            }
        }
    }
}
